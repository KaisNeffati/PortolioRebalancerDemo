/// <reference path="../../typings/AmCharts.d.ts" />
"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require("@angular/core");
var BarClusteredComponent = (function () {
    function BarClusteredComponent() {
    }
    BarClusteredComponent.prototype.ngAfterViewInit = function () {
        var chart;
        var chartData = [
            {
                "year": 2005,
                "income": 23.5,
                "expenses": 18.1
            },
            {
                "year": 2006,
                "income": 26.2,
                "expenses": 22.8
            },
            {
                "year": 2007,
                "income": 30.1,
                "expenses": 23.9
            },
            {
                "year": 2008,
                "income": 29.5,
                "expenses": 25.1
            },
            {
                "year": 2009,
                "income": 24.6,
                "expenses": 25
            }
        ];
        if (AmCharts.isReady) {
            createChart();
        }
        else {
            AmCharts.ready(function () {
                createChart();
            });
        }
        function createChart() {
            // SERIAL CHART
            chart = new AmCharts.AmSerialChart();
            chart.dataProvider = chartData;
            chart.categoryField = "year";
            chart.startDuration = 1;
            chart.plotAreaBorderColor = "#DADADA";
            chart.plotAreaBorderAlpha = 1;
            // this single line makes the chart a bar chart
            chart.rotate = true;
            // AXES
            // Category
            var categoryAxis = chart.categoryAxis;
            categoryAxis.gridPosition = "start";
            categoryAxis.gridAlpha = 0.1;
            categoryAxis.axisAlpha = 0;
            // Value
            var valueAxis = new AmCharts.ValueAxis();
            valueAxis.axisAlpha = 0;
            valueAxis.gridAlpha = 0.1;
            valueAxis.position = "top";
            chart.addValueAxis(valueAxis);
            // GRAPHS
            // first graph
            var graph1 = new AmCharts.AmGraph();
            graph1.type = "column";
            graph1.title = "Income";
            graph1.valueField = "income";
            graph1.balloonText = "Income:[[value]]";
            graph1.lineAlpha = 0;
            graph1.fillColors = "#ADD981";
            graph1.fillAlphas = 1;
            chart.addGraph(graph1);
            // second graph
            var graph2 = new AmCharts.AmGraph();
            graph2.type = "column";
            graph2.title = "Expenses";
            graph2.valueField = "expenses";
            graph2.balloonText = "Expenses:[[value]]";
            graph2.lineAlpha = 0;
            graph2.fillColors = "#81acd9";
            graph2.fillAlphas = 1;
            chart.addGraph(graph2);
            // LEGEND
            var legend = new AmCharts.AmLegend();
            chart.addLegend(legend);
            chart.creditsPosition = "top-right";
            // WRITE
            chart.write("chartdiv");
        }
    };
    return BarClusteredComponent;
}());
BarClusteredComponent = __decorate([
    core_1.Component({
        selector: 'bar-clustered',
        templateUrl: 'app/charts/BarClustered.component.html'
    }),
    __metadata("design:paramtypes", [])
], BarClusteredComponent);
exports.BarClusteredComponent = BarClusteredComponent;
//# sourceMappingURL=BarClustered.component.js.map