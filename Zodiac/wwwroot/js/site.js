$(window).ready(function ()
{
    $(".form").on("change input", [".name", ".surname", ".email", ".date"],

        function ()
        {
            console.log("form changed");

            if ($(".name").val() !== "" && $(".surname").val() !== "" && $(".email").val() !== "" && $(".date").val() !== "")
            {

                console.log("completed");
                $(".submit").prop("disabled", false);

            }
        });
});