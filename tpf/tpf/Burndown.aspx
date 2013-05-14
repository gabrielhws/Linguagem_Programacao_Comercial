<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Burndown.aspx.cs" Inherits="tpf.Burndown" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
	<title>Dashboard - Burndown Chart</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">    
	<div id="chart_div" style="width: 900px; height: 500px;"></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <script type="text/javascript">
        google.load("visualization", "1", { packages: ["corechart"] });
        google.setOnLoadCallback(drawChart);
        function drawChart() {
            var data = google.visualization.arrayToDataTable([
              ['Weeks', 'Previsto', 'Real'],
              ['1', 120, 120],
              ['2', 80, 90],
              ['3', 50, 70],
              ['4', 25, 30],
              ['5', 0, 10],
              ['6', null, 0]
            ]);

            var options = {
                titleTextStyle: { bold: true, color: '#000', fontSize: 16 },
                series: { 0: { targetAxisIndex: 0 } },
                title: 'Burndown Chart',
                hAxis: { title: 'Weeks' },
                curveType: '',
                animation: { duration: 500 },
                width: 'auto',
                height: 'auto',
                lineWidth: 4,
                hAxis: { title: 'Weeks', formatOptions: { source: 'inline' }, format: '0.##' },
                vAxes: [{ title: 'Hours' }],
                booleanRole: 'certainty',
                legend: 'right',
                useFirstColumnAsDomain: false,
                tooltip: {}
            };

            var chart = new google.visualization.LineChart(document.getElementById('chart_div'));
            chart.draw(data, options);
        }
    </script>

</asp:Content>
