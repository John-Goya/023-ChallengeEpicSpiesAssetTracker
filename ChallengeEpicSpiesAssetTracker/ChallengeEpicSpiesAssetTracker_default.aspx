<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChallengeEpicSpiesAssetTracker_default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.ChallengeEpicSpiesAssetTracker_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 191px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><h2><span class="auto-style2">Asset Performance Tracker</span></h2>
            <p>
                Asset Name:
                <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                Elections Rigged:
                <asp:TextBox ID="electionsRiggedBox" runat="server"></asp:TextBox>
            </p>
            <p>
                Acts of Subterfuge Performed: <asp:TextBox ID="actsSubterfugeBox" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="addAssetButton" runat="server" OnClick="addAssetButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
