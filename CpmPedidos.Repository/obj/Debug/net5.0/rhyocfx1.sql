CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

ALTER TABLE tb_imagem DROP CONSTRAINT "FK_tb_imagem_tb_produto_ProdutoId";

DROP INDEX "IX_tb_imagem_ProdutoId";

ALTER TABLE tb_imagem DROP COLUMN "ProdutoId";

CREATE TABLE tb_imagem_produto (
    id_imagem integer NOT NULL,
    id_produto integer NOT NULL,
    CONSTRAINT "PK_tb_imagem_produto" PRIMARY KEY (id_imagem, id_produto),
    CONSTRAINT "FK_tb_imagem_produto_tb_imagem_id_imagem" FOREIGN KEY (id_imagem) REFERENCES tb_imagem (id) ON DELETE CASCADE,
    CONSTRAINT "FK_tb_imagem_produto_tb_produto_id_produto" FOREIGN KEY (id_produto) REFERENCES tb_produto (id) ON DELETE CASCADE
);

CREATE INDEX "IX_tb_imagem_produto_id_produto" ON tb_imagem_produto (id_produto);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20210201171455_Init', '5.0.2');

COMMIT;

