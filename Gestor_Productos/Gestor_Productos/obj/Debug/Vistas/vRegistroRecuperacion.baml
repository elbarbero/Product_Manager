   M S B A M L   `   `   `  ����  Gestor_Productos3    -Gestor_Productos.Vistas.vRegistroRecuperacion   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v19.2, Version=19.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      j fDevExpress.Xpf.LayoutControl.v19.2, Version=19.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  5      ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5      $	��400��5   $   $	��500��61     � 
ResizeMode$  NoResize=�5	       � WindowState$ Normal=�6    � WindowStartupLocation$ CenterScreen=�60    � Title 5      1  +DevExpress.Xpf.DXBinding.DXBindingExtension  *
nomVentana+.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   -  'DevExpress.Xpf.LayoutControl.LayoutItem     Label$ Registro��6   $��2��6+   $��Center=�6?   $��0,10,0,0q�6\   $��18(�6n   $
��Bold"�6|   ���#073B3A6�     5   
   $ Datos Personales��6   $��1��63   $��2��6@   $��Center=�6T   $��0,10,0,0q�6q   $��14(�6�   $��SemiBold"�6�   ���#073B3A$��Oblique$�6�   .  (DevExpress.Xpf.LayoutControl.LayoutGroup  5   
      Orientation$ Vertical=�6   $��2��62      ItemLabelsAlignment$ Local=�6?   .+�5        $
��Left=�6   $ Nombre*��69   $	��200��6I   $��	30,15,0,0q�6U   	   Content.	 5      %  DevExpress.Xpf.Editors.TextEdit  -   5        
  Name$
 	txtNombre��5      %  DevExpress.Xpf.Editors.BaseEdit   	EditValue 62     *nombre+   Mode$ TwoWay=�   UpdateSourceTrigger$ PropertyChanged=�5        5      $
��Left=�6   $ 
Apellidos*��69   $	��200��6L   $��	30,15,0,0q�6X   .	 5         -   5        $
 txtApellidos��5        65     *	apellidos+$ TwoWay=�$ PropertyChanged=�5!        5"      $
��Left=�6   $
 DNI*��69   $	��200��6F   $��	30,15,0,0q�6R   .	 5#        -   5        $
 txtDNI��5#       6/     *dni+$ TwoWay=�$ PropertyChanged=�5$      5%        5'   
   $ Vertical=�6   $��2��62   $��1��6?   $ Local=�6O   .+�5(        $
��Left=�6   $ 	Tlf. Fijo��69   $	��200��6K   $��	30,15,0,0q�6W   .	 5)        -   5        $
 
txtTlfFijo��5)         Mask$ d��63      MaskType$ Numeric=�6<      MaskUseAsDisplayFormat .  6m     *	tlfFijo+$ TwoWay=�$ PropertyChanged=�5*        5+      $
��Left=�6   $ Tlf. Móvil��69   $	��200��6L   $��	30,15,0,0q�6X   .	 5,        -   5        $
 txtTlfMovil��5,      $ d��64   $ Numeric=�6=    .  6n     *
tlfMovil+$ TwoWay=�$ PropertyChanged=�5-        5.      $
��Left=�6   $ Email*��69   $	��200��6H   $��	30,15,0,0q�6T   .	 5/        -   5        $
 txtEmail��5/      $: 4[a-zA-Z0-9._%-]{5,}@[a-zA-Z0-9.-]{2,}\.[a-zA-Z]{2,4}��61   $ RegEx=�6m    6~     *email+$ TwoWay=�$ PropertyChanged=�50      51        53   
   $ Datos de Usuario��6   $��3��63   $��2��6@   $��Center=�6T   $��0,10,0,0q�6q   $��14(�6�   $��SemiBold"�6�   ���#073B3A$��Oblique$�6�     54   
   $ Vertical=�6   $��4��62   $ Local=�6?   .+�55        $
��Left=�6   $ Usuario*��69   $	��200��6J   $��	30,15,0,0q�6V   .	 56        -   5        $
 
txtUsuario��56       63     *
username+$ TwoWay=�$ PropertyChanged=�57        58      $
��Left=�6   $ Contraseña*��69   $	��200��6M   $��
30,15,0,10q�6Y   .	 59      ,  &DevExpress.Xpf.Editors.PasswordBoxEdit  -   5          Name$ txtContrasena��59   &    6=     *
password+$ TwoWay=�$ PropertyChanged=�5:      5;        5=   
   $��5��6   $��2��6(   $ 
Horizontal=�6<   $��Center=�6U   .+�5>      &   DevExpress.Xpf.Core.SimpleButton  -	   5          Name$ 
btnAceptar��5>      $��Aceptar��62   $��Center=�6D    �� Click 6a   /  )DevExpress.Xpf.DXBinding.DXEventExtension  *(&btnAceptarCancel_Click(@sender, @args)+  5?      -
   5        $ btnCancelar��5?      $��Cancelar��63   $��Center=�6F   $��30,0,0,0q�6c    6u     *(&btnAceptarCancel_Click(@sender, @args)+5@      5A      5B      