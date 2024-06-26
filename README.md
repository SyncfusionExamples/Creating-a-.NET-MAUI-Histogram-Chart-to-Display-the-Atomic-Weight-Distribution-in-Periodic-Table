# Creating a .NET MAUI Histogram Chart to Display the Atomic Weight Distribution in Periodic Table.
This article demonstrates how to create the .NET MAUI Histogram Chart to display the distribution of Atomic Weights across the elements of the Periodic table.
Its aim to  create an interactive visualization of chemical elements from the periodic table. It utilizes a [Syncfusion Cartesian Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) to represent the relationship between atomic number and atomic weight of elements in a visually appealing manner.

**Overview**

The [.NET MAUI Histogram](https://www.syncfusion.com/maui-controls/maui-cartesian-charts/chart-types/maui-histogram-chart) is a chart that visually represents the distribution of a dataset. Histograms are effective tools for understanding the characteristics of a dataset because they provide valuable insights into the distribution and patterns present in the data.

**Customizing the appearance of the chart**

we can customize the Histogram chart appearance to boost up the visual effect of the chart. 

**Chart Title Customization** 

Customizing the chart header empowers users to create visually appealing and informative charts that effectively communicate their data insights to others. 

**Histogram series customization** 

We can enhance the appearance of the series by providing the [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Fill), [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.HistogramSeries.html#Syncfusion_Maui_Charts_HistogramSeries_Stroke) and  [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_StrokeWidth) properties. 
In addition to that we can able to customize the distribution curve appearance by using the Stroke related customization. 

**Axis customization** 

We will enhance the appearance of the axis line by initializing the chart axis. 

- **Maximum:** This property sets the maximum value displayed on the respective axis. 

- **Minimum:** Conversely, the minimum value sets the lower limit of the axis.

- **Interval:** Interval determines the spacing between major tick marks or grid lines on the axis. It helps in organizing and presenting data more clearly. 

- **ShowMajorGridLines:** Used to set the visibilty of the grid lines. 

- **Title:** Title is used to define the description data presented in chart. The unit of Atomic Weight is amu(Atomic Mass Unit) or Da (Dalton), the abbreviation of atomic weight is at. wt.


**Tooltip Customization**

The TooltipTemplate property allows users to define a custom layout and content for the tooltip. It specifies a data template that determines how the tooltip appears and what information it displays. 


![BlogOutput](https://github.com/SyncfusionExamples/Creating-a-.NET-MAUI-Histogram-Chart-to-Display-the-Atomic-Weight-Distribution-in-Periodic-Table/assets/113962276/47d58e77-45c3-4db6-b0a3-bc06ad281dcb)


## Troubleshooting

**Path too long exception**

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [Periodic Table Elements](https://www.syncfusion.com/blogs/post/maui-histogram-chart-periodic-table) blog post.
