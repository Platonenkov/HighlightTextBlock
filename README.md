## HighlightTextBlock - Text highlighting for WPF TextBlock

### Quick Start
#### Installation:
Install-Package HighlightTextBlock -Version 1.0.0
#### Modifying the XAML file

After installing HighlightTextBlock:

* Open up the xaml file containing the TextBlock you wish to add highlighting. 
* Add this namespace reference to the XAML: 
  ```C#
  xmlns:hltb="clr-namespace:HighlightTextBlock;assembly=HighlightTextBlock"
  ```
  
* Locate the TextBlock declaration in the XAML. 
#### Template
```C#
  <TextBlock Text="{Binding SomeText}"
    hltb:HighlightTextBlock.HightlightText="{Binding FindString}"
    hltb:HighlightTextBlock.Italic="True"
    hltb:HighlightTextBlock.HighlightBrush="Yellow" hltb:HighlightTextBlock.HighlightTextBrush="Red"
    hltb:HighlightTextBlock.Bold="True"/>
```
* Add this attribute:
```C#
  controls:HighlightTextBlock.HightlightText="{Binding SearchText}" 
```  
Now you have highlightable TextBlocks in your application!
* Customization:

  * Highlight color - controls:HighlightTextBlock.HighlightBrush="Yellow" 
  * Highlight text color - controls:HighlightTextBlock.HighlightTextBrush="Red"
  * Bold - controls:HighlightTextBlock.Bold="True"
  * Italic - controls:HighlightTextBlock.Italic="True"
  * Underline - controls:HighlightTextBlock.Underline="True"
  
