function result=Fuzzy_Logic_Exchange_Rate_Evaluation()
factors=[501 2.09 78.30 5 0 0.1 1 0.8; 281.7 1.28  90.70 5.8 0 0 0 0.8;139.7 0.8 91.80 9.2 0 0 1 0.8;110.1  0.25 111.10 10.30 0.3 0 0 0.8;120 0.56  84.00 12.4 0 0 0 0.8;119.2 0.35  76.20 13.5 0 0 0 0.8;125.8 0.21 96.90 13.9 0 0 0 0.8;106.1 0.11 122.60 22.2 0 0 0 0.8;99.4 0.08 110.50 23.4 0 0.5 0 0.8;108.2 0.08 119.00 25.7 0 0 0 0.8;112.3 0.08 130 30.10 0 0.9 1 0.8;110.3 0.09 132.30 33.1 0 0.4 0 0.8;111.6 0.10 125.60 51.9 0 0.1 0 0.8;116.6 0.09 132.40 78.4 0 0.2 0 0.8;122.3 0.10 125.90 97.7 0 0.3 0 0.8;112.3 0.12 65.00 101.7 0 0.3 0.9 0.8;109,1 0.10 116.20 103.40 0.4 0 0.8;104.6 0.10 119.90 117.3 0 0.6 0 0.8;99.8 0.08 108.00 126.2 0 0.8 0 0.8;100.5 0.07 109 135 0 0.9 0 0.8;124.9 0.13 105 140 0.8 1 0.9 0.8];
%factors=[124.9 0.13 105 140 0.8 1 1 0.8];
factornew=[128 0.12 94 142 0.7 0.8 0 0.7;129.2 0.14 85 130 0.8 0.7 0 0.7;135.7 0.195 80 130 0.4 0.3 0 0.7;138.9 0.3 79 129 0.4 0.3 0 0.7;129 0.28 101 128 0.4 0.3 0 0.7];
fis=readfis('Fuzzy_Logic_Exchange_Rate_Rules1');
fis1=readfis('Fuzzy_Logic_Exchange_Rate_Rules');
result=evalfis(factors,fis);
x=1994:1:2014;
subplot(2,1,1);
bar(x,result);
title('fluctuation of hrivna in %');
xlabel('Years');
ylabel('Percent of currency change');
resultnew=evalfis(factornew,fis1);
x1=01:1:05;
subplot(2,1,2);
bar(x1,resultnew);
title('fluctuation of hrivna in %');
xlabel('For current year 2015');
ylabel('Percent of currency change');
end
