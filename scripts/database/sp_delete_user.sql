CREATE OR REPLACE PROCEDURE app_user.sp_delete_user (
    p_id     IN VARCHAR2,
    p_result OUT VARCHAR2
)
IS
BEGIN
    IF p_id IS NULL OR TRIM(p_id) IS NULL THEN
        p_result := 'Erro: O campo ID é obrigatório.';
        RETURN;
    END IF;

    DELETE FROM app_user.users
    WHERE id = p_id;

    IF SQL%ROWCOUNT = 0 THEN
        p_result := 'Erro: Usuário não encontrado.';
    ELSE
        p_result := 'Usuário excluído com sucesso.';
    END IF;
END;
