function red(query) {

    $.ajax(
        {
            url: "http://10.129.54.119/doorControl.py?red=" + query,
            success: function (data) {
                alert(data);
            }
        });
}
function green(query) {
    
    $.ajax(
       {
           url: "http://10.129.54.119/doorControl.py?green=" + query,
           success: function (data) {
               alert(data);
           }
       });
}
function red2(query) {
    
    $.ajax(
      {
          url: "http://10.129.54.119/doorControl.py?red2=" + query,
          success: function (data) {
              alert(data);
          }
      });
}

function green2(query) {

    $.ajax(
      {
          url: "http://10.129.54.119/doorControl.py?green2=" + query,
          success: function (data) {
              alert(data);
          }
      });
}

function red3(query) {

    $.ajax(
      {
          url: "http://10.129.54.119/doorControl.py?red3=" + query,
          success: function (data) {
              alert(data);
          }
      });
}

function green3(query) {

    $.ajax(
      {
          url: "http://10.129.54.119/doorControl.py?green3=" + query,
          success: function (data) {
              alert(data);
          }
      });
}

function red4(query) {

    $.ajax(
      {
          url: "http://10.129.54.119/doorControl.py?red4=" + query,
          success: function (data) {
              alert(data);
          }
      });
}

function green4(query) {

    $.ajax(
      {
          url: "http://10.129.54.119/doorControl.py?green4=" + query,
          success: function (data) {
              alert(data);
          }
      });
}