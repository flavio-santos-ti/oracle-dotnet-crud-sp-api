CREATE OR REPLACE PROCEDURE app_user.sp_insert_user (
    p_id     IN VARCHAR2,
    p_name   IN VARCHAR2,
    p_email  IN VARCHAR2,
    p_result OUT VARCHAR2
) AS
BEGIN
    -- Validações básicas
    IF p_id IS NULL OR TRIM(p_id) IS NULL THEN
        p_result := 'O campo ID é obrigatório.';
        RETURN;
    ELSIF p_name IS NULL OR TRIM(p_name) IS NULL THEN
        p_result := 'O campo Nome é obrigatório.';
        RETURN;
    ELSIF p_email IS NULL OR TRIM(p_email) IS NULL THEN
        p_result := 'O campo E-mail é obrigatório.';
        RETURN;
    END IF;

    -- Insercao no banco
    INSERT INTO app_user.users (id, name, email)
    VALUES (p_id, p_name, p_email);

    p_result := 'Usuário inserido com sucesso.';

EXCEPTION
    WHEN OTHERS THEN
        p_result := 'Erro: ' || SQLERRM;
END;
