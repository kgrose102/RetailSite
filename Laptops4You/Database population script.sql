
insert into Brands (Name) values ('MSI');
insert into Brands (Name) values ('Gigabyte');
insert into Brands (Name) values ('Asus');
insert into Brands (Name) values ('Lenovo');

delete from Brands where Name ='MSI';

select * from Brands

--MSI
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('D14VGKG-057US',1, 'Crosshair 16', 'msicrosshair.jpg',1499.99,1999.99,3,0,'The latest AI powered super fast gaming laptop. Featuring the best graphic in the business. Blazing fast speed mean your game will run smooth')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('A13VF-041US',1, 'Stealth 14', 'msistealth14.jpg',1199.99,1499.99,0,10,'Sharp stealth with killer speeds makes this an excellent gaming laptop for business on the go. Take it to your meeting then game away the night.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('B13UC-2668CA',1, 'Thin 15', 'msithin15.jpg',6.85,1499.99,100,0,'Experience the ultimate gaming thin laptop. Play right along with your friends and fit it into any bag without breaking your back.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('13VF-062US',1, 'Raider GE68HX', 'msiraider.jpg',1799.99,1999.99,10,10,'Rip through your work with the blazing speed of the top of the line i9 processor. Paired with innovative cooling helps you stay cool')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('A2XWIG-034CA',1, 'Vector 16', 'msivector16.jpg',3799.99,3799.99,5,0,'This beast of a laptop can handle anything you throw at it, except maybe the kitchen sink. Feature top of the line everything it will carry you in your games')

--Gigabyte
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('9KG-43US864SH',2, 'G6X 16', 'gigabyteg6x16.jpg',1299.99,1599.99,1,10,'Big 16 inch screen will showcase your movies games and photos with dazling clarity. 4060 provides the gaming powers for all your needs')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('BYHC5USE64SH',2, 'Aorus Master 16', 'gigabyteaormaster16.jpg',1199.99,4399.99,20,0,'This mid range gaming laptop will have enough power to blow all your friends out of the water. Get the power you crave')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('KF-E3US333SH',2, 'G5 15.6', 'gigabyteg515.jpg',1199.99,1044.99,1,10,'This great base model will keep you powered up all night. Help you support your team mates as required. and let you keep cool with out innovative cooling.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('MF-H2US854KH',2, 'G6 MF', 'gigabyteg6mf.jpg',1199.99,1399.99,4,5,'This AI ready gaming laptop is here to powerup you gaming. Optimize all your games to play expertly to give you a smooth experience.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('BZHC6USD45SH',2, 'Aorus Master 18', 'gigabyteaormaster18.jpg',6299.99,6299.99,2,2,'The ultimate workstation laptop has landed. Pwn the Noobs with the 240hz screen allowing you to see everything.')

--Asus
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('HN7306WU-DB72T-CB',3, 'ProArt PX13', 'asusproart13.jpg',1999.99,2350.99,3,1,'Take your digital art to the next power level. Utilize the rotating screen and Pen capability to draw and render to your hearts content.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('FX608JPR-DS76',3, 'TUF Gaming F16', 'asustuff16.jpg',2099.99,2599.99,10,0,'TUF gaming takes you to new place. Feturng the latest i7 and RTX 5070. Stay cool with out new 2nd gen heat sink that will keep you cooler than the Arctic.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('GC33Y-059',3, 'ROG XG Mobile', 'asusxgmobile.jpg',2499.99,2499.99,3,1,'Upgrade your experience by connecting this mobile GPU. Plug it in for an instant performance boost. Small enough to bring it on the go. A perfect pairing for any laptop.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('G835LX-XS99-CA',3, 'ROG Strix Scar 18', 'asusstrixscar18.jpg',6999.99,6999.99,2,5,'Ultimate gaming performance on the go. Take this anywhere and use it to beat your friends in game, or use it IRL with how tough the game is to beat your friends.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('GU605CX-XS98-CA',3, 'ROG Zephyrus G16', 'asusZephyrusg16.jpg',2001.99,5999.9,4,1,'Creating content has never been as breath taking as it is now. The OLED screen calibrated perfectly for DCIP-3 colour space will ensure everything looks as good as the laptop.')

--Lenovo
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('83DG0099CC',4, 'Legion 5', 'lenovolegion5.jpg',1899.99,1899.99,2,1,'The core i7 processor provides a good balance for speed and battery performance. See all the action with the blazing 120hz screen featuring colour accuracy.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('83DH003ECC',4, 'Slim 5', 'lenovoslim5.jpg',2199.99,2199.99,5,8,'This slim and powerful laptop featuring a Ryzen 7 for and 8 GB RTX 4060. Powerful enough to still game, but slim enough to take where ever you need to be. Lenovo Slim 5.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('83LU000BCC',4, 'Legion Pro 5i', 'lenovolegionpro5i.jpg',2899.99,2999.99,8,2,'Upgrade you Legion experience with the sharp crisp OLED screen. Featuring blazing fast graphics and the latest Intel i9 ultra ensure no frames will be lost.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('83F5005FCC',4, 'Legion Pro 7i', 'lenovolegionpro7i.jpg',3099.99,4099.99,5,0,'Power your gaming with the new Legion pro 7i. Featuring our innovative OLED screen and top of the line mobile graphics. AI powered features enhance your experience.')
insert into Products (Id, BrandKeyId, ProductName, GraphicName, CostPrice, MSRP, QtyOnHand, QtyOnBackOrder, Description) values ('83DX00A2CC',4, 'LOQ 15', 'lenovoloq.jpg',1599.99,1599.99,10,4,'This solid mid range device will have you keeping up with Tommy that has the best of everything. PWN him and show him that money does not buy you happiness.')

select * from Products
delete from Products where BrandId = 1003






select * from Products