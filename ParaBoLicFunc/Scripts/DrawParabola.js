function doAjax(callback) {
    $.ajax({
        type: "GET",
        url: "/Data/DataSet.json",
        dataType: "json",
        success: function (data) {
            callback(data);
        },
        error: function () {
        }
    });
}
var ctx;
var scatterChart;
doAjax(function (data1) {
    console.log(JSON.stringify(data1));
    ctx = document.getElementById("Mychart").getContext('2d');
    scatterChart = new Chart(ctx, {
        type: 'line',
        data: {
            datasets: [{
                label: 'Parabola',
                fill: false,
                borderColor: "rgba(255, 15, 15)",
                backgroundColor: "rgba(0, 0, 0)",
                data: JSON.parse(JSON.stringify(data1))
            }],
        },
        options: {
            scales: {
                xAxes: [{
                    type: 'linear',
                    position: 'bottom'
                }],
            }
        }
    });
})
