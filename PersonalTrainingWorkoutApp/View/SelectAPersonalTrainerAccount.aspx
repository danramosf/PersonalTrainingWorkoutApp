<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectAPersonalTrainerAccount.aspx.cs" Inherits="PersonalTrainingWorkoutApp.View.SelectAPersonalTrainerAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal Training Workout App - Select a Personal Trainer Profile</title>
    <link href="View/css/home.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="divContainer">
                <img src="img/logo.png" class="imgLogo" />
                <div class="divButtons">
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
