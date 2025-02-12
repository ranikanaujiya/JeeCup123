function SubmitFrom() {

   // debugger;
    // get from data
    var name = $("#name").val();
    var father = $("#father").val();
    var mother = $("#mother").val();
    var dob = $("#dob").val();
    var gender = $("#gender").val();

   
    if (name == null || name == "") {
        Swal.fire({
            icon: "warning",
            title: "warning...",
            text: "Name is Required!",

        });
        return;

    }
    if (father == null || father == "") {
        Swal.fire({
            icon: "warning",
            title: "warning...",
            text: "Father Name is Required!",

        });
        return;

    }
    if (mother == null || mother == "") {
        Swal.fire({
            icon: "warning",
            title: "warning...",
            text: " Mother Name is Required!",

        });
        return;

    }
    if (dob == null || dob == "") {
        Swal.fire({
            icon: "warning",
            title: "warning...",
            text: "dob is Required!",

        });
        return;

    }
    if (gender == null || gender == "") {
        Swal.fire({
            icon: "warning",
            title: "Warning...",
            text: "Gender is required!",
        });
        return;
    }

    $.ajax({
        url: '../Home/SaveRecord',
        type: 'POST',
        data: { Name: name, FatherName: father, MotherName: mother, DOB: dob, Gender: gender },
        success: function (response)
        {

            alert(response.message)
            window.location.href='home/ShowData'
        }

        // key:value

    })

}