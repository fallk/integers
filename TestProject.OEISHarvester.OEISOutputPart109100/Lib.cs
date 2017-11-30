using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A142997
{
public static readonly BigInteger[] Value={ 0L,1L,17L,409L,13756L,624364L,36981072L,2777988240L,258456976128L,29199105421056L,3939691125888000L,625956978121344000L,BigInteger.Parse("115709065165486080000"),BigInteger.Parse("24625602280458786816000") };
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
public class A142997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142997Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142997.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A142997.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142997Inst Instance=new A142997Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142998
{
public static readonly BigInteger[] Value={ 0L,1L,25L,809L,34380L,1890076L,131608656L,11369370384L,1196133878016L,150793148779776L,22461588531072000L,3905311348190592000L,BigInteger.Parse("784153616550893568000"),BigInteger.Parse("180142618195367442432000") };
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
public class A142998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142998Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142998.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A142998.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142998Inst Instance=new A142998Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142999
{
public static readonly BigInteger[] Value={ 0L,1L,3L,31L,460L,12076L,420336L,21114864L,1325949696L,109027627776L,10771080883200L,1316468976307200L,187978181665996800L,BigInteger.Parse("31997755234356019200"),BigInteger.Parse("6232784237890147123200"),BigInteger.Parse("1409976507981835100160000"),BigInteger.Parse("359243973790625586216960000"),BigInteger.Parse("104259271562188189469245440000") };
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
public class A142999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A142999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142999Inst Instance=new A142999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143176
{
public static readonly long[] Value={ 1L,2L,6L,12L,30L,36L,84L,120L,180L,240L,660L,720L,1560L,1260L,1680L,2880L,6120L,5040L,15960L,10080L,15120L,27720L,115920L,83160L,138600L,196560L,302400L,277200L,803880L,498960L,1562400L,665280L,720720L,1413720L,1441440L,2162160L,8205120L };
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
public class A143176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143176Inst : IEnumerable<long>
{
public static readonly long[] Value=A143176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143176.Bytes);
public long this[int i]=>Value[i];

public static A143176Inst Instance=new A143176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143177
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,6L,12L,15L,20L,24L,60L,60L,120L,90L,112L,180L,360L,280L,840L,504L,720L,1260L,5040L,3465L,5544L,7560L,11200L,9900L,27720L,16632L,50400L,20790L,21840L,41580L,41184L,60060L,221760L,138600L,110880L,162162L,554400L,205920L,720720L,327600L };
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
public class A143177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143177Inst : IEnumerable<long>
{
public static readonly long[] Value=A143177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143177.Bytes);
public long this[int i]=>Value[i];

public static A143177Inst Instance=new A143177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143178
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,6L,14L,8L,18L,20L,44L,12L,52L,28L,30L,48L,204L,72L,228L,60L,84L,132L,276L,72L,150L,156L,108L,84L,348L,60L,372L,96L,132L,204L,140L,72L,444L,228L,156L,120L,984L,168L,1032L,264L,180L,828L,1692L,240L,1176L,600L,1020L,780L,3180L,540L,660L,504L,1140L,1740L };
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
public class A143178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143178Inst : IEnumerable<long>
{
public static readonly long[] Value=A143178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143178.Bytes);
public long this[int i]=>Value[i];

public static A143178Inst Instance=new A143178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143179
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,4L,1L,4L,2L,2L,3L,12L,4L,12L,3L,4L,6L,12L,3L,6L,6L,4L,3L,12L,2L,12L,3L,4L,6L,4L,2L,12L,6L,4L,3L,24L,4L,24L,6L,4L,18L,36L,5L,24L,12L,20L,15L,60L,10L,12L,9L,20L,30L,60L,6L,60L,30L,8L,15L,24L,20L,120L,30L,40L,12L,120L,15L,120L,60L,24L,45L,36L,30L,180L,18L,40L,120L };
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
public class A143179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143179Inst : IEnumerable<long>
{
public static readonly long[] Value=A143179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143179.Bytes);
public long this[int i]=>Value[i];

public static A143179Inst Instance=new A143179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143180
{
public static readonly long[] Value={ -1L,3L,3L,19L,4L,19L,53L,17L,17L,53L,111L,48L,27L,48L,111L,199L,103L,55L,55L,103L,199L,323L,188L,107L,80L,107L,188L,323L,489L,309L,189L,129L,129L,189L,309L,489L,703L,472L,307L,208L,175L,208L,307L,472L,703L,971L,683L,467L,323L,251L,251L,323L,467L,683L,971L,1299L,948L,675L,480L,363L,324L,363L,480L,675L,948L,1299L };
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
public class A143180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143180Inst : IEnumerable<long>
{
public static readonly long[] Value=A143180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143180.Bytes);
public long this[int i]=>Value[i];

public static A143180Inst Instance=new A143180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143181
{
public static readonly long[] Value={ 1L,1L,7L,135L,549L,7209L,1741L,4197L,172434L,2638147L };
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
public class A143181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143181Inst : IEnumerable<long>
{
public static readonly long[] Value=A143181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143181.Bytes);
public long this[int i]=>Value[i];

public static A143181Inst Instance=new A143181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143182
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,3L,4L,2L,2L,4L,5L,3L,1L,3L,5L,6L,4L,2L,2L,4L,6L,7L,5L,3L,1L,3L,5L,7L,8L,6L,4L,2L,2L,4L,6L,8L,9L,7L,5L,3L,1L,3L,5L,7L,9L,10L,8L,6L,4L,2L,2L,4L,6L,8L,10L,11L,9L,7L,5L,3L,1L,3L,5L,7L,9L,11L };
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
public class A143182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143182Inst : IEnumerable<long>
{
public static readonly long[] Value=A143182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143182.Bytes);
public long this[int i]=>Value[i];

public static A143182Inst Instance=new A143182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143183
{
public static readonly long[] Value={ 1L,4L,4L,9L,1L,9L,16L,6L,6L,16L,25L,13L,1L,13L,25L,36L,22L,8L,8L,22L,36L,49L,33L,17L,1L,17L,33L,49L,64L,46L,28L,10L,10L,28L,46L,64L,81L,61L,41L,21L,1L,21L,41L,61L,81L,100L,78L,56L,34L,12L,12L,34L,56L,78L,100L,121L,97L,73L,49L,25L,1L,25L,49L,73L,97L,121L };
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
public class A143183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143183Inst : IEnumerable<long>
{
public static readonly long[] Value=A143183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143183.Bytes);
public long this[int i]=>Value[i];

public static A143183Inst Instance=new A143183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143184
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,10L,15L,23L,33L,49L,69L,98L,136L,188L,256L,348L,466L,622L,824L,1084L,1418L,1846L,2389L,3077L,3947L,5038L,6407L,8115L,10241L,12876L,16141L,20160L,25110L,31179L,38609L,47674L,58724L,72141L,88421L,108114L,131902L,160565L,195061L,236468L };
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
public class A143184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143184Inst : IEnumerable<long>
{
public static readonly long[] Value=A143184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143184.Bytes);
public long this[int i]=>Value[i];

public static A143184Inst Instance=new A143184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143185
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,6L,1L,1L,12L,6L,12L,1L,1L,20L,20L,20L,20L,1L,1L,30L,45L,20L,45L,30L,1L,1L,42L,84L,70L,70L,84L,42L,1L,1L,56L,140L,168L,70L,168L,140L,56L,1L,1L,72L,216L,336L,252L,252L,336L,216L,72L,1L,1L,90L,315L,600L,630L,252L,630L,600L,315L,90L,1L };
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
public class A143185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143185Inst : IEnumerable<long>
{
public static readonly long[] Value=A143185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143185.Bytes);
public long this[int i]=>Value[i];

public static A143185Inst Instance=new A143185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143186
{
public static readonly long[] Value={ 28L,35L,65L,72L,91L,126L,126L,133L,152L,189L,217L,224L,243L,250L,217L,224L,243L,280L,341L,344L,351L,370L,407L,432L,468L,513L,344L,351L,370L,407L,468L,513L,520L,539L,559L,576L,637L,686L,728L,730L,737L,756L,793L,513L,520L,539L,576L,637L,728L,730L,737L,756L,793L };
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
public class A143186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143186Inst : IEnumerable<long>
{
public static readonly long[] Value=A143186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143186.Bytes);
public long this[int i]=>Value[i];

public static A143186Inst Instance=new A143186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143187
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,6L,2L,2L,1L,1L,2L,2L,6L,6L,2L,2L,1L,1L,2L,2L,6L,4L,6L,2L,2L,1L,1L,2L,2L,6L,4L,4L,6L,2L,2L,1L,1L,2L,2L,6L,4L,10L,4L,6L,2L,2L,1L };
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
public class A143187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143187Inst : IEnumerable<long>
{
public static readonly long[] Value=A143187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143187.Bytes);
public long this[int i]=>Value[i];

public static A143187Inst Instance=new A143187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143188
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,6L,6L,1L,1L,8L,12L,8L,1L,1L,10L,20L,20L,10L,1L,1L,12L,30L,120L,30L,12L,1L,1L,14L,42L,210L,210L,42L,14L,1L,1L,16L,56L,336L,280L,336L,56L,16L,1L,1L,18L,72L,504L,504L,504L,504L,72L,18L,1L,1L,20L,90L,720L,840L,2520L,840L,720L,90L,20L,1L };
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
public class A143188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143188Inst : IEnumerable<long>
{
public static readonly long[] Value=A143188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143188.Bytes);
public long this[int i]=>Value[i];

