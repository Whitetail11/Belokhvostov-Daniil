function MyBind(idt, obj, field) {
    let input = document.getElementById(idt);
    input.addEventListener('change', function(e) {
        obj[field] = e.target.value;
        calc();
    });
    Object.defineProperty(obj, field, {
        get: function() {return this['__' + field];},
        set: function(value) {
            if(this[field] === value)
            return;
            this['__' + field] = value;
            input.value = value;
        }
    })
}

function MyBindRadio(name, obj, field) {
    let inputs = document.getElementsByName(name);
    inputs.forEach((input) => {
        input.addEventListener('change', function(e) {
            obj[field] = e.target.value;
            calc();
        });
    });
    
   
}


const pricing = {
    "MGM Grand": 1000,
    "CityCenter": 1500,
    "The Palazzo": 700,
    "The Mirage": 300
}

let Hotel = {
    startdate: "yyy-mm-dd",
    enddate: "yyy-mm-dd",
    name: "MGM Grand",
    sum: 0,
}


function calc() {
    if(Hotel.startdate && Hotel.enddate && Hotel.name) {
      const days = document.getElementById("days");
      days.value = Math.round((new Date(Hotel.enddate) - new Date(Hotel.startdate))/(24*60*60*1000));
      if(pricing[Hotel.name]) {
        Hotel.sum = pricing[Hotel.name] * days.value;
      }
    }
  }


document.addEventListener("DOMContentLoaded", function(event) {
    MyBind("startdate", Hotel, 'startdate');
    MyBind("enddate", Hotel, 'enddate');
    MyBind("sum", Hotel, 'sum');
    MyBindRadio("hotel", Hotel, 'name');
});

    
