using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A083491
{
public static readonly long[] Value={ 3L,6L,9L,12L,30L,42L,51L,60L,72L,81L,90L,111L,204L,315L,402L,513L,600L,711L,804L,912L,3000L,4116L,5007L,6111L,7002L,8115L,9000L,11112L,30000L,41112L,50007L,61113L,70002L,81111L,90000L,111111L,200004L,311115L,400002L,511113L,600000L,711111L,800004L };
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
public class A083491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083491Inst : IEnumerable<long>
{
public static readonly long[] Value=A083491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083491.Bytes);
public long this[int i]=>Value[i];

public static A083491Inst Instance=new A083491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083508
{
public static readonly long[] Value={ 0L,0L,2L,7L,16L,24L,40L,56L,77L,96L,137L,158L,214L,249L,284L,322L,418L,464L,583L,645L,708L,774L,946L,1007L,1125L,1220L,1330L,1420L,1685L,1768L,2069L,2203L,2346L,2492L,2658L,2750L,3166L,3362L,3553L,3675L,4183L,4344L,4909L,5129L,5327L,5575L,6252L,6432L,6849L };
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
public class A083508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083508Inst : IEnumerable<long>
{
public static readonly long[] Value=A083508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083508.Bytes);
public long this[int i]=>Value[i];

public static A083508Inst Instance=new A083508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083509
{
public static readonly long[] Value={ 25L,121L,125L,127L,128L,216L,289L,343L,347L,625L,736L,1022L,1024L,1285L,1296L,1792L,2048L,2187L,2349L,2500L,2501L,2502L,2503L,2504L,2505L,2506L,2507L,2508L,2509L,2592L,2737L,2916L,3125L,3281L,3375L,3378L,3685L,3864L,3972L,4088L,4096L,4106L,4167L,4536L,4624L };
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
public class A083509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083509Inst : IEnumerable<long>
{
public static readonly long[] Value=A083509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083509.Bytes);
public long this[int i]=>Value[i];

public static A083509Inst Instance=new A083509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083510
{
public static readonly long[] Value={ 4L,22L,29L,37L,79L,106L,154L,172L,191L,211L,254L,326L,352L,379L,466L,529L,667L,704L,904L,947L,991L,1036L,1129L,1177L,1276L,1379L,1486L,1541L,1597L,1654L,1712L,1771L,1892L,1954L,2279L,2347L,2557L,2629L,2776L,2927L,3004L,3082L,3161L,3404L,3571L,3742L,3829L };
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
public class A083510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083510Inst : IEnumerable<long>
{
public static readonly long[] Value=A083510.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083510.Bytes);
public long this[int i]=>Value[i];

public static A083510Inst Instance=new A083510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083511
{
public static readonly long[] Value={ 11L,22L,121L,154L,352L,407L,704L,781L,1177L,1276L,1771L,1892L,2486L,2629L,3322L,3487L,4279L,4466L,5357L,5566L,6556L,6787L,7876L,8129L,9317L,9592L,10879L,11176L,12562L,12881L,14366L,14707L,16291L,16654L,18337L,18722L,20504L,20911L,22792L,23221L };
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
public class A083511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083511Inst : IEnumerable<long>
{
public static readonly long[] Value=A083511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083511.Bytes);
public long this[int i]=>Value[i];

public static A083511Inst Instance=new A083511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083512
{
public static readonly long[] Value={ 209L,308L,407L,506L,605L,704L,803L,902L,10109L,10208L,10307L,10406L,10505L,10604L,10703L,10802L,10901L,20108L,20207L,20306L,20405L,20504L,20603L,20702L,20801L,30107L,30206L,30305L,30404L,30503L,30602L,30701L,40106L,40205L,40304L,40403L };
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
public class A083512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083512Inst : IEnumerable<long>
{
public static readonly long[] Value=A083512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083512.Bytes);
public long this[int i]=>Value[i];

public static A083512Inst Instance=new A083512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083513
{
public static readonly long[] Value={ 10901L,20702L,30503L,40304L,50105L,101070101L,102050201L,103030301L,104010401L,201050102L,202030202L,203010302L,301030103L,302010203L,401010104L,1010105010101L,1010203020101L,1010301030101L,1020103010201L,1020201020201L };
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
public class A083513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083513Inst : IEnumerable<long>
{
public static readonly long[] Value=A083513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083513.Bytes);
public long this[int i]=>Value[i];

public static A083513Inst Instance=new A083513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083514
{
public static readonly long[] Value={ 3L,2L,8L,7L,2L,3L,5L,2L,6L,3L,2L,5L,4L,2L,3L,4L,2L,4L,3L,2L,4L,9L,2L,3L,5L,2L,6L,3L,2L,5L,5L,2L,3L,6L,2L,5L,3L,2L,7L,4L,2L,3L,4L,2L,4L,3L,2L,4L,5L,2L,3L,6L,2L,5L,3L,2L,8L,8L,2L,3L,7L,2L,7L,3L,2L,6L,4L,2L,3L,4L,2L,4L,3L,2L,4L,7L,2L,3L,8L,2L,8L,3L,2L,6L,6L,2L,3L,5L,2L,8L,3L,2L,5L,4L,2L,3L,4L,2L,4L,3L,2L,4L,6L,2L,3L };
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
public class A083514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083514Inst : IEnumerable<long>
{
public static readonly long[] Value=A083514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083514.Bytes);
public long this[int i]=>Value[i];

public static A083514Inst Instance=new A083514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083515
{
public static readonly long[] Value={ 0L,5L,10L,45L,125L,445L,1914L,4445L,1570L,44445L,156989L,444445L,941538L,4444445L,9826365L,44444445L,139362425L,444444445L,1287131805L,4444444445L,2222074045L,44444444445L,11388893810L,444444444445L,1138889380989L,4444444444445L };
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
public class A083515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083515Inst : IEnumerable<long>
{
public static readonly long[] Value=A083515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083515.Bytes);
public long this[int i]=>Value[i];

public static A083515Inst Instance=new A083515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083516
{
public static readonly long[] Value={ 55L,11L,66L,22L,77L,33L,88L,44L,99L,55L,10901L,66L,616L,77L,21912L,88L,737L,99L,32923L,1991L,858L,2992L,43934L,3993L,979L,4994L,54945L,5995L,1099901L,6996L,65956L,7997L,2199912L,8998L,76967L,9999L,3299923L,199991L,87978L,299992L,4399934L,399993L };
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
public class A083516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083516Inst : IEnumerable<long>
{
public static readonly long[] Value=A083516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083516.Bytes);
public long this[int i]=>Value[i];

public static A083516Inst Instance=new A083516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083517
{
public static readonly long[] Value={ 91L,136L,946L,1081L,1711L,1891L,2701L,5671L,7021L,8911L,10585L,11935L,13861L,14365L,18145L,19306L,21736L,25651L,26335L,29161L,32131L,36856L,41041L,44551L,49141L,55945L,64261L,65341L,69751L,70876L,82621L,92665L,93961L,106030L,107416L,108811L };
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
public class A083517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083517Inst : IEnumerable<long>
{
public static readonly long[] Value=A083517.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083517.Bytes);
public long this[int i]=>Value[i];

public static A083517Inst Instance=new A083517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083518
{
public static readonly long[] Value={ 3L,5L,7L,27L,45L,495L,3615L,16695L,533445L,832305L,122789427L,8705408757L,77597861913L };
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
public class A083518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083518Inst : IEnumerable<long>
{
public static readonly long[] Value=A083518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083518.Bytes);
public long this[int i]=>Value[i];

public static A083518Inst Instance=new A083518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083519
{
public static readonly long[] Value={ 1L,3L,5L,9L,129L,1179L,21105L,96525L,419925L,13690959L,8403613179L };
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
public class A083519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083519Inst : IEnumerable<long>
{
public static readonly long[] Value=A083519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083519.Bytes);
public long this[int i]=>Value[i];

public static A083519Inst Instance=new A083519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083520
{
public static readonly long[] Value={ 3L,7L,13L,31L,43L,61L,73L,157L,211L,241L,307L,337L,421L,463L,601L,757L,991L,1123L,1321L,1483L,1723L,2521L,2551L,2731L,2971L,3307L,3361L,3541L,3907L,4423L,4831L,5113L,5701L,6007L,6163L,6481L,6841L,8011L,8191L,9241L,9901L,10303L,10627L,11131L,12211L,12433L };
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
public class A083520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083520Inst : IEnumerable<long>
{
public static readonly long[] Value=A083520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083520.Bytes);
public long this[int i]=>Value[i];

public static A083520Inst Instance=new A083520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083521
{
public static readonly ulong[] Value={ 2L,3L,7L,0L,2521L,20161L,604801L,6652801L,726485761L,39916801L,39916801L,140792940288001L,14820309504001L,10461394944001L,641171050071552001L,425757851430912001L,9366672731480064001UL,8515157028618240001L };
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
public class A083521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083521Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A083521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083521.Bytes);
public ulong this[int i]=>Value[i];

public static A083521Inst Instance=new A083521Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083522
{
public static readonly long[] Value={ 1L,1L,1L,0L,3L,3L,4L,4L,6L,2L,1L,10L,5L,3L,9L,6L,6L,4L,5L,8L,6L,7L,19L,25L,11L,2L,1L,3L,9L,23L,7L,7L,39L,5L,7L,2L,1L,5L,78L,2L,1L,15L,19L,12L,17L,6L,3L,14L,8L,21L,23L,17L,14L,40L,16L,6L,8L,13L,15L,5L,15L,82L,46L,51L,39L,43L,6L,11L,61L,57L,16L,2L,1L,26L,54L,2L,1L,13L,4L,62L,31L,69L,27L,155L,21L };
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
public class A083522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083522Inst : IEnumerable<long>
{
public static readonly long[] Value=A083522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083522.Bytes);
public long this[int i]=>Value[i];

public static A083522Inst Instance=new A083522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083523
{
public static readonly BigInteger[] Value={ 1L,2L,8L,8L,144L,46368L,4807526976L,BigInteger.Parse("51680708854858323072"),BigInteger.Parse("5972304273877744135569338397692020533504"),BigInteger.Parse("79757008057644623350300078764807923712509139103039448418553259155159833079730688") };
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
public class A083523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083523Inst Instance=new A083523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083556
{
public static readonly long[] Value={ 3L,9L,15L,105L,105L,105L,105L,105L,165L,165L,75075L,75075L,75075L,75075L,75075L,75075L,855855L,855855L,5583435L,5583435L,5583435L,18625035L,18625035L,18625035L,18625035L,18625035L,27183585L,27183585L,27183585L,27183585L,27183585L };
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
public class A083556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083556Inst : IEnumerable<long>
{
public static readonly long[] Value=A083556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083556.Bytes);
public long this[int i]=>Value[i];

public static A083556Inst Instance=new A083556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083557
{
public static readonly long[] Value={ 3L,11L,7L,23L,71L,43L,131L,79L,239L,719L,127L,383L,1151L,691L,83L,251L,151L,13L,41L,5L,17L,53L,23L,71L,43L,131L,79L,239L,719L,127L,383L,1151L,691L,83L,251L,151L,13L,41L,5L,17L,53L,23L,71L,43L,131L,79L,239L,719L,127L,383L,1151L,691L,83L,251L,151L,13L,41L,5L,17L,53L,23L };
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
public class A083557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083557Inst : IEnumerable<long>
{
public static readonly long[] Value=A083557.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083557.Bytes);
public long this[int i]=>Value[i];

public static A083557Inst Instance=new A083557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083558
{
public static readonly long[] Value={ 6L,21L,105L,301L,1221L,2041L,4641L,6517L,11661L,23577L,28861L,49321L,67281L,77701L,101661L,146121L,201957L,223321L,296341L,352941L,383761L,486877L,564981L,697137L,903361L,1020201L,1082221L,1213701L,1283257L,1430241L,2032381L,2231061L,2552721L,2666437L };
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
public class A083558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083558Inst : IEnumerable<long>
{
public static readonly long[] Value=A083558.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083558.Bytes);
public long this[int i]=>Value[i];

public static A083558Inst Instance=new A083558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083559
{
public static readonly long[] Value={ 1L,12L,50L,134L,280L,507L,834L,1277L,1855L,2586L,3489L,4580L,5878L,7401L,9168L,11195L,13501L,16104L,19023L,22274L,25876L,29847L,34206L,38969L,44155L,49782L,55869L,62432L,69490L,77061L,85164L,93815L,103033L,112836L,123243L,134270L,145936L };
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
public class A083559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083559Inst : IEnumerable<long>
{
public static readonly long[] Value=A083559.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083559.Bytes);
public long this[int i]=>Value[i];

public static A083559Inst Instance=new A083559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083560
{
public static readonly long[] Value={ 1L,27L,176L,640L,1707L,3760L,7280L,12842L,21120L,32880L,48986L,70400L,98176L,133466L,177520L,231680L,297386L,376176L,469680L,579626L,707840L,856240L,1026842L,1221760L,1443200L,1693466L,1974960L,2290176L,2641706L,3032240L,3464560L };
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
public class A083560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083560Inst : IEnumerable<long>
{
public static readonly long[] Value=A083560.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083560.Bytes);
public long this[int i]=>Value[i];

public static A083560Inst Instance=new A083560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083561
{
public static readonly long[] Value={ 1L,3L,4L,7L,12L,13L,20L,21L,29L,39L,50L,41L,63L,55L,56L,79L,96L,97L,116L,117L,137L,159L,182L,161L,207L,233L,260L,261L,289L,319L,350L,351L,383L,417L,452L,419L,489L,527L,566L,567L,608L,569L,651L,695L,653L,741L,788L,743L,837L,887L,938L,939L,992L,941L,1047L };
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
public class A083561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083561Inst : IEnumerable<long>
{
public static readonly long[] Value=A083561.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083561.Bytes);
public long this[int i]=>Value[i];

public static A083561Inst Instance=new A083561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083562
{
public static readonly long[] Value={ 3L,3L,3L,17L,3L,5L,67L,29L,3L,3L,3L,373L,5L,3L,5L,3L,257L,641L,7L,383L,43L,139L,571L,3967L,2971L };
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
public class A083562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083562Inst : IEnumerable<long>
{
public static readonly long[] Value=A083562.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083562.Bytes);
public long this[int i]=>Value[i];

public static A083562Inst Instance=new A083562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083563
{
public static readonly long[] Value={ 0L,2L,3L,6L,18L,54L,183L,636L,2316L,8610L,32763L,126582L,495981L,1964718L,7857939L,31682202L,128644290L,525573252L,2158930398L,8911295286L,36942107373L,153742174722L,642088530453L,2690224616904L,11304554951127L,47630390054802L };
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
public class A083563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083563Inst : IEnumerable<long>
{
public static readonly long[] Value=A083563.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083563.Bytes);
public long this[int i]=>Value[i];

public static A083563Inst Instance=new A083563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083564
{
public static readonly long[] Value={ 3L,21L,72L,329L,1353L,5796L,24447L,103729L,439128L,1860621L,7880997L,33385604L,141421803L,599075421L,2537719272L,10749959329L,45537545553L,192900159396L,817138154247L,3461452823129L,14662949371128L,62113250430021L };
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
public class A083564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083564Inst : IEnumerable<long>
{
public static readonly long[] Value=A083564.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083564.Bytes);
public long this[int i]=>Value[i];

public static A083564Inst Instance=new A083564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083565
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,3L,3L,23L,3L,131L,3L,67L,7L,3L,43L,461L,523L,3L,1021L,113L,3877L,5L,19L,1493L,3L,5L,7L,3187L,5L,593L,2633L,5L,661L,3371L,179L,3889L,3L,839L,443L,3023L,1579L,1613L,251L,139L,751L,3343L,229L,5233L,4153L };
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
public class A083565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083565Inst : IEnumerable<long>
{
public static readonly long[] Value=A083565.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083565.Bytes);
public long this[int i]=>Value[i];

public static A083565Inst Instance=new A083565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083566
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,15L,19L,25L,27L,53L,57L,65L,71L,87L,101L,151L,195L,247L,253L,255L,277L,289L,291L,301L,321L,355L,361L,443L,455L,461L,491L,531L,533L,541L,599L,603L,619L,635L,647L,667L,805L,817L,871L,1003L,1011L,1179L,1205L,1223L,1327L,1357L,1531L,1551L,1603L,1619L };
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
public class A083566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083566Inst : IEnumerable<long>
{
public static readonly long[] Value=A083566.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083566.Bytes);
public long this[int i]=>Value[i];

public static A083566Inst Instance=new A083566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083567
{
public static readonly long[] Value={ 21L,37L,42L,45L,53L,69L,73L,74L,81L,83L,84L,90L,106L,133L,137L,138L,141L,146L,148L,155L,161L,162L,165L,166L,168L,177L,180L,211L,212L,261L,265L,266L,269L,273L,274L,276L,281L,282L,289L,291L,292L,295L,296L,299L,310L,321L,322L,324L,330L,332L,336L,354L,359L,360L };
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
public class A083567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083567Inst : IEnumerable<long>
{
public static readonly long[] Value=A083567.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083567.Bytes);
public long this[int i]=>Value[i];

public static A083567Inst Instance=new A083567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083568
{
public static readonly long[] Value={ 1L,1L,2L,12L,286L,33592L,23178480L,108995910720L,3973186258569120L };
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
public class A083568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083568Inst : IEnumerable<long>
{
public static readonly long[] Value=A083568.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083568.Bytes);
public long this[int i]=>Value[i];

public static A083568Inst Instance=new A083568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083569
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,5L,4L,9L,8L,13L,12L,11L,10L,15L,14L,21L,20L,19L,18L,17L,16L,25L,24L,23L,22L,27L,26L,31L,30L,29L,28L,35L,34L,33L,32L,37L,36L,41L,40L,39L,38L,47L,46L,45L,44L,43L,42L,49L,48L,51L,50L,55L,54L,53L,52L,57L,56L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,79L,78L,77L };
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
public class A083569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083569Inst : IEnumerable<long>
{
public static readonly long[] Value=A083569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083569.Bytes);
public long this[int i]=>Value[i];

public static A083569Inst Instance=new A083569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083570
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,1L,2L,2L,1L,0L,2L };
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
public class A083570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083570Inst : IEnumerable<long>
{
public static readonly long[] Value=A083570.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083570.Bytes);
public long this[int i]=>Value[i];

public static A083570Inst Instance=new A083570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083571
{
public static readonly long[] Value={ 2L,3L,5L,10L,12L,72L };
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
public class A083571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083571Inst : IEnumerable<long>
{
public static readonly long[] Value=A083571.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083571.Bytes);
public long this[int i]=>Value[i];

public static A083571Inst Instance=new A083571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083604
{
public static readonly long[] Value={ 255945L,2645268L,3218870L,4657555L,4657556L,5130874L,5425806L,5961931L,6653783L,9036112L,11867965L,13249047L,13255651L,15684440L,18548887L,20316848L,22107705L,22564362L,23503699L,28388441L,28580580L,29435972L,30584158L,31678241L };
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
public class A083604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083604Inst : IEnumerable<long>
{
public static readonly long[] Value=A083604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083604.Bytes);
public long this[int i]=>Value[i];

public static A083604Inst Instance=new A083604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083605
{
public static readonly long[] Value={ 4657555L,42408103L,70787432L,87389489L,111369664L,112702803L,112722135L,130810586L,159090113L,159090114L,174624972L,174624973L,179524595L,182658205L,197757791L,199394968L,199394969L };
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
public class A083605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083605Inst : IEnumerable<long>
{
public static readonly long[] Value=A083605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083605.Bytes);
public long this[int i]=>Value[i];

public static A083605Inst Instance=new A083605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083606
{
public static readonly long[] Value={ 1735L,1889L,2278L,2376L,3434L,4902L,4903L,7911L,7964L,7965L,9203L,9293L,9334L,10427L,11704L,12486L,12487L,12857L,13040L,13562L,13725L,14668L,16679L,17619L,17882L,19099L,19479L,21576L,25469L,26266L,26959L,27433L,29447L,30291L,30454L,30527L };
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
public class A083606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083606Inst : IEnumerable<long>
{
public static readonly long[] Value=A083606.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083606.Bytes);
public long this[int i]=>Value[i];

public static A083606Inst Instance=new A083606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083607
{
public static readonly long[] Value={ 4902L,7964L,12486L,43405L,50271L,55736L,62920L,65260L,65261L,71778L,83521L,97191L,98423L,103025L,105290L,123462L,125053L,125172L,125656L,138493L,138655L,150949L,162191L,192255L,196397L,204561L,204850L,209562L,216368L,216660L,267139L,272809L };
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
public class A083607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083607Inst : IEnumerable<long>
{
public static readonly long[] Value=A083607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083607.Bytes);
public long this[int i]=>Value[i];

public static A083607Inst Instance=new A083607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083608
{
public static readonly long[] Value={ 65260L,327074L,580735L,619398L,644011L,720510L,963024L,963025L,993919L,1078372L,1196183L,1303184L,1347014L,1391134L,1580648L,1592452L,1636486L,1637080L,1637081L,1795773L,1795774L,1921819L,1964004L,1991262L,2162262L,2355086L };
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
public class A083608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083608Inst : IEnumerable<long>
{
public static readonly long[] Value=A083608.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083608.Bytes);
public long this[int i]=>Value[i];

public static A083608Inst Instance=new A083608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083609
{
public static readonly long[] Value={ 963024L,1637080L,1795773L,2523356L,3474036L,5463417L,5803105L,7024615L,9742967L,11836401L,12883291L,13208202L,13371031L,15419528L,15783557L,18183625L,19081176L,20031349L,20363606L,20399387L,20735063L,21682696L,25303344L };
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
public class A083609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083609Inst : IEnumerable<long>
{
public static readonly long[] Value=A083609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083609.Bytes);
public long this[int i]=>Value[i];

public static A083609Inst Instance=new A083609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083610
{
public static readonly long[] Value={ 1698L,4928L,6917L,7651L,8413L,8736L,8828L,12520L,17614L,21973L,22580L,22704L,22749L,23471L,25094L,25179L,28467L,28468L,28469L,30583L,32631L,33095L,35838L,37507L,38597L,41392L,42438L,42734L,45756L,48033L,48207L,48369L,49287L,50547L,52794L };
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
public class A083610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083610Inst : IEnumerable<long>
{
public static readonly long[] Value=A083610.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083610.Bytes);
public long this[int i]=>Value[i];

public static A083610Inst Instance=new A083610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083611
{
public static readonly long[] Value={ 28467L,28468L,66846L,79979L,84542L,89085L,89086L,93498L,95730L,119658L,145459L,146043L,146044L,150803L,158335L,162369L,169124L,172951L,178501L,186291L,190241L,191664L,193042L,214252L,217711L,222180L,231023L,235521L,263318L,263955L,297544L };
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
public class A083611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083611Inst : IEnumerable<long>
{
public static readonly long[] Value=A083611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083611.Bytes);
public long this[int i]=>Value[i];

public static A083611Inst Instance=new A083611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083612
{
public static readonly long[] Value={ 28467L,89085L,146043L,335792L,680738L,710100L,710101L,710102L,899654L,987207L,1108406L,1129019L,1129020L,1135766L,1321501L,1454595L,1961784L,2305499L,2384621L,2403869L,2607453L,2657509L,2756644L,2872302L,2961123L,3079956L };
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
public class A083612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083612Inst : IEnumerable<long>
{
public static readonly long[] Value=A083612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083612.Bytes);
public long this[int i]=>Value[i];

public static A083612Inst Instance=new A083612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083613
{
public static readonly long[] Value={ 710100L,710101L,1129019L,3204765L,3204766L,4098542L,4640063L,5524958L,9831707L,10985154L,12376276L,12469058L,12469059L,13230524L,13247803L,15239977L,18216168L,18216169L,19175682L,19175683L,22562616L,23375381L,24287401L };
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
public class A083613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083613Inst : IEnumerable<long>
{
public static readonly long[] Value=A083613.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083613.Bytes);
public long this[int i]=>Value[i];

public static A083613Inst Instance=new A083613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083614
{
public static readonly long[] Value={ 710100L,3204765L,12469058L,18216168L,19175682L,36488176L,36488177L,42437943L,54526147L,76792653L,87263786L,95101068L,112249661L,113232305L,118231603L,130495608L,130508230L,198084084L };
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
public class A083614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083614Inst : IEnumerable<long>
{
public static readonly long[] Value=A083614.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083614.Bytes);
public long this[int i]=>Value[i];

public static A083614Inst Instance=new A083614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083615
{
public static readonly long[] Value={ 2707L,2928L,3476L,3809L,3866L,4175L,4923L,5290L,5675L,6327L,6346L,9384L,9445L,13565L,18912L,21929L,23157L,23223L,25937L,26531L,27887L,28220L,28872L,34587L,35496L,36878L,37072L,37758L,37989L,39388L,39826L,42220L,42424L,45136L,45796L,46495L };
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
public class A083615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083615Inst : IEnumerable<long>
{
public static readonly long[] Value=A083615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083615.Bytes);
public long this[int i]=>Value[i];

public static A083615Inst Instance=new A083615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083616
{
public static readonly long[] Value={ 54525L,57609L,74544L,75558L,83075L,97382L,106823L,108041L,130571L,135340L,137820L,163656L,164061L,171688L,201039L,226761L,235180L,249462L,253741L,280191L,301142L,331550L,366179L,366941L,410226L,416365L,420021L,428389L,445365L,451439L,456129L };
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
public class A083616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083616Inst : IEnumerable<long>
{
public static readonly long[] Value=A083616.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083616.Bytes);
public long this[int i]=>Value[i];

public static A083616Inst Instance=new A083616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083617
{
public static readonly long[] Value={ 808650L,828499L,828500L,1159493L,1160895L,1218361L,1264270L,1264271L,1290645L,1364846L,1378434L,1394738L,1660588L,1691163L,1691164L,1780532L,2006297L,2038552L,2202740L,2341312L,2502895L,2558106L,2562163L,2932009L,3017406L };
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
public class A083617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083617Inst : IEnumerable<long>
{
public static readonly long[] Value=A083617.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083617.Bytes);
public long this[int i]=>Value[i];

public static A083617Inst Instance=new A083617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083618
{
public static readonly long[] Value={ 828499L,1264270L,1691163L,3280219L,3311569L,3552343L,6252652L,6885738L,7282004L,10049065L,10549618L,10567078L,11588274L,11793700L,12376485L,14302933L,15107731L,15408837L,16027040L,16963877L,17122307L,17893953L,17893954L };
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
public class A083618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083618Inst : IEnumerable<long>
{
public static readonly long[] Value=A083618.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083618.Bytes);
public long this[int i]=>Value[i];

public static A083618Inst Instance=new A083618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083619
{
public static readonly long[] Value={ 17893953L,22931745L,22931746L,23189751L,23724968L,26621347L,48484522L,65122865L,65122866L,101281206L,114016129L,139676210L,143452823L,158136797L,162805048L,180943775L,183739324L,187015739L,193053713L,195259463L,199439192L };
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
public class A083619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083619Inst : IEnumerable<long>
{
public static readonly long[] Value=A083619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083619.Bytes);
public long this[int i]=>Value[i];

public static A083619Inst Instance=new A083619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083652
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,15L,18L,22L,26L,30L,34L,38L,42L,46L,50L,55L,60L,65L,70L,75L,80L,85L,90L,95L,100L,105L,110L,115L,120L,125L,130L,136L,142L,148L,154L,160L,166L,172L,178L,184L,190L,196L,202L,208L,214L,220L,226L,232L,238L,244L,250L,256L,262L,268L,274L,280L,286L,292L };
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
public class A083652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083652Inst : IEnumerable<long>
{
public static readonly long[] Value=A083652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083652.Bytes);
public long this[int i]=>Value[i];

public static A083652Inst Instance=new A083652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083653
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,2L,1L,3L,8L,4L,10L,2L,3L,1L,3L,7L,16L,8L,4L,9L,18L,10L,21L,2L,7L,3L,9L,1L,3L,5L,7L,15L,32L,16L,8L,17L,36L,4L,9L,19L,34L,18L,10L,10L,37L,21L,2L,6L,15L,7L,3L,12L,19L,9L,21L,1L,7L,3L,19L,5L,7L,13L,15L,31L,64L,32L,16L,33L,8L,34L,17L,35L,68L,36L,18L,4L,73L,9L,19L,39L,66L,34L,20L,18L };
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
public class A083653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083653Inst : IEnumerable<long>
{
public static readonly long[] Value=A083653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083653.Bytes);
public long this[int i]=>Value[i];

public static A083653Inst Instance=new A083653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083654
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,3L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,2L,4L,2L,3L,2L,3L,2L,3L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,3L,3L,2L,3L,3L,2L,2L,3L,2L,2L,2L };
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
public class A083654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083654Inst : IEnumerable<long>
{
public static readonly long[] Value=A083654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083654.Bytes);
public long this[int i]=>Value[i];

public static A083654Inst Instance=new A083654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083655
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,10L,16L,32L,36L,64L,128L,136L,256L,512L,528L,1024L,2048L,2080L,4096L,8192L,8256L,16384L,32768L,32896L,65536L,131072L,131328L,262144L,524288L,524800L,1048576L,2097152L,2098176L,4194304L,8388608L,8390656L,16777216L,33554432L };
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
public class A083655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083655Inst : IEnumerable<long>
{
public static readonly long[] Value=A083655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083655.Bytes);
public long this[int i]=>Value[i];

public static A083655Inst Instance=new A083655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083656
{
public static readonly long[] Value={ 1L,3L,8L,15L,24L,35L,47L,62L,78L,97L,118L,140L,165L,191L,220L,251L,284L,319L,355L,394L,435L,478L,523L,569L,618L,668L,721L,776L,833L,892L,952L,1015L,1080L,1147L,1216L,1286L,1359L,1433L,1510L,1589L,1669L,1752L,1836L,1923L,2012L,2103L,2196L,2290L,2387L,2485L,2586L };
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
public class A083656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083656Inst : IEnumerable<long>
{
public static readonly long[] Value=A083656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083656.Bytes);
public long this[int i]=>Value[i];

public static A083656Inst Instance=new A083656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083657
{
public static readonly long[] Value={ 1L,6L,14L,24L,37L,54L,74L,96L,121L,150L,182L,216L,254L,295L,338L,384L,434L,487L,542L,600L,662L,727L,794L,865L,939L,1016L,1095L,1178L,1264L,1352L,1443L,1538L,1636L,1736L,1839L,1946L,2056L,2168L,2284L,2403L,2525L,2649L,2777L,2908L,3041L,3177L,3317L,3460L,3605L };
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
public class A083657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083657Inst : IEnumerable<long>
{
public static readonly long[] Value=A083657.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083657.Bytes);
public long this[int i]=>Value[i];

public static A083657Inst Instance=new A083657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083658
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,15L,27L,45L,81L,135L,243L,405L,729L,1215L,2187L,3645L,6561L,10935L,19683L,32805L,59049L,98415L,177147L,295245L,531441L,885735L,1594323L,2657205L,4782969L,7971615L,14348907L,23914845L,43046721L,71744535L,129140163L,215233605L,387420489L };
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
public class A083658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083658Inst : IEnumerable<long>
{
public static readonly long[] Value=A083658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083658.Bytes);
public long this[int i]=>Value[i];

public static A083658Inst Instance=new A083658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083659
{
public static readonly BigInteger[] Value={ 1L,2L,7L,37L,266L,2963L,38785L,662308L,12622637L,290982959L,8451128448L,262275964847L,9712661827787L,398481410904114L,17144413330704689L,806185907954024497L,4274499753489003030L,BigInteger.Parse("2522761040466700203267") };
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
public class A083659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083659.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083659Inst Instance=new A083659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083660
{
public static readonly long[] Value={ 1L,5L,14L,5L,5L,9L,1L,1L,29L,23L,28L,13L,46L,22L,18L,116L,35L,18L,155L,7L,81L,1L,139L,52L,262L,215L,56L,29L,11L,6L,256L,119L,381L,592L,67L,189L,116L,46L,5L,275L,139L,27L,101L,118L,96L,167L,196L,393L,275L,91L,146L,415L,193L,127L,85L,73L,6L,4L,50L,118L,1046L,362L,5L,431L,248L,180L,82L,230L,125L };
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
public class A083660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083660Inst : IEnumerable<long>
{
public static readonly long[] Value=A083660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083660.Bytes);
public long this[int i]=>Value[i];

public static A083660Inst Instance=new A083660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083661
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,2L,1L,1L,0L,2L,1L,1L,0L,3L,2L,2L,1L,2L,1L,1L,0L,3L,2L,2L,1L,2L,1L,1L,0L,4L,3L,3L,2L,3L,2L,2L,1L,3L,2L,2L,1L,2L,1L,1L,0L,4L,3L,3L,2L,3L,2L,2L,1L,3L,2L,2L,1L,2L,1L,1L,0L,5L,4L,4L,3L,4L,3L,3L,2L,4L,3L,3L,2L,3L,2L,2L,1L,4L,3L,3L,2L,3L,2L,2L,1L,3L,2L,2L,1L,2L,1L };
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
public class A083661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083661Inst : IEnumerable<long>
{
public static readonly long[] Value=A083661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083661.Bytes);
public long this[int i]=>Value[i];

public static A083661Inst Instance=new A083661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083662
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,5L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L };
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
public class A083662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083662Inst : IEnumerable<long>
{
public static readonly long[] Value=A083662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083662.Bytes);
public long this[int i]=>Value[i];

public static A083662Inst Instance=new A083662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083663
{
public static readonly long[] Value={ 3L,2L,1L,1L,2L,1L,1L,5L,3L,4L,4L,1L,5L,1L,2L,9L,2L,30L,30L,5L,44L,2L,7L,13L,5L,3L,11L,2L,14L,1L,7L,1L,1L,30L,16L,22L,36L,1L,38L,13L,22L,6L,36L,17L,36L,40L,31L,25L,38L,13L,4L,32L,22L,154L,10L,27L,7L,121L,9L,33L,19L,19L,4L,26L,100L,18L,46L,75L,21L,11L,34L,75L,38L,7L,45L,3L,19L,13L,59L,39L,72L };
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
public class A083663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083663Inst : IEnumerable<long>
{
public static readonly long[] Value=A083663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083663.Bytes);
public long this[int i]=>Value[i];

public static A083663Inst Instance=new A083663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083664
{
public static readonly long[] Value={ 1L,2L,3L,11L,4L,22L,28L,9L,19L,10L,17L,16L,29L,8L,34L,88L,7L,23L,18L,20L,14L,31L,154L,13L,38L,231L,12L,21L,25L,30L,209L,42L,6L,37L,15L,35L,143L,49L,77L,40L,26L,33L,47L,303L,57L,333L,64L,66L,32L,50L,132L,48L,44L,53L,404L,58L,364L,111L,5L,60L,101L,55L,91L,99L,46L,437L,92L,236L };
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
public class A083664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083664Inst : IEnumerable<long>
{
public static readonly long[] Value=A083664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083664.Bytes);
public long this[int i]=>Value[i];

public static A083664Inst Instance=new A083664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083665
{
public static readonly long[] Value={ 1L,2L,3L,5L,59L,33L,17L,14L,8L,10L,4L,27L,24L,21L,35L,12L,11L,19L,9L,20L,28L,6L,18L,117L,29L,41L,388L,7L,13L,30L,22L,49L,42L,15L,36L,442L,34L,25L,248L,40L,234L,32L,268L,53L,74L,65L,43L,52L,38L,50L,199L,574L,54L,337L,62L,72L,45L,56L,142L,60L,461L,274L,134L,47L,439L,48L,377L,87L };
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
public class A083665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083665Inst : IEnumerable<long>
{
public static readonly long[] Value=A083665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083665.Bytes);
public long this[int i]=>Value[i];

public static A083665Inst Instance=new A083665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083666
{
public static readonly long[] Value={ 2L,6L,33L,44L,88L,161L,171L,222L,232L,252L,272L,323L,414L,434L,464L,494L,505L,525L,555L,616L,858L,1551L,2002L,2112L,2332L,2772L,2992L,3773L,4224L,4554L,4774L,5005L,5225L,5445L,5555L,6336L,6776L,7007L,7667L,8118L,8778L,9009L,10001L,10101L,10701L,11811L };
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
public class A083666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083666Inst : IEnumerable<long>
{
public static readonly long[] Value=A083666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083666.Bytes);
public long this[int i]=>Value[i];

public static A083666Inst Instance=new A083666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083667
{
public static readonly BigInteger[] Value={ 1L,2L,12L,216L,11664L,1889568L,918330048L,1338925209984L,5856458868470016L,BigInteger.Parse("76848453272063549952"),BigInteger.Parse("3025216211508053707410432"),BigInteger.Parse("357271984146678126737757198336"),BigInteger.Parse("126579320351263180234426948827254784") };
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
public class A083667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083667Inst Instance=new A083667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083716
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,3L,1L,1L,2L,6L,1L,5L,1L,3L,2L,1L,1L,7L,4L,1L,7L,3L,1L,5L,1L,15L,2L,1L,4L,10L,1L,1L,2L,7L,1L,5L,1L,3L,8L,1L,1L,15L,6L,9L,2L,3L,1L,17L,4L,7L,2L,1L,1L,11L,1L,1L,8L,30L,4L,5L,1L,3L,2L,9L,1L,23L,1L,1L,14L,3L,6L,5L,1L,15L,26L,1L,1L,11L,4L,1L,2L,7L,1L,17L,6L,3L,2L,1L,4L,29L,1L,13L,8L };
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
public class A083716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083716Inst : IEnumerable<long>
{
public static readonly long[] Value=A083716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083716.Bytes);
public long this[int i]=>Value[i];

public static A083716Inst Instance=new A083716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083717
{
public static readonly long[] Value={ 1L,4L,9L,6L,25L,15L,49L,14L,21L,35L,121L,33L,169L,91L,65L,26L,289L,51L,361L,95L,133L,209L,529L,69L,115L,299L,69L,161L,841L,145L,961L,62L,341L,527L,217L,93L,1369L,703L,481L,185L,1681L,287L,1849L,473L,215L,989L,2209L,141L,329L,235L,799L,611L,2809L,159L,583L,371L };
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
public class A083717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083717Inst : IEnumerable<long>
{
public static readonly long[] Value=A083717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083717.Bytes);
public long this[int i]=>Value[i];

public static A083717Inst Instance=new A083717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083718
{
public static readonly long[] Value={ 2L,4L,6L,5L,10L,8L,14L,9L,10L,12L,22L,14L,26L,20L,18L,15L,34L,20L,38L,24L,26L,30L,46L,26L,28L,36L,26L,30L,58L,34L,62L,33L,42L,48L,38L,34L,74L,56L,50L,42L,82L,48L,86L,54L,48L,66L,94L,50L,54L,52L,64L,60L,106L,56L,64L,60L,72L,82L,118L,64L,122L,92L,68L,63L,74L,72L,134L,84L,90L,74L };
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
public class A083718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083718Inst : IEnumerable<long>
{
public static readonly long[] Value=A083718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083718.Bytes);
public long this[int i]=>Value[i];

public static A083718Inst Instance=new A083718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083719
{
public static readonly long[] Value={ 0L,1L,6L,18L,44L,90L,174L,294L,472L,702L,1010L,1430L,1932L,2574L,3346L,4230L,5264L,6494L,7938L,9538L,11380L,13440L,15686L,18216L,21000L,24100L,27586L,31374L,35420L,39788L,44430L,49414L,55072L,61116L,67626L,74480L,81972L,89836L,98230L,107172L,116600L,126608L };
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
public class A083719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083719Inst : IEnumerable<long>
{
public static readonly long[] Value=A083719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083719.Bytes);
public long this[int i]=>Value[i];

public static A083719Inst Instance=new A083719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083720
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,1L,30L,1L,2L,3L,210L,1L,2310L,15L,2L,1L,30030L,1L,510510L,3L,10L,105L,9699690L,1L,6L,1155L,2L,15L,223092870L,1L,6469693230L,1L,70L,15015L,6L,1L,200560490130L,255255L,770L,3L,7420738134810L,5L,304250263527210L,105L,2L,4849845L };
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
public class A083720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083720Inst : IEnumerable<long>
{
public static readonly long[] Value=A083720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083720.Bytes);
public long this[int i]=>Value[i];

public static A083720Inst Instance=new A083720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083721
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,3L,2L,1L,0L,3L,0L,2L,3L,5L,0L,5L,0L,5L,4L,3L,0L,7L,6L,3L,7L,5L,0L,7L,0L,10L,6L,4L,7L,9L,0L,4L,6L,9L,0L,9L,0L,9L,11L,5L,0L,13L,11L,12L,8L,9L,0L,14L,11L,12L,8L,6L,0L,14L,0L,7L,14L,17L,12L,13L,0L,12L,10L,15L,0L,18L,0L,9L,18L,13L,16L,15L,0L,19L,20L,9L,0L,19L,16L,9L,13L,18L,0L,21L,18L };
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
public class A083721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083721Inst : IEnumerable<long>
{
public static readonly long[] Value=A083721.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083721.Bytes);
public long this[int i]=>Value[i];

public static A083721Inst Instance=new A083721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083722
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,5L,1L,105L,35L,7L,1L,385L,1L,143L,1001L,15015L,1L,85085L,1L,323323L,46189L,4199L,1L,37182145L,7436429L,7429L,37182145L,1062347L,1L,215656441L,1L,100280245065L,86822723L,392863L,955049953L,33426748355L,1L,765049L,247110827L,247357937827L,1L,1448810778701L,1L };
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
public class A083722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083722Inst : IEnumerable<long>
{
public static readonly long[] Value=A083722.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083722.Bytes);
public long this[int i]=>Value[i];

public static A083722Inst Instance=new A083722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083723
{
public static readonly long[] Value={ 2L,7L,17L,31L,59L,83L,125L,159L,215L,299L,351L,455L,545L,615L,719L,863L,1019L,1115L,1291L,1439L,1553L,1759L,1931L,2159L,2449L,2651L,2807L,3023L,3189L,3419L,3967L,4223L,4553L,4759L,5249L,5471L,5845L,6231L,6551L,6959L,7379L,7643L,8255L,8535L,8909L,9199L,9963L };
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
public class A083723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083723Inst : IEnumerable<long>
{
public static readonly long[] Value=A083723.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083723.Bytes);
public long this[int i]=>Value[i];

public static A083723Inst Instance=new A083723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083724
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,9L,42L,44L,46L,66L,69L,73L,88L,234L,257L,344L,1280L,1930L,2601L,2826L,3506L };
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
public class A083724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083724Inst : IEnumerable<long>
{
public static readonly long[] Value=A083724.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083724.Bytes);
public long this[int i]=>Value[i];

public static A083724Inst Instance=new A083724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083725
{
public static readonly long[] Value={ 0L,3L,12L,33L,72L,145L,252L,413L,624L,909L,1300L,1771L,2376L,3107L,3948L,4935L,6112L,7497L,9036L,10811L,12800L,14973L,17424L,20125L,23136L,26525L,30212L,34155L,38416L,42949L,47820L,53351L,59264L,65637L,72352L,79695L,87408L,95645L,104424L,113685L,123520L,133947L };
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
public class A083725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083725Inst : IEnumerable<long>
{
public static readonly long[] Value=A083725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083725.Bytes);
public long this[int i]=>Value[i];

public static A083725Inst Instance=new A083725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083726
{
public static readonly long[] Value={ 0L,3L,8L,18L,32L,60L,84L,126L,160L,216L,300L,352L,456L,546L,616L,720L,864L,1020L,1116L,1292L,1440L,1554L,1760L,1932L,2160L,2450L,2652L,2808L,3024L,3190L,3420L,3968L,4224L,4554L,4760L,5250L,5472L,5846L,6232L,6552L,6960L,7380L,7644L,8256L,8536L,8910L,9200L,9964L };
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
public class A083726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083726Inst : IEnumerable<long>
{
public static readonly long[] Value=A083726.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083726.Bytes);
public long this[int i]=>Value[i];

public static A083726Inst Instance=new A083726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083727
{
public static readonly long[] Value={ 0L,-6L,-8L,0L,32L,120L,336L,840L,1984L,4536L,10160L,22440L,49056L,106392L,229264L,491400L,1048448L,2228088L,4718448L,9961320L,20971360L,44040024L,92274512L,192937800L,402652992L,838860600L,1744830256L,3623878440L,7516192544L,15569256216L,32212254480L,66571992840L };
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
public class A083727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083727Inst : IEnumerable<long>
{
public static readonly long[] Value=A083727.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083727.Bytes);
public long this[int i]=>Value[i];

public static A083727Inst Instance=new A083727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083728
{
public static readonly long[] Value={ 1L,480L,1440L,1920L,3360L,2880L,5760L,3840L,7200L,6240L,8640L,5760L,13440L,6720L,11520L,11520L,14880L,8640L,18720L,9600L,20160L,15360L,17280L,11520L,28800L,14880L,20160L,19200L,26880L,14400L,34560L,15360L,30240L,23040L,25920L,23040L,43680L,18240L,28800L };
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
public class A083728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083728Inst : IEnumerable<long>
{
public static readonly long[] Value=A083728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083728.Bytes);
public long this[int i]=>Value[i];

public static A083728Inst Instance=new A083728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083729
{
public static readonly long[] Value={ 8L,2L,4L,2L,6L,4L,0L,6L,8L,7L,1L,1L,9L,2L,8L,5L,1L,4L,6L,4L,0L,5L,0L,6L,6L,1L,7L,2L,6L,2L,9L,0L,9L,4L,2L,3L,5L,7L,0L,9L,0L,1L,5L,6L,2L,6L,1L,3L,0L,8L,4L,4L,2L,1L,9L,5L,3L,0L,0L,3L,9L,2L,1L,3L,9L,7L,2L,1L,9L,7L,4L,3L,5L,3L,8L,6L,3L,2L,1L,1L,1L,6L,5L,5L,1L,1L,6L,2L,6L,0L,2L,9L,8L,2L,9L,2L,4L,7L,1L,8L,2L,0L,5L,0L,4L };
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
public class A083729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083729Inst : IEnumerable<long>
{
public static readonly long[] Value=A083729.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083729.Bytes);
public long this[int i]=>Value[i];

public static A083729Inst Instance=new A083729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083730
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,1L,4L,9L,1L,1L,4L,1L,1L,1L,4L,1L,9L,1L,4L,1L,1L,1L,4L,25L,1L,9L,4L,1L,1L,1L,4L,1L,1L,1L,9L,1L,1L,1L,4L,1L,1L,1L,4L,9L,1L,1L,4L,49L,25L,1L,4L,1L,9L,1L,4L,1L,1L,1L,4L,1L,1L,9L,4L,1L,1L,1L,4L,1L,1L,1L,9L,1L,1L,25L,4L,1L,1L,1L,4L,9L,1L,1L,4L,1L,1L,1L,4L,1L,9L,1L,4L,1L,1L,1L,4L,1L,49L,9L };
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
public class A083730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083730Inst : IEnumerable<long>
{
public static readonly long[] Value=A083730.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083730.Bytes);
public long this[int i]=>Value[i];

public static A083730Inst Instance=new A083730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083731
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,1L,-1L,0L,1L,1L,0L,-1L,0L,1L,2L,0L,-1L,-1L,0L,1L,2L,1L,-1L,-1L,-1L,0L,1L,3L,1L,0L,-2L,-1L,-1L,0L,1L,3L,3L,-1L,-1L,-2L,-1L,-1L,0L,1L,4L,3L,1L,-2L,-2L,-2L,-1L,-1L,0L,1L,4L,5L,1L,-1L,-3L,-2L,-2L,-1L,-1L,0L,1L,5L,6L,3L,-2L,-2L,-4L,-2L,-2L,-1L,-1L,0L,1L,5L,8L,4L,0L,-4L,-3L,-4L,-2L,-2L,-1L,-1L,0L };
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
public class A083731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083731Inst : IEnumerable<long>
{
public static readonly long[] Value=A083731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083731.Bytes);
public long this[int i]=>Value[i];

public static A083731Inst Instance=new A083731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083796
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,3L,1L,2L,5L,6L,1L,2L,3L,4L,14L,1L,2L,3L,4L,8L,30L,1L,2L,3L,4L,5L,6L,39L,1L,2L,3L,4L,5L,6L,11L,28L,1L,2L,3L,4L,5L,6L,7L,8L,804L,1L,2L,3L,4L,5L,6L,7L,8L,24L,1620L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2465L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,17L,15048L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L };
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
public class A083796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083796Inst : IEnumerable<long>
{
public static readonly long[] Value=A083796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083796.Bytes);
public long this[int i]=>Value[i];

public static A083796Inst Instance=new A083796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083797
{
public static readonly long[] Value={ 1L,1L,3L,6L,14L,30L,39L,28L,804L,1620L,2465L,15048L,27642L,138502L,360255L,360120L,720584L,8648478L,12252069L,208287880L,232792350L,232792098L,232792307L,2327925312L,5354228580L,16062686250L,26771144049L,26771143896L,80313432794L };
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
public class A083797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083797Inst : IEnumerable<long>
{
public static readonly long[] Value=A083797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083797.Bytes);
public long this[int i]=>Value[i];

public static A083797Inst Instance=new A083797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083798
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,3L,13L,12L,9L,8L,23L,22L,21L,20L,10L,47L,46L,45L,44L,40L,18L,59L,58L,57L,56L,55L,54L,21L,59L,58L,57L,56L,55L,54L,49L,32L,839L,838L,837L,836L,835L,834L,833L,832L,36L,1679L,1678L,1677L,1676L,1675L,1674L,1673L,1672L,1656L,60L,2519L,2518L,2517L,2516L,2515L,2514L,2513L,2512L,2511L,2510L,55L };
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
public class A083798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083798Inst : IEnumerable<long>
{
public static readonly long[] Value=A083798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083798.Bytes);
public long this[int i]=>Value[i];

public static A083798Inst Instance=new A083798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083799
{
public static readonly long[] Value={ 0L,2L,3L,8L,10L,18L,21L,32L,36L,60L,55L,72L,78L,98L,105L,240L,136L,162L,171L,200L,210L,462L,253L,288L,300L,390L,351L,504L,406L,450L,465L,512L,528L,1122L,595L,1260L,666L,722L,741L,1560L,820L,882L,903L,968L,990L,2070L,1081L,1152L,1176L,1400L,1275L,2652L,1378L,1458L,1485L,3080L,1596L,3306L,1711L,1800L,1830L };
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
public class A083799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083799Inst : IEnumerable<long>
{
public static readonly long[] Value=A083799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083799.Bytes);
public long this[int i]=>Value[i];

public static A083799Inst Instance=new A083799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083800
{
public static readonly long[] Value={ 0L,1L,5L,13L,23L,47L,59L,59L,839L,1679L,2519L,15119L,27719L,138599L,360359L,360359L,720719L,8648639L,12252239L,208288079L,232792559L,232792559L,232792559L,2327925599L,5354228879L,16062686639L,26771144399L,26771144399L,80313433199L,1204701497999L,2329089562799L,16303626939599L,144403552893599L };
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
public class A083800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083800Inst : IEnumerable<long>
{
public static readonly long[] Value=A083800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083800.Bytes);
public long this[int i]=>Value[i];

public static A083800Inst Instance=new A083800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083801
{
public static readonly long[] Value={ 1L,1L,1L,5L,2L,1L,13L,6L,3L,2L,23L,11L,7L,5L,2L,47L,23L,15L,11L,8L,3L,59L,29L,19L,14L,11L,9L,3L,59L,29L,19L,14L,11L,9L,7L,4L,839L,419L,279L,209L,167L,139L,119L,104L,4L,1679L,839L,559L,419L,335L,279L,239L,209L,184L,6L,2519L,1259L,839L,629L,503L,419L,359L,314L,279L,251L,5L };
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
public class A083801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083801Inst : IEnumerable<long>
{
public static readonly long[] Value=A083801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083801.Bytes);
public long this[int i]=>Value[i];

public static A083801Inst Instance=new A083801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083802
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,4L,6L,5L,6L,6L,7L,7L,15L,8L,9L,9L,10L,10L,21L,11L,12L,12L,15L,13L,18L,14L,15L,15L,16L,16L,33L,17L,35L,18L,19L,19L,39L,20L,21L,21L,22L,22L,45L,23L,24L,24L,28L,25L,51L,26L,27L,27L,55L,28L,57L,29L,30L,30L,31L,31L,63L,32L,65L,33L,34L,34L,69L,35L,36L,36L,37L,37L,75L,38L,77L,39L,40L,40L };
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
public class A083802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083802Inst : IEnumerable<long>
{
public static readonly long[] Value=A083802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083802.Bytes);
public long this[int i]=>Value[i];

public static A083802Inst Instance=new A083802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083803
{
public static readonly long[] Value={ 1L,1L,0L,1L,7L,3L,1L,0L,3L,7L,13L,11L,0L,1L,27L,1L,7L,0L,3L,7L,9L,39L,0L,9L,1L,19L,51L,0L,1L,3L,7L,1L,0L,3L,49L,9L,3L,0L,17L,19L,1L,9L,0L,7L,23L,1L,11L,0L,1L,1L,77L,1L,0L,33L,1L,109L,11L,0L,1L,3L,3L,1L,0L,7L,1L,51L,39L,0L,3L,21L,59L,21L,0L,13L,47L,1L,1L,0L,9L,7L,9L,19L,0L,29L,3L,37L,149L,0L,7L,21L };
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
public class A083803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083803Inst : IEnumerable<long>
{
public static readonly long[] Value=A083803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083803.Bytes);
public long this[int i]=>Value[i];

public static A083803Inst Instance=new A083803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083804
{
public static readonly long[] Value={ 1L,2L,0L,0L,0L,0L,3L,2L,1L,10L,0L,8L,16L,8L,15L,20L,9L,4L,24L,20L,13L,28L,25L,28L,25L,30L,32L,20L,9L,10L,27L,2L,16L,10L,5L,36L,26L,10L,33L,20L,33L,46L,26L,28L,30L,50L,4L,48L,13L,50L,3L,12L,12L,6L,30L,64L,53L,56L,61L,60L,69L,36L,12L,8L,65L,74L,66L,4L,44L,20L,3L,76L,31L,62L,75L,6L,85L,56L };
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
public class A083804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083804Inst : IEnumerable<long>
{
public static readonly long[] Value=A083804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083804.Bytes);
public long this[int i]=>Value[i];

public static A083804Inst Instance=new A083804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083805
{
public static readonly BigInteger[] Value={ 1L,6L,40L,300L,2400L,20000L,171429L,1500004L,13333369L,1200003211L,10909120100L,100000267584L,9230793930832L,85714515072012L,8000021406721121L,750002006880105095L,7058842417695106777L,BigInteger.Parse("66666845056009341783") };
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
public class A083805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083805Inst Instance=new A083805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083806
{
public static readonly long[] Value={ 1L,25L,27L,121L,125L,225L,512L,1521L,3721L,7225L,12321L,13225L,27225L,35721L,55225L,57121L,112225L,133225L,151321L,172225L,212521L,235225L,373321L,511225L,1125721L,1177225L,1357225L,1525225L,1535121L,2217121L,2512225L,2772225L,3115225L,3553225L };
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
public class A083806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083806Inst : IEnumerable<long>
{
public static readonly long[] Value=A083806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083806.Bytes);
public long this[int i]=>Value[i];

public static A083806Inst Instance=new A083806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083807
{
public static readonly long[] Value={ 4L,8L,9L,49L,64L,400L,484L,900L,4096L,4489L,4900L,6084L,6400L,6889L,8000L,8464L,8649L,9409L,9604L,40000L,40804L,44944L,48400L,64000L,64009L,66049L,68644L,69696L,80089L,88804L,90000L,94864L,400689L,404496L,409600L,440896L,444889L,448900L,466489L };
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
public class A083807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083807Inst : IEnumerable<long>
{
public static readonly long[] Value=A083807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083807.Bytes);
public long this[int i]=>Value[i];

public static A083807Inst Instance=new A083807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083808
{
public static readonly long[] Value={ 2L,23L,223L,24443L,199999L,666667L,19999999L,22222223L,666666667L,44444444441L,22222222223L,2444444444443L,17777777777777L,88888888888889L,1333333333333333L,64444444444444439L,88888888888888889L };
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
public class A083808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083808Inst : IEnumerable<long>
{
public static readonly long[] Value=A083808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083808.Bytes);
public long this[int i]=>Value[i];

public static A083808Inst Instance=new A083808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083809
{
public static readonly long[] Value={ 2L,3L,7L,7L,29L,59L,5L,11L,23L,47L,11L,23L,47L,283L,1699L,7L,29L,59L,709L,2837L,22697L,29L,59L,709L,2837L,22697L,590123L,1180247L,17L,103L,619L,2477L,34679L,416149L,7490683L,29962733L,19L,191L,383L,4597L,27583L,330997L,9267917L,74143337L,1038006719L };
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
public class A083809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083809Inst : IEnumerable<long>
{
public static readonly long[] Value=A083809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083809.Bytes);
public long this[int i]=>Value[i];

public static A083809Inst Instance=new A083809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083810
{
public static readonly BigInteger[] Value={ 2L,7L,59L,47L,1699L,22697L,1180247L,29962733L,1038006719L,411043979L,295951664941L,439109442193L,84309012901073L,1566310690709L,BigInteger.Parse("399766531626388768981"),71604415998366709L,BigInteger.Parse("180443128315884106709") };
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
public class A083810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083810Inst Instance=new A083810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083811
{
public static readonly long[] Value={ 36L,396L,3996L,39996L,399996L,3999996L,39999996L,399999996L,3999999996L,39999999996L,399999999996L,3999999999996L };
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
public class A083811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083811Inst : IEnumerable<long>
{
public static readonly long[] Value=A083811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083811.Bytes);
public long this[int i]=>Value[i];

public static A083811Inst Instance=new A083811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083844
{
public static readonly long[] Value={ 2L,4L,10L,19L,51L,112L,316L,841L,2378L,6656L,18822L,54110L,156081L,456362L,1339875L,3954181L,11726896L,34900213L,104248948L,312357934L,938457801L,2826683630L,8533327397L,25814570672L,78239402726L,237542444180L,722354138859L,5342656862803L };
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
public class A083844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083844Inst : IEnumerable<long>
{
public static readonly long[] Value=A083844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083844.Bytes);
public long this[int i]=>Value[i];

public static A083844Inst Instance=new A083844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083845
{
public static readonly long[] Value={ 2L,6L,26L,94L,314L,986L,3160L,9990L,31614L,99996L,316206L,999960L,3162246L,9999960L,31622764L,99999966L,316227734L,999999924L,3162277654L,9999999956L,31622776500L,99999999964L,316227766006L,999999999886L,3162277660140L };
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
public class A083845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083845Inst : IEnumerable<long>
{
public static readonly long[] Value=A083845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083845.Bytes);
public long this[int i]=>Value[i];

public static A083845Inst Instance=new A083845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083846
{
public static readonly long[] Value={ 5L,37L,677L,8837L,98597L,972197L,9985601L,99800101L,999444997L,9999200017L,99986234437L,999920001601L,9999799764517L,99999200001601L,999999202999697L,9999993200001157L,99999979750774757L,999999848000005777L };
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
public class A083846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083846Inst : IEnumerable<long>
{
public static readonly long[] Value=A083846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083846.Bytes);
public long this[int i]=>Value[i];

public static A083846Inst Instance=new A083846Inst();

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