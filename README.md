

<div align="center" >
<div>
  
## HighlightTextBlock - Text highlighting for WPF TextBlock
</div>
 <div>  
   
![Demo](https://github.com/Platonenkov/HighlightTextblock/blob/master/Resources/highlight.gif)
</div>

</div>   


<div align="center" >
  
### Quick Start
</div>   

#### Installation:
Install-Package HighlightTextBlock -Version 1.0.0
<div align="center" >
  
### Modifying the XAML file
</div>   

After installing HighlightTextBlock:

* Open up the xaml file containing the TextBlock you wish to add highlighting. 
* Add this namespace reference to the XAML: 
  ```C#
  xmlns:hltb="clr-namespace:HighlightTextBlock;assembly=HighlightTextBlock"
  ```
  
* Locate the TextBlock declaration in the XAML. 

<div align="center" >
  
### Template
</div>   

```C#
  <TextBlock Text="{Binding FullText}"
    hltb:HighlightTextBlock.HightlightText="{Binding FindString}"
    hltb:HighlightTextBlock.Italic="True"
    hltb:HighlightTextBlock.HighlightBrush="Yellow" hltb:HighlightTextBlock.HighlightTextBrush="Red"
    hltb:HighlightTextBlock.Bold="True"/>
```

Now you have highlightable TextBlocks in your application!
<div align="center" >
  
## Customization
</div>


  * Highlight color - controls:HighlightTextBlock.HighlightBrush="Yellow" 
  * Highlight text color - controls:HighlightTextBlock.HighlightTextBrush="Red"
  * Bold - controls:HighlightTextBlock.Bold="True"
  * Italic - controls:HighlightTextBlock.Italic="True"
  * Underline - controls:HighlightTextBlock.Underline="True"
  
