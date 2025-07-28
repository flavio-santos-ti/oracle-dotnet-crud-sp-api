CREATE OR REPLACE VIEW app_user.vw_users AS
SELECT
    id,
    name,
    email
FROM
    app_user.users;
