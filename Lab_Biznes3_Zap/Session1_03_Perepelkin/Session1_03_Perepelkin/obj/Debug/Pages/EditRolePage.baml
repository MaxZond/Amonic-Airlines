   M S B A M L   `   `   `  ????Q  MSession1_03_Perepelkin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Session1_03_Perepelkin.PagesSession1_03_Perepelkin.Pages  5      /    )Session1_03_Perepelkin.Pages.EditRolePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Session1_03_Perepelkin.Pages     5      -   5          N? Title$  EditRolePage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??24* ?6   ?? 5      $	??45* ?6   ?? 5      $	??45* ?6   ?? 5      $	??45* ?6   ?? 5      $	??45* ?6   ?? 5      $
??125* ?6   ?? 5      $	??70* ?6   ?? 5      $	??43* ?6    ? ColumnDefinitions 5   
   ?? 5      $
??247* ?6   ?? 5      $
??385* ?6   ?? 5      $
??168* ?6   .+?5   
   ?? -   5         ??Name$ 	EmailTBox??5      $
??Left=?6%   $??	153,0,0,0q?6@    ?? TextWrapping$
 Wrap=?6S   $??Center=?6~   $	??224??6?   $??30??6?   
???????
???   ?$??20(?6?    ?? TextAlignment$ Center=?6?   $??1??6?   $??1??6  $??Verdana)?6  ??6g   ?? *Email+6  ?? 5   
   $
??Left=?6   $??3,0,0,0q?6/   $
??Wrap=?6@   $??Email address??6T   $??Center=?6i   $??30??6?   $	??150??6?   $??20(?6?    ?? TextAlignment$ Center=?6?   $??1??6?   $??1??6?   $??	Tw Cen MT)?6?   ?? 5   
   -   5        $ FirstNameTBox??5      $
??Left=?6)   $??	153,0,0,0q?6D   $
 Wrap=?6W   $??Center=?6?   $	??224??6?   $??28??6?   
???????
???   ?$??20(?6?   $ Center=?6?   $??1??6  $??2??6  $??Verdana)?6"  ??6k   ?? *	FirstName+6"  ?? 5   
   $
??Left=?6   $??3,0,0,0q?6/   $
??Wrap=?6@   $??
First name??6T   $??Center=?6f   $??28??6?   $	??150??6?   $??20(?6?   $ Center=?6?   $??1??6?   $??2??6?   $??	Tw Cen MT)?6?   ?? 5   
   -   5        $ LastNameTBox??5      $
??Left=?6(   $??	153,7,0,0q?6C   $
 Wrap=?6V   $	??Top=?6?   $	??224??6?   $??29??6?   
???????
???   ?$??20(?6?   $ Center=?6?   $??1??6   $??3??6  $??Verdana)?6  ??6j   ?? *
LastName+6  ?? 5    
   $
??Left=?6   $??3,7,0,0q?6/   $
??Wrap=?6@   $??	Last name??6T   $	??Top=?6e   $??29??6}   $	??150??6?   $??20(?6?   $ Center=?6?   $??1??6?   $??3??6?   $??	Tw Cen MT)?6?   ?? 5!   
   $
??Left=?6   $??3,11,0,0q?6/   $
??Wrap=?6A   $??Office??6U   $	??Top=?6c   $??29??6{   $	??150??6?   $??20(?6?   $ Center=?6?   $??1??6?   $??4??6?   $??	Tw Cen MT)?6?   ?? 5"   
   -   5         ??Name$ OfficeCB??5"      $
??Left=?6%   $??
153,11,0,0q?6@   $	??Top=?6T   $	??224??6l   $??29??6x   
???????$??1??6?   $??4??6?   $??Verdana)?6?   ??5#      ?? 5$       ?? EndPoint$	 0,1&?6&   .??5%      ? 	 ? Color$	 	#FFF0F0F0??6#   ? 5&      $	 White??6#   
 ? Offset$
 1Q?61   5'      5)      ?? 5*   
   $
??Left=?6   $??3,32,0,0q?6/   $
??Wrap=?6A   $
??Role??6U   $	??Top=?6a   $??30??6y   $	??150??6?   $??20(?6?   $ Center=?6?   $??1??6?   $??5??6?   $??	Tw Cen MT)?6?   	? 5+   
   -   5         	?Name$ 	UserRadio??5+      $
??User??6)   $
??Left=?68   $??
153,32,0,0q?6S   $	??Top=?6g   $??30??6   $	??224??6?   $??17(?6?   $??1??6?   $??5??6?   $??	Tw Cen MT)?6?   	? 5,   
   -   5        $ 
AdminRadio??5,      $??Admin??6*   $
??Left=?6:   $??
153,71,0,0q?6U   $	??Top=?6i   $??28??6?   $	??224??6?   $??17(?6?   $??1??6?   $??5??6?   $??	Tw Cen MT)?6?   ?? 5-   
   -   5         ??Name$ 
SaveButton??5-      $??Apply??6%   $
??Left=?65   $??53,0,0,0q?6P   $??Center=?6b   $??42??6}   $	??100??6?   $??20(?6?   ???	#FF34F719
???????
???????$??1??6?   $??6??6  $??Verdana)?6  ?? 5.   
   -	   5        $ CancelButton??5.      $??Cancel??6'   $
??Left=?68   $??	265,0,0,0q?6S   $??Center=?6f   $??42??6?   $	??102??6?   $??20(?6?   ???	#FFF71919
???????
???????$??1??6   $??6??6  $??Verdana)?6  5/      50      