create or replace function sf_check_iszam
(
    p_iszam  in autok.iszam%type
)
return int
deterministic
as
    v_iszam_char char(1);
    v_ciklus int;
begin
if p_iszam is null then
    return 0;
end if;
if length(trim(p_iszam)) = 4 then
    v_ciklus :=1;
    while v_ciklus <=4 loop
        v_iszam_char := substr(p_iszam, v_ciklus, 1);
        if not 1 <= v_rendszam_char and v_rendszam_char <= 9 then
            return 0;            
        end if;
        v_ciklus := v_ciklus +1;
    end loop;
    return 1;
end if;
return 0;
end sf_check_iszam;
        