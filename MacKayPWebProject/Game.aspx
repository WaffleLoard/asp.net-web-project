<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="MacKayPWebProject.Game" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input type="text" ID="widthTextBox" />

    <input type="text" ID="heightTextBox" />

    <input type="text" ID="numBombsTextBox" />

    <button type="Button" ID="GenerateBoard" onclick="validateInputs()">Test</button>
    <br />
    <span ID="warningBox" class="errorMessage"></span>
</asp:Content>
