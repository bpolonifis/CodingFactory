function confimDelete(studentId) {
    if (comfirm("Are you sure you wan to delete this student?")) {
        window.location.href = "/Students/" + studentId + "/Delete"
    }
}