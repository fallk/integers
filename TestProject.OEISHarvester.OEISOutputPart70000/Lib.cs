using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A140605
{
public static readonly long[] Value={ 2L,3L,3L,4L,3L,5L,3L,5L,5L,5L,3L,6L,3L,5L,5L,7L,3L,7L,3L,7L,5L,5L,3L,7L,5L,5L,7L,7L,3L,7L,3L,9L,5L,5L,5L,8L,3L,5L,5L,9L,3L,7L,3L,7L,7L,5L,3L,11L,5L,7L,5L,7L,3L,8L,5L,9L,5L,5L,3L,11L,3L,5L,7L,11L,5L,7L,3L,7L,5L,7L,3L,11L,3L,5L,7L,7L,5L,7L,3L,11L,8L,5L,3L,11L,5L,5L,5L,9L,3L,11L,5L,7L,5L,5L,5L,12L,3L,7L,7L,11L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140605Inst : IEnumerable<long>
{
public static readonly long[] Value=A140605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140605.Bytes);
public long this[int i]=>Value[i];

public static A140605Inst Instance=new A140605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140606
{
public static readonly BigInteger[] Value={ 1L,6L,68L,1170L,27142L,793002L,27914126L,1150212810L,54326011414L,2894532443154L,171800282010062L,11243812043430330L,804596872359480358L,BigInteger.Parse("62506696942427106498"),BigInteger.Parse("5239819196582605428254"),BigInteger.Parse("471480120474696200252970"),BigInteger.Parse("45328694990444455796547766"),BigInteger.Parse("4637556923393331549190920306") };
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
public class A140606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140606Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140606.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140606.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140606Inst Instance=new A140606Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140607
{
public static readonly long[] Value={ 3L,5L,7L,10L,11L,13L,13L,17L,19L,22L,23L,31L,37L,29L,31L,31L,43L,37L,37L,41L,43L,55L,47L,64L,45L,53L,61L,55L,59L,61L,55L,61L,67L,78L,71L,73L,91L,106L,79L,136L,83L,77L,85L,89L,91L,96L,109L,97L,136L,101L,103L,109L,107L,109L,109L,113L,155L,103L,145L,166L,111L,201L,127L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140607Inst : IEnumerable<long>
{
public static readonly long[] Value=A140607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140607.Bytes);
public long this[int i]=>Value[i];

public static A140607Inst Instance=new A140607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140608
{
public static readonly long[] Value={ 15L,33L,39L,51L,57L,63L,65L,85L,87L,111L,117L,123L,129L,145L,159L,171L,177L,183L,185L,195L,201L,205L,249L,255L,265L,273L,275L,291L,303L,305L,315L,321L,327L,333L,339L,341L,393L,399L,411L,417L,435L,447L,451L,455L,465L,471L,481L,485L,489L,505L,511L,513L,519L,537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140608Inst : IEnumerable<long>
{
public static readonly long[] Value=A140608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140608.Bytes);
public long this[int i]=>Value[i];

public static A140608Inst Instance=new A140608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140609
{
public static readonly long[] Value={ 17L,25L,31L,32L,36L,43L,45L,46L,50L,51L,53L,59L,60L,62L,63L,66L,67L,68L,69L,74L,78L,79L,81L,83L,86L,87L,88L,92L,93L,95L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140609Inst : IEnumerable<long>
{
public static readonly long[] Value=A140609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140609.Bytes);
public long this[int i]=>Value[i];

public static A140609Inst Instance=new A140609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140610
{
public static readonly long[] Value={ 2L,7L,19L,41L,43L,83L,103L,127L,233L,569L,673L,683L,1069L,1217L,1571L,2609L,2713L,2957L,3371L,3671L,3847L,3919L,4957L,4973L,6229L,7193L,7253L,7639L,8161L,8527L,9439L,9949L,10159L,12959L,13687L,13763L,13831L,13967L,15497L,16741L,17681L,17807L,20047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140610Inst : IEnumerable<long>
{
public static readonly long[] Value=A140610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140610.Bytes);
public long this[int i]=>Value[i];

public static A140610Inst Instance=new A140610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140611
{
public static readonly long[] Value={ 4L,6L,10L,15L,16L,24L,26L,32L,42L,72L,78L,81L,102L,111L,124L,168L,172L,182L,196L,205L,209L,212L,240L,243L,276L,299L,301L,308L,320L,326L,345L,357L,361L,412L,425L,426L,427L,429L,455L,477L,490L,494L,526L,564L,591L,605L,610L,637L,638L,645L,664L,670L,672L,682L,684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140611Inst : IEnumerable<long>
{
public static readonly long[] Value=A140611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140611.Bytes);
public long this[int i]=>Value[i];

public static A140611Inst Instance=new A140611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140612
{
public static readonly long[] Value={ 1L,4L,8L,9L,16L,17L,25L,36L,40L,49L,52L,64L,72L,73L,80L,81L,89L,97L,100L,116L,121L,136L,144L,145L,148L,169L,180L,193L,196L,225L,232L,233L,241L,244L,256L,260L,288L,289L,292L,305L,313L,324L,337L,360L,361L,369L,388L,400L,404L,409L,424L,441L,449L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140612Inst : IEnumerable<long>
{
public static readonly long[] Value=A140612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140612.Bytes);
public long this[int i]=>Value[i];

public static A140612Inst Instance=new A140612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140613
{
public static readonly long[] Value={ 7L,79L,127L,151L,271L,439L,607L,919L,967L,1063L,1231L,1327L,1399L,1447L,1471L,1663L,1759L,1999L,2239L,2287L,2383L,2503L,2551L,2647L,2719L,2767L,2791L,3079L,3319L,3343L,3511L,3559L,3583L,3607L,3823L,3847L,3967L,4111L,4231L,4567L,4639L,4663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140613Inst : IEnumerable<long>
{
public static readonly long[] Value=A140613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140613.Bytes);
public long this[int i]=>Value[i];

public static A140613Inst Instance=new A140613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140614
{
public static readonly long[] Value={ 23L,47L,71L,191L,311L,383L,599L,647L,719L,839L,863L,911L,983L,1103L,1367L,1439L,1511L,1607L,1871L,2039L,2399L,2423L,2447L,2663L,2687L,2711L,2927L,3023L,3191L,3359L,3623L,3719L,3767L,4007L,4079L,4271L,4679L,4799L,4871L,4943L,5039L,5087L,5303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140614Inst : IEnumerable<long>
{
public static readonly long[] Value=A140614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140614.Bytes);
public long this[int i]=>Value[i];

public static A140614Inst Instance=new A140614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140615
{
public static readonly long[] Value={ 13L,61L,109L,277L,349L,373L,541L,613L,733L,853L,877L,997L,1069L,1117L,1381L,1429L,1597L,1669L,1693L,1789L,1861L,1933L,2053L,2221L,2389L,2437L,2749L,2917L,3109L,3181L,3229L,3253L,3373L,3517L,3541L,3637L,3709L,4021L,4549L,4597L,4813L,4861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140615Inst : IEnumerable<long>
{
public static readonly long[] Value=A140615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140615.Bytes);
public long this[int i]=>Value[i];

public static A140615Inst Instance=new A140615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140648
{
public static readonly long[] Value={ 1L,2L,0L,4L,1L,0L,8L,2L,0L,1L,16L,4L,1L,0L,2L,32L,8L,2L,0L,1L,4L,64L,16L,4L,1L,0L,2L,8L,128L,32L,8L,2L,0L,1L,4L,16L,256L,64L,16L,4L,1L,0L,2L,8L,32L,512L,128L,32L,8L,2L,0L,1L,4L,16L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140648Inst : IEnumerable<long>
{
public static readonly long[] Value=A140648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140648.Bytes);
public long this[int i]=>Value[i];

public static A140648Inst Instance=new A140648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140649
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,4L,2L,1L,0L,8L,4L,2L,1L,0L,16L,8L,4L,2L,1L,0L,32L,16L,8L,4L,2L,1L,0L,64L,32L,16L,8L,4L,2L,1L,0L,128L,64L,32L,16L,8L,4L,2L,1L,0L,256L,128L,64L,32L,16L,8L,4L,2L,1L,0L,512L,256L,128L,64L,32L,16L,8L,4L,2L,1L,0L,1024L,512L,256L,128L,64L,32L,16L,8L,4L,2L,1L,0L,2048L,1024L,512L,256L,128L,64L,32L,16L,8L,4L,2L,1L,0L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140649Inst : IEnumerable<long>
{
public static readonly long[] Value=A140649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140649.Bytes);
public long this[int i]=>Value[i];

public static A140649Inst Instance=new A140649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140650
{
public static readonly BigInteger[] Value={ 0L,3L,48L,600L,32256L,1177344L,268369920L,36506664960L,35184338534400L,18577347909255168L,BigInteger.Parse("73786976226118729728"),BigInteger.Parse("153476910691030086451200"),BigInteger.Parse("2475880078570197599844827136"),BigInteger.Parse("20440865928680162788862343512064"),BigInteger.Parse("1329227995784915854457062986570792960") };
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
public class A140650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140650Inst Instance=new A140650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140651
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,36L,7L,32L,27L,100L,11L,144L,13L,196L,225L,128L,17L,324L,19L,400L,441L,484L,23L,576L,125L,676L,243L,784L,29L,900L,31L,512L,1089L,1156L,1225L,1296L,37L,1444L,1521L,1600L,41L,1764L,43L,1936L,2025L,2116L,47L,2304L,343L,2500L,2601L,2704L,53L,2916L,3025L,3136L,3249L,3364L,59L,3600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140651Inst : IEnumerable<long>
{
public static readonly long[] Value=A140651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140651.Bytes);
public long this[int i]=>Value[i];

public static A140651Inst Instance=new A140651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140652
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,13L,19L,24L,31L,38L,48L,55L,67L,78L,90L,102L,118L,131L,149L,164L,182L,201L,223L,240L,263L,286L,310L,333L,361L,384L,414L,441L,471L,502L,534L,562L,598L,633L,669L,702L,742L,777L,819L,858L,898L,941L,987L,1026L,1073L,1118L,1166L,1213L,1265L,1312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140652Inst : IEnumerable<long>
{
public static readonly long[] Value=A140652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140652.Bytes);
public long this[int i]=>Value[i];

public static A140652Inst Instance=new A140652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140653
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140653Inst : IEnumerable<long>
{
public static readonly long[] Value=A140653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140653.Bytes);
public long this[int i]=>Value[i];

public static A140653Inst Instance=new A140653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140654
{
public static readonly BigInteger[] Value={ 3L,201L,52690971L,BigInteger.Parse("949196149445558443966545"),BigInteger.Parse("5549006906251488336142058083587971135417862217678366680875041864474951923") };
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
public class A140654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140654Inst Instance=new A140654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140655
{
public static readonly long[] Value={ 53L,157L,263L,367L,577L,683L,787L,997L,1103L,1523L,1627L,1733L,2153L,2467L,2677L,2887L,3203L,3307L,3413L,3517L,3623L,3727L,3833L,4253L,4357L,4463L,4567L,4673L,4987L,5197L,5303L,5407L,5827L,6037L,6143L,6247L,6353L,6563L,6983L,7193L,7297L,7507L,7717L,7823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140655Inst : IEnumerable<long>
{
public static readonly long[] Value=A140655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140655.Bytes);
public long this[int i]=>Value[i];

public static A140655Inst Instance=new A140655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140656
{
public static readonly BigInteger[] Value={ 1L,3L,40322L,6402373705728003L,BigInteger.Parse("263130836933693530167218012160000004"),BigInteger.Parse("30414093201713378043612608166064768844377641568960512000000000005"),BigInteger.Parse("61234458376886086861524070385274672740778091784697328983823014963978384987221689274204160000000000000006") };
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
public class A140656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140656Inst Instance=new A140656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140657
{
public static readonly long[] Value={ 4L,-1L,7L,5L,19L,29L,67L,125L,259L,509L,1027L,2045L,4099L,8189L,16387L,32765L,65539L,131069L,262147L,524285L,1048579L,2097149L,4194307L,8388605L,16777219L,33554429L,67108867L,134217725L,268435459L,536870909L,1073741827L,2147483645L,4294967299L,8589934589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140657Inst : IEnumerable<long>
{
public static readonly long[] Value=A140657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140657.Bytes);
public long this[int i]=>Value[i];

public static A140657Inst Instance=new A140657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140658
{
public static readonly long[] Value={ 5173601L,13694761L,16070429L,27509653L,54029741L,66096253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140658Inst : IEnumerable<long>
{
public static readonly long[] Value=A140658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140658.Bytes);
public long this[int i]=>Value[i];

public static A140658Inst Instance=new A140658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140659
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,12L,25L,50L,102L,204L,409L,818L,1638L,3276L,6553L,13106L,26214L,52428L,104857L,209714L,419430L,838860L,1677721L,3355442L,6710886L,13421772L,26843545L,53687090L,107374182L,214748364L,429496729L,858993458L,1717986918L,3435973836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140659Inst : IEnumerable<long>
{
public static readonly long[] Value=A140659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140659.Bytes);
public long this[int i]=>Value[i];

public static A140659Inst Instance=new A140659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140660
{
public static readonly long[] Value={ 4L,13L,49L,193L,769L,3073L,12289L,49153L,196609L,786433L,3145729L,12582913L,50331649L,201326593L,805306369L,3221225473L,12884901889L,51539607553L,206158430209L,824633720833L,3298534883329L,13194139533313L,52776558133249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140660Inst : IEnumerable<long>
{
public static readonly long[] Value=A140660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140660.Bytes);
public long this[int i]=>Value[i];

public static A140660Inst Instance=new A140660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140661
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,11L,13L,14L,15L,17L,18L,19L,20L,24L,25L,28L,29L,31L,32L,33L,34L,38L,40L,41L,44L,46L,47L,48L,49L,54L,55L,56L,57L,62L,63L,64L,65L,68L,69L,70L,71L,73L,75L,76L,77L,83L,85L,89L,90L,92L,93L,100L,101L,104L,105L,106L,107L,109L,110L,111L,113L,119L,120L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140661Inst : IEnumerable<long>
{
public static readonly long[] Value=A140661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140661.Bytes);
public long this[int i]=>Value[i];

public static A140661Inst Instance=new A140661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140662
{
public static readonly long[] Value={ 1L,3L,8L,20L,50L,126L,322L,834L,2187L,5797L,15510L,41834L,113633L,310571L,853466L,2356778L,6536381L,18199283L,50852018L,142547558L,400763222L,1129760414L,3192727796L,9043402500L,25669818475L,73007772801L,208023278208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140662Inst : IEnumerable<long>
{
public static readonly long[] Value=A140662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140662.Bytes);
public long this[int i]=>Value[i];

public static A140662Inst Instance=new A140662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140663
{
public static readonly long[] Value={ 2L,0L,7L,1L,9L,6L,9L,2L,2L,9L,0L,8L,2L,3L,1L,2L,9L,1L,5L,2L,3L,4L,1L,9L,0L,5L,5L,6L,3L,6L,3L,2L,9L,5L,7L,7L,7L,8L,5L,3L,5L,3L,3L,8L,0L,7L,5L,9L,5L,4L,1L,1L,6L,2L,2L,7L,1L,7L,4L,9L,0L,8L,1L,8L,3L,9L,4L,6L,6L,6L,1L,0L,9L,8L,5L,2L,7L,7L,3L,4L,0L,0L,6L,9L,0L,0L,6L,6L,5L,7L,7L,5L,4L,6L,3L,0L,9L,8L,5L,3L,8L,5L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140663Inst : IEnumerable<long>
{
public static readonly long[] Value=A140663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140663.Bytes);
public long this[int i]=>Value[i];

public static A140663Inst Instance=new A140663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140696
{
public static readonly long[] Value={ 4L,4L,4L,6L,4L,4L,6L,8L,6L,4L,4L,8L,6L,6L,4L,10L,6L,6L,8L,4L,4L,6L,8L,6L,8L,4L,6L,6L,8L,4L,4L,12L,6L,4L,6L,6L,8L,4L,8L,10L,8L,6L,6L,4L,16L,4L,6L,12L,8L,4L,8L,12L,4L,15L,4L,6L,6L,12L,6L,8L,4L,12L,10L,6L,4L,16L,8L,6L,6L,8L,10L,4L,8L,8L,6L,8L,14L,4L,12L,12L,4L,4L,6L,10L,16L,6L,4L,16L,4L,12L,8L,12L,4L,8L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140696Inst : IEnumerable<long>
{
public static readonly long[] Value=A140696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140696.Bytes);
public long this[int i]=>Value[i];

public static A140696Inst Instance=new A140696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140697
{
public static readonly long[] Value={ 1L,5L,11L,18L,29L,55L,55L,72L,96L,145L,131L,198L,181L,275L,319L,288L,305L,480L,379L,522L,605L,655L,551L,792L,720L,905L,864L,990L,869L,1595L,991L,1152L,1441L,1525L,1595L,1728L,1405L,1895L,1991L,2088L,1721L,3025L,1891L,2358L,2784L,2755L,2255L,3168L,2688L,3600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140697Inst : IEnumerable<long>
{
public static readonly long[] Value=A140697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140697.Bytes);
public long this[int i]=>Value[i];

public static A140697Inst Instance=new A140697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140698
{
public static readonly long[] Value={ 1L,0L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,0L,-1L,1L,-1L,-2L,0L,0L,-1L,1L,1L,1L,1L,0L,0L,-1L,1L,-1L,1L,1L,0L,0L,0L,-1L,1L,1L,-2L,-2L,0L,0L,0L,0L,-1L,1L,-1L,1L,0L,1L,0L,0L,0L,0L,-1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140698Inst : IEnumerable<long>
{
public static readonly long[] Value=A140698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140698.Bytes);
public long this[int i]=>Value[i];

public static A140698Inst Instance=new A140698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140699
{
public static readonly long[] Value={ 1L,2L,-1L,3L,0L,-1L,2L,-2L,0L,0L,5L,0L,0L,0L,-1L,1L,-3L,-2L,0L,0L,1L,7L,0L,0L,0L,0L,0L,-1L,2L,-2L,0L,0L,0L,0L,0L,0L,3L,0L,-3L,0L,0L,0L,0L,0L,0L,1L,-5L,0L,0L,-2L,0L,0L,0L,0L,1L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,-2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,-7L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,0L,0L,1L,1L,0L,-5L,0L,-3L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140699Inst : IEnumerable<long>
{
public static readonly long[] Value=A140699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140699.Bytes);
public long this[int i]=>Value[i];

public static A140699Inst Instance=new A140699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140700
{
public static readonly long[] Value={ 1L,-2L,-3L,0L,-5L,6L,-7L,0L,0L,10L,-11L,0L,-13L,14L,15L,0L,-17L,0L,-19L,0L,21L,22L,-23L,0L,0L,26L,0L,0L,-29L,30L,-31L,0L,33L,34L,35L,0L,-37L,38L,39L,0L,-41L,42L,-43L,0L,0L,46L,-47L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140700Inst : IEnumerable<long>
{
public static readonly long[] Value=A140700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140700.Bytes);
public long this[int i]=>Value[i];

public static A140700Inst Instance=new A140700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140701
{
public static readonly BigInteger[] Value={ 1L,4L,40L,760L,23560L,1083760L,69360640L,5895654400L,642626329600L,87397180825600L,14507932017049600L,2887078471392870400L,BigInteger.Parse("678463440777324544000"),BigInteger.Parse("185898982772986925056000") };
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
public class A140701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140701Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140701.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140701.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140701Inst Instance=new A140701Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140702
{
public static readonly BigInteger[] Value={ 40L,1625L,151776L,27316471L,8429601664L,4108830350625L,2977546171600000L,3062351613203813051L,BigInteger.Parse("4308809606735976861696"),BigInteger.Parse("8050856986181775515023417"),BigInteger.Parse("19490752185922086291273856000"),BigInteger.Parse("59888297825402713913058605859375"),BigInteger.Parse("229474927848540723655596345639141376") };
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
public class A140702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140702.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140702Inst Instance=new A140702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140703
{
public static readonly long[] Value={ 1L,4L,1L,7L,1L,1L,13L,4L,1L,1L,16L,4L,1L,1L,1L,25L,7L,4L,1L,1L,1L,28L,7L,4L,1L,1L,1L,1L,38L,13L,4L,4L,1L,1L,1L,1L,44L,13L,7L,4L,1L,1L,1L,1L,1L,53L,16L,7L,4L,4L,1L,1L,1L,1L,1L,56L,16L,7L,4L,4L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140703Inst : IEnumerable<long>
{
public static readonly long[] Value=A140703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140703.Bytes);
public long this[int i]=>Value[i];

public static A140703Inst Instance=new A140703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140704
{
public static readonly long[] Value={ 1L,4L,1L,4L,1L,1L,10L,4L,1L,1L,4L,1L,1L,1L,1L,16L,7L,4L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,20L,10L,4L,4L,1L,1L,1L,1L,10L,4L,4L,1L,1L,1L,1L,1L,1L,16L,7L,4L,4L,4L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,40L,22L,13L,7L,4L,4L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140704Inst : IEnumerable<long>
{
public static readonly long[] Value=A140704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140704.Bytes);
public long this[int i]=>Value[i];

public static A140704Inst Instance=new A140704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140705
{
public static readonly long[] Value={ 1L,5L,1L,9L,1L,1L,19L,5L,1L,1L,23L,5L,1L,1L,1L,39L,9L,5L,1L,1L,1L,43L,9L,5L,1L,1L,1L,1L,63L,19L,5L,5L,1L,1L,1L,1L,73L,19L,9L,5L,1L,1L,1L,1L,1L,89L,23L,9L,5L,5L,1L,1L,1L,1L,1L,93L,23L,9L,5L,51L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140705Inst : IEnumerable<long>
{
public static readonly long[] Value=A140705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140705.Bytes);
public long this[int i]=>Value[i];

public static A140705Inst Instance=new A140705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140706
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,0L,7L,4L,5L,2L,11L,5L,13L,4L,6L,8L,17L,7L,19L,9L,10L,8L,23L,8L,19L,10L,18L,13L,29L,11L,31L,16L,18L,14L,22L,12L,37L,16L,22L,16L,41L,15L,43L,21L,25L,20L,47L,16L,41L,21L,30L,25L,53L,18L,38L,24L,34L,26L,59L,15L,61L,28L,37L,32L,46L,23L,67L,33L,42L,27L,71L,24L,73L,34L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140706Inst : IEnumerable<long>
{
public static readonly long[] Value=A140706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140706.Bytes);
public long this[int i]=>Value[i];

public static A140706Inst Instance=new A140706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140707
{
public static readonly long[] Value={ 1L,2L,5L,10L,11L,12L,13L,21L,22L,23L,26L,27L,28L,29L,39L,42L,45L,46L,47L,51L,54L,57L,58L,59L,61L,78L,87L,90L,91L,93L,94L,102L,105L,114L,115L,117L,118L,120L,122L,124L,125L,159L,174L,175L,182L,183L,186L,187L,189L,191L,207L,210L,215L,219L,220L,221L,223L,230L,234L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140707Inst : IEnumerable<long>
{
public static readonly long[] Value=A140707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140707.Bytes);
public long this[int i]=>Value[i];

public static A140707Inst Instance=new A140707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140708
{
public static readonly long[] Value={ 14083L,14087L,6047L,13159L,12923L,43427L,5297L,12959L,11813L,11827L,4597L,10979L,10753L,39367L,3947L,10799L,9743L,9767L,3347L,8999L,8783L,35507L,2797L,8839L,7873L,7907L,2297L,7219L,7013L,31847L,1847L,7079L,6203L,6247L,1447L,5639L,5443L,28387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140708Inst : IEnumerable<long>
{
public static readonly long[] Value=A140708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140708.Bytes);
public long this[int i]=>Value[i];

public static A140708Inst Instance=new A140708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140709
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,15L,5L,3L,1L,87L,20L,8L,4L,1L,567L,107L,28L,12L,5L,1L,4167L,674L,135L,40L,17L,6L,1L,34407L,4841L,809L,175L,57L,23L,7L,1L,316647L,39248L,5650L,984L,232L,80L,30L,8L,1L,3219687L,355895L,44898L,6634L,1216L,312L,110L,38L,9L,1L,35878887L,3575582L,400793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140709Inst : IEnumerable<long>
{
public static readonly long[] Value=A140709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140709.Bytes);
public long this[int i]=>Value[i];

public static A140709Inst Instance=new A140709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140710
{
public static readonly long[] Value={ 1L,3L,10L,38L,172L,944L,6208L,47696L,417952L,4101824L,44491648L,528068096L,6804155392L,94559581184L,1409615239168L,22434345998336L,379633330204672L,6805952938041344L,128854632579186688L,2568966172926181376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140710Inst : IEnumerable<long>
{
public static readonly long[] Value=A140710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140710.Bytes);
public long this[int i]=>Value[i];

public static A140710Inst Instance=new A140710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140711
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,10L,12L,1L,1L,20L,62L,36L,1L,1L,35L,217L,339L,126L,2L,1L,56L,602L,1880L,1907L,572L,22L,1L,84L,1428L,7656L,15311L,12004L,3514L,312L,10L,1L,120L,3024L,25332L,85543L,127804L,88034L,28296L,4342L,368L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140711Inst : IEnumerable<long>
{
public static readonly long[] Value=A140711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140711.Bytes);
public long this[int i]=>Value[i];

public static A140711Inst Instance=new A140711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140760
{
public static readonly long[] Value={ 2L,6L,12L,14L,24L,26L,30L,28L,48L,50L,54L,62L,52L,58L,96L,56L,60L,98L,102L,110L,126L,100L,106L,118L,192L,104L,108L,194L,114L,122L,198L,206L,222L,254L,112L,124L,116L,196L,202L,214L,238L,384L,120L,200L,204L,386L,210L,218L,390L,230L,246L,398L,414L,446L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140760Inst : IEnumerable<long>
{
public static readonly long[] Value=A140760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140760.Bytes);
public long this[int i]=>Value[i];

public static A140760Inst Instance=new A140760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140761
{
public static readonly long[] Value={ 5L,19L,41L,83L,163L,167L,179L,191L,223L,229L,241L,263L,269L,271L,317L,337L,349L,367L,389L,433L,463L,491L,521L,701L,719L,757L,809L,823L,829L,859L,877L,883L,919L,941L,971L,991L,997L,1021L,1033L,1049L,1091L,1153L,1181L,1193L,1223L,1291L,1301L,1319L,1327L,1361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140761Inst : IEnumerable<long>
{
public static readonly long[] Value=A140761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140761.Bytes);
public long this[int i]=>Value[i];

public static A140761Inst Instance=new A140761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140762
{
public static readonly BigInteger[] Value={ 30L,9699690L,304250263527210L,BigInteger.Parse("267064515689275851355624017992790"),BigInteger.Parse("5766152219975951659023630035336134306565384015606066319856068810"),BigInteger.Parse("962947420735983927056946215901134429196419130606213075415963491270") };
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
public class A140762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140762Inst Instance=new A140762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140763
{
public static readonly long[] Value={ 2L,10L,77L,238L,874L,2747L,2914L,3266L,3638L,4661L,5117L,5830L,6601L,6870L,7141L,9523L,10191L,10887L,11966L,13490L,16401L,19113L,21037L,23069L,40313L,41741L,46191L,50887L,53342L,54998L,58406L,60146L,61910L,65534L,68341L,72179L,75130L,76127L,80189L,82253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140763Inst : IEnumerable<long>
{
public static readonly long[] Value=A140763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140763.Bytes);
public long this[int i]=>Value[i];

public static A140763Inst Instance=new A140763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140764
{
public static readonly long[] Value={ 1L,37L,613L,519018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140764Inst : IEnumerable<long>
{
public static readonly long[] Value=A140764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140764.Bytes);
public long this[int i]=>Value[i];

public static A140764Inst Instance=new A140764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140765
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,4L,3L,7L,10L,10L,4L,10L,16L,20L,20L,5L,13L,22L,30L,35L,35L,6L,16L,28L,40L,50L,56L,56L,7L,19L,34L,50L,65L,77L,84L,84L,8L,22L,40L,60L,80L,98L,112L,120L,120L,9L,25L,46L,70L,95L,119L,140L,156L,165L,165L,10L,28L,52L,80L,110L,140L,168L,192L,210L,220L,220L,11L,31L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140765Inst : IEnumerable<long>
{
public static readonly long[] Value=A140765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140765.Bytes);
public long this[int i]=>Value[i];

public static A140765Inst Instance=new A140765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140766
{
public static readonly long[] Value={ 1L,5L,24L,114L,540L,2556L,12096L,57240L,270864L,1281744L,6065280L,28701216L,135815616L,642686400L,3041224704L,14391229824L,68100030720L,322252805376L,1524916647936L,7215983055360L,34146398444544L,161582492335104L,764616563343360L,3618204426049536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140766Inst : IEnumerable<long>
{
public static readonly long[] Value=A140766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140766.Bytes);
public long this[int i]=>Value[i];

public static A140766Inst Instance=new A140766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140767
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,5L,2L,2L,1L,4L,9L,7L,9L,2L,2L,1L,5L,14L,16L,25L,11L,13L,2L,2L,1L,6L,20L,30L,55L,36L,49L,15L,17L,2L,2L,1L,7L,27L,50L,105L,91L,140L,64L,81L,19L,21L,2L,2L,1L,8L,35L,77L,182L,196L,336L,204L,285L,100L,121L,23L,25L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140767Inst : IEnumerable<long>
{
public static readonly long[] Value=A140767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140767.Bytes);
public long this[int i]=>Value[i];

public static A140767Inst Instance=new A140767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140768
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140768Inst : IEnumerable<long>
{
public static readonly long[] Value=A140768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140768.Bytes);
public long this[int i]=>Value[i];

public static A140768Inst Instance=new A140768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140769
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,9L,10L,11L,14L,15L,16L,17L,23L,26L,27L,28L,29L,32L,33L,34L,35L,38L,39L,44L,45L,46L,47L,50L,51L,52L,53L,56L,57L,58L,59L,62L,65L,68L,69L,70L,71L,74L,75L,76L,77L,82L,83L,86L,87L,88L,89L,92L,93L,94L,95L,98L,99L,104L,107L,112L,113L,116L,117L,118L,119L,122L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140769Inst : IEnumerable<long>
{
public static readonly long[] Value=A140769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140769.Bytes);
public long this[int i]=>Value[i];

public static A140769Inst Instance=new A140769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140770
{
public static readonly BigInteger[] Value={ 1L,16L,289L,4624L,67081L,902500L,11471769L,139570596L,1640493009L,18754206916L,209576262025L,2298031637476L,24798178969729L,263962539461776L,2776718023652329L,28909790108979264L,298278580556192769L,3052900712959977636L,BigInteger.Parse("31023767417676585561"),BigInteger.Parse("313247762072931012804") };
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
public class A140770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140770Inst Instance=new A140770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140771
{
public static readonly long[] Value={ 83L,127L,293L,337L,503L,547L,757L,967L,1553L,1597L,1973L,2017L,2393L,2437L,2647L,2857L,3023L,3067L,3697L,3863L,3907L,4073L,4283L,4327L,4493L,4703L,4957L,5167L,5333L,6007L,6173L,6217L,6427L,6637L,6803L,7013L,7057L,7433L,7477L,7643L,7687L,7853L,8273L,8317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140771Inst : IEnumerable<long>
{
public static readonly long[] Value=A140771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140771.Bytes);
public long this[int i]=>Value[i];

public static A140771Inst Instance=new A140771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140772
{
public static readonly long[] Value={ 89L,331L,509L,541L,719L,751L,929L,1171L,1381L,1559L,1801L,1979L,2011L,2221L,2399L,2609L,2819L,2851L,3061L,3271L,3449L,3659L,3691L,4079L,4111L,4289L,4919L,4951L,5581L,5791L,6211L,6389L,6421L,6599L,6841L,7019L,7229L,7649L,7681L,8069L,8101L,8311L,8521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140772Inst : IEnumerable<long>
{
public static readonly long[] Value=A140772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140772.Bytes);
public long this[int i]=>Value[i];

public static A140772Inst Instance=new A140772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140773
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,5L,2L,6L,4L,5L,2L,10L,2L,5L,5L,9L,2L,10L,2L,10L,5L,5L,2L,16L,4L,5L,6L,10L,2L,14L,2L,12L,5L,5L,5L,20L,2L,5L,5L,16L,2L,14L,2L,10L,10L,5L,2L,24L,4L,10L,5L,10L,2L,16L,5L,16L,5L,5L,2L,28L,2L,5L,10L,16L,5L,14L,2L,10L,5L,14L,2L,32L,2L,5L,10L,10L,5L,14L,2L,24L,9L,5L,2L,28L,5L,5L,5L,16L,2L,28L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140773Inst : IEnumerable<long>
{
public static readonly long[] Value=A140773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140773.Bytes);
public long this[int i]=>Value[i];

public static A140773Inst Instance=new A140773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140774
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,4L,1L,2L,2L,2L,1L,4L,1L,3L,2L,2L,2L,3L,1L,2L,2L,4L,1L,3L,1L,2L,3L,2L,1L,5L,1L,3L,2L,2L,1L,4L,2L,4L,2L,2L,1L,6L,1L,2L,3L,3L,2L,3L,1L,2L,2L,4L,1L,5L,1L,2L,3L,2L,2L,3L,1L,5L,2L,2L,1L,5L,2L,2L,2L,3L,1L,5L,2L,2L,2L,2L,2L,6L,1L,3L,2L,3L,1L,3L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140774Inst : IEnumerable<long>
{
public static readonly long[] Value=A140774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140774.Bytes);
public long this[int i]=>Value[i];

public static A140774Inst Instance=new A140774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140775
{
public static readonly long[] Value={ 2L,6L,10L,22L,30L,34L,42L,58L,70L,78L,82L,102L,118L,130L,142L,190L,202L,210L,214L,274L,298L,310L,322L,330L,358L,382L,394L,442L,454L,462L,478L,510L,538L,562L,582L,610L,622L,658L,694L,714L,730L,742L,790L,838L,862L,922L,930L,970L,1002L,1038L,1042L,1110L,1138L,1198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140775Inst : IEnumerable<long>
{
public static readonly long[] Value=A140775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140775.Bytes);
public long this[int i]=>Value[i];

public static A140775Inst Instance=new A140775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140824
{
public static readonly long[] Value={ 0L,1L,3L,6L,15L,41L,108L,281L,735L,1926L,5043L,13201L,34560L,90481L,236883L,620166L,1623615L,4250681L,11128428L,29134601L,76275375L,199691526L,522799203L,1368706081L,3583319040L,9381251041L,24560434083L,64300051206L,168339719535L,440719107401L,1153817602668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140824Inst : IEnumerable<long>
{
public static readonly long[] Value=A140824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140824.Bytes);
public long this[int i]=>Value[i];

public static A140824Inst Instance=new A140824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140825
{
public static readonly long[] Value={ 1L,1L,3L,-1L,5L,23L,1L,-1L,9L,55L,-19L,11L,-19L,251L,1901L,27L,-11L,11L,-27L,475L,4277L,-863L,271L,-191L,271L,-863L,19087L,198721L,1375L,-351L,191L,-191L,351L,-1375L,36799L,434241L,-33953L,7297L,-3233L,2497L,-3233L,7297L,-33953L,1070017L,14097247L,57281L,-10625L,3969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140825Inst : IEnumerable<long>
{
public static readonly long[] Value=A140825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140825.Bytes);
public long this[int i]=>Value[i];

public static A140825Inst Instance=new A140825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140826
{
public static readonly long[] Value={ 3L,4L,5L,7L,11L,13L,17L,18L,19L,20L,23L,24L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140826Inst : IEnumerable<long>
{
public static readonly long[] Value=A140826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140826.Bytes);
public long this[int i]=>Value[i];

public static A140826Inst Instance=new A140826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140827
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,11L,15L,26L,41L,56L,97L,153L,209L,362L,571L,780L,1351L,2131L,2911L,5042L,7953L,10864L,18817L,29681L,40545L,70226L,110771L,151316L,262087L,413403L,564719L,978122L,1542841L,2107560L,3650401L,5757961L,7865521L,13623482L,21489003L,29354524L,50843527L,80198051L,109552575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140827Inst : IEnumerable<long>
{
public static readonly long[] Value=A140827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140827.Bytes);
public long this[int i]=>Value[i];

public static A140827Inst Instance=new A140827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140828
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,5L,4L,6L,5L,7L,6L,7L,7L,7L,8L,8L,8L,9L,8L,10L,8L,11L,9L,11L,10L,11L,10L,11L,11L,12L,11L,13L,11L,14L,11L,15L,11L,16L,11L,17L,11L,18L,11L,18L,12L,18L,13L,18L,13L,18L,14L,18L,14L,19L,14L,20L,14L,20L,15L,19L,16L,20L,16L,20L,16L,21L,17L,21L,17L,21L,18L,21L,18L,22L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140828Inst : IEnumerable<long>
{
public static readonly long[] Value=A140828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140828.Bytes);
public long this[int i]=>Value[i];

public static A140828Inst Instance=new A140828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140829
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,5L,5L,7L,8L,12L,12L,20L,19L,33L,30L,54L,48L,88L,77L,143L,124L,232L,200L,376L,323L,609L,522L,986L,844L,1596L,1365L,2583L,2208L,4180L,3572L,6764L,5779L,10945L,9350L,17710L,15128L,28656L,24477L,46367L,39604L,75024L,64080L,121392L,103683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140829Inst : IEnumerable<long>
{
public static readonly long[] Value=A140829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140829.Bytes);
public long this[int i]=>Value[i];

public static A140829Inst Instance=new A140829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140830
{
public static readonly long[] Value={ 97L,113L,307L,727L,743L,937L,953L,1163L,1373L,1567L,1583L,1777L,1987L,2003L,2213L,2423L,2617L,2633L,2843L,3037L,3457L,3877L,4297L,4507L,4523L,4733L,4943L,5153L,5347L,5557L,5573L,5783L,6203L,6397L,6607L,6833L,7027L,7043L,7237L,7253L,7673L,7867L,7883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140830Inst : IEnumerable<long>
{
public static readonly long[] Value=A140830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140830.Bytes);
public long this[int i]=>Value[i];

public static A140830Inst Instance=new A140830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140831
{
public static readonly long[] Value={ 12L,24L,40L,45L,48L,56L,60L,63L,80L,84L,90L,96L,112L,120L,126L,132L,135L,144L,156L,160L,168L,175L,176L,180L,189L,192L,204L,208L,224L,228L,240L,252L,264L,270L,275L,276L,280L,288L,297L,300L,312L,315L,320L,325L,336L,348L,350L,351L,352L,360L,372L,378L,384L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140831Inst : IEnumerable<long>
{
public static readonly long[] Value=A140831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140831.Bytes);
public long this[int i]=>Value[i];

public static A140831Inst Instance=new A140831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140832
{
public static readonly long[] Value={ 1L,2L,5L,12L,30L,75L,188L,470L,1175L,2938L,7345L,18362L,45905L,114762L,286905L,717262L,1793155L,4482888L,11207220L,28018050L,70045125L,175112812L,437782030L,1094455075L,2736137688L,6840344220L,17100860550L,42752151375L,106880378438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140832Inst : IEnumerable<long>
{
public static readonly long[] Value=A140832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140832.Bytes);
public long this[int i]=>Value[i];

public static A140832Inst Instance=new A140832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140833
{
public static readonly long[] Value={ 0L,2L,2L,6L,6L,16L,16L,42L,42L,110L,110L,288L,288L,754L,754L,1974L,1974L,5168L,5168L,13530L,13530L,35422L,35422L,92736L,92736L,242786L,242786L,635622L,635622L,1664080L,1664080L,4356618L,4356618L,11405774L,11405774L,29860704L,29860704L,78176338L,78176338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140833Inst : IEnumerable<long>
{
public static readonly long[] Value=A140833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140833.Bytes);
public long this[int i]=>Value[i];

public static A140833Inst Instance=new A140833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140834
{
public static readonly long[] Value={ 2L,3L,17L,19L,83L,97L,113L,163L,179L,257L,337L,419L,499L,593L,641L,643L,673L,769L,787L,881L,883L,1153L,1297L,1409L,1459L,1553L,1889L,2003L,2083L,2131L,2417L,2579L,2593L,2609L,2657L,2659L,2689L,2819L,3169L,3217L,3697L,3779L,3889L,3907L,4099L,4129L,4177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140834Inst : IEnumerable<long>
{
public static readonly long[] Value=A140834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140834.Bytes);
public long this[int i]=>Value[i];

public static A140834Inst Instance=new A140834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140835
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,6L,6L,2L,3L,12L,18L,12L,3L,5L,25L,25L,25L,25L,5L,8L,48L,120L,160L,120L,48L,8L,13L,91L,91L,91L,91L,91L,91L,13L,21L,168L,588L,168L,1470L,168L,588L,168L,21L,34L,306L,306L,2856L,306L,306L,2856L,306L,306L,34L,55L,550L,2475L,550L,2475L,13860L,2475L,550L,2475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140835Inst : IEnumerable<long>
{
public static readonly long[] Value=A140835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140835.Bytes);
public long this[int i]=>Value[i];

public static A140835Inst Instance=new A140835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140836
{
public static readonly long[] Value={ 1L,2L,4L,15L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140836Inst : IEnumerable<long>
{
public static readonly long[] Value=A140836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140836.Bytes);
public long this[int i]=>Value[i];

public static A140836Inst Instance=new A140836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140837
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140837Inst : IEnumerable<long>
{
public static readonly long[] Value=A140837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140837.Bytes);
public long this[int i]=>Value[i];

public static A140837Inst Instance=new A140837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140838
{
public static readonly long[] Value={ 1L,2L,4L,11L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140838Inst : IEnumerable<long>
{
public static readonly long[] Value=A140838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140838.Bytes);
public long this[int i]=>Value[i];

public static A140838Inst Instance=new A140838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140839
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140839Inst : IEnumerable<long>
{
public static readonly long[] Value=A140839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140839.Bytes);
public long this[int i]=>Value[i];

public static A140839Inst Instance=new A140839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140872
{
public static readonly long[] Value={ 22L,12L,18L,87L,21L,84L,32L,2L,92L,16L,7L,24L,4L,27L,82L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140872Inst : IEnumerable<long>
{
public static readonly long[] Value=A140872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140872.Bytes);
public long this[int i]=>Value[i];

public static A140872Inst Instance=new A140872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140873
{
public static readonly long[] Value={ -60L,-240L,-280L,840L,-1440L,-1200L,3360L,5040L,-6720L,-4704L,-15120L,26880L,26880L,-26880L,-17024L,-60480L,-110880L,161280L,129024L,-96768L,-57600L,332640L,-604800L,-705600L,806400L,564480L,-322560L,-184320L,1330560L,2882880L,-4435200L,-3991680L,3548160L,2280960L,-1013760L,-563200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140873Inst : IEnumerable<long>
{
public static readonly long[] Value=A140873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140873.Bytes);
public long this[int i]=>Value[i];

public static A140873Inst Instance=new A140873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140874
{
public static readonly long[] Value={ -4L,-4L,-8L,-3L,-12L,-13L,-1L,-15L,-25L,-19L,2L,-16L,-40L,-44L,-26L,6L,-14L,-56L,-84L,-70L,-34L,11L,-8L,-70L,-140L,-154L,-104L,-43L,17L,3L,-78L,-210L,-294L,-258L,-147L,-53L,24L,20L,-75L,-288L,-504L,-552L,-405L,-200L,-64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140874Inst : IEnumerable<long>
{
public static readonly long[] Value=A140874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140874.Bytes);
public long this[int i]=>Value[i];

public static A140874Inst Instance=new A140874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140875
{
public static readonly long[] Value={ -2L,-4L,0L,-4L,-4L,0L,-6L,-2L,-2L,2L,-6L,-2L,-6L,-6L,2L,-8L,-2L,-2L,-2L,-2L,4L,-8L,-4L,0L,-8L,-4L,-4L,4L,-10L,0L,-6L,-4L,0L,-6L,-4L,6L,-10L,-4L,-2L,0L,-10L,-8L,-2L,-4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140875Inst : IEnumerable<long>
{
public static readonly long[] Value=A140875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140875.Bytes);
public long this[int i]=>Value[i];

public static A140875Inst Instance=new A140875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140876
{
public static readonly long[] Value={ 2L,0L,6L,-2L,2L,16L,0L,-10L,10L,40L,2L,-2L,-36L,36L,96L,0L,14L,-14L,-112L,112L,224L,-2L,2L,64L,-64L,-320L,320L,512L,0L,-18L,18L,240L,-240L,-864L,864L,1152L,2L,-2L,-100L,100L,800L,-800L,-2240L,2240L,2560L,0L,22L,-22L,-440L,440L,2464L,-2464L,-5632L,5632L,5632L,-2L,2L,144L,-144L,-1680L,1680L,7168L,-7168L,-13824L,13824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140876Inst : IEnumerable<long>
{
public static readonly long[] Value=A140876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140876.Bytes);
public long this[int i]=>Value[i];

public static A140876Inst Instance=new A140876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140877
{
public static readonly long[] Value={ 4L,-7L,6L,-8L,-17L,4L,17L,-22L,-44L,-16L,12L,51L,-48L,-120L,-96L,-31L,46L,146L,-80L,-336L,-352L,-16L,-113L,140L,412L,-64L,-944L,-1088L,49L,-78L,-372L,360L,1160L,224L,-2624L,-3072L,20L,211L,-296L,-1156L,784L,3264L,1536L,-7168L,-8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140877Inst : IEnumerable<long>
{
public static readonly long[] Value=A140877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140877.Bytes);
public long this[int i]=>Value[i];

public static A140877Inst Instance=new A140877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140878
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,1L,5L,11L,19L,10L,2L,1L,9L,37L,85L,158L,103L,35L,5L,1L,14L,87L,332L,782L,1521L,1126L,499L,126L,14L,1L,20L,172L,911L,3343L,8004L,16056L,12941L,6765L,2296L,462L,42L,1L,27L,305L,2096L,10147L,36350L,88044L,180621L,154750L,90781L,37178L,10254L,1716L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140878Inst : IEnumerable<long>
{
public static readonly long[] Value=A140878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140878.Bytes);
public long this[int i]=>Value[i];

public static A140878Inst Instance=new A140878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140879
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,5L,1L,20L,1L,139L,1L,1777L,1L,42295L,1L,1888140L,1L,158903233L,1L,25355226287L,1L,7707419775769L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140879Inst : IEnumerable<long>
{
public static readonly long[] Value=A140879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140879.Bytes);
public long this[int i]=>Value[i];

public static A140879Inst Instance=new A140879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140880
{
public static readonly long[] Value={ 2L,6L,6L,12L,24L,12L,20L,60L,60L,20L,30L,120L,180L,120L,30L,42L,210L,420L,420L,210L,42L,56L,336L,840L,1120L,840L,336L,56L,72L,504L,1512L,2520L,2520L,1512L,504L,72L,90L,720L,2520L,5040L,6300L,5040L,2520L,720L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140880Inst : IEnumerable<long>
{
public static readonly long[] Value=A140880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140880.Bytes);
public long this[int i]=>Value[i];

public static A140880Inst Instance=new A140880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140881
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,10L,12L,16L,20L,25L,32L,41L,52L,65L,83L,104L,132L,166L,210L,265L,335L,422L,533L,673L,849L,1072L,1353L,1707L,2154L,2718L,3430L,4329L,5462L,6893L,8698L,10975L,13850L,17476L,22053L,27828L,35115L,44310L,55913L,70555L,89030L,112344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140881Inst : IEnumerable<long>
{
public static readonly long[] Value=A140881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140881.Bytes);
public long this[int i]=>Value[i];

public static A140881Inst Instance=new A140881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140882
{
public static readonly long[] Value={ 1L,2L,-1L,0L,-4L,1L,0L,-8L,6L,-1L,0L,-12L,19L,-8L,1L,0L,-16L,44L,-34L,10L,-1L,0L,-20L,85L,-104L,53L,-12L,1L,0L,-24L,146L,-259L,200L,-76L,14L,-1L,0L,-28L,231L,-560L,606L,-340L,103L,-16L,1L,0L,-32L,344L,-1092L,1572L,-1210L,532L,-134L,18L,-1L,0L,-36L,489L,-1968L,3630L,-3652L,2171L,-784L,169L,-20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140882Inst : IEnumerable<long>
{
public static readonly long[] Value=A140882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140882.Bytes);
public long this[int i]=>Value[i];

public static A140882Inst Instance=new A140882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140883
{
public static readonly long[] Value={ 2L,1L,1L,1L,0L,1L,4L,-3L,-3L,4L,9L,0L,-16L,0L,9L,16L,5L,-20L,-20L,5L,16L,31L,0L,-30L,0L,-30L,0L,31L,64L,-7L,-112L,56L,56L,-112L,-7L,64L,129L,0L,-288L,0L,320L,0L,-288L,0L,129L,256L,9L,-576L,-120L,432L,432L,-120L,-576L,9L,256L,511L,0L,-1230L,0L,720L,0L,720L,0L,-1230L,0L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140883Inst : IEnumerable<long>
{
public static readonly long[] Value=A140883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140883.Bytes);
public long this[int i]=>Value[i];

public static A140883Inst Instance=new A140883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140884
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,13L,43L,580L,1897L,23851L,149041L,14348161L,74552521L,7849966951L,311500453881L,64690704744716L,2466747100788601L,493809829542170401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140884Inst : IEnumerable<long>
{
public static readonly long[] Value=A140884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140884.Bytes);
public long this[int i]=>Value[i];

public static A140884Inst Instance=new A140884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140885
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,1L,2L,2L,1L,1L,0L,2L,0L,1L,1L,2L,2L,2L,2L,1L,1L,-1L,1L,0L,1L,-1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,0L,0L,0L,2L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L,2L,0L,0L,1L,1L,-1L,1L,-1L,1L,0L,1L,-1L,1L,-1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,0L,-1L,0L,1L,0L,0L,0L,1L,0L,-1L,0L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140885Inst : IEnumerable<long>
{
public static readonly long[] Value=A140885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140885.Bytes);
public long this[int i]=>Value[i];

public static A140885Inst Instance=new A140885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140886
{
public static readonly long[] Value={ 1L,1L,-1L,0L,-2L,1L,-1L,-1L,3L,-1L,-1L,1L,3L,-4L,1L,-2L,5L,-1L,-6L,5L,-1L,-1L,5L,-6L,-3L,10L,-6L,1L,-2L,11L,-21L,13L,8L,-15L,7L,-1L,-2L,13L,-33L,38L,-11L,-19L,21L,-8L,1L,-2L,16L,-52L,86L,-69L,7L,34L,-28L,9L,-1L,-1L,12L,-54L,124L,-155L,90L,13L,-56L,36L,-10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140886Inst : IEnumerable<long>
{
public static readonly long[] Value=A140886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140886.Bytes);
public long this[int i]=>Value[i];

public static A140886Inst Instance=new A140886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140887
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,3L,2L,3L,3L,4L,2L,3L,4L,2L,3L,3L,6L,3L,3L,3L,2L,4L,4L,4L,3L,5L,2L,4L,4L,4L,4L,4L,3L,3L,4L,2L,5L,5L,4L,3L,4L,4L,2L,6L,5L,5L,3L,4L,1L,6L,3L,4L,2L,5L,4L,4L,5L,4L,4L,5L,6L,1L,5L,5L,5L,3L,3L,5L,3L,5L,3L,6L,5L,4L,4L,3L,5L,4L,1L,5L,4L,5L,7L,3L,5L,5L,5L,4L,1L,3L,4L,5L,3L,5L,4L,4L,5L,4L,6L,4L,5L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140887Inst : IEnumerable<long>
{
public static readonly long[] Value=A140887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140887.Bytes);
public long this[int i]=>Value[i];

public static A140887Inst Instance=new A140887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140920
{
public static readonly BigInteger[] Value={ 1L,2002L,1002001L,208416208L,23029990984L,1566039386912L,72261531710368L,2424984388825856L,62305564808355232L,1274867710694037824L,BigInteger.Parse("21427584214357481888"),BigInteger.Parse("303282730418598205184"),BigInteger.Parse("3688967826726218553440"),BigInteger.Parse("39214657989988793866400"),BigInteger.Parse("369491052699789370779000") };
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
public class A140920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140920Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140920.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140920.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140920Inst Instance=new A140920Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140921
{
public static readonly BigInteger[] Value={ 1L,5005L,5725720L,2530768240L,559299781040L,72261531710368L,6062460972064640L,356031798904887040L,15480536486999030720UL,BigInteger.Parse("520384188062967417280") };
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
public class A140921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140921.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140921Inst Instance=new A140921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140922
{
public static readonly BigInteger[] Value={ 1L,11440L,27810640L,24584605760L,10323075958624L,2424984388825856L,356031798904887040L,BigInteger.Parse("35384083398854927360") };
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
public class A140922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140922.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140922Inst Instance=new A140922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140923
{
public static readonly ulong[] Value={ 1L,24310L,118195220L,198520691512L,151561524301616L,62305564808355232L,15480536486999030720UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140923Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A140923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140923.Bytes);
public ulong this[int i]=>Value[i];

public static A140923Inst Instance=new A140923Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140924
{
public static readonly BigInteger[] Value={ 1L,48620L,449141836L,1371597504992L,1832516612010448L,1274867710694037824L,BigInteger.Parse("520384188062967417280") };
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
public class A140924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140924Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140924.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140924.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140924Inst Instance=new A140924Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140925
{
public static readonly long[] Value={ 1L,66L,1716L,26026L,273273L,2186184L,14158144L,77364144L,367479684L,1551580888L,5924217936L,20734762776L,67255063876L,203982391536L,582806832960L,1578435172600L,4073755482225L,10064572367850L,23896002230100L,54709268263650L,121141951155225L,260114319363600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140925Inst : IEnumerable<long>
{
public static readonly long[] Value=A140925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140925.Bytes);
public long this[int i]=>Value[i];

public static A140925Inst Instance=new A140925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140926
{
public static readonly long[] Value={ 1L,286L,26026L,1184183L,33157124L,644195552L,9386849472L,108284013552L,1028698128744L,8291930371088L,58043512597616L,359423289546776L,1998551478139216L,10102567911472960L,46904779588981600L,201759529849663500L,810005171308207875L,3054446745056957250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140926Inst : IEnumerable<long>
{
public static readonly long[] Value=A140926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140926.Bytes);
public long this[int i]=>Value[i];

public static A140926Inst Instance=new A140926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140927
{
public static readonly BigInteger[] Value={ 1L,1001L,273273L,33157124L,2254684432L,98561919456L,3031952379456L,69951472754592L,1268665346776464L,18748054569029968L,232187445047217296L,2464759032039691296L,BigInteger.Parse("22841906047840362560"),BigInteger.Parse("187629942535831549600"),BigInteger.Parse("1383573735925984746000"),BigInteger.Parse("9257736027151809697500") };
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
public class A140927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140927Inst Instance=new A140927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140928
{
public static readonly BigInteger[] Value={ 1L,3003L,2186184L,644195552L,98561919456L,9095857138368L,559611782036736L,24648355308799872L,819557814017595744L,BigInteger.Parse("21427584214357481888"),BigInteger.Parse("454924095627897307776"),BigInteger.Parse("8048657076493567752960"),BigInteger.Parse("121208942878147181041600"),BigInteger.Parse("1581318351414483181236000") };
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
public class A140928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140928.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A140928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140928Inst Instance=new A140928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}