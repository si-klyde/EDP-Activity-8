<?php
header("Content-Type: application/json");
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: POST, GET, OPTIONS");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

$servername = "localhost";
$username = "root";
$password = "1052";
$dbname = "database_edp";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die(json_encode(["success" => false, "message" => "Connection failed: " . $conn->connect_error]));
}

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    $sql = "SELECT employees.emp_id, employees.emp_name, employees.emp_pos, employees.emp_pay, branches.branch_name AS from_branch, employees.emp_key
            FROM employees 
            JOIN branches ON employees.from_branch = branches.branch_id";
    $result = $conn->query($sql);

    $data = [];
    while($row = $result->fetch_assoc()) {
        $data[] = $row;
    }
    echo json_encode($data);
} elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);
    
    if (!isset($input['emp_name']) || !isset($input['emp_pos']) || !isset($input['emp_pay']) || !isset($input['from_branch']) || !isset($input['emp_key'])) {
        echo json_encode(["success" => false, "message" => "Invalid input"]);
        $conn->close();
        exit();
    }

    $emp_name = $input['emp_name'];
    $emp_pos = $input['emp_pos'];
    $emp_pay = $input['emp_pay'];
    $branch_txt = $input['from_branch'];
    $emp_key = $input['emp_key'];

    $branch_id = null;
    $check_branch_sql = "SELECT branch_id FROM branches WHERE branch_name = ?";
    $check_branch_stmt = $conn->prepare($check_branch_sql);
    $check_branch_stmt->bind_param("s", $branch_txt);
    $check_branch_stmt->execute();
    $check_branch_result = $check_branch_stmt->get_result();

    if ($check_branch_result->num_rows > 0) {
        $row = $check_branch_result->fetch_assoc();
        $branch_id = $row['branch_id'];
    } else {
        $insert_branch_sql = "INSERT INTO branches (branch_name) VALUES (?)";
        $insert_branch_stmt = $conn->prepare($insert_branch_sql);
        $insert_branch_stmt->bind_param("s", $branch_txt);
        if (!$insert_branch_stmt->execute()) {
            echo json_encode(["success" => false, "message" => "Error inserting branch: " . $insert_branch_stmt->error]);
            $conn->close();
            exit();
        }
        $branch_id = $insert_branch_stmt->insert_id;
    }

    $insert_employee_sql = "INSERT INTO employees (emp_name, emp_pos, emp_pay, from_branch, emp_key) VALUES (?, ?, ?, ?, ?)";
    $insert_employee_stmt = $conn->prepare($insert_employee_sql);
    $insert_employee_stmt->bind_param("sssds", $emp_name, $emp_pos, $emp_pay, $branch_id, $emp_key);
    
    if ($insert_employee_stmt->execute()) {
        echo json_encode(["success" => true, "message" => "New employee added", "employee_id" => $insert_employee_stmt->insert_id]);
    } else {
        echo json_encode(["success" => false, "message" => "Error: " . $insert_employee_stmt->error]);
    }
}

$conn->close();
?>