public static A143188Inst Instance=new A143188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143189
{
public static readonly long[] Value={ 1L,2L,8L,11L,17L,29L,38L,43L,47L,67L,68L,71L,73L,74L,86L,89L,95L,101L,103L,107L,109L,116L,122L,127L,128L,143L,151L,188L,191L,194L,197L,215L,223L,227L,241L,248L,251L,254L,269L,277L,283L,302L,305L,317L,323L,332L,349L,359L,368L,371L,373L,397L };
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
public class A143189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143189Inst : IEnumerable<long>
{
public static readonly long[] Value=A143189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143189.Bytes);
public long this[int i]=>Value[i];

public static A143189Inst Instance=new A143189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143190
{
public static readonly long[] Value={ 10L,29L,41L,43L,40L,44L,26L,21L,15L,15L,18L,18L,18L,10L,10L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
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
public class A143190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143190Inst : IEnumerable<long>
{
public static readonly long[] Value=A143190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143190.Bytes);
public long this[int i]=>Value[i];

public static A143190Inst Instance=new A143190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143191
{
public static readonly long[] Value={ 284L,1413L,2113L,3266L,4943L,6242L,9105L,11586L,6269L,6427L,8407L,8406L,9224L,11079L,12451L,8392L,3469L,4253L,4043L,4126L,4087L,4657L,4330L,4639L,5114L,3983L,5839L,4415L,6376L,4537L,5231L,5161L,4090L,3199L,2057L,3372L,2285L,2270L,2525L,2609L,2590L,1209L };
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
public class A143191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143191Inst : IEnumerable<long>
{
public static readonly long[] Value=A143191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143191.Bytes);
public long this[int i]=>Value[i];

public static A143191Inst Instance=new A143191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143224
{
public static readonly long[] Value={ 0L,9L,36L,37L,46L,49L,85L,102L,107L,118L,122L,127L,129L,140L,157L,184L,194L,216L,228L,360L,365L,377L,378L,406L,416L,487L,511L,571L,609L,614L,672L,733L,767L,806L,813L,863L,869L,916L,923L,950L,978L,988L,1249L,1279L,1280L,1385L,1427L,1437L,1483L,1539L,1551L,1690L };
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
public class A143224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143224Inst : IEnumerable<long>
{
public static readonly long[] Value=A143224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143224.Bytes);
public long this[int i]=>Value[i];

public static A143224Inst Instance=new A143224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143225
{
public static readonly long[] Value={ 0L,3L,9L,9L,10L,10L,16L,20L,19L,21L,23L,23L,24L,25L,28L,31L,32L,36L,38L,56L,57L,59L,59L,62L,65L,71L,75L,84L,88L,88L,96L,102L,107L,115L,116L,119L,120L,126L,125L,129L,132L,132L,163L,168L,168L,182L,189L,189L,192L,197L,198L,213L,236L };
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
public class A143225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143225Inst : IEnumerable<long>
{
public static readonly long[] Value=A143225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143225.Bytes);
public long this[int i]=>Value[i];

public static A143225Inst Instance=new A143225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143226
{
public static readonly long[] Value={ 42L,55L,56L,58L,69L,77L,80L,119L,136L,137L,143L,145L,149L,156L,174L,177L,178L,188L,219L,225L,232L,247L,253L,254L,257L,261L,263L,297L,306L,310L,325L,327L,331L,335L,339L,341L,344L,356L,379L,395L,402L,410L,418L,421L,425L,433L,451L,485L,500L };
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
public class A143226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143226Inst : IEnumerable<long>
{
public static readonly long[] Value=A143226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143226.Bytes);
public long this[int i]=>Value[i];

public static A143226Inst Instance=new A143226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143227
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,1L,2L,2L,3L,3L,3L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,3L,2L,1L,1L,2L,2L,6L,3L,3L,1L,1L,1L,2L,1L,1L,1L,1L,6L,3L,8L,3L,2L,3L,2L,3L,1L,1L,4L,3L,10L,2L,1L,1L,2L,3L,1L,3L,4L,2L,2L,9L,7L,2L,2L,4L,3L,3L,1L,2L,3L,5L,1L,2L,3L,2L,11L,3L,1L,2L,4L,7L,1L,1L,1L,1L,1L,5L,1L,2L,3L,3L,4L,2L,2L,9L,5L,1L,4L,2L,2L };
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
public class A143227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143227Inst : IEnumerable<long>
{
public static readonly long[] Value=A143227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143227.Bytes);
public long this[int i]=>Value[i];

public static A143227Inst Instance=new A143227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143228
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,3L,3L,6L,9L,5L,5L,10L,15L,25L,7L,7L,1421L,35L,49L,11L,11L,22L,33L,55L,77L,121L,15L,15L,30L,45L,75L,105L,165L,225L,22L,22L,44L,66L,110L,154L,242L,330L,484L,30L,30L,60L,90L,150L,210L,330L,450L,660L,900L,42L,42L,84L,126L,210L,294L,462630L,924L,1260L,1764L };
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
public class A143228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143228Inst : IEnumerable<long>
{
public static readonly long[] Value=A143228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143228.Bytes);
public long this[int i]=>Value[i];

public static A143228Inst Instance=new A143228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143229
{
public static readonly long[] Value={ 1L,2L,8L,21L,60L,133L,330L,675L,1474L,2910L,5838L,10920L,20944L,37673L,68580L,120384L,211365L,359964L,614845L,1022630L,1701678L,2776752L,4517016L,7232565L,11557350L,18201568L,28579152L,44373420L,68634280L,105109125L,160436916L,242692582L,365853180L,547346709L };
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
public class A143229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143229Inst : IEnumerable<long>
{
public static readonly long[] Value=A143229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143229.Bytes);
public long this[int i]=>Value[i];

public static A143229Inst Instance=new A143229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143230
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,2L,2L,4L,4L,4L,4L,8L,8L,16L,2L,2L,4L,4L,8L,4L,6L,6L,12L,12L,24L,12L,36L,4L,4L,8L,8L,16L,8L,24L,16L,6L,6L,12L,12L,24L,12L,36L,24L,36L,4L,4L,8L,8L,16L,8L,24L,16L,24L,16L,10L,10L,20L,20L,40L,20L,60L,40L,60L,40L,100L,4L,4L,8L,8L,16L,8L,24L,16L,24L,16L,40L,16L };
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
public class A143230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143230Inst : IEnumerable<long>
{
public static readonly long[] Value=A143230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143230.Bytes);
public long this[int i]=>Value[i];

public static A143230Inst Instance=new A143230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143231
{
public static readonly long[] Value={ 1L,2L,8L,12L,40L,24L,108L,88L,168L,128L,420L,184L,696L,384L,576L,640L,1536L,612L,2160L,1024L,1680L,1500L,3784L,1440L,4000L,2544L,4140L,2904L,7560L,2224L,9240L,5184L,6880L,5760L,9216L,4752L,15552L,8100L,11376L,7840L,21200L,6504L,24528L,12080L,15072L,14300L };
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
public class A143231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143231Inst : IEnumerable<long>
{
public static readonly long[] Value=A143231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143231.Bytes);
public long this[int i]=>Value[i];

public static A143231Inst Instance=new A143231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143232
{
public static readonly long[] Value={ 2L,0L,2L,0L,2L,1L,2L,0L,2L,1L,3L,1L,3L,1L,2L,0L,2L,1L,3L,2L,3L,2L,4L,2L,4L,2L,3L,2L,3L,1L,2L,0L,2L,1L,3L,2L,4L,2L,4L,3L,5L,3L,5L,4L,5L,4L,5L,3L,5L,4L,5L,4L,5L,3L,5L,3L,4L,2L,4L,2L,3L,1L,2L,0L,2L,1L,3L,2L,4L,3L,4L,3L,5L,4L,6L,4L,6L,5L,7L,5L,7L,6L,7L,6L,7L,5L,7L,6L,8L,6L,8L,7L,8L,7L,8L,6L,8L,7L,8L,7L,8L,6L,8L,6L,7L };
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
public class A143232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143232Inst : IEnumerable<long>
{
public static readonly long[] Value=A143232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143232.Bytes);
public long this[int i]=>Value[i];

public static A143232Inst Instance=new A143232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143233
{
public static readonly long[] Value={ 2L,9L,1L,5L,6L,0L,9L,0L,4L,0L,3L,0L,8L,1L,8L,7L,8L,0L,1L,3L,8L,3L,8L,4L,4L,5L,6L,4L,6L,8L,3L,9L,4L,9L,1L,8L,8L,6L,4L,0L,6L,6L,1L,5L,3L,9L,8L,5L,8L,3L,7L,2L,7L,0L,2L,6L,1L,0L,0L,1L,5L,6L,9L,1L,1L,1L,7L,4L,7L,6L,3L,6L,8L,8L,0L,4L,3L,8L,8L,6L,1L,7L,2L,6L,6L,2L,6L,8L,2L,4L,3L,0L,3L,1L,3L,4L,0L,5L,8L,9L,0L,8L,9L,7L,2L };
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
public class A143233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143233Inst : IEnumerable<long>
{
public static readonly long[] Value=A143233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143233.Bytes);
public long this[int i]=>Value[i];

public static A143233Inst Instance=new A143233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143234
{
public static readonly long[] Value={ 1L,3L,29L,5L,5L,7L,25L,9L,9L,11L,21L,13L,13L,15L,17L,17L,17L,19L,13L,21L,21L,23L,9L,25L,25L,27L,5L,29L,29L,31L,1L,1L,1L,3L,29L,5L,5L,7L,25L,9L,9L,11L,21L,13L,13L,15L,17L,17L,17L,19L,13L,21L,21L,23L,9L,25L,25L,27L,5L,29L,29L,31L,1L,1L,1L,3L,29L,5L,5L,7L,25L,9L,9L,11L,21L,13L,13L,15L,17L };
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
public class A143234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143234Inst : IEnumerable<long>
{
public static readonly long[] Value=A143234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143234.Bytes);
public long this[int i]=>Value[i];

public static A143234Inst Instance=new A143234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143235
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,4L,3L,6L,6L,9L,2L,4L,4L,6L,4L,4L,8L,8L,12L,8L,16L,2L,4L,4L,6L,4L,8L,4L,4L,8L,8L,12L,8L,16L,8L,16L,3L,6L,6L,9L,6L,12L,6L,12L,9L,4L,8L,8L,12L,8L,16L,8L,16L,12L,16L,2L,4L,4L,6L,4L,8L,4L,8L,6L,8L,4L,6L,12L,12L,18L,12L,24L,12L,24L,18L,24L,12L,36L,2L,4L,4L,6L,4L,8L,4L,8L,6L,8L,4L,12L,4L };
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
public class A143235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143235Inst : IEnumerable<long>
{
public static readonly long[] Value=A143235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143235.Bytes);
public long this[int i]=>Value[i];

public static A143235Inst Instance=new A143235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143236
{
public static readonly long[] Value={ 1L,6L,10L,24L,20L,56L,32L,80L,69L,108L,58L,210L,74L,164L,180L,250L,104L,348L,120L,396L,280L,296L,152L,672L,261L,364L,380L,606L,206L,888L,226L,714L,492L,508L,524L,1260L,284L,584L,600L,1264L,320L,1344L,340L,1056L,1092L,744L,376L,1980L,603L,1242L,844L,1302L,438L,1816L,924L };
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
public class A143236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143236Inst : IEnumerable<long>
{
public static readonly long[] Value=A143236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143236.Bytes);
public long this[int i]=>Value[i];

public static A143236Inst Instance=new A143236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143237
{
public static readonly long[] Value={ 1L,3L,9L,4L,12L,16L,7L,21L,28L,49L,6L,18L,24L,42L,36L,12L,36L,48L,84L,72L,144L,8L,24L,32L,56L,48L,96L,64L,15L,45L,60L,105L,90L,180L,120L,225L,13L,39L,52L,91L,78L,156L,104L,195L,169L,18L,54L,72L,126L,108L,216L,144L,270L,234L,324L,12L,36L,48L,84L,72L,144L,96L,180L,156L,216L };
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
public class A143237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143237Inst : IEnumerable<long>
{
public static readonly long[] Value=A143237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143237.Bytes);
public long this[int i]=>Value[i];

public static A143237Inst Instance=new A143237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143238
{
public static readonly long[] Value={ 1L,12L,32L,105L,126L,396L,328L,840L,897L,1566L,1188L,3556L,1974L,3960L };
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
public class A143238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143238Inst : IEnumerable<long>
{
public static readonly long[] Value=A143238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143238.Bytes);
public long this[int i]=>Value[i];

public static A143238Inst Instance=new A143238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143239
{
public static readonly long[] Value={ 1L,2L,-1L,3L,0L,-1L,4L,-2L,0L,0L,5L,0L,0L,0L,-1L,6L,-3L,-2L,0L,0L,1L,7L,0L,0L,0L,0L,0L,-1L,8L,-4L,0L,0L,0L,0L,0L,0L,9L,0L,-3L,0L,0L,0L,0L,0L,0L,10L,-5L,0L,0L,-2L,0L,0L,0L,0L,1L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,12L,-6L,-4L,0L,0L,2L,0L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,14L,-7L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,0L,0L,1L };
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
public class A143239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143239Inst : IEnumerable<long>
{
public static readonly long[] Value=A143239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143239.Bytes);
public long this[int i]=>Value[i];

public static A143239Inst Instance=new A143239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143272
{
public static readonly long[] Value={ 1L,6L,12L,30L,30L,84L,56L,144L,135L,220L,132L,468L,182L,420L,480L,680L,306L,1026L,380L,1260L,924L,1012L,552L,2400L,975L,1404L,1512L,2436L,870L,3720L,992L,3168L,2244L,2380L,2520L,5994L,1406L,2964L,3120L,6560L,1722L,7224L,1892L,5940L,6210L,4324L,2256L,11760L };
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
public class A143272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143272Inst : IEnumerable<long>
{
public static readonly long[] Value=A143272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143272.Bytes);
public long this[int i]=>Value[i];

public static A143272Inst Instance=new A143272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143273
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,6L,4L,8L,8L,12L,5L,10L,10L,15L,10L,6L,12L,12L,18L,12L,24L,7L,14L,14L,21L,14L,28L,14L,8L,16L,16L,24L,16L,32L,16L,32L,9L,18L,18L,27L,18L,36L,18L,36L,27L,10L,20L,30L,20L,40L,20L,40L,30L,40L,11L,22L,22L,33L,22L,44L,22L,44L,33L,44L,22L };
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
public class A143273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143273Inst : IEnumerable<long>
{
public static readonly long[] Value=A143273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143273.Bytes);
public long this[int i]=>Value[i];

public static A143273Inst Instance=new A143273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143274
{
public static readonly long[] Value={ 1L,6L,15L,32L,50L,84L,112L,160L,207L,270L,319L,420L,481L,574L,675L,800L,884L,1044L,1140L,1320L,1470L,1628L,1748L,2016L,2175L,2366L,2565L,2828L,2987L,3330L,3503L,3808L,4059L,4318L,4585L,5040L,5254L,5548L,5850L,6320L,6560L,7056L,7310L,7744L,8190L,8556L,8836L };
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
public class A143274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143274Inst : IEnumerable<long>
{
public static readonly long[] Value=A143274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143274.Bytes);
public long this[int i]=>Value[i];

public static A143274Inst Instance=new A143274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143275
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,3L,11L,7L,12L,7L,19L,9L,23L,11L,21L,16L,31L,12L,35L,21L,33L,19L,43L,21L,48L,23L,44L,33L,55L,21L,59L,36L,57L,31L,77L,36L,71L,35L,69L,49L,79L,33L,83L,57L,84L,43L,91L,48L,108L,48L,93L,69L,103L,44L,133L,77L,105L,55L,115L,63L,119L,59L,132L,80L,161L,57L,131L,93L,129L };
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
public class A143275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143275Inst : IEnumerable<long>
{
public static readonly long[] Value=A143275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143275.Bytes);
public long this[int i]=>Value[i];

public static A143275Inst Instance=new A143275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143276
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,3L,0L,0L,0L,1L,0L,5L,10L,0L,0L,1L,5L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,1L,4L,0L,1L,0L,0L,0L,0L,0L,1L,0L,3L,0L,0L,0L,0L,0L,0L,0L,1L,9L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
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
public class A143276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143276Inst : IEnumerable<long>
{
public static readonly long[] Value=A143276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143276.Bytes);
public long this[int i]=>Value[i];

public static A143276Inst Instance=new A143276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143277
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,0L,-1L,-2L,-1L,1L,-1L,-2L,0L,0L,-1L,0L,2L,1L,-2L,0L,1L,1L,1L,2L,0L,1L,1L,-1L,-1L,2L,3L,-1L,0L,2L,-1L,-1L,1L,1L,-3L,0L,0L,-1L,1L,2L,0L,-3L,-1L,-2L,-2L,1L,0L,-1L,0L,0L,-2L,0L,2L,-2L,-1L,0L,-2L,-2L,1L,1L,-1L,2L,0L,-2L,1L,2L,-1L,0L,3L,-2L,-1L,2L,-1L,-3L,3L,2L,-1L,3L,5L,-1L,-2L,1L,0L,0L,1L,-1L,0L,2L,0L,0L,3L,1L,-2L,0L,0L,0L,4L,2L,-3L,1L,1L };
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
public class A143277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143277Inst : IEnumerable<long>
{
public static readonly long[] Value=A143277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143277.Bytes);
public long this[int i]=>Value[i];

public static A143277Inst Instance=new A143277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143278
{
public static readonly long[] Value={ 1L,-25L,-49L,0L,0L,121L,0L,169L,0L,0L,0L,0L,-289L,0L,0L,-361L,0L,0L,0L,0L,0L,0L,529L,0L,0L,0L,625L,0L,0L,0L,0L,0L,0L,0L,0L,-841L,0L,0L,0L,0L,-961L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1225L,0L,0L,0L,0L,0L,1369L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1681L,0L,0L,0L,0L,0L,0L,-1849L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A143278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143278Inst : IEnumerable<long>
{
public static readonly long[] Value=A143278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143278.Bytes);
public long this[int i]=>Value[i];

public static A143278Inst Instance=new A143278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143279
{
public static readonly long[] Value={ 0L,1L,2L,3L,23L,27L,33L,63L,158L,278L,290L,351L,471L,797L,8462L,28793L,266030L };
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
public class A143279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143279Inst : IEnumerable<long>
{
public static readonly long[] Value=A143279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143279.Bytes);
public long this[int i]=>Value[i];

public static A143279Inst Instance=new A143279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143280
{
public static readonly long[] Value={ 3L,0L,5L,9L,4L,0L,7L,4L,0L,5L,3L,4L,2L,5L,7L,6L,1L,4L,4L,5L,3L,9L,4L,7L,5L,4L,9L,9L,2L,3L,3L,2L,7L,8L,6L,1L,2L,9L,7L,7L,2L,5L,4L,7L,2L,6L,3L,3L,5L,3L,4L,0L,2L,0L,9L,2L,9L,9L,7L,1L,8L,7L,7L,9L,8L,0L,5L,4L,4L,2L,8L,1L,9L,6L,8L,4L,6L,1L,3L,5L,3L,5L,7L,4L,8L,1L,8L,5L,7L,4L,4L,8L,3L,4L,9L,7L,8L,2L,8L,3L,1L,5L,0L,1L,5L };
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
public class A143280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143280Inst : IEnumerable<long>
{
public static readonly long[] Value=A143280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143280.Bytes);
public long this[int i]=>Value[i];

public static A143280Inst Instance=new A143280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143281
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,8L,15L,27L,48L,84L,145L,248L,421L,710L,1191L,1989L,3309L,5487L,9073L,14966L,24634L,40472L,66384L,108729L,177858L,290610L,474364L,773615L,1260643L,2052818L,3340662L,5433345L,8832432L,14351403L,23309326L,37844645L,61423513L,99663191L,161665653L };
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
public class A143281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143281Inst : IEnumerable<long>
{
public static readonly long[] Value=A143281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143281.Bytes);
public long this[int i]=>Value[i];

public static A143281Inst Instance=new A143281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143282
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,5L,9L,15L,24L,38L,60L,94L,146L,225L,345L,527L,802L,1216L,1838L,2771L,4168L,6256L,9372L,14016L,20929L,31208L,46476L,69133L,102726L,152494L,226171L,335169L,496320L,734440L,1086102L,1605187L,2371049L,3500522L,5165573L,7619251L };
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
public class A143282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143282Inst : IEnumerable<long>
{
public static readonly long[] Value=A143282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143282.Bytes);
public long this[int i]=>Value[i];

public static A143282Inst Instance=new A143282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143283
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,3L,4L,6L,10L,16L,24L,35L,51L,75L,110L,160L,231L,332L,476L,681L,972L,1384L,1966L,2787L,3944L,5573L,7864L,11082L,15597L,21926L,30791L,43199L,60553L,84807L,118682L,165966L,231930L,323905L,452083L,630629L,879224L,1225205L,1706532L,2375901L };
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
public class A143283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143283Inst : IEnumerable<long>
{
public static readonly long[] Value=A143283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143283.Bytes);
public long this[int i]=>Value[i];

public static A143283Inst Instance=new A143283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143284
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,7L,11L,17L,25L,35L,48L,66L,92L,129L,180L,249L,342L,468L,640L,875L,1195L,1629L,2216L,3009L,4080L,5526L,7477L,10107L,13649L,18415L,24823L,33433L,44995L,60513L,81330L,109241L,146644L,196742L,263813L,353570L,473640L,634201L };
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
public class A143284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143284Inst : IEnumerable<long>
{
public static readonly long[] Value=A143284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143284.Bytes);
public long this[int i]=>Value[i];

public static A143284Inst Instance=new A143284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143285
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,8L,12L,18L,26L,36L,48L,63L,83L,111L,150L,203L,273L,364L,482L,636L,839L,1108L,1464L,1933L,2548L,3352L,4402L,5774L,7568L,9914L,12980L,16983L,22204L,29008L,37870L,49408L,64425L,83963L,109373L,142406L,185331L,241088L,313486L };
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
public class A143285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143285Inst : IEnumerable<long>
{
public static readonly long[] Value=A143285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143285.Bytes);
public long this[int i]=>Value[i];

public static A143285Inst Instance=new A143285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143286
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,9L,13L,19L,27L,37L,49L,63L,80L,102L,132L,173L,228L,300L,392L,508L,654L,839L,1076L,1382L,1778L,2289L,2945L,3783L,4850L,6207L,7934L,10135L,12943L,16526L,21095L,26915L,34320L,43733L,55692L,70882L,90174L,114673L,145778L };
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
public class A143286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143286Inst : IEnumerable<long>
{
public static readonly long[] Value=A143286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143286.Bytes);
public long this[int i]=>Value[i];

public static A143286Inst Instance=new A143286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143287
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,10L,14L,20L,28L,38L,50L,64L,80L,99L,123L,155L,198L,255L,329L,423L,540L,684L,861L,1080L,1354L,1700L,2139L,2696L,3400L,4285L,5392L,6772L,8490L,10630L,13300L,16637L,20812L,26036L,32568L,40726L,50902L,63582L,79372L };
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
public class A143287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143287Inst : IEnumerable<long>
{
public static readonly long[] Value=A143287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143287.Bytes);
public long this[int i]=>Value[i];

public static A143287Inst Instance=new A143287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143320
{
public static readonly long[] Value={ 1L,4L,-1L,8L,-1L,-1L,15L,-4L,-1L,0L,21L,-4L,-1L,0L,-1L,33L,-8L,-4L,0L,-1L,1L,41L,-8L,-4L,0L,-1L,1L,-1L,56L,-15L,-4L,0L,-1L,1L,-1L,0L,69L,-15L,-8L,0L,-1L,1L,-1L,0L,0L,87L,-21L,-8L,0L,-4L,1L,-1L,0L,0L,1L,99L,-21L,-8L,0L,-4L,1L,-1L,0L,0L,1L,-1L,127L,-33L,-15L,0L,-4L,4L,-1L,0L,0L,1L,-1L,0L };
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
public class A143320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143320Inst : IEnumerable<long>
{
public static readonly long[] Value=A143320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143320.Bytes);
public long this[int i]=>Value[i];

public static A143320Inst Instance=new A143320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143321
{
public static readonly long[] Value={ 15L,20L,24L,35L,54L,95L,98L,104L,119L,135L,143L,144L,160L,189L,207L,209L,224L,287L,319L,323L,324L,351L,363L,375L,377L,384L,390L,459L,464L,527L,539L,559L,608L,779L,845L,864L,875L,899L,923L,989L,999L,1000L,1007L,1029L,1189L,1199L,1215L,1280L,1343L,1349L,1375L };
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
public class A143321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143321Inst : IEnumerable<long>
{
public static readonly long[] Value=A143321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143321.Bytes);
public long this[int i]=>Value[i];

public static A143321Inst Instance=new A143321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143322
{
public static readonly long[] Value={ 6L,21L,28L,36L,50L,96L,99L,216L,225L,301L,325L,352L,400L,441L,486L,495L,496L,576L,630L,676L,697L,784L,847L,925L,1225L,1296L,1333L,1521L,1536L,1587L,1695L,1701L,1792L,1909L,2025L,2041L,2133L,2145L,2500L,2601L,2624L,2916L,2926L,3025L,3200L,3220L,3276L,3456L };
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
public class A143322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143322Inst : IEnumerable<long>
{
public static readonly long[] Value=A143322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143322.Bytes);
public long this[int i]=>Value[i];

public static A143322Inst Instance=new A143322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143323
{
public static readonly long[] Value={ 1L,1L,-2L,-1L,1L,-2L,-2L,1L,3L,1L,0L,2L,0L,-2L,-2L,-1L,0L,3L,0L,-1L,4L,0L,-2L,-2L,1L,0L,-4L,2L,2L,-2L,0L,1L,0L,0L,-2L,-3L,0L,0L,0L,1L,2L,4L,-2L,0L,3L,-2L,-2L,2L,3L,1L,0L,0L,0L,-4L,0L,-2L,0L,2L,0L,2L,2L,0L,-6L,-1L,0L,0L,-2L,0L,4L,-2L,0L,3L,0L,0L,-2L,0L,0L,0L,0L,-1L,5L,2L,-2L,-4L,0L,-2L,-4L,0L,2L,3L,0L,2L,0L,-2L,0L,-2L,0L,3L,0L,-1L,2L,0L,-2L,0L,4L };
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
public class A143323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143323Inst : IEnumerable<long>
{
public static readonly long[] Value=A143323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143323.Bytes);
public long this[int i]=>Value[i];

public static A143323Inst Instance=new A143323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143324
{
public static readonly long[] Value={ 1L,2L,0L,3L,2L,0L,4L,6L,6L,0L,5L,12L,24L,12L,0L,6L,20L,60L,72L,30L,0L,7L,30L,120L,240L,240L,54L,0L,8L,42L,210L,600L,1020L,696L,126L,0L,9L,56L,336L,1260L,3120L,4020L,2184L,240L,0L,10L,72L,504L,2352L,7770L,15480L,16380L,6480L,504L,0L,11L,90L,720L,4032L,16800L,46410L,78120L,65280L,19656L,990L,0L };
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
public class A143324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143324Inst : IEnumerable<long>
{
public static readonly long[] Value=A143324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143324.Bytes);
public long this[int i]=>Value[i];

public static A143324Inst Instance=new A143324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143325
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,3L,0L,1L,3L,8L,6L,0L,1L,4L,15L,24L,15L,0L,1L,5L,24L,60L,80L,27L,0L,1L,6L,35L,120L,255L,232L,63L,0L,1L,7L,48L,210L,624L,1005L,728L,120L,0L,1L,8L,63L,336L,1295L,3096L,4095L,2160L,252L,0L,1L,9L,80L,504L,2400L,7735L,15624L,16320L,6552L,495L,0L,1L,10L,99L };
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
public class A143325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143325Inst : IEnumerable<long>
{
public static readonly long[] Value=A143325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143325.Bytes);
public long this[int i]=>Value[i];

public static A143325Inst Instance=new A143325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143326
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,9L,10L,1L,5L,16L,33L,22L,1L,6L,25L,76L,105L,52L,1L,7L,36L,145L,316L,345L,106L,1L,8L,49L,246L,745L,1336L,1041L,232L,1L,9L,64L,385L,1506L,3865L,5356L,3225L,472L,1L,10L,81L,568L,2737L,9276L,19345L,21736L,9705L,976L,1L,11L,100L,801L,4600L,19537L,55686L };
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
public class A143326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143326Inst : IEnumerable<long>
{
public static readonly long[] Value=A143326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143326.Bytes);
public long this[int i]=>Value[i];

public static A143326Inst Instance=new A143326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143327
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,5L,1L,1L,4L,11L,11L,1L,1L,5L,19L,35L,26L,1L,1L,6L,29L,79L,115L,53L,1L,1L,7L,41L,149L,334L,347L,116L,1L,1L,8L,55L,251L,773L,1339L,1075L,236L,1L,1L,9L,71L,391L,1546L,3869L,5434L,3235L,488L,1L,1L,10L,89L,575L,2791L,9281L,19493L,21754L,9787L,983L,1L,1L,11L };
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
public class A143327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143327Inst : IEnumerable<long>
{
public static readonly long[] Value=A143327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143327.Bytes);
public long this[int i]=>Value[i];

public static A143327Inst Instance=new A143327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143328
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,6L,5L,1L,5L,10L,14L,8L,1L,6L,15L,30L,32L,14L,1L,7L,21L,55L,90L,80L,23L,1L,8L,28L,91L,205L,294L,196L,41L,1L,9L,36L,140L,406L,829L,964L,508L,71L,1L,10L,45L,204L,728L,1960L,3409L,3304L,1318L,127L,1L,11L,55L,285L,1212L,4088L,9695L,14569L,11464L,3502L,226L,1L };
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
public class A143328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143328Inst : IEnumerable<long>
{
public static readonly long[] Value=A143328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143328.Bytes);
public long this[int i]=>Value[i];

public static A143328Inst Instance=new A143328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143329
{
public static readonly long[] Value={ 3L,2L,7L,11L,19L,61L,47L,109L,73L,223L,211L,251L,239L,167L,151L,157L,137L,439L,421L,419L,499L,463L,331L,787L,827L,971L,991L,1009L,947L,911L,641L,647L,659L,701L,757L,613L,569L,521L,1549L,1663L,1747L,1789L,1697L,1667L,1933L,1951L,1877L,1291L,1367L,1531L,1447L,1451L };
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
public class A143329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143329Inst : IEnumerable<long>
{
public static readonly long[] Value=A143329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143329.Bytes);
public long this[int i]=>Value[i];

public static A143329Inst Instance=new A143329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143330
{
public static readonly long[] Value={ 1L,1L,3L,8L,25L,83L,289L,1041L,3847L,14504L,55569L,215727L,846761L,3354858L,13398965L,53888063L,218053915L,887107888L,3626373205L,14887942624L,61358959587L,253771944529L,1052917272543L,4381374717994L,18280470530047L,76459765772375L };
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
public class A143330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143330Inst : IEnumerable<long>
{
public static readonly long[] Value=A143330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143330.Bytes);
public long this[int i]=>Value[i];

public static A143330Inst Instance=new A143330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143331
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L };
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
public class A143331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143331Inst : IEnumerable<long>
{
public static readonly long[] Value=A143331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143331.Bytes);
public long this[int i]=>Value[i];

public static A143331Inst Instance=new A143331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143332
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,7L,12L,11L,31L,51L,44L,117L,216L,157L,453L,851L,566L,803L,788L,127L,859L,931L,440L,521L,432L,409L,809L,739L,458L,239L,828L,947L,391L,531L,148L,173L,360L,837L,61L,1011L,942L,475L,36L,375L,307L,579L,496L,145L,864L,689L,465L };
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
public class A143332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143332Inst : IEnumerable<long>
{
public static readonly long[] Value=A143332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143332.Bytes);
public long this[int i]=>Value[i];

public static A143332Inst Instance=new A143332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143333
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,3L,3L,1L,1L,0L,0L,0L,1L,1L,5L,0L,0L,5L,1L,1L,0L,15L,0L,15L,0L,1L,1L,7L,21L,35L,35L,21L,7L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,9L,0L,0L,0L,0L,0L,0L,9L,1L,1L,0L,45L,0L,0L,0L,0L,0L,45L,0L,1L };
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
public class A143333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143333Inst : IEnumerable<long>
{
public static readonly long[] Value=A143333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143333.Bytes);
public long this[int i]=>Value[i];

public static A143333Inst Instance=new A143333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143334
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,5L,5L,1L,1L,8L,8L,8L,1L,1L,11L,12L,12L,11L,1L,1L,14L,13L,14L,13L,14L,1L,1L,17L,17L,17L,17L,17L,17L,1L,1L,20L,20L,20L,20L,20L,20L,20L,1L,1L,23L,24L,24L,24L,24L,24L,24L,23L,1L,1L,30L,29L,30L,30L,30L,30L,30L,29L,30L,1L };
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
public class A143334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143334Inst : IEnumerable<long>
{
public static readonly long[] Value=A143334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143334.Bytes);
public long this[int i]=>Value[i];

public static A143334Inst Instance=new A143334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143335
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,1L,-2L,0L,-1L,-3L,2L,-6L,1L,-4L,-3L,-3L,-5L,-4L,-7L,-6L,-9L,-8L,-14L,-10L,-18L,-18L,-20L,-28L,-27L,-38L,-39L,-50L,-57L,-67L,-79L,-94L,-109L,-128L,-154L,-175L,-213L,-244L,-292L,-341L,-400L,-475L,-553L,-655L,-768L,-905L,-1062L,-1253L };
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
public class A143335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143335Inst : IEnumerable<long>
{
public static readonly long[] Value=A143335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143335.Bytes);
public long this[int i]=>Value[i];

public static A143335Inst Instance=new A143335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143528
{
public static readonly long[] Value={ 1L,2L,3L,7L,4L,5L,12L,9L,6L,8L,41L,14L,11L,13L,10L,70L,19L,16L,18L,15L,17L,239L,24L,21L,23L,20L,22L,29L,408L,53L,26L,28L,25L,27L,34L,46L,1393L,82L,31L,33L,30L,32L,39L,51L,58L,2378L,111L,36L,38L,35L,37L,44L,56L,63L,75L,8119L,140L,65L,43L,40L,42L,49L,61L,68L,80L };
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
public class A143528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143528Inst : IEnumerable<long>
{
public static readonly long[] Value=A143528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143528.Bytes);
public long this[int i]=>Value[i];

public static A143528Inst Instance=new A143528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143529
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,7L,9L,11L,12L,10L,13L,16L,18L,17L,19L,14L,20L,21L,23L,29L,22L,15L,32L,25L,28L,35L,70L,24L,26L,38L,35L,30L,45L,47L,99L,34L,27L,39L,37L,40L,49L,52L,57L,169L,41L,31L,48L,43L,42L,50L,54L,76L,59L,408L,58L,36L,51L,55L,44L,62L,69L,81L,88L };
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
public class A143529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143529Inst : IEnumerable<long>
{
public static readonly long[] Value=A143529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143529.Bytes);
public long this[int i]=>Value[i];

public static A143529Inst Instance=new A143529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143530
{
public static readonly long[] Value={ 1L,4L,8L,2L,7L,7L,3L,7L,8L,7L,1L,0L,0L,8L,0L,7L,6L,5L,8L,5L,8L,6L,3L,8L,4L,4L,4L,7L,7L,0L,6L,0L,5L,9L,3L,1L,2L,0L,2L,7L,1L,7L,1L,2L,9L,2L,5L,0L,3L,2L,5L,4L,2L,5L,1L,4L,0L,8L,8L,6L,4L,7L,8L,3L,4L,2L,0L,0L,3L,1L,7L,2L,3L,7L,2L,7L,9L,8L,6L,0L,1L,9L,1L,1L,4L,0L,1L,1L,6L,5L,2L,8L,8L,1L,0L,5L,5L,9L,5L,1L,3L,8L,0L,7L,5L };
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
public class A143530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143530Inst : IEnumerable<long>
{
public static readonly long[] Value=A143530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143530.Bytes);
public long this[int i]=>Value[i];

public static A143530Inst Instance=new A143530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143531
{
public static readonly long[] Value={ 1L,8L,2L,8L,6L,4L,3L,2L,6L,9L,7L,5L,2L,5L,2L,2L,6L,1L,0L,4L,0L,9L,7L,3L,2L,5L,2L,7L,3L,1L,8L,0L,6L,9L,3L,2L,0L,0L,0L,8L,6L,5L,2L,9L,1L,8L,1L,1L,0L,1L,9L,8L,6L,3L,2L,3L,9L,2L,0L,2L,7L,7L,9L,1L,1L,5L,9L,7L,7L,1L,1L,1L,7L,2L,0L,4L,6L,4L,1L,1L,8L,0L,0L,9L,2L,7L,8L,5L,5L,0L,1L,1L,2L,5L,5L,8L,2L,4L,4L,2L,1L,5L,4L,0L,0L };
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
public class A143531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143531Inst : IEnumerable<long>
{
public static readonly long[] Value=A143531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143531.Bytes);
public long this[int i]=>Value[i];

public static A143531Inst Instance=new A143531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143532
{
public static readonly long[] Value={ 0L,1L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,166L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,2L,1L,2L,2504L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A143532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143532Inst : IEnumerable<long>
{
public static readonly long[] Value=A143532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143532.Bytes);
public long this[int i]=>Value[i];

public static A143532Inst Instance=new A143532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143533
{
public static readonly long[] Value={ 0L,1L,2L,4L,18L,40L,162L,526L,1708L,4838L,13522L,34062L };
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
public class A143533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143533Inst : IEnumerable<long>
{
public static readonly long[] Value=A143533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143533.Bytes);
public long this[int i]=>Value[i];

public static A143533Inst Instance=new A143533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143534
{
public static readonly long[] Value={ 0L,1L,1L,6L,166L,2504L,33102L,411100L,4911098L,57111096L,651111094L,7311111092L };
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
public class A143534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143534Inst : IEnumerable<long>
{
public static readonly long[] Value=A143534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143534.Bytes);
public long this[int i]=>Value[i];

public static A143534Inst Instance=new A143534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143535
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,2L,2L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L };
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
public class A143535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143535Inst : IEnumerable<long>
{
public static readonly long[] Value=A143535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143535.Bytes);
public long this[int i]=>Value[i];

public static A143535Inst Instance=new A143535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143536
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A143536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143536Inst : IEnumerable<long>
{
public static readonly long[] Value=A143536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143536.Bytes);
public long this[int i]=>Value[i];

public static A143536Inst Instance=new A143536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143537
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,2L,2L,1L,0L,3L,3L,2L,1L,3L,3L,2L,1L,1L,0L,4L,4L,3L,2L,2L,1L,1L,4L,4L,3L,2L,2L,1L,1L,0L,4L,4L,3L,2L,2L,1L,1L,0L,0L,4L,4L,3L,2L,2L,1L,1L,0L,0L,0L,5L,5L,4L,3L,3L,2L,2L,1L,1L,1L,1L,5L,5L,4L,3L,3L,2L,21L,1L,1L,1L,0L,6L,6L,5L,4L,4L,3L,3L,2L,2L,2L,2L,1L,1L };
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
public class A143537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143537Inst : IEnumerable<long>
{
public static readonly long[] Value=A143537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143537.Bytes);
public long this[int i]=>Value[i];

public static A143537Inst Instance=new A143537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143538
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L };
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
public class A143538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143538Inst : IEnumerable<long>
{
public static readonly long[] Value=A143538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143538.Bytes);
public long this[int i]=>Value[i];

public static A143538Inst Instance=new A143538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143539
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,0L,2L,3L,1L,3L,1L,1L,3L,1L,2L,3L,3L,1L,2L,3L,1L,4L,2L,1L,5L,1L,1L,5L,3L,1L,2L,4L,1L,3L,4L,2L,5L,3L,1L,4L,2L,2L,6L,2L,1L,3L,2L,3L,5L,4L,1L,5L,5L,1L,6L,3L,2L,5L,1L,2L,2L,4L,3L,5L,4L,0L,7L,4L,1L,6L,3L,1L,5L,2L,2L,5L,6L,1L,2L,5L,2L,7L,4L,2L,6L,2L,2L,9L,2L,3L,4L,4L,2L,2L,4L,1L,9L,5L,3L,5L,5L,3L };
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
public class A143539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143539Inst : IEnumerable<long>
{
public static readonly long[] Value=A143539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143539.Bytes);
public long this[int i]=>Value[i];

public static A143539Inst Instance=new A143539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143540
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,2L,1L,0L,0L,3L,2L,0L,1L,0L,3L,2L,0L,1L,0L,0L,4L,3L,0L,2L,0L,1L,0L,4L,3L,0L,2L,0L,1L,0L,0L,4L,3L,0L,2L,0L,1L,0L,0L,0L,4L,3L,0L,2L,0L,1L,0L,0L,0L,0L,5L,4L,0L,3L,0L,2L,0L,0L,0L,1L };
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
public class A143540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143540Inst : IEnumerable<long>
{
public static readonly long[] Value=A143540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143540.Bytes);
public long this[int i]=>Value[i];

public static A143540Inst Instance=new A143540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143541
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L };
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
public class A143541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143541Inst : IEnumerable<long>
{
public static readonly long[] Value=A143541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143541.Bytes);
public long this[int i]=>Value[i];

public static A143541Inst Instance=new A143541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143542
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,2L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,2L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L };
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
public class A143542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143542Inst : IEnumerable<long>
{
public static readonly long[] Value=A143542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143542.Bytes);
public long this[int i]=>Value[i];

public static A143542Inst Instance=new A143542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143543
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,1L,38L,19L,6L,1L,728L,230L,55L,10L,1L,26704L,5098L,825L,125L,15L,1L,1866256L,207536L,20818L,2275L,245L,21L,1L,251548592L,15891372L,925036L,64673L,5320L,434L,28L,1L,66296291072L,2343580752L,76321756L,3102204L,169113L,11088L,714L,36L,1L };
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
public class A143543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143543Inst : IEnumerable<long>
{
public static readonly long[] Value=A143543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143543.Bytes);
public long this[int i]=>Value[i];

public static A143543Inst Instance=new A143543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143704
{
public static readonly long[] Value={ 9L,20L,35L,15L,20L,26L,32L,50L,102L,10L,42L,56L,299L,15L,14L,48L,28L,93L,72L,88L,95L,18L,185L,63L,45L,92L,430L,44L,25L,1175L,18L,18L,21L,38L,132L,30L,39L,190L,1829L,12L,132L,68L,54L,36L,938L,68L,52L,852L,15L,150L,200L,8L,286L,65L,324L,32L,3569L,12L,204L,135L,93L,200L,25L,40L };
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
public class A143704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143704Inst : IEnumerable<long>
{
public static readonly long[] Value=A143704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143704.Bytes);
public long this[int i]=>Value[i];

public static A143704Inst Instance=new A143704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143705
{
public static readonly BigInteger[] Value={ 27L,1024L,78125L,125L,1024L,169L,256L,100000L,16926659444736L,25L,441L,2097152L,BigInteger.Parse("41753905413413116367045797"),125L,49L,4096L,16384L,29791L,1296L,8589934592L,2476099L,81L,BigInteger.Parse("72759576141834259033203125"),9261L,3375L };
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
public class A143705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143705Inst Instance=new A143705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143706
{
public static readonly long[] Value={ 5L,9L,13L,9L,9L,24L,41L,26L,25L,8L,40L,22L,45L,9L,12L,42L,11L,61L,157L,26L,39L,16L,43L,41L,29L,207L,64L,15L,11L,93L,11L,16L,13L,36L,691L,14L,25L,40L,117L,7L,307L,95L,20L,67L,100L,21L,71L,106L,9L,148L,116L,6L,144L,19L,162L,19L,165L,7L,52L,89L,61L,981L,11L,93L,49L,109L,97L,112L };
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
public class A143706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143706Inst : IEnumerable<long>
{
public static readonly long[] Value=A143706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143706.Bytes);
public long this[int i]=>Value[i];

public static A143706Inst Instance=new A143706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143707
{
public static readonly long[] Value={ 5L,14L,20L,12L,14L,44L,45L,56L,42L,10L,76L,50L,68L,12L,20L,78L,18L,145L,165L,70L,44L,28L,117L,44L,65L,215L,150L,26L,21L,140L,14L,28L,25L,68L,715L,24L,55L,154L,176L,10L,315L,155L,56L,75L,234L,38L,75L,390L,12L,150L,296L,8L,342L,32L,474L,35L,248L,10L,154L,92L,145L,1001L,21L,105L };
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
public class A143707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143707Inst : IEnumerable<long>
{
public static readonly long[] Value=A143707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143707.Bytes);
public long this[int i]=>Value[i];

public static A143707Inst Instance=new A143707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143708
{
public static readonly BigInteger[] Value={ 1L,128L,1024L,64L,128L,14641L,14348907L,5764801L,2097152L,32L,130321L,9765625L,17179869184L,64L,625L,4826809L,512L,20511149L,BigInteger.Parse("116415321826934814453125"),6103515625L,4194304L,2401L,4052555153018976267L,4194304L,371293L };
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
public class A143708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143708.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143708Inst Instance=new A143708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143709
{
public static readonly BigInteger[] Value={ 4L,9L,15L,11L,9L,123L,1594325L,348L,33L,10L,363L,132L,2071L,11L,27L,2200L,11L,844L,BigInteger.Parse("4656612873077392578127"),136L,131077L,51L,46L,524291L,172L,BigInteger.Parse("45474735088646411895751953127"),2230L,15L,14L,8388655L,19L,51L,28L,291L };
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
public class A143709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143709.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143709Inst Instance=new A143709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143710
{
public static readonly long[] Value={ 6L,9L,12L,8L,9L,15L,18L,15L,23L,7L,23L,15L,36L,8L,9L,19L,11L,34L,38L,19L,24L,11L,42L,24L,18L,48L,53L,15L,10L,72L,9L,11L,10L,21L,68L,11L,16L,29L,90L,7L,68L,36L,15L,20L,81L,21L,28L,83L,8L,77L,45L,6L,37L,18L,85L,12L,126L,7L,29L,48L,34L,102L,10L,22L,28L,80L,26L,105L,11L,16L,9L,105L,123L };
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
public class A143710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143710Inst : IEnumerable<long>
{
public static readonly long[] Value=A143710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143710.Bytes);
public long this[int i]=>Value[i];

public static A143710Inst Instance=new A143710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143711
{
public static readonly long[] Value={ 6L,20L,42L,18L,20L,44L,78L,105L,136L,12L,76L,105L,506L,18L,20L,117L,28L,174L,310L,165L,170L,28L,222L,114L,78L,410L,903L,44L,30L,2162L,24L,28L,30L,68L,1378L,45L,66L,399L,3422L,12L,610L,186L,84L,130L,2211L,68L,138L,2485L,18L,292L,555L,8L,1463L,78L,632L,60L,6806L,12L };
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
public class A143711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143711Inst : IEnumerable<long>
{
public static readonly long[] Value=A143711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143711.Bytes);
public long this[int i]=>Value[i];

public static A143711Inst Instance=new A143711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143712
{
public static readonly long[] Value={ 21L,23L,25L,27L,29L,41L,43L,45L,47L,49L,61L,63L,65L,67L,69L,81L,83L,85L,87L,89L,201L,203L,205L,207L,209L,221L,223L,225L,227L,229L,241L,243L,245L,247L,249L,261L,263L,265L,267L,269L,281L,283L,285L,287L,289L,401L,403L,405L,407L,409L,421L,423L,425L,427L,429L,441L,443L,445L,447L };
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
public class A143712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143712Inst : IEnumerable<long>
{
public static readonly long[] Value=A143712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143712.Bytes);
public long this[int i]=>Value[i];

public static A143712Inst Instance=new A143712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143713
{
public static readonly long[] Value={ 3L,4L,5L,6L,10L,22L,31L,92L,174L,237L,886L };
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
public class A143713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143713Inst : IEnumerable<long>
{
public static readonly long[] Value=A143713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143713.Bytes);
public long this[int i]=>Value[i];

public static A143713Inst Instance=new A143713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143714
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,3L,0L,4L,4L,0L,0L,11L,0L,0L,10L,8L,0L,7L,0L,17L,18L,0L,0L,28L,0L,0L,10L,16L,0L,19L,0L,15L,18L,0L,6L,33L,0L,0L,14L,42L,0L,35L,0L,16L,42L,0L,0L,77L,0L,0L,18L,19L,0L,19L,24L,53L,20L,0L,0L,120L,0L,0L,60L,29L,30L,34L,0L,25L,24L,12L,0L,114L,0L,0L,46L,28L,18L,27L,0L,103L,28L,0L,0L,140L };
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
public class A143714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143714Inst : IEnumerable<long>
{
public static readonly long[] Value=A143714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143714.Bytes);
public long this[int i]=>Value[i];

public static A143714Inst Instance=new A143714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143715
{
public static readonly long[] Value={ 0L,0L,2L,3L,3L,6L,6L,10L,14L,14L,14L,25L,25L,25L,35L,43L,43L,50L,50L,67L,85L,85L,85L,113L,113L,113L,123L,139L,139L,158L,158L,173L,191L,191L,197L,230L,230L,230L,244L,286L,286L,321L,321L,337L,379L,379L,379L,456L,456L,456L,474L,493L,493L,512L,536L,589L,609L,609L,609L };
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
public class A143715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143715Inst : IEnumerable<long>
{
public static readonly long[] Value=A143715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143715.Bytes);
public long this[int i]=>Value[i];

public static A143715Inst Instance=new A143715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143716
{
public static readonly BigInteger[] Value={ 1L,2L,3L,4L,15625L,7L,72L,10L,313842837672L,393737638569928L,240L,17L,BigInteger.Parse("14164706907106753527152640") };
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
public class A143716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143716Inst Instance=new A143716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143717
{
public static readonly long[] Value={ 4L,5L,8L,4L,5L,7L,12L,1L,19L,3L,15L,5L,32L,4L,1L,7L,7L,24L,28L,9L,20L,3L,36L,20L,8L,38L,47L,11L,4L,68L,5L,3L,0L,13L,42L,5L,6L,15L,86L,3L,58L,26L,1L,10L,75L,17L,22L,73L,4L,73L,29L,2L,1L,14L,73L,2L,122L,3L,15L,44L,24L,80L,4L,8L,24L,18L,16L,95L,7L,10L,5L,101L,117L,14L,9L,158L,3L,108L,9L,31L };
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
public class A143717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143717Inst : IEnumerable<long>
{
public static readonly long[] Value=A143717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143717.Bytes);
public long this[int i]=>Value[i];

public static A143717Inst Instance=new A143717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143718
{
public static readonly long[] Value={ 4L,8L,16L,20L,25L,28L,32L,40L,44L,48L,49L,50L,52L,56L,64L,68L,76L,80L,81L,88L,92L,96L,98L,100L,104L,112L,116L,121L,124L,125L,128L,136L,140L,144L,148L,152L,160L,162L,164L,169L,172L,175L,176L,184L,188L,192L,196L,200L,208L,212L,220L,224L,232L,236L,242L,243L,244L,245L,248L,250L };
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
public class A143718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143718Inst : IEnumerable<long>
{
public static readonly long[] Value=A143718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143718.Bytes);
public long this[int i]=>Value[i];

public static A143718Inst Instance=new A143718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143719
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,11L,12L,13L,14L,15L,17L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,51L,52L,53L,55L,57L,58L,59L,61L,62L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,82L,83L,85L,86L,87L,89L,91L,92L,93L,94L,95L,97L,100L };
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
public class A143719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143719Inst : IEnumerable<long>
{
public static readonly long[] Value=A143719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143719.Bytes);
public long this[int i]=>Value[i];

public static A143719Inst Instance=new A143719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143832
{
public static readonly long[] Value={ 13L,223L,349L,503L,1399L,1693L,3583L,6173L,9463L,16183L,18143L,27103L,28349L,33613L,40823L,42349L,48733L,59149L,66653L,70573L,80863L,89599L,101149L,115933L,126349L,129023L,139999L,151423L,157303L,169399L,181943L,185149L,201599L,204973L,218749L };
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
public class A143832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143832Inst : IEnumerable<long>
{
public static readonly long[] Value=A143832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143832.Bytes);
public long this[int i]=>Value[i];

public static A143832Inst Instance=new A143832Inst();

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