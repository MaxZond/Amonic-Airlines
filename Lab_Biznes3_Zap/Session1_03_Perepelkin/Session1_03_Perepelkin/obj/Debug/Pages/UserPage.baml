   M S B A M L   `   `   `  ????Q  MSession1_03_Perepelkin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Session1_03_Perepelkin.PagesSession1_03_Perepelkin.Pages  5      5clr-namespace:AMONIC_Airlines_3AMONIC_Airlines_3  6@   +    %Session1_03_Perepelkin.Pages.UserPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Session1_03_Perepelkin.Pages     5      2local1clr-namespace:AMONIC_Airlines_3     6@   -   5          N? Title$  UserPage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??53* ?6   ?? 5      $	??58* ?6   ?? 5      $	??40* ?6   ?? 5      $
??291* ?6   ?? 5      $??8* ?6    ? ColumnDefinitions 5   
   ?? 5      $??0* ?6   ?? 5      $	??36* ?6   ?? 5      $
??139* ?6   ?? 5      $
??149* ?6   ?? 5      $	??91* ?6   ?? 5      $
??342* ?6   ?? 5      $	??43* ?6   .+?5   
   ?? -   5         ??Name$ hiLable??5      $?? ??6!   $
??Left=?6,   $??Center=?6G   $	??356??6b   $??40??6n   $??20(?6z   $??1??6?   $??2??6?   $??8,0,0,0q?6?   $??3??6?   $??	Tw Cen MT)?6?   ?? 5   
   -   5        $ TimeSpentLable??5      $??Time spent on system: ??6(   $
??Left=?6I   $??25,0,0,0q?6d   $??Center=?6v   $	??214??6?   $??40??6?   $??20(?6?   $??3??6?   $??2??6?   $??2??6?   $??	Tw Cen MT)?6?   ?? 5   
   -   5        $ CrashesLable??5      $?? ??6&   $
??Left=?61   $??	136,0,0,0q?6L   $??Center=?6_   $	??202??6z   $??40??6?   $??20(?6?   $??2??6?   $??5??6?   $??	Tw Cen MT)?6?   ?? 5    
   -   5         ??Name$ 
ExitButton??5       $
??Exit??6%   $
??Left=?64   $??5,5,0,0q?6O   $	??Top=?6`   $??40??6x   $	??122??6?   $??20(?6?   $??2??6?   $??Verdana)?6?   ??6?   Z? ??6?   Z? 6?   ?? 5!   
   -   5        $ 
TimerLable??5!      $?? ??6$   $
??Left=?6/   $??Center=?6J   $??94??6e   $??40??6p   $??20(?6|   $??5??6?   $??2??6?   $??	Tw Cen MT)?6?   &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ UserGrid??5"      $??4??6%   $??0,4,0,2q?69      AutoGenerateColumns .     
IsReadOnly . $??3??6x   $??2??6?   $??Verdana)?6?    ? 	Resources 5#      &   AMONIC_Airlines_3.ColorConverter   ColorConverter??%   &	          5$      6(   5%      	   RowStyle	 5&      ?? 5'      
 ?? 
TargetType)  #System.Windows.Controls.DataGridRow"
  6   .?5(      ??  ?? Property ? ?? ?? Value 63   ?? *Color+ ?? 	Converter# [  5)         Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   ??  ?? Path$ 
Date_login?  5-      $ 
Login time??6%   $	 100 69    6E   ?? $ 
Login_time?  5.      $ Logout time??6%   $	 100 6:    6F   ?? $ Logout_time?  5/      $ Time spent on system??6%   $	 150 6C    6O   ?? $ 
Time_spent?  50      $ Unsuccessful logout??6%   $ * 6B    6L   ?? *Unsuccessful_logout+  51      $ Color??6%   $ * 64      
Visibility$ Hidden=?6]    6>   ?? $ Color?6]   53      ?? 54   
   -   5        $ ShutDownButton??54      $??Shutdown??6)   $??Center=?6<   $??0,5,0,0q?6Y   $	??Top=?6j   $??40??6?   $	??122??6?   $??20(?6?   $??3??6?   $??Verdana)?6  ??6?   Z? ??6?   Z? 6  55      56      