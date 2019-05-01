var form = document.querySelector('.ValidForm')
var fields = form.querySelectorAll('.field')
var stepfield = form.querySelector('#Step')

form.addEventListener('submit', function (event) {
    for (var i = 0; i < fields.length; i++) {
        if (fields[i].value.match(/[A-Za-zА-Яа-я]/g)) {          
            document.querySelector('.wrongs').innerHTML = "<p>Fields have chars</p>"
            
            console.log('field have chars', fields[i])
            event.preventDefault()
        } 
    }
    if (stepfield.value < 0) {
        event.preventDefault()
        document.querySelector('.wrongs').innerHTML = "<p>Field Step cant be a negative or zero</p>"
    }
    
})
