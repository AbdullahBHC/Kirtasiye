   M S B A M L   `   `   `  ????E  AKırtasiye, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kırtasiye.PagesKırtasiye.Pages  5      !    Kırtasiye.Pages.UrunGirisi   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Kırtasiye.Pages     5        N? Title$  
UrunGirisi??5	      .??5      ? 
???????.+?5   
   ?? -   5         ??Name$ btngeri??5      $??	Geri Dön??6"   $	??100??65   $??20??6A   $
??Left=?6M   $	??Top=?6h   $??	20,20,0,0q?6?   ? 5   
   $??200,50q?6    ? RowDefinitions 5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??Auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    .+?5      ?? $"??Y E N İ   U R U N   E K L E??6   $??25(?6;   $??Black"?6I    ?? TextAlignment$ Center=?6\   $??Italic$?6s   $??0,0,0,10q?6?   ?? 5      $??1??6   $??10??6%   $
??auto??61   ? 5      $??2??6   $
??0,10q?6    .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??Center=?66   .+?5      ?? $??Urun Adı : ??6!      tbUrunGirisText#??[  64   ?? 5      -   5         ??Name$ 	TxUrunAdi??5   +   $	??150??6   6+   5       5!      ? 5"      $??3??6   $
??0,10q?6    .+?5#      ?? $ 
Horizontal=?6   $??Center=?66   .+?5$      ?? $??Urun Alış Fiyatı : ??6    #??[  6;   ?? 5%      -   5        $ TxUrunAlisFiyati??5%   *   $	??150??6   6*   5&      5'      ? 5(      $??4??6   $
??0,10q?6    .+?5)      ?? $ 
Horizontal=?6   $??Center=?66   .+?5*      ?? $??Urun Satış Fiyatı : ??6    #??[  6<   ?? 5+      -   5        $ TxUrunSatisFiyati??5+   *   $	??150??6   6*   5,      5-      ? 5.      $??5??6   $
??0,10q?6    .+?5/      ?? $ 
Horizontal=?6   $??Center=?66   .+?50      ?? $??Urun Adeti : ??6    #??[  66   ?? 51      -   5        $ 
TxUrunAdet??51   *   $	??150??6   6*   52      53      ? 54      $??6??6   $
??0,10q?6    .+?55      ?? $ 
Horizontal=?6   $??Center=?66   .+?56      ?? $??Urun Kategorisi : ??6    #??[  6:   ?? 57      -   5         ??Name$ 
CbKategori??57   +   $	??150??6   6+   58      59      ? 5:      $??7??6   $	??0,5q?6    .+?5;      ?? -   5        $ 	BtnKaydet??5;   *   $??Kaydet??6   $	??250??6=   5<      5=      5>      5?      