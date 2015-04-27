$(document).ready(function () {
    
    /*Gets and sets the initial door status, so users know whether a door is open or locked*/
    GetInitialDoorStatus();
});

/*Return values from the form that validates password*/
function validatePasswordComplete(data, status, xhr) {

    //alert(data.responseJSON)
    //alert(data.responseJSON.door)
    //alert(data.responseJSON.result)

    switch (data.responseJSON.door) {
        case "door-1":
            if (data.responseJSON.result)
            {
                OpenCloseStorage1();
            }
            break;
        case "door-2":
            if (data.responseJSON.result) {
                OpenCloseStorage2();
            }
            break;
        case "door-3":
            if (data.responseJSON.result) {
                OpenCloseOffice();
            }
            break;
        case "door-4":
            if (data.responseJSON.result) {
                OpenCloseAccessories();
            }
            break;
        default:
            break;
            
    }
}

/*Gets initial door status and sets appropriate classes in the view, so we can add colors based on status*/
function GetInitialDoorStatus()
{
    $.ajax({
            url: "http://10.13.39.10/doorControl.py?storage1=check",
            complete: function (data) {
                if (data.responseText == "closed") {
                    $('.door-status.door-1').addClass("locked");
                }
                else if (data.responseText == "open") {
                    $('.door-status.door-1').removeClass("locked");
                }
            }
    });
    $.ajax({
        url: "http://10.13.39.10/doorControl.py?storage2=check",
        complete: function (data) {
            if (data.responseText == "closed") {
                $('.door-status.door-2').addClass("locked");
            }
            else if (data.responseText == "open") {
                $('.door-status.door-2').removeClass("locked");
            }
        }
    });
    $.ajax({
        url: "http://10.13.39.10/doorControl.py?office=check",
        complete: function (data) {
            if (data.responseText == "closed") {
                $('.door-status.door-3').addClass("locked");
            }
            else if (data.responseText == "open") {
                $('.door-status.door-3').removeClass("locked");
            }
        }
    });
    $.ajax({
        url: "http://10.13.39.10/doorControl.py?accessories=check",
        complete: function (data) {
            if (data.responseText == "closed") {
                $('.door-status.door-4').addClass("locked");
            }
            else if (data.responseText == "open") {
                $('.door-status.door-4').removeClass("locked");
            }
        }
    });
}


/*Opens or closes doors, based on current door status - if open, then close. if close, then open*/
function OpenCloseStorage1()
{
    $.ajax(
        {
            url: "http://10.13.39.10/doorControl.py?storage1=check",
            complete: function (data) {
                if (data.responseText == "closed")
                {
                    Storage1("open");
                    $('.door-status.door-1').removeClass("locked");
                }
                else if (data.responseText == "open")
                {
                    Storage1("close");
                    $('.door-status.door-1').addClass("locked");
                }
            }
        });
}

function OpenCloseStorage2() {
    $.ajax(
        {
            url: "http://10.13.39.10/doorControl.py?storage2=check",
            complete: function (data) {
                if (data.responseText == "closed") {
                    Storage2("open");
                    $('.door-status.door-2').removeClass("locked");
                }
                else if (data.responseText == "open") {
                    Storage2("close");
                    $('.door-status.door-2').addClass("locked");
                }
            }
        });
}

function OpenCloseOffice() {
    $.ajax(
        {
            url: "http://10.13.39.10/doorControl.py?office=check",
            complete: function (data) {
                if (data.responseText == "closed") {
                    Office("open");
                    $('.door-status.door-3').removeClass("locked");
                }
                else if (data.responseText == "open") {
                    Office("close");
                    $('.door-status.door-3').addClass("locked");
                }
            }
        });
}

function OpenCloseAccessories() {
    $.ajax(
        {
            url: "http://10.13.39.10/doorControl.py?accessories=check",
            complete: function (data) {
                if (data.responseText == "closed") {
                    Accessories("open");
                    $('.door-status.door-4').removeClass("locked");
                }
                else if (data.responseText == "open") {
                    Accessories("close");
                    $('.door-status.door-4').addClass("locked");
                }
            }
        });
}


/*Logic to turn LED's off or on based on action parameter*/
function Storage1(action) {

    if (action == "close")
    {
        red("on");
        green("off")
    }
    else if (action == "open")
    {
        red("off");
        green("on");
    }
}

function Storage2(action) {
    if (action == "close") {
        red2("on");
        green2("off")
    }
    else if (action == "open") {
        red2("off");
        green2("on");
    }
}

function Office(action) {

    if (action == "close") {
        red3("on");
        green3("off")
    }
    else if (action == "open") {
        red3("off");
        green3("on");
    }
}

function Accessories(action) {

    if (action == "close") {
        red4("on");
        green4("off")
    }
    else if (action == "open") {
        red4("off");
        green4("on");
    }
}


/*Controls the actual LED's*/
function red(query) {
    //storage1 red
    $.ajax(
        {
            url: "http://10.13.39.10/doorControl.py?red=" + query,
            succes: function (data) {
                console.log(data);
            }
        });
}
function green(query) {
    //storage1 green
    $.ajax(
       {
           url: "http://10.13.39.10/doorControl.py?green=" + query,
           success: function (data) {
               console.log(data);
           }
       });
}
function red2(query) {
    //storage2 red
    $.ajax(
      {
          url: "http://10.13.39.10/doorControl.py?red2=" + query,
          success: function (data) {
              console.log(data);
          }
      });
}

function green2(query) {
    //storage2 green
    $.ajax(
      {
          url: "http://10.13.39.10/doorControl.py?green2=" + query,
          success: function (data) {
              console.log(data);
          }
      });
}

function red3(query) {
    //office red
    $.ajax(
      {
          url: "http://10.13.39.10/doorControl.py?red3=" + query,
          success: function (data) {
              console.log(data);
          }
      });
}

function green3(query) {
    //office green
    $.ajax(
      {
          url: "http://10.13.39.10/doorControl.py?green3=" + query,
          success: function (data) {
              console.log(data);
          }
      });
}

function red4(query) {
    //accessories red
    $.ajax(
      {
          url: "http://10.13.39.10/doorControl.py?red4=" + query,
          success: function (data) {
              console.log(data);
          }
      });
}

function green4(query) {
    //accessories green
    $.ajax(
      {
          url: "http://10.13.39.10/doorControl.py?green4=" + query,
          success: function (data) {
              console.log(data);
          }
      });
}