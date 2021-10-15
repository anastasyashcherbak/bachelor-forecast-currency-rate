function r=Interpolation_forecast()
X=1:1:12;
%forecast for dollar
Y=[15.8127;24.4799;23.2562;22.7095;20.9;19.4656;19.93;20.39;18.999;19.6985;19.2328;18.0686];
%forecast for euro
Y1=[18.5345;27.7968;25.3243;24.4653;22.5;20.955;21.4215;21.8872;20.4901;21.1887;20.7630;20.7695];
r=0;
%plot(X,Y);
XX=1:0.2:12;
YY=interp1(X,Y,XX,'cubic');
subplot(2,1,1);
plot(XX,YY,'r');
title('forecasted exchange rate for dollar');
xlabel('Months of 2015 year');
ylabel('Hrivna per dollar');
grid on;
YY1=interp1(X,Y1,XX,'cubic');
XX1=1:0.2:12;
subplot(2,1,2);
plot(XX1,YY1,'r');
title('forecasted exchange rate for EURO');
xlabel('Months of 2015 year');
ylabel('Hrivna per EURO');
grid on;