   M S B A M L   `   `   `  ����  Gestor_Productos$    Gestor_Productos.Vistas.vLogin   5      a ]DevExpress.Xpf.Core.v19.2, Version=19.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      j fDevExpress.Xpf.LayoutControl.v19.2, Version=19.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  5        � Title$  vLogin��5      $	��500��6   $	��500��6!    � WindowState$ Normal=�6-    � 
ResizeMode$ NoResize=�6B    � WindowStartupLocation$ CenterScreen=�6X   .��5	      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   .  (DevExpress.Xpf.LayoutControl.LayoutGroup  $��0��6   $��2��6(      Orientation$ 
Horizontal=�6<   .+�5      &   DevExpress.Xpf.Editors.ImageEdit  -   5          Name$ Image��5         Stretch$ Uniform=�6+   	   Source$	 ../Recursos/Abejas.png��6=   
   ShowMenu
 .  %  DevExpress.Xpf.Editors.BaseEdit   
ShowBorder .  6n   5        5   
   $��1��6   $��2��6(   $ Vertical=�6<   .+�5      -  'DevExpress.Xpf.LayoutControl.LayoutItem     Label$ Inicio de sesión��6   $��Center=�67   $��0,10,0,0q�6T   $��18(�6f   $
��Bold"�6t   ���#073B3A6�     5      $��Center=�6   $ Usuario��6;      LabelPosition$	 Top=�6K   $	��300��6_   $��0,15,0,0q�6k      Content. 5      %  DevExpress.Xpf.Editors.TextEdit  -   5          Name$ 
txtUsuario��5      $��1��6�      	EditValue 63   1  +DevExpress.Xpf.DXBinding.DXBindingExtension  *	usuario+   Mode$ TwoWay=�   UpdateSourceTrigger$ PropertyChanged=�6�   5        5      $��Center=�6   $ Contraseña��6;   $	 Top=�6N   $��0,0,0,10q�6b   . 5       ��  �� Orientation$ 
Horizontal=�6   .+�5!      ,  &DevExpress.Xpf.Editors.PasswordBoxEdit  -   5          Name$ txtContrasena��5!   *   $	��280��6A   $��2��6M   y�6Z     *$"viewPass ? `Visible` : `Collapsed`+ 6�     *
contrasena+$ TwoWay=�$ PropertyChanged=�{�6�     *#!usuario == null ? `False`: `True`+  5"      $	��280��6#   ��.   6A   ��  �� ElementName$ txtContrasena�� �� Path$ Password�y�6�     *$"viewPass ? `Collapsed` : `Visible`+&   DevExpress.Xpf.Core.SimpleButton  5#      -   5          Name$ btnViewPassword��5#   '   $��20��6@   $��Stretch=�6K   $	��2,0q�6g   $	��5,2q�6t   
������ {�6�     *&$contrasena != null ? `True`: `False`+   Glyph 5$   '   *	  $DevExpress.Xpf.Core.DXImageExtension	  *SvgImages/Dashboards/Zoom.svg+ J� PreviewMouseDown 5%   '   /
  )DevExpress.Xpf.DXBinding.DXEventExtension
  *+)btnViewPassword_MouseDown(@sender, @args)+ J� PreviewMouseUp 6p   
  *+)btnViewPassword_MouseDown(@sender, @args)+6�   5&      5(      5)        5+   
   $��2��6   $��2��6(   $ Vertical=�6<   $��Center=�6S   .+�5,        -   5        $ btnSiguiente��5,      $��	Siguiente��64   $	��150��6H   {�6T        Expr$E ?contrasena != null and contrasena.Length >= 4? `True` : `False`��   FallbackValue$ False�� �� Click 6�   
  *$"btnSiguiente_Click(@sender, @args)+5-      �� 5/   
   -   5         ��Name$ btnRegistro��5/      $��3��6)   $��0��66   $��Bottom=�6F   $��Center=�6a   $��0,0,0,15q�6~   ���#D5DE40$��13(�6�   $
��Bold"�6�   $��Registrarse��6�   $��	Underline{�6�    � Cursor$
 Hand��6�     J� MouseUp  6  
  *.,RegistroRecuperacion_MouseUp(@sender, @args)+�� 50   
   -   5        $ btnRecuperacionPass��50      $��3��61   $��1��6>   $��Bottom=�6N   $��Center=�6i   $��0,0,0,15q�6�   ���#D5DE40$��13(�6�   $
��Bold"�6�   $$��¿Has olvidado la contraseña?��6�   $��	Underline{�6�   $
 Hand��6    6  
  *.,RegistroRecuperacion_MouseUp(@sender, @args)+52      53      