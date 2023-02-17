function isResultValid() {

    if (document.getElementById('result').value != 'pass' && document.getElementById("result").value != "fail") {
        return "Result should be pass or fail only";
    }
    else {
        return "";
    }
}
function addCourse() {
    var courseTitle = document.querySelector('#courseTitle');
    var result = document.querySelector('#result');
    var _course = {};
    _course.title = courseTitle.value;
    _course.result = result.value;
    $.ajax({
        type: "POST",
        url: "/api/Student/InsertCourse",
        data: JSON.stringify(_course),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (r) {
            alert("success");
        }
    });
}



function isValid() {
    var WrongResultMessage = isResultValid();
    var FinalErrorMessage = "Errors:";

    if (WrongResultMessage != "")
        FinalErrorMessage += "\n" + WrongResultMessage;

    if (FinalErrorMessage != "Errors:") {
        alert(FinalErrorMessage);
        return false;
    }
    else {
        addCourse();
        return true;
    }
}