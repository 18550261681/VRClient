   M S B A M L   `   `   `  ����D  @CommonLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`>clr-namespace:CommonLib.control.imageButton;assembly=CommonLibCommonLib.control.imageButton  5   	   nEclr-namespace:CommonLib.control.textBoxDefaltValue;assembly=CommonLib$CommonLib.control.textBoxDefaltValue  5   	    VRClient   VRClient.view.winLogin   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Nbtn>clr-namespace:CommonLib.control.imageButton;assembly=CommonLib     5   	   WtxtExEclr-namespace:CommonLib.control.textBoxDefaltValue;assembly=CommonLib     5   	   -   5          �Name$  window��5   	    � Title$  ��6    � WindowStyle$
 None=�6#    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M   $	��320��6s   $	��480��6�   .��5      � .+�5
   
   �� $5��//VRClient;component/img/winLogin/backGround.png��6   $	��320��6J   $	��480��6W   6e   /   )CommonLib.control.imageButton.ImageButton  5   
   -   5          Name$ btnClose��5      $��25��6,   $��25��68      NormalImage$: 4/VRClient;component/img/winLogin/btnClose_Normal.png��6C      
HoverImage$9 3/VRClient;component/img/winLogin/btnClose_Hover.png��6�      ActiveImage$: 4/VRClient;component/img/winLogin/btnClose_Active.png��6�   $��10q�6  $��Right=�6  $	��Top=�63  ��6K  �� *DataContext.CloseCmd+	 �� ElementName$	 window����6�  �� $	 window��6�  7   1CommonLib.control.textBoxDefaltValue.NormalTextEx  5   
   -   5        
  Name$
 	txtUserId��5      
���   �$��16(�6C   $	��180��6R   $��25��6^   $��0q�6j   
������    
BrushColor �#AAAAAA   DefaltValue$ 	用户名��5   -   $��229,81,71,214q�6{   ��6?   �� *UserId+ �� UpdateSourceTrigger$ PropertyChanged=�6{   8   2CommonLib.control.textBoxDefaltValue.PasswordBoxEx  5   
      Hint$ 密码��6   
���   �$��16(�6;   $	��180��6I   $��25��6U   
�������$��218,117,60,139q�5   l      Password 6   ��  �� Path$ Password�$ PropertyChanged=� �� Mode$ TwoWay=�6l   �� 5   
   $	��200��6   $��36��6   $��登录��6)   $��16(�67      ButtonNormoal#��[  6F   $��208,189,50,56q�6�   ��6m   �� *OKCmd+��6�   �� $	 window��6�   5      5      