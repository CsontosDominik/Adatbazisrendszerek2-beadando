set serveroutput on;
declare
    v_iszamhelyese int;
    v_iszam hazak.iszam%type := '3300';
begin
    v_iszamhelyese := sf_check_iszam(v_iszam);
    
    if  v_iszamhelyese = 1 then
        dbme_output.put_line('Az ir�ny�t�sz�m megfelelo form�tumu: '||v_iszam);
    else
        dbme_output.put_line('Az ir�ny�t�sz�m nem megfelelo form�tumu: '||v_iszam);
    end if;
end;