var customerPad;
var employeePad;
function SaveAsync() {
    var employeeDataURL = employeePad.toDataURL('image/svg+xml')
    document.getElementById("AffairDetail_SignaturePath").value = employeeDataURL;
    document.getElementById("AffairDetail_CustomerSignaturePath").value = customerPad.toDataURL('image/svg+xml');
    var dataArray=$('#Affair').serializeArray()
    $.ajax({
        type: 'POST',
        url: '/Affairs/New',
        data: dataArray,
        success: function () {
            window.location.assign("/Affairs/Index")
        }
    });
    
}


function initializeClock() {
    $('.clockpicker').clockpicker({
        autoclose: true,
        align: 'left'
    });
}
$(document).ready(function () {
    $(".affair-header").click(function () {
        $(".affair-collapse").collapse('toggle');
    })
    $(".detail-header").click(function () {
        $(".detail-collapse").collapse('toggle');
    })
    $(".employee-header").click(function () {
        $(".employee-collapse").collapse('toggle');
    })
    $(".vehicle-header").click(function () {
        $(".vehicle-collapse").collapse('toggle');
    })
    initializeClock();
    initializeSignature();
})
function initializeSignature() {
    var customerCanvas = document.getElementById("customerPad");
    var employeeCanvas = document.getElementById("employeePad");
    customerPad = new SignaturePad(customerCanvas);
    employeePad = new SignaturePad(employeeCanvas);
}



function diff(start, end) {
    start = start.split(":");
    end = end.split(":");
    var startDate = new Date(0, 0, 0, start[0], start[1], 0);
    var endDate = new Date(0, 0, 0, end[0], end[1], 0);
    var diff;
    if (endDate.getTime() > startDate.getTime()) {
        diff = endDate.getTime() - startDate.getTime();
    }
    else {
        diff = startDate.getTime() - endDate.getTime();
    }
    var hours = Math.floor(diff / 1000 / 60 / 60);
    diff -= hours * 1000 * 60 * 60;
    var minutes = Math.floor(diff / 1000 / 60);

    return (hours <= 9 ? "0" : "") + hours + ":" + (minutes <= 9 ? "0" : "") + minutes;
}
function onTimeChanged(beginTime, endTime, target,target2)
{
    target.value = diff(beginTime.value, endTime.value);
    target2.value = diff(beginTime.value, endTime.value);
}

function sumOfTimes(time1,time2,time3,summedTarget) {
    var hour = 0;
    var minute = 0;
    var second = 0;

    var splitTime1 = time1.value.split(':');
    var splitTime2 = time2.value.split(':');
    var splitTime3 = time3.value.split(':');

    hour = parseInt(splitTime1[0]) + parseInt(splitTime2[0]) + parseInt(splitTime3[0]);
    minute = parseInt(splitTime1[1]) + parseInt(splitTime2[1]) + parseInt(splitTime3[1]);
    hour = hour + minute / 60;
    minute = minute % 60;
    second = parseInt(splitTime1[2]) + parseInt(splitTime2[2]) + parseInt(splitTime3[2]);
   // minute = minute + second / 60;
    //second = second % 60;

    summedTarget.value= (hour<=9? "0":"")+hour + ":" + (minute<=9?"0":"")+ minute;

}