CREATE OR REPLACE PROCEDURE app_user.sp_update_user (
    p_id     IN VARCHAR2,
    p_name   IN VARCHAR2,
    p_email  IN VARCHAR2,
    p_result OUT VARCHAR2
)
IS
BEGIN
    -- Validações básicas
    IF p_id IS NULL OR TRIM(p_id) IS NULL THEN
        p_result := 'Erro: O campo ID é obrigatório.';
        RETURN;
    ELSIF p_name IS NULL OR TRIM(p_name) IS NULL THEN
        p_result := 'Erro: O campo Nome é obrigatório.';
        RETURN;
    ELSIF p_email IS NULL OR TRIM(p_email) IS NULL THEN
        p_result := 'Erro: O campo E-mail é obrigatório.';
        RETURN;
    END IF;

    -- Atualização no banco
    UPDATE app_user.users
    SET name = p_name,
        email = p_email
    WHERE id = p_id;

    -- Verifica se algum registro foi atualizado
    IF SQL%ROWCOUNT = 0 THEN
        p_result := 'Erro: Usuário não encontrado.';
    ELSE
        p_result := 'Usuário atualizado com sucesso.';
    END IF;
END;
