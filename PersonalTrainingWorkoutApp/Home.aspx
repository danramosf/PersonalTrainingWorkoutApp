<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PersonalTrainingWorkoutApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal Training Workout App v1.0</title>
    <link href="View/css/home.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="divContainer">
                <img alt="" src="View/img/logo.png" class="imgLogo" />
                <div class="divButtons">
                    <asp:Button ID="Button1" runat="server" Text="I'm a Personal Trainer" CssClass="btnHome" />
                    <asp:Button ID="Button2" runat="server" Text="I just want to see my workouts" CssClass="btnHome" />
                </div>
            </div>
            <footer>Developed by Brahiam Baron and Daniel Ferreira.</footer>
        </div>
    </form>
</body>
</html>
