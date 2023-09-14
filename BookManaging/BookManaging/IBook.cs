namespace BookManaging
{
    /// <summary>
    /// Interface mô tả thông tin về một cuốn sách.
    /// </summary>
    interface IBook
    {
        /// <summary>
        /// Chỉ mục (indexer) cho danh sách chương sách.
        /// </summary>
        /// <param name="index">Chỉ mục của chương sách.</param>
        /// <returns>Tên chương sách.</returns>
        string this[int index] { get; set; }

        /// <summary>
        /// Tên của cuốn sách.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Tên tác giả của cuốn sách.
        /// </summary>
        string Author { get; set; }

        /// <summary>
        /// Nhà xuất bản của cuốn sách.
        /// </summary>
        string Publisher { get; set; }

        /// <summary>
        /// Số ISBN (International Standard Book Number) của cuốn sách.
        /// </summary>
        string ISBN { get; set; }

        /// <summary>
        /// Năm xuất bản của cuốn sách.
        /// </summary>
        int Year { get; set; }

        /// <summary>
        /// Hiển thị thông tin của cuốn sách.
        /// </summary>
        void Show();
    }
}
