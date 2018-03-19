#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("pn5dPhHrXMchFH/Vu8sZXTDvPHpbl7ZnhkXdjRA7NeXKCUYpSOXoiTiY9EMC3aNRY8NbjzJI1ce4TYEAY2iovDbM89eMt451sYMJIZd8J5A8zzoOzNSV17RSTp6zhqwkuLnsPcLafH7WHzA0ZLTm8MhI8w/NJ6PKVcJYj2Wl2zwUxGaBfWYD6ZO/L6UfOSBSpKWBEgMZDlDhL1x1lZ/ccze0urWFN7S/tze0tLUTuK43CSTRr/htd9XCLJuXNsR9EfmuWuXNnmy/PUolmAT+Z1yrWVpfjNBsrAGfvTPTl3zjXS57zp0QfgHw/6DIHSAjhTe0l4W4s7yfM/0zQri0tLSwtba2UUFlkvgqgzC8VgUjfz95LArIeHo56rYoj1rrMre2tLW0");
        private static int[] order = new int[] { 8,13,2,6,5,6,6,10,13,11,12,12,13,13,14 };
        private static int key = 181;

        public static byte[] Data() {
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
