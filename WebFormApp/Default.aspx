<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div style="font-size:x-large; text-align:center">
       Student Information Management Form
       <br />

       <br />
      

   </div>
     <table class="nav-justified">
           <tr>
               <td>Std Id</td>
               <td>
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
               </td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td>Name</td>
               <td>
                   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
               </td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td>Address</td>
               <td>
                   <asp:DropDownList ID="DropDownList1" runat="server">
                       <asp:ListItem>USA</asp:ListItem>
                       <asp:ListItem>ASIA</asp:ListItem>
                       <asp:ListItem>BD</asp:ListItem>
                   </asp:DropDownList>
               </td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td>Age</td>
               <td>
                   <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
               </td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td>Contract</td>
               <td>
                   <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
               </td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td>&nbsp;</td>
               <td>
                   <asp:Button ID="Button1" runat="server" BackColor="#0000CC" BorderColor="#000066" ForeColor="White" OnClick="Insert" Text="Insert" Width="70px" />
                   <asp:Button ID="Button2" runat="server" BackColor="#CC0000" BorderColor="#003300" ForeColor="White" OnClick="Delete" Text="Delete" Width="70px" />
                   <asp:Button ID="Button3" runat="server" BackColor="#006600" BorderColor="#000066" ForeColor="White" OnClick="Update" Text="Update" Width="70px" />
                   <br />
                   <br />
                   <asp:GridView ID="GridView1" runat="server" Width="626px">
                   </asp:GridView>
               </td>
               <td>&nbsp;</td>
           </tr>
       </table>
</asp:Content>
