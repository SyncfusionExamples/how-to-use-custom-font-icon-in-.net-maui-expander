You can customize the expander header icon with font icons in  [.NET MAUI Expander](https://www.syncfusion.com/maui-controls/maui-expander). Please follow the steps below to use the font icons in the Expander Header element.

**Step 1**: Place the ttf file in the shared code project and set the Build action as MauiFont.

**Step 2**: In ResourceDictionary, define the font to use the custom font as StaticResource.

```
<ContentPage.Resources>
    <ResourceDictionary>
        <OnPlatform x:TypeArguments="x:String" x:Key="ExpanderIcon">
            <On Platform="Android" Value="ExpanderIcons.ttf#ExpanderIcons" />
            <On Platform="WinUI" Value="ExpanderIcons.ttf#ExpanderIcons" />
            <On Platform="iOS" Value="ExpanderIcons" />
            <On Platform="MacCatalyst" Value="ExpanderIcons"/>
        </OnPlatform>
    </ResourceDictionary>
    <local:ExpanderIconConverter x:Key="ExpanderIconConverter"/>
</ContentPage.Resources>
```

**Step 3**: Bind the FontFamily for Label using resource key. Use converter to display platform specific icons and bind the Device platform using RuntimePlatform to specify the platform in the ConverterParameter. Set HeaderIconPosition as None to hide the default Header icon.

```
<ContentPage.Content>
    <ScrollView BackgroundColor="#EDF2F5">
        <StackLayout>
            <syncfusion:SfExpander x:Name="expander1" HeaderIconPosition="None">
                <syncfusion:SfExpander.Header>
                    <Grid HeightRequest="50">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="70"/>
                            <ColumnDefinition Width="*"/>
                        </Grid.ColumnDefinitions>
                        <Label HorizontalOptions="Center" VerticalOptions="Center"
                         FontFamily="{StaticResource ExpanderIcon}"
                         Text="{Binding Path=IsExpanded,Source={x:Reference expander1}, Converter={StaticResource ExpanderIconConverter}}"/>
                        <Label Text="Veg Pizza" Grid.Column="1" TextColor="#495F6E"  VerticalTextAlignment="Center" />
                    </Grid>
                </syncfusion:SfExpander.Header>
                <syncfusion:SfExpander.Content>
                    <Grid Padding="10" BackgroundColor="#FFFFFF">
                        <Label BackgroundColor="#FFFFFF" HeightRequest="60" Text="Veg pizza is prepared with the items that meet vegetarian standards by not including any meat or animal tissue products." TextColor="#303030" VerticalTextAlignment="Center"/>
                    </Grid>
                </syncfusion:SfExpander.Content>
            </syncfusion:SfExpander>

            <syncfusion:SfExpander x:Name="expander2" HeaderIconPosition="None">
                <syncfusion:SfExpander.Header>
                    <Grid HeightRequest="50">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="70"/>
                            <ColumnDefinition Width="*"/>
                        </Grid.ColumnDefinitions>
                        <Label HorizontalOptions="Center" VerticalOptions="Center"
                            FontFamily="{StaticResource ExpanderIcon}"
                            Text="{Binding Path=IsExpanded,Source={x:Reference expander2}, Converter={StaticResource ExpanderIconConverter}, ConverterParameter={x:Static Device.RuntimePlatform}}"/>
                        <Label Text="Non-veg Pizza" Grid.Column="1" TextColor="#495F6E"  VerticalTextAlignment="Center" />
                    </Grid>
                </syncfusion:SfExpander.Header>
                <syncfusion:SfExpander.Content>
                    <Grid Padding="10" BackgroundColor="#FFFFFF">
                        <Label Text="Non-veg pizza is prepared by including the meat and animal tissue products." HeightRequest="50" TextColor="#303030" VerticalTextAlignment="Center"/>
                    </Grid>
                </syncfusion:SfExpander.Content>
            </syncfusion:SfExpander>
        </StackLayout>
    </ScrollView>
</ContentPage.Content>
```

**Step 4**: Converter to display icon.

```
public class ExpanderIconConverter : IValueConverter
   {
       public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
       {
           if ((bool)value)
           {
               return "\ue700";
           }
           else
           {             
               return "\ue701";
           }
       }

       public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
       {
           throw new NotImplementedException();
       }
   }
   ```

   [View sample in GitHub](https://github.com/SyncfusionExamples/how-to-use-custom-font-icon-in-.net-maui-expander)

**Conclusion**
I hope you enjoyed learning about how to use a custom font icon for Expander in .NET MAUI (SfExpander).
You can refer to our [.NET MAUI Expander ](https://www.syncfusion.com/maui-controls/maui-expander) feature tour page to know about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/maui/expander/getting-started), and how to quickly get started for configuration specifications. You can also explore our .NET MAUI Expander [example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Expander) to understand how to create and manipulate data.
For current customers, you can check out our components from the License and Downloads page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to check out our other controls.
If you have any queries or require clarifications, please let us know in the comments section below. You can also contact us through our [support forums](https://www.syncfusion.com/forums/), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sflistview). We are always happy to assist you!