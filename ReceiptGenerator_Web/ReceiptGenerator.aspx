<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReceiptGenerator.aspx.cs" Inherits="ReceiptGenerator_Web.ReceiptGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        <asp:Image ID="img" runat="server" Visible="false" />
    </form>
</body>
</html>--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReceiptGenerator.aspx.cs" Inherits="ReceiptGenerator_Web.ReceiptGenerator" %>
<!DOCTYPE html>
<html lang="ko">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>SW마에스트로</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet">
    <link href="Content/site.css" rel="stylesheet">
  </head>
  <body>
    <div class="container-fluid">
        <div class="row header">
            <h4>SW 마에스트로</h4>
            <h1>영수증 발급</h1>
        </div>
        <div class="row body">
            <h4>설명</h4>
            <p>
                개인 정보를 바탕으로 기부금 영수증을 생성하는 사이트입니다<br>
                사이트와 관련된 기타 문의 사항은 develope_e@naver.com 으로 보내주시기 바랍니다. <br>
            </p>
            <p class="text-danger">반드시 이미지에 <b>서명</b>을 첨부해주세요!</p>
            <form runat="server">
                <div class="form-group">
                    <label for="inputName">이름</label>
                    <input name="i_name" type="text" class="form-control" placeholder="홍길동" value="<%= this.Name %>" required>
                </div>
                <div class="form-group">
                    <label for="inputAddress">주소</label>
                    <input name="i_address" type="text" class="form-control" placeholder="서울 특별시 강남구 테헤란로 311(역삼동) 아남타워 빌딩 6층, 7층" value="<%= this.Address %>" required>
                </div>
                <div class="form-group">
                    <label for="inputNum">주민등록번호</label>
                    <input name="i_rreg" type="text" class="form-control" placeholder="123456-1234567" pattern="\d{6}\-\d{7}" title="123456-1234567 형식으로 입력해주세요" autocomplete="true" value="<%= this.RReg %>" required>
                </div>
                <div class="form-group">
                    <label for="inputDate">발급 날짜</label>
                    <input name="inputDate" type="date" class="form-control" placeholder="를 입력하세요" value="<%= this.Date %>" required>
                </div>
                <div class="form-group">
                    <label>
                        <asp:CheckBox ID="chkSave" runat="server"/>
                        주민등록을 제외한 정보를 저장
                    </label>
                </div>
                
                <asp:Button ID="btnGenerate" runat="server" Text="제출" Width="100%" CssClass="btn btn-default btn-submit" OnClick="btnGenerate_Click" />
                <asp:Image ID="img" runat="server" Visible="false" />
            </form>
        </div>
    </div>
    <!-- jQuery -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <!-- Bootstrap -->
    <script src="Scripts/bootstrap.min.js"></script>
  </body>
</html>