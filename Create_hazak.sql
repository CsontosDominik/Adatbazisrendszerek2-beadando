drop table hazak;
create table hazak
(
    epitese varchar2(200) not null,
    szobakszama int not null,
    emelet int not null,
    futes varchar2(200) not null,
    varos varchar2(200) not null,
    iszam char(4) not null,
    tipus char(50) not null,
    hszam char(11) not null,
    
    constraint pk_hazak primary key(varos,hszam),
    constraint ch_tipus check(tipus in ('Kertesház', 'Társasház', 'Emeletesház'))
    
);
