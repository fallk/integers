using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A244382
{
public static readonly long[] Value={ 7L,1L,8L,7L,9L,0L,3L,3L,5L,1L,6L,4L,1L,0L,6L,2L,2L,9L,4L,4L,0L,5L,1L,1L,7L,5L,4L,9L,2L,4L,4L,4L,2L,1L,0L,6L,7L,5L,4L,5L,7L,8L,4L,1L,8L,5L,4L,1L,5L,4L,2L,8L,7L,5L,4L,9L,5L,8L,0L,6L,6L,6L,3L,7L,2L,8L,2L,0L,0L,5L,2L,6L,6L,4L,4L,0L,0L,9L,4L,0L,6L,7L,4L,3L,4L,9L,5L,0L,8L,8L,5L,5L,8L,5L,3L,8L,8L,2L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244382Inst : IEnumerable<long>
{
public static readonly long[] Value=A244382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244382.Bytes);
public long this[int i]=>Value[i];

public static A244382Inst Instance=new A244382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244383
{
public static readonly long[] Value={ 2L,10L,24L,50L,64L,70L,138L,204L,222L,238L,270L,278L,344L,362L,448L,498L,508L,574L,814L,964L,994L,1188L,1216L,1340L,1374L,1394L,1426L,1454L,1510L,1556L,1582L,1652L,1748L,1760L,1880L,2060L,2180L,2192L,2224L,2424L,2436L,2500L,2674L,2784L,2874L,3166L,3168L,3190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244383Inst : IEnumerable<long>
{
public static readonly long[] Value=A244383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244383.Bytes);
public long this[int i]=>Value[i];

public static A244383Inst Instance=new A244383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244384
{
public static readonly long[] Value={ 60L,74L,86L,150L,164L,438L,446L,504L,560L,620L,830L,870L,890L,908L,990L,1194L,1302L,1488L,1596L,1668L,1788L,2252L,2354L,2564L,2652L,2838L,3194L,3602L,3792L,3828L,3924L,3960L,4296L,4506L,4608L,4676L,4968L,5352L,5402L,5504L,5694L,5868L,5922L,6150L,6170L,6176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244384Inst : IEnumerable<long>
{
public static readonly long[] Value=A244384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244384.Bytes);
public long this[int i]=>Value[i];

public static A244384Inst Instance=new A244384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244385
{
public static readonly long[] Value={ 10L,192L,244L,442L,474L,480L,654L,840L,862L,892L,904L,978L,1152L,1164L,1248L,1428L,1438L,1564L,1618L,1792L,1878L,2142L,2368L,2398L,2488L,2880L,3228L,3592L,3610L,3708L,3910L,3928L,4102L,4210L,4318L,4432L,4464L,5118L,5748L,5842L,6052L,6060L,6064L,6262L,6804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244385Inst : IEnumerable<long>
{
public static readonly long[] Value=A244385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244385.Bytes);
public long this[int i]=>Value[i];

public static A244385Inst Instance=new A244385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244386
{
public static readonly long[] Value={ 2L,88L,126L,230L,300L,582L,596L,612L,730L,790L,886L,978L,1000L,1022L,1088L,1160L,1616L,1710L,1958L,2200L,2480L,2512L,2746L,3058L,3120L,3132L,3142L,3348L,3398L,3546L,3568L,3800L,4068L,4190L,4268L,4438L,4446L,4692L,4780L,5012L,5026L,5300L,5498L,5558L,5698L,5880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244386Inst : IEnumerable<long>
{
public static readonly long[] Value=A244386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244386.Bytes);
public long this[int i]=>Value[i];

public static A244386Inst Instance=new A244386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244387
{
public static readonly long[] Value={ 102L,200L,570L,1368L,1428L,1674L,1796L,1980L,2148L,2426L,2534L,2600L,2990L,3006L,3138L,3188L,3696L,4116L,4122L,4710L,4808L,5078L,6072L,6158L,6486L,6732L,6762L,6956L,7080L,7146L,7190L,7328L,7866L,7976L,8256L,8664L,9494L,9758L,9780L,9890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244387Inst : IEnumerable<long>
{
public static readonly long[] Value=A244387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244387.Bytes);
public long this[int i]=>Value[i];

public static A244387Inst Instance=new A244387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244388
{
public static readonly long[] Value={ 4L,6L,60L,208L,250L,282L,294L,384L,400L,502L,760L,942L,1032L,1050L,1390L,1560L,2028L,2038L,2124L,2182L,3196L,4246L,4426L,4522L,4932L,4986L,5020L,5092L,5830L,6216L,6634L,6868L,7128L,7156L,7182L,7240L,7356L,7428L,7642L,7858L,8188L,8454L,8500L,8670L,9130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244388Inst : IEnumerable<long>
{
public static readonly long[] Value=A244388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244388.Bytes);
public long this[int i]=>Value[i];

public static A244388Inst Instance=new A244388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244389
{
public static readonly long[] Value={ 110L,130L,214L,258L,282L,392L,474L,522L,546L,676L,734L,856L,1096L,1116L,1186L,1192L,1376L,1446L,1540L,1552L,1558L,1804L,2032L,2100L,2154L,2474L,2614L,2848L,3092L,4550L,4932L,5000L,5354L,5554L,5604L,5878L,5996L,6136L,6410L,6648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244389Inst : IEnumerable<long>
{
public static readonly long[] Value=A244389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244389.Bytes);
public long this[int i]=>Value[i];

public static A244389Inst Instance=new A244389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244390
{
public static readonly long[] Value={ 12L,78L,92L,324L,588L,758L,800L,1248L,1380L,1472L,2324L,2450L,3038L,3930L,4328L,4370L,5580L,5952L,6072L,6164L,6872L,6890L,6918L,7814L,9318L,9734L,9944L,10074L,10122L,10272L,10598L,11070L,11298L,11852L,12054L,12210L,12930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244390Inst : IEnumerable<long>
{
public static readonly long[] Value=A244390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244390.Bytes);
public long this[int i]=>Value[i];

public static A244390Inst Instance=new A244390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244391
{
public static readonly long[] Value={ 100L,136L,276L,288L,696L,772L,810L,1036L,1128L,1602L,1678L,1806L,1956L,1962L,2212L,2220L,2500L,2610L,2670L,2718L,2796L,2818L,3066L,3366L,3598L,3936L,4198L,4360L,4452L,4782L,5340L,5998L,6126L,6202L,6210L,6990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244391Inst : IEnumerable<long>
{
public static readonly long[] Value=A244391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244391.Bytes);
public long this[int i]=>Value[i];

public static A244391Inst Instance=new A244391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244392
{
public static readonly long[] Value={ 2L,3L,11L,13L,17L,23L,29L,31L,41L,43L,47L,53L,61L,71L,83L,101L,103L,107L,113L,127L,131L,137L,211L,223L,227L,233L,241L,311L,313L,331L,401L,421L,431L,433L,443L,503L,521L,523L,541L,601L,613L,631L,641L,643L,701L,811L,821L,1013L,1021L,1031L,1033L,1051L,1061L,1063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244392Inst : IEnumerable<long>
{
public static readonly long[] Value=A244392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244392.Bytes);
public long this[int i]=>Value[i];

public static A244392Inst Instance=new A244392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244393
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,9L,13L,17L,25L,33L,45L,61L,82L,106L,142L,183L,238L,306L,395L,499L,638L,804L,1014L,1268L,1586L,1967L,2447L,3018L,3721L,4566L,5598L,6827L,8328L,10108L,12257L,14812L,17884L,21508L,25856L,30980L,37076L,44261L,52776L,62768L,74578L,88407L,104681L,123703L,146018L,172019L,202445L,237830L,279087L,326991L,382706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244393Inst : IEnumerable<long>
{
public static readonly long[] Value=A244393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244393.Bytes);
public long this[int i]=>Value[i];

public static A244393Inst Instance=new A244393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244394
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,111L,222L,333L,335L,444L,534L,551L,555L,579L,589L,666L,682L,777L,888L,954L,956L,999L,1102L,1111L,2138L,2204L,2222L,2246L,2649L,3190L,3333L,4354L,4408L,4428L,4444L,5332L,5376L,5555L,5644L,5925L,6294L,6666L,6933L,7480L,7528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244394Inst : IEnumerable<long>
{
public static readonly long[] Value=A244394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244394.Bytes);
public long this[int i]=>Value[i];

public static A244394Inst Instance=new A244394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244395
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,8L,11L,15L,20L,26L,34L,46L,59L,78L,101L,129L,163L,209L,261L,329L,412L,517L,641L,798L,986L,1216L,1493L,1829L,2229L,2721L,3303L,4000L,4841L,5841L,7034L,8458L,10144L,12137L,14512L,17306L,20596L,24483L,29045L,34391L,40680L,48032L,56627L,66666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244395Inst : IEnumerable<long>
{
public static readonly long[] Value=A244395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244395.Bytes);
public long this[int i]=>Value[i];

public static A244395Inst Instance=new A244395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244396
{
public static readonly long[] Value={ 2L,5L,12L,21L,39L,54L,87L,117L,162L,204L,279L,333L,435L,516L,624L,732L,900L,1017L,1224L,1380L,1590L,1785L,2082L,2286L,2616L,2886L,3237L,3543L,4005L,4305L,4830L,5238L,5748L,6204L,6816L,7266L,8004L,8571L,9279L,9879L,10779L,11373L,12360L,13110L,14010L,14835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244396Inst : IEnumerable<long>
{
public static readonly long[] Value=A244396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244396.Bytes);
public long this[int i]=>Value[i];

public static A244396Inst Instance=new A244396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244397
{
public static readonly long[] Value={ 22L,24L,28L,33L,39L,42L,44L,48L,55L,66L,77L,82L,84L,88L,93L,99L,111L,124L,164L,222L,248L,333L,444L,526L,548L,555L,666L,724L,777L,842L,888L,999L,1111L,1248L,1664L,2162L,2222L,2500L,2855L,3200L,3333L,3600L,3748L,4324L,4444L,4864L,5042L,5128L,5555L,5768L,5882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244397Inst : IEnumerable<long>
{
public static readonly long[] Value=A244397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244397.Bytes);
public long this[int i]=>Value[i];

public static A244397Inst Instance=new A244397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244398
{
public static readonly long[] Value={ 1L,2L,5L,10L,22L,45L,97L,206L,450L,982L,2178L,4849L,10904L,24630L,56010L,127911L,293546L,676156L,1563371L,3626148L,8436378L,19680276L,46026617L,107890608L,253450710L,596572386L,1406818758L,3323236237L,7862958390L,18632325318L,44214569099L,105061603968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244398Inst : IEnumerable<long>
{
public static readonly long[] Value=A244398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244398.Bytes);
public long this[int i]=>Value[i];

public static A244398Inst Instance=new A244398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244399
{
public static readonly long[] Value={ 1L,2L,6L,16L,43L,113L,300L,787L,2074L,5460L,14391L,37960L,100275L,265187L,702307L,1862463L,4945952L,13152441L,35023003L,93385548L,249330208L,666539949L,1784102735L,4781254117L,12828545419L,34459732110L,92668129050L,249469906115L,672296028786L,1813606782459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244399Inst : IEnumerable<long>
{
public static readonly long[] Value=A244399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244399.Bytes);
public long this[int i]=>Value[i];

public static A244399Inst Instance=new A244399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244400
{
public static readonly long[] Value={ 1L,2L,6L,17L,49L,136L,386L,1081L,3044L,8549L,24052L,67642L,190426L,536205L,1510920L,4259418L,12014682L,33907056L,95740913L,270468869L,764450150L,2161638413L,6115252839L,17307553766L,49005101669L,138811296158L,393351362321L,1115072623713L,3162183392471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244400Inst : IEnumerable<long>
{
public static readonly long[] Value=A244400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244400.Bytes);
public long this[int i]=>Value[i];

public static A244400Inst Instance=new A244400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244401
{
public static readonly long[] Value={ 1L,2L,6L,17L,50L,142L,409L,1169L,3356L,9617L,27601L,79210L,227527L,653793L,1879867L,5407806L,15564968L,44820889L,129127761L,372177974L,1073169150L,3095721985L,8933568154L,25789862435L,74477871565L,215155604291L,621754458752L,1797297119000L,5196966140656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244401Inst : IEnumerable<long>
{
public static readonly long[] Value=A244401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244401.Bytes);
public long this[int i]=>Value[i];

public static A244401Inst Instance=new A244401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244402
{
public static readonly long[] Value={ 1L,2L,6L,17L,50L,143L,415L,1192L,3444L,9931L,28687L,82857L,239563L,692878L,2005381L,5806915L,16824277L,48767953L,141430699L,410341703L,1191064873L,3458607705L,10046993035L,29196507434L,84874753458L,246814998803L,717965190047L,2089140528083L,6080768466919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244402Inst : IEnumerable<long>
{
public static readonly long[] Value=A244402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244402.Bytes);
public long this[int i]=>Value[i];

public static A244402Inst Instance=new A244402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244403
{
public static readonly long[] Value={ 1L,2L,6L,17L,50L,143L,416L,1198L,3467L,10019L,29001L,83945L,243228L,705012L,2044935L,5934425L,17231410L,50058023L,145491836L,423056364L,1230683672L,3581556220L,10427172296L,30368394833L,88476965536L,257860132679L,751756288476L,2192311994070L,6395199688864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244403Inst : IEnumerable<long>
{
public static readonly long[] Value=A244403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244403.Bytes);
public long this[int i]=>Value[i];

public static A244403Inst Instance=new A244403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244404
{
public static readonly long[] Value={ 1L,2L,6L,17L,50L,143L,416L,1199L,3473L,10042L,29089L,84259L,244316L,708679L,2057087L,5974077L,17359390L,50467157L,146789962L,427148444L,1243513350L,3621591235L,10551595959L,30753712080L,89666493709L,261522175986L,763002239120L,2226771020793L,6500575182332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244404Inst : IEnumerable<long>
{
public static readonly long[] Value=A244404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244404.Bytes);
public long this[int i]=>Value[i];

public static A244404Inst Instance=new A244404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244405
{
public static readonly long[] Value={ 1L,2L,6L,17L,50L,143L,416L,1199L,3474L,10048L,29112L,84347L,244630L,709767L,2060754L,5986231L,17399060L,50595235L,147199567L,428448576L,1247613511L,3634451971L,10591746511L,30878554201L,90053295475L,262716880036L,766682072349L,2238077375703L,6535237181868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244405Inst : IEnumerable<long>
{
public static readonly long[] Value=A244405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244405.Bytes);
public long this[int i]=>Value[i];

public static A244405Inst Instance=new A244405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244406
{
public static readonly long[] Value={ 1L,2L,6L,17L,50L,143L,416L,1199L,3474L,10049L,29118L,84370L,244718L,710081L,2061842L,5989898L,17411214L,50634907L,147327663L,428858279L,1248914115L,3638554143L,10604615353L,30918735919L,90178253585L,263104102071L,767878267996L,2241762411780L,6546561427512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244406Inst : IEnumerable<long>
{
public static readonly long[] Value=A244406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244406.Bytes);
public long this[int i]=>Value[i];

public static A244406Inst Instance=new A244406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244407
{
public static readonly long[] Value={ 1L,2L,6L,17L,50L,143L,416L,1199L,3474L,10049L,29119L,84377L,244748L,710199L,2062274L,5991418L,17416401L,50652248L,147384676L,429043390L,1249508947L,3640449679L,10610613552L,30937605076L,90237313083L,263288153074L,768449666117L,2243530461067L,6552016136667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244407Inst : IEnumerable<long>
{
public static readonly long[] Value=A244407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244407.Bytes);
public long this[int i]=>Value[i];

public static A244407Inst Instance=new A244407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244408
{
public static readonly long[] Value={ 4L,6L,8L,12L,18L,24L,30L,38L,98L,122L,126L,128L,220L,302L,308L,332L,346L,488L,556L,854L,908L,962L,992L,1144L,1150L,1274L,1354L,1360L,1362L,1382L,1408L,1424L,1532L,1768L,1856L,1928L,2078L,2188L,2200L,2438L,2512L,2530L,2618L,2642L,3458L,3818L,3848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244408Inst : IEnumerable<long>
{
public static readonly long[] Value=A244408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244408.Bytes);
public long this[int i]=>Value[i];

public static A244408Inst Instance=new A244408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244409
{
public static readonly long[] Value={ 3L,4L,6L,13L,15L,16L,43L,112L,278L,346L,527L,845L,1214L,1612L,2189L,2863L,10278L,610410L,981350L,2054106L,3286515L,3764767L,4293562L,5543363L,5728393L,20142483L,66790186L,67652048L,72730730L,137252581L,198373964L,338557754L,406463074L,687452210L,911028356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244409Inst : IEnumerable<long>
{
public static readonly long[] Value=A244409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244409.Bytes);
public long this[int i]=>Value[i];

public static A244409Inst Instance=new A244409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244410
{
public static readonly long[] Value={ 1L,1L,5L,16L,49L,142L,415L,1198L,3473L,10048L,29118L,84376L,244747L,710198L,2062273L,5991417L,17416400L,50652247L,147384675L,429043389L,1249508946L,3640449678L,10610613551L,30937605075L,90237313082L,263288153073L,768449666116L,2243530461066L,6552016136666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244410Inst : IEnumerable<long>
{
public static readonly long[] Value=A244410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244410.Bytes);
public long this[int i]=>Value[i];

public static A244410Inst Instance=new A244410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244411
{
public static readonly long[] Value={ 1L,4L,22L,26L,49L,111L,121L,202L,1001L,1111L,2285L,10001L,10201L,11111L,100001L,1000001L,1001001L,1012101L,1100011L,1101011L,1109111L,1111111L,3069307L,10000001L,12028229L,12866669L,100000001L,101000101L,110000011L,110091011L,200010002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244411Inst : IEnumerable<long>
{
public static readonly long[] Value=A244411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244411.Bytes);
public long this[int i]=>Value[i];

public static A244411Inst Instance=new A244411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244412
{
public static readonly long[] Value={ 18L,38L,38L,80L,102L,212L,224L,440L,440L,440L,578L,728L,1250L,1460L,1742L,2012L,2282L,3434L,3482L,4190L,4664L,4760L,4760L,6890L,7212L,7212L,7212L,8054L,10772L,12830L,12830L,13592L,13592L,14282L,17402L,17402L,17402L,18212L,22502L,22502L,22502L,25220L,28202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244412Inst : IEnumerable<long>
{
public static readonly long[] Value=A244412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244412.Bytes);
public long this[int i]=>Value[i];

public static A244412Inst Instance=new A244412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244413
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244413Inst : IEnumerable<long>
{
public static readonly long[] Value=A244413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244413.Bytes);
public long this[int i]=>Value[i];

public static A244413Inst Instance=new A244413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244414
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,7L,8L,9L,10L,11L,2L,13L,14L,15L,16L,17L,3L,19L,20L,21L,22L,23L,4L,25L,26L,27L,28L,29L,5L,31L,32L,33L,34L,35L,1L,37L,38L,39L,40L,41L,7L,43L,44L,45L,46L,47L,8L,49L,50L,51L,52L,53L,9L,55L,56L,57L,58L,59L,10L,61L,62L,63L,64L,65L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244414Inst : IEnumerable<long>
{
public static readonly long[] Value=A244414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244414.Bytes);
public long this[int i]=>Value[i];

public static A244414Inst Instance=new A244414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244415
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,3L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,3L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,3L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244415Inst : IEnumerable<long>
{
public static readonly long[] Value=A244415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244415.Bytes);
public long this[int i]=>Value[i];

public static A244415Inst Instance=new A244415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244416
{
public static readonly long[] Value={ 1L,6L,6L,36L,1L,6L,1L,216L,36L,6L,1L,36L,1L,6L,6L,1296L,1L,36L,1L,36L,6L,6L,1L,216L,1L,6L,216L,36L,1L,6L,1L,7776L,6L,6L,1L,36L,1L,6L,6L,216L,1L,6L,1L,36L,36L,6L,1L,1296L,1L,6L,6L,36L,1L,216L,1L,216L,6L,6L,1L,36L,1L,6L,36L,46656L,1L,6L,1L,36L,6L,6L,1L,216L,1L,6L,6L,36L,1L,6L,1L,1296L,1296L,6L,1L,36L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244416Inst : IEnumerable<long>
{
public static readonly long[] Value=A244416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244416.Bytes);
public long this[int i]=>Value[i];

public static A244416Inst Instance=new A244416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244417
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,1L,0L,3L,2L,1L,0L,2L,0L,1L,1L,4L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,3L,2L,0L,1L,0L,5L,1L,1L,0L,2L,0L,1L,1L,3L,0L,1L,0L,2L,2L,1L,0L,4L,0L,1L,1L,2L,0L,3L,0L,3L,1L,1L,0L,2L,0L,1L,2L,6L,0L,1L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,1L,0L,4L,4L,1L,0L,2L,0L,1L,1L,3L,0L,2L,0L,2L,1L,1L,0L,5L,0L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244417Inst : IEnumerable<long>
{
public static readonly long[] Value=A244417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244417.Bytes);
public long this[int i]=>Value[i];

public static A244417Inst Instance=new A244417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244418
{
public static readonly long[] Value={ 1L,2L,5L,3L,8L,13L,4L,11L,18L,25L,5L,14L,23L,32L,41L,6L,17L,28L,39L,50L,61L,7L,20L,33L,46L,59L,72L,85L,8L,23L,38L,53L,68L,83L,98L,113L,9L,26L,43L,60L,77L,94L,111L,128L,145L,10L,29L,48L,67L,86L,105L,124L,143L,162L,181L,11L,32L,53L,74L,95L,116L,137L,158L,179L,200L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244418Inst : IEnumerable<long>
{
public static readonly long[] Value=A244418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244418.Bytes);
public long this[int i]=>Value[i];

public static A244418Inst Instance=new A244418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244419
{
public static readonly long[] Value={ 1L,1L,2L,-1L,2L,4L,-1L,-4L,4L,8L,1L,-4L,-12L,8L,16L,1L,6L,-12L,-32L,16L,32L,-1L,6L,24L,-32L,-80L,32L,64L,-1L,-8L,24L,80L,-80L,-192L,64L,128L,1L,-8L,-40L,80L,240L,-192L,-448L,128L,256L,1L,10L,-40L,-160L,240L,672L,-448L,-1024L,256L,512L,-1L,10L,60L,-160L,-560L,672L,1792L,-1024L,-2304L,512L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244419Inst : IEnumerable<long>
{
public static readonly long[] Value=A244419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244419.Bytes);
public long this[int i]=>Value[i];

public static A244419Inst Instance=new A244419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244420
{
public static readonly long[] Value={ 1L,3L,1L,5L,5L,1L,35L,21L,7L,1L,63L,21L,9L,9L,1L,231L,165L,165L,55L,11L,1L,429L,1287L,715L,143L,39L,13L,1L,6435L,5005L,3003L,1365L,455L,105L,15L,1L,12155L,2431L,1547L,1547L,595L,85L,17L,17L,1L,46189L,37791L,12597L,6783L,2907L,969L,969L,171L,19L,1L,88179L,146965L,101745L,14535L,6783L,20349L,5985L,665L,105L,21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244420Inst : IEnumerable<long>
{
public static readonly long[] Value=A244420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244420.Bytes);
public long this[int i]=>Value[i];

public static A244420Inst Instance=new A244420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244421
{
public static readonly long[] Value={ 1L,4L,4L,8L,16L,16L,64L,64L,64L,64L,128L,64L,64L,256L,256L,512L,512L,1024L,1024L,1024L,1024L,1024L,4096L,4096L,2048L,2048L,4096L,4096L,16384L,16384L,16384L,16384L,16384L,16384L,16384L,16384L,32768L,8192L,8192L,16384L,16384L,8192L,8192L,65536L,65536L,131072L,131072L,65536L,65536L,65536L,65536L,262144L,262144L,262144L,262144L,262144L,524288L,524288L,131072L,131072L,1048576L,1048576L,524288L,524288L,1048576L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244421Inst : IEnumerable<long>
{
public static readonly long[] Value=A244421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244421.Bytes);
public long this[int i]=>Value[i];

public static A244421Inst Instance=new A244421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244422
{
public static readonly long[] Value={ 2L,1L,0L,1L,-2L,0L,1L,-3L,0L,0L,1L,-4L,2L,0L,0L,1L,-5L,5L,0L,0L,0L,1L,-6L,9L,-2L,0L,0L,0L,1L,-7L,14L,-7L,0L,0L,0L,0L,1L,-8L,20L,-16L,2L,0L,0L,0L,0L,1L,-9L,27L,-30L,9L,0L,0L,0L,0L,0L,1L,-10L,35L,-50L,25L,-2L,0L,0L,0L,0L,0L,1L,-11L,44L,-77L,55L,-11L,0L,0L,0L,0L,0L,0L,1L,-12L,54L,-112L,105L,-36L,2L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244422Inst : IEnumerable<long>
{
public static readonly long[] Value=A244422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244422.Bytes);
public long this[int i]=>Value[i];

public static A244422Inst Instance=new A244422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244423
{
public static readonly long[] Value={ 1L,4L,22L,111L,121L,202L,1001L,1111L,10001L,10201L,11111L,100001L,1000001L,1001001L,1012101L,1100011L,1101011L,1111111L,10000001L,100000001L,101000101L,110000011L,200010002L,10000000001L,10011111001L,11000100011L,11001010011L,11100100111L,11101010111L,20000100002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244423Inst : IEnumerable<long>
{
public static readonly long[] Value=A244423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244423.Bytes);
public long this[int i]=>Value[i];

public static A244423Inst Instance=new A244423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244424
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,2L,1L,2L,179L,0L,1L,2L,1L,4L,5L,28L,1L,3590L,1L,4L,0L,0L,1L,0L,25L,122L,0L,46L,1L,0L,1L,0L,71L,4L,569L,2L,1L,20L,5L,0L,1L,2L,1L,8L,0L,0L,1L,0L,193L,2L,0L,0L,1L,0L,0L,2L,5L,4L,1L,0L,1L,2L,0L,4L,5L,938L,1L,2L,119L,58L,1L,116L,1L,0L,125L,346L,5L,2L,1L,2L,0L,0L,1L,0L,0L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244424Inst : IEnumerable<long>
{
public static readonly long[] Value=A244424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244424.Bytes);
public long this[int i]=>Value[i];

public static A244424Inst Instance=new A244424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244425
{
public static readonly long[] Value={ 1L,5L,1L,7L,5L,5L,7L,1L,7L,5L,1L,1L,1L,5L,1L,1L,1L,2L,2L,9L,3L,3L,7L,4L,4L,7L,5L,5L,7L,6L,6L,9L,7L,7L,3L,8L,9L,7L,8L,7L,7L,8L,0L,3L,7L,2L,8L,5L,3L,2L,2L,3L,5L,8L,2L,7L,3L,0L,8L,7L,7L,8L,0L,3L,7L,2L,8L,5L,3L,2L,2L,3L,5L,8L,2L,7L,3L,0L,8L,7L,7L,8L,0L,3L,7L,2L,8L,5L,3L,2L,2L,3L,5L,8L,2L,7L,3L,0L,8L,7L,7L,8L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244425Inst : IEnumerable<long>
{
public static readonly long[] Value=A244425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244425.Bytes);
public long this[int i]=>Value[i];

public static A244425Inst Instance=new A244425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244426
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,1L,9L,8L,7L,2L,1L,1L,1L,0L,5L,1L,4L,1L,3L,1L,1L,8L,1L,7L,1L,6L,1L,2L,2L,2L,1L,2L,0L,2L,9L,7L,2L,6L,2L,5L,2L,4L,2L,3L,2L,3L,1L,3L,0L,3L,9L,2L,8L,2L,3L,7L,3L,6L,3L,5L,3L,4L,3L,3L,3L,4L,3L,4L,2L,4L,1L,4L,0L,4L,9L,3L,8L,0L,5L,9L,4L,8L,4L,7L,4L,6L,4L,5L,4L,4L,7L,5L,6L,5L,5L,5L,4L,5L,3L,5L,2L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244426Inst : IEnumerable<long>
{
public static readonly long[] Value=A244426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244426.Bytes);
public long this[int i]=>Value[i];

public static A244426Inst Instance=new A244426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244427
{
public static readonly long[] Value={ 1L,1L,2L,6L,9L,26L,80L,340L,1690L,11432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244427Inst : IEnumerable<long>
{
public static readonly long[] Value=A244427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244427.Bytes);
public long this[int i]=>Value[i];

public static A244427Inst Instance=new A244427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244428
{
public static readonly long[] Value={ 1L,1164L,8148L,11596L,12028L,28128L,32980L,34144L,34528L,36244L,38764L,39916L,41164L,41516L,73200L,75252L,81172L,84196L,94023L,100348L,181948L,182430L,192175L,193380L,193612L,194044L,195780L,196896L,200574L,204180L,208416L,211620L,214176L,217668L,220116L,225696L,230860L,235716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244428Inst : IEnumerable<long>
{
public static readonly long[] Value=A244428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244428.Bytes);
public long this[int i]=>Value[i];

public static A244428Inst Instance=new A244428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244429
{
public static readonly long[] Value={ 1L,56L,568L,1001L,1431L,3344L,10688L,17619L,24099L,37432L,40797L,46096L,50571L,52687L,55581L,62375L,75221L,88863L,97273L,98752L,111224L,134672L,235495L,247033L,251403L,266176L,269072L,271099L,275077L,299576L,320489L,333888L,364067L,372331L,407319L,534413L,561008L,614465L,646691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244429Inst : IEnumerable<long>
{
public static readonly long[] Value=A244429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244429.Bytes);
public long this[int i]=>Value[i];

public static A244429Inst Instance=new A244429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244430
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,44L,316L,2776L,28912L,347888L,4750064L,72548576L,1225540096L,22686824512L,456700011328L,9932944782464L,232113573798656L,5799735585095936L,154302762658308352L,4354977806995644928L,BigInteger.Parse("129961223706359609344"),BigInteger.Parse("4088626884119702752256"),BigInteger.Parse("135246429574930409348096") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244430Inst Instance=new A244430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244431
{
public static readonly long[] Value={ 16L,17L,26L,27L,39L,40L,41L,42L,44L,45L,47L,48L,53L,54L,55L,56L,59L,60L,71L,72L,74L,75L,81L,82L,83L,84L,85L,86L,89L,90L,99L,100L,102L,103L,105L,106L,107L,108L,123L,124L,125L,128L,129L,135L,136L,179L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244431Inst : IEnumerable<long>
{
public static readonly long[] Value=A244431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244431.Bytes);
public long this[int i]=>Value[i];

public static A244431Inst Instance=new A244431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244432
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,137L,1437L,18547L,284221L,5042289L,101635289L,2294115299L,57323597289L,1570795420537L,46836600355573L,1509632295204243L,52303597825637333L,1938434314587648353L,BigInteger.Parse("76521195859545355569"),BigInteger.Parse("3205495988651927796931"),BigInteger.Parse("142018837513142207290561") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244432Inst Instance=new A244432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244433
{
public static readonly long[] Value={ 4L,12L,19L,19L,59L,92L,159L,159L,159L,227L,227L,256L,256L,256L,514L,514L,706L,706L,706L,706L,706L,706L,706L,1466L,1466L,1466L,1466L,1466L,1466L,5207L,5207L,5207L,5207L,5207L,5207L,5207L,5207L,5207L,5207L,5207L,5207L,21209L,21209L,21209L,21209L,21209L,21209L,21209L,21209L,21209L,21209L,21209L,21209L,62809L,62809L,62809L,86914L,86914L,86914L,152351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244433Inst : IEnumerable<long>
{
public static readonly long[] Value=A244433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244433.Bytes);
public long this[int i]=>Value[i];

public static A244433Inst Instance=new A244433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244434
{
public static readonly long[] Value={ 2L,5L,6L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244434Inst : IEnumerable<long>
{
public static readonly long[] Value=A244434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244434.Bytes);
public long this[int i]=>Value[i];

public static A244434Inst Instance=new A244434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244435
{
public static readonly long[] Value={ 5L,13L,13L,62L,73L,73L,89L,118L,118L,118L,118L,118L,236L,926L,959L,959L,959L,959L,959L,959L,1063L,1474L,1474L,1474L,1667L,1667L,6118L,8249L,9098L,9098L,9098L,9098L,9098L,9098L,9098L,9098L,9098L,9098L,9098L,9098L,9098L,9098L,9098L,35573L,35573L,35573L,57448L,57448L,57448L,57448L,57448L,57448L,57448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244435Inst : IEnumerable<long>
{
public static readonly long[] Value=A244435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244435.Bytes);
public long this[int i]=>Value[i];

public static A244435Inst Instance=new A244435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244436
{
public static readonly long[] Value={ 4L,7L,13L,14L,21L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244436Inst : IEnumerable<long>
{
public static readonly long[] Value=A244436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244436.Bytes);
public long this[int i]=>Value[i];

public static A244436Inst Instance=new A244436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244437
{
public static readonly BigInteger[] Value={ 1L,1L,4L,41L,845L,30012L,1650475L,130216865L,13944696526L,1945060435587L,342412144747677L,74216506678085290L,BigInteger.Parse("19414505134246518741"),BigInteger.Parse("6029823819095965829293"),BigInteger.Parse("2193174302711080501699684"),BigInteger.Parse("923346371767630311443639677"),BigInteger.Parse("445468655004100653462280596881"),BigInteger.Parse("244137607569262412209821327718964") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244437Inst Instance=new A244437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244438
{
public static readonly long[] Value={ 8L,188L,285L,902L,2013L,8493L,37406L,40977L,61918L,68210L,90094L,303853L,352941L,360446L,375565L,467654L,501693L,724934L,889285L,940093L,1079662L,1473565L,1488957L,1517206L,1573045L,1692302L,1864285L,2048973L,2077405L,2346226L,2584106L,2693517L,3393934L,3509997L,3802029L,4083526L,4194406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244438Inst : IEnumerable<long>
{
public static readonly long[] Value=A244438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244438.Bytes);
public long this[int i]=>Value[i];

public static A244438Inst Instance=new A244438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244439
{
public static readonly long[] Value={ 5L,55L,56L,123L,135L,147L,175L,304L,351L,644L,1015L,2464L,19304L,61131L,162524L,476671L,567644L,712724L,801944L,2435488L,3346399L,3885056L,4555999L,8085560L,8369360L,12516692L,22702119L,29628800L,83884031L,83994624L,84789247L,354812535L,860616295L,1091535704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244439Inst : IEnumerable<long>
{
public static readonly long[] Value=A244439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244439.Bytes);
public long this[int i]=>Value[i];

public static A244439Inst Instance=new A244439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244440
{
public static readonly long[] Value={ 68L,668L,6668L,67744L,72352L,666668L,7143040L,66666752L,71430400L,666666752L,714304000L,6666666668L,7143040000L,71430400000L,666666666668L,666666668032L,714304000000L,714499133440L,7143040000000L,7144991334400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244440Inst : IEnumerable<long>
{
public static readonly long[] Value=A244440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244440.Bytes);
public long this[int i]=>Value[i];

public static A244440Inst Instance=new A244440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244441
{
public static readonly long[] Value={ 2L,31L,2621L,9941L,5599921L,5599921L,5219088341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244441Inst : IEnumerable<long>
{
public static readonly long[] Value=A244441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244441.Bytes);
public long this[int i]=>Value[i];

public static A244441Inst Instance=new A244441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244442
{
public static readonly long[] Value={ 2L,2L,2L,834007L,53918617L,53918617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244442Inst : IEnumerable<long>
{
public static readonly long[] Value=A244442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244442.Bytes);
public long this[int i]=>Value[i];

public static A244442Inst Instance=new A244442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244443
{
public static readonly long[] Value={ 2L,6L,15L,77L,185L,187L,475L,3820L,4043L,4090L,11231L,30589L,57023L,126815L,131055L,983032L,983033L,2617339L,4046839L,11534206L,11534207L,65011702L,66777087L,368279551L,469745405L,973061887L,1064828671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244443Inst : IEnumerable<long>
{
public static readonly long[] Value=A244443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244443.Bytes);
public long this[int i]=>Value[i];

public static A244443Inst Instance=new A244443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244444
{
public static readonly long[] Value={ 4L,5L,506311L,4761903L,506767303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244444Inst : IEnumerable<long>
{
public static readonly long[] Value=A244444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244444.Bytes);
public long this[int i]=>Value[i];

public static A244444Inst Instance=new A244444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244445
{
public static readonly long[] Value={ 2L,3L,4L,4L,2L,5L,2L,2L,2L,8L,2L,2L,2L,5L,3L,2L,2L,3L,2L,2L,3L,4L,2L,3L,3L,2L,2L,3L,2L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,6L,2L,2L,26L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244445Inst : IEnumerable<long>
{
public static readonly long[] Value=A244445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244445.Bytes);
public long this[int i]=>Value[i];

public static A244445Inst Instance=new A244445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244446
{
public static readonly long[] Value={ 25L,323L,48L,34L,53L,471L,58L,78L,84L,76L,71L,122L,64L,144L,162L,118L,74L,188L,106L,258L,156L,2512L,68L,254L,94L,107L,132L,2326L,876L,536L,154L,182L,268L,468L,98L,2061L,106L,408L,264L,286L,258L,1520900L,423L,618L,276L,648L,579L,518L,204L,708L,196L,370L,164L,1088L,300L,1518L,412L,3616L,158L,1226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244446Inst : IEnumerable<long>
{
public static readonly long[] Value=A244446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244446.Bytes);
public long this[int i]=>Value[i];

public static A244446Inst Instance=new A244446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244447
{
public static readonly long[] Value={ 11L,8L,13L,37350L,25L,18L,28L,20L,61L,22L,44L,40L,52L,250L,39L,60L,68L,60L,58L,76L,168L,46L,92L,69L,2040L,56L,126L,84L,114L,140L,88L,74L,108L,90L,288L,92L,148L,108L,283L,324L,164L,180L,100L,40878L,125L,474L,162L,108L,773L,71L,111L,240L,168L,315L,148L,194L,564L,390L,128L,144L,124L,164L,153L,279L,1008L,162L,102L,152L,432L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244447Inst : IEnumerable<long>
{
public static readonly long[] Value=A244447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244447.Bytes);
public long this[int i]=>Value[i];

public static A244447Inst Instance=new A244447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244448
{
public static readonly long[] Value={ 4L,153L,442L,213L,179L,120L,46L,37L,47L,264L,145416L,1101L,107L,79L,71L,78L,716L,637L,98L,249L,71L,126L,13258L,1243L,119L,163L,119L,131L,140497L,381L,191L,156L,101L,169L,1574L,315L,151L,193L,167L,2158L,148L,104L,202L,289L,1969L,882L,2572L,428L,251L,357L,314L,283L,2327L,1281L,199L,130L,212L,1128L,148L,1039L,235L,5081L,17483L,271L,430L,257L,431L,1225L,191L,234L,19638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244448Inst : IEnumerable<long>
{
public static readonly long[] Value=A244448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244448.Bytes);
public long this[int i]=>Value[i];

public static A244448Inst Instance=new A244448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244449
{
public static readonly long[] Value={ 20L,80L,320L,20480L,65792L,327680L,1310720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244449Inst : IEnumerable<long>
{
public static readonly long[] Value=A244449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244449.Bytes);
public long this[int i]=>Value[i];

public static A244449Inst Instance=new A244449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244450
{
public static readonly BigInteger[] Value={ 1L,10000000000L,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("1000000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244450Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244450.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244450Inst Instance=new A244450Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244451
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,236L,2756L,39376L,665464L,12986416L,287394416L,7112021696L,194607175136L,5834321568064L,190181750900416L,6697115871398656L,253362903806266496L,10248299242094541056UL,BigInteger.Parse("441359565949128552704"),BigInteger.Parse("20163160035504969573376"),BigInteger.Parse("973917774772339989408256") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244451Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244451.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244451Inst Instance=new A244451Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244452
{
public static readonly long[] Value={ 3L,5L,7L,13L,37L,47L,103L,233L,293L,313L,607L,677L,743L,1367L,1447L,2087L,2543L,3023L,3803L,3863L,4093L,4153L,4373L,4583L,4643L,4793L,4957L,5087L,5153L,5623L,5683L,5923L,6287L,7177L,7247L,7547L,7817L,8093L,8527L,9133L,9403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244452Inst : IEnumerable<long>
{
public static readonly long[] Value=A244452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244452.Bytes);
public long this[int i]=>Value[i];

public static A244452Inst Instance=new A244452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244453
{
public static readonly long[] Value={ 23L,89L,47L,178481L,233L,1103L,2089L,223L,616318177L,13367L,164511353L,431L,9719L,2099863L,2351L,4513L,13264529L,6361L,69431L,20394401L,179951L,3203431780337L,193707721L,761838257287L,228479L,48544121L,212885833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244453Inst : IEnumerable<long>
{
public static readonly long[] Value=A244453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244453.Bytes);
public long this[int i]=>Value[i];

public static A244453Inst Instance=new A244453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244454
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,0L,1L,0L,7L,1L,0L,1L,0L,17L,2L,0L,0L,1L,0L,42L,4L,1L,0L,0L,1L,0L,105L,7L,2L,0L,0L,0L,1L,0L,267L,15L,2L,1L,0L,0L,0L,1L,0L,684L,28L,4L,2L,0L,0L,0L,0L,1L,0L,1775L,56L,7L,2L,1L,0L,0L,0L,0L,1L,0L,4639L,110L,12L,2L,2L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244454Inst : IEnumerable<long>
{
public static readonly long[] Value=A244454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244454.Bytes);
public long this[int i]=>Value[i];

public static A244454Inst Instance=new A244454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244455
{
public static readonly long[] Value={ 1L,1L,3L,7L,17L,42L,105L,267L,684L,1775L,4639L,12238L,32491L,86859L,233496L,631082L,1713613L,4673455L,12795426L,35159212L,96927479L,268021520L,743188706L,2066071045L,5757360011L,16079027344L,44997313684L,126166307275L,354384737204L,997083779801L,2809751278062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244455Inst : IEnumerable<long>
{
public static readonly long[] Value=A244455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244455.Bytes);
public long this[int i]=>Value[i];

public static A244455Inst Instance=new A244455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244456
{
public static readonly long[] Value={ 1L,0L,1L,2L,4L,7L,15L,28L,56L,110L,220L,436L,878L,1762L,3560L,7205L,14650L,29838L,60991L,124938L,256628L,528238L,1089834L,2252860L,4666304L,9682422L,20125777L,41900433L,87369029L,182441944L,381499040L,798782945L,1674575394L,3514733683L,7385298837L,15534856067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244456Inst : IEnumerable<long>
{
public static readonly long[] Value=A244456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244456.Bytes);
public long this[int i]=>Value[i];

public static A244456Inst Instance=new A244456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244457
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,2L,4L,7L,12L,20L,34L,56L,98L,167L,284L,484L,835L,1433L,2467L,4250L,7345L,12700L,22004L,38154L,66266L,115224L,200623L,349654L,610126L,1065739L,1863547L,3261672L,5714277L,10020092L,17586014L,30890654L,54305289L,95542387L,168221056L,296401979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244457Inst : IEnumerable<long>
{
public static readonly long[] Value=A244457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244457.Bytes);
public long this[int i]=>Value[i];

public static A244457Inst Instance=new A244457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244458
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,2L,2L,2L,4L,7L,12L,16L,25L,38L,61L,94L,147L,227L,356L,550L,862L,1345L,2113L,3299L,5168L,8091L,12721L,19981L,31421L,49384L,77761L,122487L,193151L,304623L,480852L,759367L,1200150L,1897594L,3002329L,4752436L,7527155L,11927290L,18909719L,29993579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244458Inst : IEnumerable<long>
{
public static readonly long[] Value=A244458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244458.Bytes);
public long this[int i]=>Value[i];

public static A244458Inst Instance=new A244458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244459
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,2L,2L,2L,2L,4L,7L,12L,16L,21L,29L,43L,65L,99L,142L,206L,297L,436L,641L,945L,1383L,2029L,2976L,4378L,6432L,9464L,13913L,20495L,30205L,44547L,65670L,96846L,142857L,210941L,311636L,460613L,680848L,1006682L,1488915L,2203324L,3261840L,4830671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244459Inst : IEnumerable<long>
{
public static readonly long[] Value=A244459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244459.Bytes);
public long this[int i]=>Value[i];

public static A244459Inst Instance=new A244459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244460
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,2L,2L,2L,2L,2L,4L,7L,12L,16L,21L,25L,34L,47L,70L,103L,147L,201L,276L,377L,527L,743L,1057L,1486L,2088L,2911L,4073L,5704L,8027L,11290L,15897L,22340L,31411L,44159L,62165L,87516L,123296L,173642L,244636L,344684L,485976L,685362L,966971L,1364301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244460Inst : IEnumerable<long>
{
public static readonly long[] Value=A244460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244460.Bytes);
public long this[int i]=>Value[i];

public static A244460Inst Instance=new A244460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244461
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,2L,2L,2L,2L,2L,2L,4L,7L,12L,16L,21L,25L,30L,38L,52L,74L,108L,151L,206L,271L,356L,468L,629L,855L,1180L,1620L,2212L,2991L,4030L,5420L,7320L,9922L,13508L,18396L,25049L,34032L,46194L,62653L,85051L,115548L,157168L,213852L,291046L,395990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244461Inst : IEnumerable<long>
{
public static readonly long[] Value=A244461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244461.Bytes);
public long this[int i]=>Value[i];

public static A244461Inst Instance=new A244461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244462
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,2L,2L,2L,2L,2L,4L,7L,12L,16L,21L,25L,30L,34L,43L,56L,79L,112L,156L,210L,276L,351L,447L,570L,741L,978L,1314L,1764L,2367L,3137L,4131L,5398L,7058L,9236L,12161L,16077L,21340L,28326L,37573L,49696L,65623L,86526L,114122L,150624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244462Inst : IEnumerable<long>
{
public static readonly long[] Value=A244462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244462.Bytes);
public long this[int i]=>Value[i];

public static A244462Inst Instance=new A244462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244463
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,2L,2L,2L,2L,2L,2L,4L,7L,12L,16L,21L,25L,30L,34L,39L,47L,61L,83L,117L,160L,215L,280L,356L,442L,549L,682L,864L,1112L,1458L,1919L,2533L,3313L,4298L,5521L,7057L,8995L,11497L,14751L,19042L,24687L,32102L,41731L,54172L,70112L,90535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244463Inst : IEnumerable<long>
{
public static readonly long[] Value=A244463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244463.Bytes);
public long this[int i]=>Value[i];

public static A244463Inst Instance=new A244463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244464
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,7L,12L,16L,21L,25L,30L,34L,39L,43L,52L,65L,88L,121L,165L,219L,285L,360L,447L,544L,661L,805L,998L,1256L,1613L,2085L,2709L,3500L,4496L,5709L,7201L,9016L,11277L,14108L,17738L,22410L,28484L,36330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244464Inst : IEnumerable<long>
{
public static readonly long[] Value=A244464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244464.Bytes);
public long this[int i]=>Value[i];

public static A244464Inst Instance=new A244464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244465
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244465Inst : IEnumerable<long>
{
public static readonly long[] Value=A244465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244465.Bytes);
public long this[int i]=>Value[i];

public static A244465Inst Instance=new A244465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244466
{
public static readonly long[] Value={ 1L,9L,14L,18L,22L,46L,94L,118L,166L,214L,334L,358L,422L,454L,526L,662L,694L,718L,766L,926L,934L,958L,961L,1006L,1094L,1126L,1142L,1174L,1382L,1438L,1678L,1718L,1726L,1774L,1822L,1849L,1922L,1934L,1966L,2038L,2246L,2374L,2462L,2566L,2582L,2606L,2614L,2638L,2654L,2734L,2878L,2966L,2974L,3046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244466Inst : IEnumerable<long>
{
public static readonly long[] Value=A244466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244466.Bytes);
public long this[int i]=>Value[i];

public static A244466Inst Instance=new A244466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244467
{
public static readonly long[] Value={ 1L,3L,6L,8L,8L,0L,8L,1L,0L,7L,8L,5L,3L,2L,2L,3L,5L,9L,3L,9L,6L,4L,3L,3L,4L,7L,0L,5L,0L,7L,5L,4L,4L,5L,8L,1L,6L,1L,8L,6L,5L,5L,6L,9L,2L,7L,2L,9L,7L,6L,6L,8L,0L,3L,8L,4L,0L,8L,7L,7L,9L,1L,4L,9L,5L,1L,9L,8L,9L,0L,2L,6L,0L,6L,3L,1L,0L,0L,1L,3L,7L,1L,7L,4L,2L,1L,1L,2L,4L,8L,2L,8L,5L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244467Inst : IEnumerable<long>
{
public static readonly long[] Value=A244467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244467.Bytes);
public long this[int i]=>Value[i];

public static A244467Inst Instance=new A244467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244468
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,293L,6056L,175687L,6719476L,325741705L,19470659968L,1403821003211L,119836341280844L,11923671362914093L,1365089081187409072L,BigInteger.Parse("177915120382062044815"),BigInteger.Parse("26161941602115263558716"),BigInteger.Parse("4306833594841510336897553"),BigInteger.Parse("788302770933266249649820544"),BigInteger.Parse("159446049770474152196515579027") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244468Inst Instance=new A244468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244469
{
public static readonly BigInteger[] Value={ 0L,1L,7L,58L,515L,4746L,44758L,428772L,4154403L,40599130L,399429602L,3950996556L,39255152846L,391466112324L,3916110379020L,39281346256008L,394942611929379L,3978982062756090L,40160256911157610L,405995113593507900L,4110284071450416090L,BigInteger.Parse("41666530928566504620"),BigInteger.Parse("422876855107176561780") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244469Inst Instance=new A244469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244470
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,9L,17L,25L,40L,72L,106L,169L,305L,449L,716L,1292L,1902L,3033L,5473L,8057L,12848L,23184L,34130L,54425L,98209L,144577L,230548L,416020L,612438L,976617L,1762289L,2594329L,4137016L,7465176L,10989754L,17524681L,31622993L,46553345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244470Inst : IEnumerable<long>
{
public static readonly long[] Value=A244470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244470.Bytes);
public long this[int i]=>Value[i];

public static A244470Inst Instance=new A244470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244471
{
public static readonly long[] Value={ 1L,11L,3L,7L,71L,31L,111L,113L,33L,117L,77L,13L,37L,711L,1111L,19L,9L,91L,1117L,73L,311L,131L,1131L,1133L,93L,331L,11111L,39L,99L,97L,119L,333L,911L,133L,931L,1139L,771L,337L,713L,339L,933L,391L,1137L,773L,1113L,991L,11171L,3111L,777L,3311L,79L,17L,191L,171L,11311L,137L,719L,993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244471Inst : IEnumerable<long>
{
public static readonly long[] Value=A244471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244471.Bytes);
public long this[int i]=>Value[i];

public static A244471Inst Instance=new A244471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244472
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,19L,31L,50L,81L,131L,212L,343L,555L,898L,1453L,2351L,3804L,6155L,9959L,16114L,26073L,42187L,68260L,110447L,178707L,289154L,467861L,757015L,1224876L,1981891L,3206767L,5188658L,8395425L,13584083L,21979508L,35563591L,57543099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244472Inst : IEnumerable<long>
{
public static readonly long[] Value=A244472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244472.Bytes);
public long this[int i]=>Value[i];

public static A244472Inst Instance=new A244472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244473
{
public static readonly long[] Value={ 1L,3L,5L,11L,18L,30L,49L,80L,129L,209L,338L,547L,885L,1432L,2317L,3749L,6066L,9815L,15881L,25696L,41577L,67273L,108850L,176123L,284973L,461096L,746069L,1207165L,1953234L,3160399L,5113633L,8274032L,13387665L,21661697L,35049362L,56711059L,91760421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244473Inst : IEnumerable<long>
{
public static readonly long[] Value=A244473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244473.Bytes);
public long this[int i]=>Value[i];

public static A244473Inst Instance=new A244473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244474
{
public static readonly long[] Value={ 2L,4L,10L,17L,29L,47L,79L,128L,208L,337L,546L,883L,1429L,2312L,3741L,6053L,9794L,15847L,25641L,41488L,67129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244474Inst : IEnumerable<long>
{
public static readonly long[] Value=A244474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244474.Bytes);
public long this[int i]=>Value[i];

public static A244474Inst Instance=new A244474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244475
{
public static readonly long[] Value={ 1L,3L,9L,16L,27L,46L,76L,123L,207L,335L,545L,882L,1428L,2311L,3740L,6051L,9791L,15842L,25633L,41475L,67108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244475Inst : IEnumerable<long>
{
public static readonly long[] Value=A244475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244475.Bytes);
public long this[int i]=>Value[i];

public static A244475Inst Instance=new A244475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244476
{
public static readonly long[] Value={ 2L,8L,15L,26L,45L,75L,121L,199L,322L,542L,877L,1427L,2309L,3739L,6050L,9790L,15841L,25632L,41473L,67105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244476Inst : IEnumerable<long>
{
public static readonly long[] Value=A244476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244476.Bytes);
public long this[int i]=>Value[i];

public static A244476Inst Instance=new A244476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244477
{
public static readonly long[] Value={ 3L,2L,1L,3L,5L,4L,3L,8L,7L,3L,11L,10L,3L,14L,13L,3L,17L,16L,3L,20L,19L,3L,23L,22L,3L,26L,25L,3L,29L,28L,3L,32L,31L,3L,35L,34L,3L,38L,37L,3L,41L,40L,3L,44L,43L,3L,47L,46L,3L,50L,49L,3L,53L,52L,3L,56L,55L,3L,59L,58L,3L,62L,61L,3L,65L,64L,3L,68L,67L,3L,71L,70L,3L,74L,73L,3L,77L,76L,3L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244477Inst : IEnumerable<long>
{
public static readonly long[] Value=A244477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244477.Bytes);
public long this[int i]=>Value[i];

public static A244477Inst Instance=new A244477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244478
{
public static readonly long[] Value={ 2L,0L,2L,2L,2L,2L,4L,4L,4L,4L,4L,6L,6L,6L,8L,8L,8L,8L,8L,8L,10L,10L,10L,12L,12L,12L,12L,14L,14L,14L,16L,16L,16L,16L,16L,16L,16L,18L,18L,18L,20L,20L,20L,20L,22L,22L,22L,24L,24L,24L,24L,24L,26L,26L,26L,28L,28L,28L,28L,30L,30L,30L,32L,32L,32L,32L,32L,32L,32L,32L,34L,34L,34L,36L,36L,36L,36L,38L,38L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244478Inst : IEnumerable<long>
{
public static readonly long[] Value=A244478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244478.Bytes);
public long this[int i]=>Value[i];

public static A244478Inst Instance=new A244478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244479
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244479Inst : IEnumerable<long>
{
public static readonly long[] Value=A244479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244479.Bytes);
public long this[int i]=>Value[i];

public static A244479Inst Instance=new A244479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244480
{
public static readonly long[] Value={ 2L,2L,2L,5L,5L,8L,8L,8L,11L,14L,14L,17L,20L,20L,20L,23L,26L,26L,29L,32L,32L,32L,32L,32L,32L,32L,35L,38L,38L,41L,44L,47L,50L,53L,53L,56L,59L,59L,62L,62L,65L,68L,71L,74L,77L,77L,80L,83L,83L,83L,83L,83L,83L,83L,86L,89L,89L,92L,95L,98L,101L,104L,104L,107L,110L,110L,113L,113L,116L,119L,122L,125L,128L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244480Inst : IEnumerable<long>
{
public static readonly long[] Value=A244480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244480.Bytes);
public long this[int i]=>Value[i];

public static A244480Inst Instance=new A244480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244481
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,4L,7L,7L,7L,10L,10L,13L,16L,19L,19L,19L,19L,19L,19L,19L,22L,22L,25L,28L,31L,31L,31L,31L,31L,31L,31L,34L,37L,40L,40L,43L,46L,46L,49L,49L,52L,55L,58L,61L,64L,64L,67L,70L,73L,73L,76L,79L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,82L,85L,88L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244481Inst : IEnumerable<long>
{
public static readonly long[] Value=A244481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244481.Bytes);
public long this[int i]=>Value[i];

public static A244481Inst Instance=new A244481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}