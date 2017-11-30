using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A007538
{
public static readonly long[] Value={ 2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007538Inst : IEnumerable<long>
{
public static readonly long[] Value=A007538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007538.Bytes);
public long this[int i]=>Value[i];

public static A007538Inst Instance=new A007538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007537
{
public static readonly BigInteger[] Value={ 0L,1L,45L,15913L,1073579193L,4611686005542975085L,BigInteger.Parse("85070591730234615801280047645054636261"),BigInteger.Parse("28948022309329048855892746252171976961956366698726387156269151989162886489297") };
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
public class A007537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A007537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A007537Inst Instance=new A007537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007536
{
public static readonly long[] Value={ 4L,5L,9L,10L,11L,14L,19L,20L,23L,24L,25L,26L,32L,33L,37L,38L,39L,41L,42L,48L,50L,53L,54L,55L,59L,63L,64L,65L,69L,70L,76L,77L,80L,83L,85L,86L,89L,99L,102L,104L,108L,110L,113L,114L,115L,116L,123L,124L,128L,129L,130L,131L,140L,143L,144L,145L,146L,152L,161L,162L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007536Inst : IEnumerable<long>
{
public static readonly long[] Value=A007536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007536.Bytes);
public long this[int i]=>Value[i];

public static A007536Inst Instance=new A007536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007535
{
public static readonly long[] Value={ 4L,341L,91L,15L,124L,35L,25L,9L,28L,33L,15L,65L,21L,15L,341L,51L,45L,25L,45L,21L,55L,69L,33L,25L,28L,27L,65L,45L,35L,49L,49L,33L,85L,35L,51L,91L,45L,39L,95L,91L,105L,205L,77L,45L,76L,133L,65L,49L,66L,51L,65L,85L,65L,55L,63L,57L,65L,133L,87L,341L,91L,63L,341L,65L,112L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007535Inst : IEnumerable<long>
{
public static readonly long[] Value=A007535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007535.Bytes);
public long this[int i]=>Value[i];

public static A007535Inst Instance=new A007535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007534
{
public static readonly long[] Value={ 2L,4L,94L,96L,98L,400L,402L,404L,514L,516L,518L,784L,786L,788L,904L,906L,908L,1114L,1116L,1118L,1144L,1146L,1148L,1264L,1266L,1268L,1354L,1356L,1358L,3244L,3246L,3248L,4204L,4206L,4208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007534Inst : IEnumerable<long>
{
public static readonly long[] Value=A007534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007534.Bytes);
public long this[int i]=>Value[i];

public static A007534Inst Instance=new A007534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007533
{
public static readonly long[] Value={ 2L,41L,130L,269L,458L,697L,986L,1325L,1714L,2153L,2642L,3181L,3770L,4409L,5098L,5837L,6626L,7465L,8354L,9293L,10282L,11321L,12410L,13549L,14738L,15977L,17266L,18605L,19994L,21433L,22922L,24461L,26050L,27689L,29378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007533Inst : IEnumerable<long>
{
public static readonly long[] Value=A007533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007533.Bytes);
public long this[int i]=>Value[i];

public static A007533Inst Instance=new A007533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007532
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,24L,43L,63L,89L,132L,135L,153L,175L,209L,224L,226L,262L,264L,267L,283L,332L,333L,334L,357L,370L,371L,372L,373L,374L,375L,376L,377L,378L,379L,407L,445L,463L,518L,598L,629L,739L,794L,849L,935L,994L,1034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007532Inst : IEnumerable<long>
{
public static readonly long[] Value=A007532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007532.Bytes);
public long this[int i]=>Value[i];

public static A007532Inst Instance=new A007532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007531
{
public static readonly long[] Value={ 0L,0L,0L,6L,24L,60L,120L,210L,336L,504L,720L,990L,1320L,1716L,2184L,2730L,3360L,4080L,4896L,5814L,6840L,7980L,9240L,10626L,12144L,13800L,15600L,17550L,19656L,21924L,24360L,26970L,29760L,32736L,35904L,39270L,42840L,46620L,50616L,54834L,59280L,63960L,68880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007531Inst : IEnumerable<long>
{
public static readonly long[] Value=A007531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007531.Bytes);
public long this[int i]=>Value[i];

public static A007531Inst Instance=new A007531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007530
{
public static readonly long[] Value={ 5L,11L,101L,191L,821L,1481L,1871L,2081L,3251L,3461L,5651L,9431L,13001L,15641L,15731L,16061L,18041L,18911L,19421L,21011L,22271L,25301L,31721L,34841L,43781L,51341L,55331L,62981L,67211L,69491L,72221L,77261L,79691L,81041L,82721L,88811L,97841L,99131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007530Inst : IEnumerable<long>
{
public static readonly long[] Value=A007530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007530.Bytes);
public long this[int i]=>Value[i];

public static A007530Inst Instance=new A007530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007529
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,37L,41L,67L,97L,101L,103L,107L,191L,193L,223L,227L,277L,307L,311L,347L,457L,461L,613L,641L,821L,823L,853L,857L,877L,881L,1087L,1091L,1277L,1297L,1301L,1423L,1427L,1447L,1481L,1483L,1487L,1607L,1663L,1693L,1783L,1867L,1871L,1873L,1993L,1997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007529Inst : IEnumerable<long>
{
public static readonly long[] Value=A007529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007529.Bytes);
public long this[int i]=>Value[i];

public static A007529Inst Instance=new A007529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007528
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,41L,47L,53L,59L,71L,83L,89L,101L,107L,113L,131L,137L,149L,167L,173L,179L,191L,197L,227L,233L,239L,251L,257L,263L,269L,281L,293L,311L,317L,347L,353L,359L,383L,389L,401L,419L,431L,443L,449L,461L,467L,479L,491L,503L,509L,521L,557L,563L,569L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007528Inst : IEnumerable<long>
{
public static readonly long[] Value=A007528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007528.Bytes);
public long this[int i]=>Value[i];

public static A007528Inst Instance=new A007528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007527
{
public static readonly long[] Value={ 5L,10L,11L,20L,25L,26L,38L,39L,54L,65L,70L,114L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007527Inst : IEnumerable<long>
{
public static readonly long[] Value=A007527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007527.Bytes);
public long this[int i]=>Value[i];

public static A007527Inst Instance=new A007527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007526
{
public static readonly BigInteger[] Value={ 0L,1L,4L,15L,64L,325L,1956L,13699L,109600L,986409L,9864100L,108505111L,1302061344L,16926797485L,236975164804L,3554627472075L,56874039553216L,966858672404689L,17403456103284420L,330665665962403999L,6613313319248080000L,BigInteger.Parse("138879579704209680021"),BigInteger.Parse("3055350753492612960484") };
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
public class A007526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A007526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A007526Inst Instance=new A007526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007525
{
public static readonly long[] Value={ 1L,4L,4L,2L,6L,9L,5L,0L,4L,0L,8L,8L,8L,9L,6L,3L,4L,0L,7L,3L,5L,9L,9L,2L,4L,6L,8L,1L,0L,0L,1L,8L,9L,2L,1L,3L,7L,4L,2L,6L,6L,4L,5L,9L,5L,4L,1L,5L,2L,9L,8L,5L,9L,3L,4L,1L,3L,5L,4L,4L,9L,4L,0L,6L,9L,3L,1L,1L,0L,9L,2L,1L,9L,1L,8L,1L,1L,8L,5L,0L,7L,9L,8L,8L,5L,5L,2L,6L,6L,2L,2L,8L,9L,3L,5L,0L,6L,3L,4L,4L,4L,9L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007525Inst : IEnumerable<long>
{
public static readonly long[] Value=A007525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007525.Bytes);
public long this[int i]=>Value[i];

public static A007525Inst Instance=new A007525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007524
{
public static readonly long[] Value={ 3L,0L,1L,0L,2L,9L,9L,9L,5L,6L,6L,3L,9L,8L,1L,1L,9L,5L,2L,1L,3L,7L,3L,8L,8L,9L,4L,7L,2L,4L,4L,9L,3L,0L,2L,6L,7L,6L,8L,1L,8L,9L,8L,8L,1L,4L,6L,2L,1L,0L,8L,5L,4L,1L,3L,1L,0L,4L,2L,7L,4L,6L,1L,1L,2L,7L,1L,0L,8L,1L,8L,9L,2L,7L,4L,4L,2L,4L,5L,0L,9L,4L,8L,6L,9L,2L,7L,2L,5L,2L,1L,1L,8L,1L,8L,6L,1L,7L,2L,0L,4L,0L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007524Inst : IEnumerable<long>
{
public static readonly long[] Value=A007524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007524.Bytes);
public long this[int i]=>Value[i];

public static A007524Inst Instance=new A007524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007523
{
public static readonly long[] Value={ 3L,13L,51413L,951413L,2951413L,53562951413L,979853562951413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007523Inst : IEnumerable<long>
{
public static readonly long[] Value=A007523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007523.Bytes);
public long this[int i]=>Value[i];

public static A007523Inst Instance=new A007523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007522
{
public static readonly long[] Value={ 7L,23L,31L,47L,71L,79L,103L,127L,151L,167L,191L,199L,223L,239L,263L,271L,311L,359L,367L,383L,431L,439L,463L,479L,487L,503L,599L,607L,631L,647L,719L,727L,743L,751L,823L,839L,863L,887L,911L,919L,967L,983L,991L,1031L,1039L,1063L,1087L,1103L,1151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007522Inst : IEnumerable<long>
{
public static readonly long[] Value=A007522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007522.Bytes);
public long this[int i]=>Value[i];

public static A007522Inst Instance=new A007522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007521
{
public static readonly long[] Value={ 5L,13L,29L,37L,53L,61L,101L,109L,149L,157L,173L,181L,197L,229L,269L,277L,293L,317L,349L,373L,389L,397L,421L,461L,509L,541L,557L,613L,653L,661L,677L,701L,709L,733L,757L,773L,797L,821L,829L,853L,877L,941L,997L,1013L,1021L,1061L,1069L,1093L,1109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007521Inst : IEnumerable<long>
{
public static readonly long[] Value=A007521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007521.Bytes);
public long this[int i]=>Value[i];

public static A007521Inst Instance=new A007521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007520
{
public static readonly long[] Value={ 3L,11L,19L,43L,59L,67L,83L,107L,131L,139L,163L,179L,211L,227L,251L,283L,307L,331L,347L,379L,419L,443L,467L,491L,499L,523L,547L,563L,571L,587L,619L,643L,659L,683L,691L,739L,787L,811L,827L,859L,883L,907L,947L,971L,1019L,1051L,1091L,1123L,1163L,1171L,1187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007520Inst : IEnumerable<long>
{
public static readonly long[] Value=A007520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007520.Bytes);
public long this[int i]=>Value[i];

public static A007520Inst Instance=new A007520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007519
{
public static readonly long[] Value={ 17L,41L,73L,89L,97L,113L,137L,193L,233L,241L,257L,281L,313L,337L,353L,401L,409L,433L,449L,457L,521L,569L,577L,593L,601L,617L,641L,673L,761L,769L,809L,857L,881L,929L,937L,953L,977L,1009L,1033L,1049L,1097L,1129L,1153L,1193L,1201L,1217L,1249L,1289L,1297L,1321L,1361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007519Inst : IEnumerable<long>
{
public static readonly long[] Value=A007519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007519.Bytes);
public long this[int i]=>Value[i];

public static A007519Inst Instance=new A007519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007518
{
public static readonly long[] Value={ 0L,3L,9L,21L,39L,66L,102L,150L,210L,285L,375L,483L,609L,756L,924L,1116L,1332L,1575L,1845L,2145L,2475L,2838L,3234L,3666L,4134L,4641L,5187L,5775L,6405L,7080L,7800L,8568L,9384L,10251L,11169L,12141L,13167L,14250L,15390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007518Inst : IEnumerable<long>
{
public static readonly long[] Value=A007518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007518.Bytes);
public long this[int i]=>Value[i];

public static A007518Inst Instance=new A007518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007501
{
public static readonly BigInteger[] Value={ 2L,3L,6L,21L,231L,26796L,359026206L,64449908476890321L,BigInteger.Parse("2076895351339769460477611370186681"),BigInteger.Parse("2156747150208372213435450937462082366919951682912789656986079991221") };
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
public class A007501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A007501.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A007501Inst Instance=new A007501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007500
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,31L,37L,71L,73L,79L,97L,101L,107L,113L,131L,149L,151L,157L,167L,179L,181L,191L,199L,311L,313L,337L,347L,353L,359L,373L,383L,389L,701L,709L,727L,733L,739L,743L,751L,757L,761L,769L,787L,797L,907L,919L,929L,937L,941L,953L,967L,971L,983L,991L,1009L,1021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007500Inst : IEnumerable<long>
{
public static readonly long[] Value=A007500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007500.Bytes);
public long this[int i]=>Value[i];

public static A007500Inst Instance=new A007500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007499
{
public static readonly long[] Value={ 2L,3L,4L,12L,20L,55L,127L,371L,1037L,3249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007499Inst : IEnumerable<long>
{
public static readonly long[] Value=A007499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007499.Bytes);
public long this[int i]=>Value[i];

public static A007499Inst Instance=new A007499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007498
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,10L,12L,14L,19L,23L,24L,36L,38L,39L,48L,62L,93L,106L,120L,134L,150L,196L,294L,317L,320L,385L,586L,597L,654L,738L,945L,1031L,1172L,1282L,1404L,1426L,1452L,1521L,1752L,1812L,1836L,1844L,1862L,2134L,2232L,2264L,2667L,3750L,3903L,3927L,4274L,4354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007498Inst : IEnumerable<long>
{
public static readonly long[] Value=A007498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007498.Bytes);
public long this[int i]=>Value[i];

public static A007498Inst Instance=new A007498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007497
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,15L,24L,60L,168L,480L,1512L,4800L,15748L,28672L,65528L,122880L,393192L,1098240L,4124736L,15605760L,50328576L,149873152L,371226240L,1710858240L,7926750720L,33463001088L,109760857440L,384120963072L,1468475386560L,7157589626880L,33151875434496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007497Inst : IEnumerable<long>
{
public static readonly long[] Value=A007497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007497.Bytes);
public long this[int i]=>Value[i];

public static A007497Inst Instance=new A007497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007496
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,18L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007496Inst : IEnumerable<long>
{
public static readonly long[] Value=A007496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007496.Bytes);
public long this[int i]=>Value[i];

public static A007496Inst Instance=new A007496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007495
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,4L,5L,4L,8L,8L,7L,11L,8L,13L,4L,11L,12L,8L,12L,2L,13L,7L,22L,2L,8L,13L,26L,4L,26L,29L,17L,27L,26L,7L,33L,20L,16L,22L,29L,4L,13L,22L,25L,14L,22L,37L,18L,46L,42L,46L,9L,41L,12L,7L,26L,42L,24L,5L,44L,53L,52L,58L,29L,22L,12L,48L,27L,30L,58L,52L,49L,57L,13L,14L,32L,24L,75L,8L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007495Inst : IEnumerable<long>
{
public static readonly long[] Value=A007495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007495.Bytes);
public long this[int i]=>Value[i];

public static A007495Inst Instance=new A007495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007494
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,9L,11L,12L,14L,15L,17L,18L,20L,21L,23L,24L,26L,27L,29L,30L,32L,33L,35L,36L,38L,39L,41L,42L,44L,45L,47L,48L,50L,51L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,83L,84L,86L,87L,89L,90L,92L,93L,95L,96L,98L,99L,101L,102L,104L,105L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007494Inst : IEnumerable<long>
{
public static readonly long[] Value=A007494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007494.Bytes);
public long this[int i]=>Value[i];

public static A007494Inst Instance=new A007494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007493
{
public static readonly long[] Value={ 2L,0L,9L,4L,5L,5L,1L,4L,8L,1L,5L,4L,2L,3L,2L,6L,5L,9L,1L,4L,8L,2L,3L,8L,6L,5L,4L,0L,5L,7L,9L,3L,0L,2L,9L,6L,3L,8L,5L,7L,3L,0L,6L,1L,0L,5L,6L,2L,8L,2L,3L,9L,1L,8L,0L,3L,0L,4L,1L,2L,8L,5L,2L,9L,0L,4L,5L,3L,1L,2L,1L,8L,9L,9L,8L,3L,4L,8L,3L,6L,6L,7L,1L,4L,6L,2L,6L,7L,2L,8L,1L,7L,7L,7L,1L,5L,7L,7L,5L,7L,8L,6L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007493Inst : IEnumerable<long>
{
public static readonly long[] Value=A007493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007493.Bytes);
public long this[int i]=>Value[i];

public static A007493Inst Instance=new A007493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007492
{
public static readonly long[] Value={ 2L,0L,3L,2L,6L,7L,14L,20L,35L,54L,90L,143L,234L,376L,611L,986L,1598L,2583L,4182L,6764L,10947L,17710L,28658L,46367L,75026L,121392L,196419L,317810L,514230L,832039L,1346270L,2178308L,3524579L,5702886L,9227466L,14930351L,24157818L,39088168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007492Inst : IEnumerable<long>
{
public static readonly long[] Value=A007492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007492.Bytes);
public long this[int i]=>Value[i];

public static A007492Inst Instance=new A007492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007491
{
public static readonly long[] Value={ 2L,5L,11L,17L,29L,37L,53L,67L,83L,101L,127L,149L,173L,197L,227L,257L,293L,331L,367L,401L,443L,487L,541L,577L,631L,677L,733L,787L,853L,907L,967L,1031L,1091L,1163L,1229L,1297L,1373L,1447L,1523L,1601L,1693L,1777L,1861L,1949L,2027L,2129L,2213L,2309L,2411L,2503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007491Inst : IEnumerable<long>
{
public static readonly long[] Value=A007491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007491.Bytes);
public long this[int i]=>Value[i];

public static A007491Inst Instance=new A007491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007490
{
public static readonly long[] Value={ 3L,17L,29L,43L,73L,127L,179L,197L,251L,277L,281L,307L,349L,359L,397L,433L,521L,547L,557L,577L,593L,701L,757L,811L,853L,857L,863L,881L,919L,953L,1009L,1051L,1091L,1217L,1249L,1367L,1459L,1483L,1559L,1583L,1637L,1753L,1801L,1861L,1907L,2017L,2027L,2069L,2087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007490Inst : IEnumerable<long>
{
public static readonly long[] Value=A007490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007490.Bytes);
public long this[int i]=>Value[i];

public static A007490Inst Instance=new A007490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007489
{
public static readonly BigInteger[] Value={ 0L,1L,3L,9L,33L,153L,873L,5913L,46233L,409113L,4037913L,43954713L,522956313L,6749977113L,93928268313L,1401602636313L,22324392524313L,378011820620313L,6780385526348313L,128425485935180313L,2561327494111820313L,BigInteger.Parse("53652269665821260313") };
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
public class A007489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A007489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A007489Inst Instance=new A007489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007488
{
public static readonly long[] Value={ 61L,163L,487L,691L,1297L,1861L,4201L,4441L,4483L,5209L,5227L,9049L,9631L,12391L,14437L,16141L,16987L,61483L,63211L,65707L,65899L,67057L,69481L,92767L,94273L,96979L,106303L,108061L,123031L,123373L,125329L,127291L,129643L,142771L,146857L,148249L,165901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007488Inst : IEnumerable<long>
{
public static readonly long[] Value=A007488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007488.Bytes);
public long this[int i]=>Value[i];

public static A007488Inst Instance=new A007488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007487
{
public static readonly long[] Value={ 0L,1L,513L,20196L,282340L,2235465L,12313161L,52666768L,186884496L,574304985L,1574304985L,3932252676L,9092033028L,19696532401L,40357579185L,78800938560L,147520415296L,266108291793L,464467582161L,787155279940L,1299155279940L,2093435326521L,3300704544313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007487Inst : IEnumerable<long>
{
public static readonly long[] Value=A007487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007487.Bytes);
public long this[int i]=>Value[i];

public static A007487Inst Instance=new A007487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007486
{
public static readonly long[] Value={ 1L,3L,4L,8L,15L,27L,50L,92L,169L,311L,572L,1052L,1935L,3559L,6546L,12040L,22145L,40731L,74916L,137792L,253439L,466147L,857378L,1576964L,2900489L,5334831L,9812284L,18047604L,33194719L,61054607L,112296930L,206546256L,379897793L,698740979L,1285185028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007486Inst : IEnumerable<long>
{
public static readonly long[] Value=A007486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007486.Bytes);
public long this[int i]=>Value[i];

public static A007486Inst Instance=new A007486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007485
{
public static readonly long[] Value={ 3L,4L,4L,4L,3L,3L,5L,4L,5L,4L,3L,6L,7L,8L,7L,7L,9L,8L,9L,7L,12L,13L,13L,13L,12L,12L,14L,13L,14L,6L,11L,12L,12L,12L,11L,11L,13L,12L,13L,7L,12L,13L,13L,13L,12L,12L,14L,13L,14L,6L,11L,12L,12L,12L,11L,11L,13L,12L,13L,6L,11L,12L,12L,12L,11L,11L,13L,12L,13L,8L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007485Inst : IEnumerable<long>
{
public static readonly long[] Value=A007485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007485.Bytes);
public long this[int i]=>Value[i];

public static A007485Inst Instance=new A007485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007484
{
public static readonly long[] Value={ 2L,7L,25L,89L,317L,1129L,4021L,14321L,51005L,181657L,646981L,2304257L,8206733L,29228713L,104099605L,370756241L,1320467933L,4702916281L,16749684709L,59654886689L,212464029485L,756701861833L,2695033644469L,9598504657073L,34185581260157L,121753753094617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007484Inst : IEnumerable<long>
{
public static readonly long[] Value=A007484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007484.Bytes);
public long this[int i]=>Value[i];

public static A007484Inst Instance=new A007484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007483
{
public static readonly long[] Value={ 1L,5L,17L,61L,217L,773L,2753L,9805L,34921L,124373L,442961L,1577629L,5618809L,20011685L,71272673L,253841389L,904069513L,3219891317L,11467812977L,40843221565L,145465290649L,518082315077L,1845177526529L,6571697209741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007483Inst : IEnumerable<long>
{
public static readonly long[] Value=A007483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007483.Bytes);
public long this[int i]=>Value[i];

public static A007483Inst Instance=new A007483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007482
{
public static readonly long[] Value={ 1L,3L,11L,39L,139L,495L,1763L,6279L,22363L,79647L,283667L,1010295L,3598219L,12815247L,45642179L,162557031L,578955451L,2061980415L,7343852147L,26155517271L,93154256107L,331773802863L,1181629920803L,4208437368135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007482Inst : IEnumerable<long>
{
public static readonly long[] Value=A007482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007482.Bytes);
public long this[int i]=>Value[i];

public static A007482Inst Instance=new A007482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007481
{
public static readonly long[] Value={ 1L,2L,3L,7L,11L,25L,39L,89L,139L,317L,495L,1129L,1763L,4021L,6279L,14321L,22363L,51005L,79647L,181657L,283667L,646981L,1010295L,2304257L,3598219L,8206733L,12815247L,29228713L,45642179L,104099605L,162557031L,370756241L,578955451L,1320467933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007481Inst : IEnumerable<long>
{
public static readonly long[] Value=A007481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007481.Bytes);
public long this[int i]=>Value[i];

public static A007481Inst Instance=new A007481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007480
{
public static readonly BigInteger[] Value={ 1L,16L,1296L,20736L,12960000L,12960000L,31116960000L,497871360000L,40327580160000L,40327580160000L,590436101122560000L,590436101122560000L,BigInteger.Parse("16863445484161436160000"),BigInteger.Parse("16863445484161436160000"),BigInteger.Parse("16863445484161436160000"),BigInteger.Parse("269815127746582978560000") };
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
public class A007480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A007480.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A007480Inst Instance=new A007480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007479
{
public static readonly long[] Value={ 0L,3L,6L,5L,12L,2L,10L,9L,24L,11L,4L,14L,20L,15L,18L,17L,48L,26L,22L,21L,8L,23L,28L,38L,40L,27L,30L,29L,36L,50L,34L,33L,96L,35L,52L,62L,44L,39L,42L,41L,16L,74L,46L,45L,56L,47L,76L,86L,51L,54L,53L,60L,98L,58L,57L,72L,59L,100L,110L,68L,63L,66L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007479Inst : IEnumerable<long>
{
public static readonly long[] Value=A007479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007479.Bytes);
public long this[int i]=>Value[i];

public static A007479Inst Instance=new A007479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007478
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,5L,8L,12L,18L,27L,39L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007478Inst : IEnumerable<long>
{
public static readonly long[] Value=A007478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007478.Bytes);
public long this[int i]=>Value[i];

public static A007478Inst Instance=new A007478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007477
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,11L,22L,44L,90L,187L,392L,832L,1778L,3831L,8304L,18104L,39666L,87296L,192896L,427778L,951808L,2124135L,4753476L,10664458L,23981698L,54045448L,122041844L,276101386L,625725936L,1420386363L,3229171828L,7351869690L,16760603722L,38258956928L,87437436916L,200057233386L,458223768512L,1050614664580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007477Inst : IEnumerable<long>
{
public static readonly long[] Value=A007477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007477.Bytes);
public long this[int i]=>Value[i];

public static A007477Inst Instance=new A007477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007476
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,9L,23L,65L,199L,654L,2296L,8569L,33825L,140581L,612933L,2795182L,13298464L,65852873L,338694479L,1805812309L,9963840219L,56807228074L,334192384460L,2026044619017L,12642938684817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007476Inst : IEnumerable<long>
{
public static readonly long[] Value=A007476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007476.Bytes);
public long this[int i]=>Value[i];

public static A007476Inst Instance=new A007476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007475
{
public static readonly long[] Value={ 1L,3L,18L,7L,1L,25L,7L,539L,25L,7L,22L,442L,225L,192L,13L,15L,26914L,244L,50L,5552L,30L,553L,7L,4493L,83342L,83L,65L,775L,3807L,64L,556L,20L,106L,132L,2277L,15L,1788L,5063L,27L,11320L,280L,358L,1805L,210L,9985L,802L,183L,71752L,10123L,16806L,94707486L,1081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007475Inst : IEnumerable<long>
{
public static readonly long[] Value=A007475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007475.Bytes);
public long this[int i]=>Value[i];

public static A007475Inst Instance=new A007475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007474
{
public static readonly BigInteger[] Value={ 1L,0L,1L,2L,7L,36L,300L,3218L,42335L,644808L,11119515L,213865382L,4537496680L,105270612952L,2651295555949L,72042968876506L,2100886276796969L,65446290562491916L,2169090198219290966L,BigInteger.Parse("76211647261082309466"),BigInteger.Parse("2829612806029873399561") };
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
public class A007474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A007474.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A007474Inst Instance=new A007474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007473
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,10L,19L,33L,60L,104L,184L,316L,548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007473Inst : IEnumerable<long>
{
public static readonly long[] Value=A007473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007473.Bytes);
public long this[int i]=>Value[i];

public static A007473Inst Instance=new A007473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007472
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,29L,105L,431L,1969L,9785L,52145L,296155L,1787385L,11428949L,77124569L,546987143L,4062341601L,31502219889L,254500383457L,2137863653811L,18639586581097L,168387382189709L,1573599537048265L,15189509662516063L,151243491212611217L,1551565158004180137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007472Inst : IEnumerable<long>
{
public static readonly long[] Value=A007472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007472.Bytes);
public long this[int i]=>Value[i];

public static A007472Inst Instance=new A007472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007471
{
public static readonly long[] Value={ 1L,9L,9L,3L,9L,9L,3L,9L,9L,1L,18L,9L,9L,9L,9L,9L,9L,9L,6L,9L,18L,6L,9L,9L,6L,9L,9L,4L,9L,9L,12L,18L,18L,3L,9L,9L,3L,9L,9L,3L,18L,18L,12L,18L,9L,5L,9L,9L,9L,9L,18L,6L,18L,18L,2L,9L,9L,9L,9L,9L,12L,5L,18L,3L,9L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007471Inst : IEnumerable<long>
{
public static readonly long[] Value=A007471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007471.Bytes);
public long this[int i]=>Value[i];

public static A007471Inst Instance=new A007471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007470
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,97L,934L,11814L,188650L,3698399L,87133235L,2424143590L,78483913829L,2920947798710L,123676552368689L,5904927996501989L,315465738505181316L,BigInteger.Parse("18730636267115299571"),BigInteger.Parse("1228583480023634860711"),BigInteger.Parse("88548597460914590753663"),BigInteger.Parse("6979070787198903764535472") };
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
public class A007470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A007470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A007470Inst Instance=new A007470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007437
{
public static readonly long[] Value={ 1L,4L,7L,14L,16L,31L,29L,50L,52L,74L,67L,119L,92L,137L,142L,186L,154L,247L,191L,294L,266L,323L,277L,455L,341L,446L,430L,553L,436L,686L,497L,714L,634L,752L,674L,1001L,704L,935L,878L,1150L,862L,1298L,947L,1323L,1222L,1361L,1129L,1767L,1254L,1674L,1486L,1834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007437Inst : IEnumerable<long>
{
public static readonly long[] Value=A007437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007437.Bytes);
public long this[int i]=>Value[i];

public static A007437Inst Instance=new A007437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007436
{
public static readonly long[] Value={ 1L,0L,1L,2L,4L,6L,12L,18L,32L,50L,88L,134L,232L,364L,604L,966L,1596L,2544L,4180L,6708L,10932L,17622L,28656L,46206L,75020L,121160L,196384L,317432L,514228L,831374L,1346268L,2177322L,3524488L,5701290L,9227448L,14927632L,24157816L,39083988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007436Inst : IEnumerable<long>
{
public static readonly long[] Value=A007436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007436.Bytes);
public long this[int i]=>Value[i];

public static A007436Inst Instance=new A007436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007435
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,12L,14L,26L,37L,62L,90L,159L,234L,392L,618L,1013L,1598L,2630L,4182L,6830L,10962L,17802L,28658L,46548L,75031L,121628L,196455L,318206L,514230L,832722L,1346270L,2179322L,3524670L,5704486L,9227484L,14933129L,24157818L,39092352L,63246222L,102341006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007435Inst : IEnumerable<long>
{
public static readonly long[] Value=A007435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007435.Bytes);
public long this[int i]=>Value[i];

public static A007435Inst Instance=new A007435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007434
{
public static readonly long[] Value={ 1L,3L,8L,12L,24L,24L,48L,48L,72L,72L,120L,96L,168L,144L,192L,192L,288L,216L,360L,288L,384L,360L,528L,384L,600L,504L,648L,576L,840L,576L,960L,768L,960L,864L,1152L,864L,1368L,1080L,1344L,1152L,1680L,1152L,1848L,1440L,1728L,1584L,2208L,1536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007434Inst : IEnumerable<long>
{
public static readonly long[] Value=A007434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007434.Bytes);
public long this[int i]=>Value[i];

public static A007434Inst Instance=new A007434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007433
{
public static readonly long[] Value={ 1L,6L,11L,27L,27L,66L,51L,112L,102L,162L,123L,297L,171L,306L,297L,453L,291L,612L,363L,729L,561L,738L,531L,1232L,678L,1026L,922L,1377L,843L,1782L,963L,1818L,1353L,1746L,1377L,2754L,1371L,2178L,1881L,3024L,1683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007433Inst : IEnumerable<long>
{
public static readonly long[] Value=A007433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007433.Bytes);
public long this[int i]=>Value[i];

public static A007433Inst Instance=new A007433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007432
{
public static readonly long[] Value={ 1L,-1L,0L,1L,2L,0L,4L,1L,3L,-2L,8L,0L,10L,-4L,0L,2L,14L,-3L,16L,2L,0L,-8L,20L,0L,13L,-10L,8L,4L,26L,0L,28L,4L,0L,-14L,8L,3L,34L,-16L,0L,2L,38L,0L,40L,8L,6L,-20L,44L,0L,31L,-13L,0L,10L,50L,-8L,16L,4L,0L,-26L,56L,0L,58L,-28L,12L,8L,20L,0L,64L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007432Inst : IEnumerable<long>
{
public static readonly long[] Value=A007432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007432.Bytes);
public long this[int i]=>Value[i];

public static A007432Inst Instance=new A007432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007431
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,3L,0L,5L,2L,4L,0L,9L,1L,11L,0L,3L,4L,15L,0L,17L,3L,5L,0L,21L,2L,16L,0L,12L,5L,27L,0L,29L,8L,9L,0L,15L,4L,35L,0L,11L,6L,39L,0L,41L,9L,12L,0L,45L,4L,36L,0L,15L,11L,51L,0L,27L,10L,17L,0L,57L,3L,59L,0L,20L,16L,33L,0L,65L,15L,21L,0L,69L,8L,71L,0L,16L,17L,45L,0L,77L,12L,36L,0L,81L,5L,45L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007431Inst : IEnumerable<long>
{
public static readonly long[] Value=A007431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007431.Bytes);
public long this[int i]=>Value[i];

public static A007431Inst Instance=new A007431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007430
{
public static readonly long[] Value={ 1L,5L,6L,16L,8L,30L,10L,42L,24L,40L,14L,96L,16L,50L,48L,99L,20L,120L,22L,128L,60L,70L,26L,252L,46L,80L,82L,160L,32L,240L,34L,219L,84L,100L,80L,384L,40L,110L,96L,336L,44L,300L,46L,224L,192L,130L,50L,594L,76L,230L,120L,256L,56L,410L,112L,420L,132L,160L,62L,768L,64L,170L,240L,466L,128L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007430Inst : IEnumerable<long>
{
public static readonly long[] Value=A007430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007430.Bytes);
public long this[int i]=>Value[i];

public static A007430Inst Instance=new A007430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007429
{
public static readonly long[] Value={ 1L,4L,5L,11L,7L,20L,9L,26L,18L,28L,13L,55L,15L,36L,35L,57L,19L,72L,21L,77L,45L,52L,25L,130L,38L,60L,58L,99L,31L,140L,33L,120L,65L,76L,63L,198L,39L,84L,75L,182L,43L,180L,45L,143L,126L,100L,49L,285L,66L,152L,95L,165L,55L,232L,91L,234L,105L,124L,61L,385L,63L,132L,162L,247L,105L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007429Inst : IEnumerable<long>
{
public static readonly long[] Value=A007429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007429.Bytes);
public long this[int i]=>Value[i];

public static A007429Inst Instance=new A007429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007428
{
public static readonly long[] Value={ 1L,-3L,-3L,3L,-3L,9L,-3L,-1L,3L,9L,-3L,-9L,-3L,9L,9L,0L,-3L,-9L,-3L,-9L,9L,9L,-3L,3L,3L,9L,-1L,-9L,-3L,-27L,-3L,0L,9L,9L,9L,9L,-3L,9L,9L,3L,-3L,-27L,-3L,-9L,-9L,9L,-3L,0L,3L,-9L,9L,-9L,-3L,3L,9L,3L,9L,9L,-3L,27L,-3L,9L,-9L,0L,9L,-27L,-3L,-9L,9L,-27L,-3L,-3L,-3L,9L,-9L,-9L,9L,-27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007428Inst : IEnumerable<long>
{
public static readonly long[] Value=A007428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007428.Bytes);
public long this[int i]=>Value[i];

public static A007428Inst Instance=new A007428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007427
{
public static readonly long[] Value={ 1L,-2L,-2L,1L,-2L,4L,-2L,0L,1L,4L,-2L,-2L,-2L,4L,4L,0L,-2L,-2L,-2L,-2L,4L,4L,-2L,0L,1L,4L,0L,-2L,-2L,-8L,-2L,0L,4L,4L,4L,1L,-2L,4L,4L,0L,-2L,-8L,-2L,-2L,-2L,4L,-2L,0L,1L,-2L,4L,-2L,-2L,0L,4L,0L,4L,4L,-2L,4L,-2L,4L,-2L,0L,4L,-8L,-2L,-2L,4L,-8L,-2L,0L,-2L,4L,-2L,-2L,4L,-8L,-2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007427Inst : IEnumerable<long>
{
public static readonly long[] Value=A007427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007427.Bytes);
public long this[int i]=>Value[i];

public static A007427Inst Instance=new A007427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007426
{
public static readonly long[] Value={ 1L,4L,4L,10L,4L,16L,4L,20L,10L,16L,4L,40L,4L,16L,16L,35L,4L,40L,4L,40L,16L,16L,4L,80L,10L,16L,20L,40L,4L,64L,4L,56L,16L,16L,16L,100L,4L,16L,16L,80L,4L,64L,4L,40L,40L,16L,4L,140L,10L,40L,16L,40L,4L,80L,16L,80L,16L,16L,4L,160L,4L,16L,40L,84L,16L,64L,4L,40L,16L,64L,4L,200L,4L,16L,40L,40L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007426Inst : IEnumerable<long>
{
public static readonly long[] Value=A007426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007426.Bytes);
public long this[int i]=>Value[i];

public static A007426Inst Instance=new A007426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007425
{
public static readonly long[] Value={ 1L,3L,3L,6L,3L,9L,3L,10L,6L,9L,3L,18L,3L,9L,9L,15L,3L,18L,3L,18L,9L,9L,3L,30L,6L,9L,10L,18L,3L,27L,3L,21L,9L,9L,9L,36L,3L,9L,9L,30L,3L,27L,3L,18L,18L,9L,3L,45L,6L,18L,9L,18L,3L,30L,9L,30L,9L,9L,3L,54L,3L,9L,18L,28L,9L,27L,3L,18L,9L,27L,3L,60L,3L,9L,18L,18L,9L,27L,3L,45L,15L,9L,3L,54L,9L,9L,9L,30L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007425Inst : IEnumerable<long>
{
public static readonly long[] Value=A007425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007425.Bytes);
public long this[int i]=>Value[i];

public static A007425Inst Instance=new A007425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007424
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007424Inst : IEnumerable<long>
{
public static readonly long[] Value=A007424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007424.Bytes);
public long this[int i]=>Value[i];

public static A007424Inst Instance=new A007424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007423
{
public static readonly long[] Value={ 2L,0L,0L,1L,0L,2L,0L,1L,1L,2L,0L,1L,0L,2L,2L,1L,0L,1L,0L,1L,2L,2L,0L,1L,1L,2L,1L,1L,0L,0L,0L,1L,2L,2L,2L,1L,0L,2L,2L,1L,0L,0L,0L,1L,1L,2L,0L,1L,1L,1L,2L,1L,0L,1L,2L,1L,2L,2L,0L,1L,0L,2L,1L,1L,2L,0L,0L,1L,2L,0L,0L,1L,0L,2L,1L,1L,2L,0L,0L,1L,1L,2L,0L,1L,2L,2L,2L,1L,0L,1L,2L,1L,2L,2L,2L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007423Inst : IEnumerable<long>
{
public static readonly long[] Value=A007423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007423.Bytes);
public long this[int i]=>Value[i];

public static A007423Inst Instance=new A007423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007422
{
public static readonly long[] Value={ 1L,6L,8L,10L,14L,15L,21L,22L,26L,27L,33L,34L,35L,38L,39L,46L,51L,55L,57L,58L,62L,65L,69L,74L,77L,82L,85L,86L,87L,91L,93L,94L,95L,106L,111L,115L,118L,119L,122L,123L,125L,129L,133L,134L,141L,142L,143L,145L,146L,155L,158L,159L,161L,166L,177L,178L,183L,185L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007422Inst : IEnumerable<long>
{
public static readonly long[] Value=A007422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007422.Bytes);
public long this[int i]=>Value[i];

public static A007422Inst Instance=new A007422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007405
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,116L,648L,4088L,28640L,219920L,1832224L,16430176L,157554048L,1606879040L,17350255744L,197553645440L,2363935624704L,29638547505408L,388328781668864L,5304452565517824L,75381218537805824L,1112348880749130752L,17014743624340539392UL,BigInteger.Parse("269360902955086379008") };
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
public class A007405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A007405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A007405Inst Instance=new A007405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007404
{
public static readonly long[] Value={ 8L,1L,6L,4L,2L,1L,5L,0L,9L,0L,2L,1L,8L,9L,3L,1L,4L,3L,7L,0L,8L,0L,7L,9L,7L,3L,7L,5L,3L,0L,5L,2L,5L,2L,2L,1L,7L,0L,3L,3L,1L,1L,3L,7L,5L,9L,2L,0L,5L,5L,2L,8L,0L,4L,3L,4L,1L,2L,1L,0L,9L,0L,3L,8L,4L,3L,0L,5L,5L,6L,1L,4L,1L,9L,4L,5L,5L,5L,3L,0L,0L,0L,6L,0L,4L,8L,5L,3L,1L,3L,2L,4L,8L,3L,9L,7L,2L,6L,5L,6L,1L,7L,5L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007404Inst : IEnumerable<long>
{
public static readonly long[] Value=A007404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007404.Bytes);
public long this[int i]=>Value[i];

public static A007404Inst Instance=new A007404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007403
{
public static readonly long[] Value={ 1L,9L,92L,920L,8928L,84448L,782464L,7130880L,64117760L,570166784L,5023524864L,43915595776L,381350330368L,3292451880960L,28283033157632L,241884640182272L,2060565937127424L,17492250190544896L,148027589475696640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007403Inst : IEnumerable<long>
{
public static readonly long[] Value=A007403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007403.Bytes);
public long this[int i]=>Value[i];

public static A007403Inst Instance=new A007403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007402
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,15L,1L,5L,7L,971L,20L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007402Inst : IEnumerable<long>
{
public static readonly long[] Value=A007402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007402.Bytes);
public long this[int i]=>Value[i];

public static A007402Inst Instance=new A007402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007401
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,28L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007401Inst : IEnumerable<long>
{
public static readonly long[] Value=A007401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007401.Bytes);
public long this[int i]=>Value[i];

public static A007401Inst Instance=new A007401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007400
{
public static readonly long[] Value={ 0L,1L,4L,2L,4L,4L,6L,4L,2L,4L,6L,2L,4L,6L,4L,4L,2L,4L,6L,2L,4L,4L,6L,4L,2L,6L,4L,2L,4L,6L,4L,4L,2L,4L,6L,2L,4L,4L,6L,4L,2L,4L,6L,2L,4L,6L,4L,4L,2L,6L,4L,2L,4L,4L,6L,4L,2L,6L,4L,2L,4L,6L,4L,4L,2L,4L,6L,2L,4L,4L,6L,4L,2L,4L,6L,2L,4L,6L,4L,4L,2L,4L,6L,2L,4L,4L,6L,4L,2L,6L,4L,2L,4L,6L,4L,4L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007400Inst : IEnumerable<long>
{
public static readonly long[] Value=A007400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007400.Bytes);
public long this[int i]=>Value[i];

public static A007400Inst Instance=new A007400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007399
{
public static readonly long[] Value={ 0L,8L,61L,96L,401L,904L,219L,722L,37L,54L,26L,43L,15L,32L,4L,21L,92L,1L,9L,71L,97L,501L,905L,319L,723L,137L,541L,945L,359L,763L,177L,581L,985L,399L,704L,217L,522L,35L,34L,24L,23L,13L,12L,2L,1L,9L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007399Inst : IEnumerable<long>
{
public static readonly long[] Value=A007399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007399.Bytes);
public long this[int i]=>Value[i];

public static A007399Inst Instance=new A007399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007398
{
public static readonly long[] Value={ 0L,7L,41L,84L,19L,62L,96L,301L,803L,18L,52L,95L,201L,802L,908L,519L,625L,236L,342L,943L,59L,66L,37L,44L,15L,22L,92L,99L,601L,806L,318L,523L,35L,24L,13L,2L,9L,61L,86L,39L,64L,17L,42L,94L,101L,801L,808L,518L,525L,235L,242L,942L,949L,659L,666L,376L,383L,93L,1L,8L,51L,85L,29L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007398Inst : IEnumerable<long>
{
public static readonly long[] Value=A007398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007398.Bytes);
public long this[int i]=>Value[i];

public static A007398Inst Instance=new A007398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007397
{
public static readonly long[] Value={ 0L,5L,1L,6L,11L,61L,66L,17L,22L,72L,77L,28L,33L,83L,88L,39L,44L,94L,99L,401L,604L,906L,119L,421L,624L,926L,139L,441L,644L,946L,159L,461L,664L,966L,179L,481L,684L,986L,199L,402L,704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007397Inst : IEnumerable<long>
{
public static readonly long[] Value=A007397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007397.Bytes);
public long this[int i]=>Value[i];

public static A007397Inst Instance=new A007397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007396
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,1L,3L,5L,7L,9L,11L,31L,33L,53L,55L,75L,77L,97L,99L,101L,301L,303L,503L,505L,705L,707L,907L,909L,119L,121L,321L,323L,523L,525L,725L,727L,927L,929L,139L,141L,341L,343L,543L,545L,745L,747L,947L,949L,159L,161L,361L,363L,563L,565L,765L,767L,967L,969L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007396Inst : IEnumerable<long>
{
public static readonly long[] Value=A007396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007396.Bytes);
public long this[int i]=>Value[i];

public static A007396Inst Instance=new A007396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007395
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007395Inst : IEnumerable<long>
{
public static readonly long[] Value=A007395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007395.Bytes);
public long this[int i]=>Value[i];

public static A007395Inst Instance=new A007395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007394
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,9L,0L,20L,0L,33L,0L,48L,0L,65L,9L,84L,29L,105L,62L,128L,110L,153L,175L,189L,259L,247L,364L,340L,492L,483L,645L,693L,834L,989L,1081L,1392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007394Inst : IEnumerable<long>
{
public static readonly long[] Value=A007394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007394.Bytes);
public long this[int i]=>Value[i];

public static A007394Inst Instance=new A007394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007393
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,16L,0L,27L,0L,40L,7L,55L,23L,72L,50L,91L,90L,119L,145L,165L,217L,240L,308L,357L,427L,531L,592L,779L,832L,1120L,1189L,1582L,1720L,2211L,2499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007393Inst : IEnumerable<long>
{
public static readonly long[] Value=A007393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007393.Bytes);
public long this[int i]=>Value[i];

public static A007393Inst Instance=new A007393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007392
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,12L,0L,21L,5L,32L,17L,45L,38L,65L,70L,99L,115L,156L,180L,247L,279L,385L,435L,590L,682L,896L,1067L,1360L,1657L,2073L,2553L,3173L,3913L,4865L,5986L,7455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007392Inst : IEnumerable<long>
{
public static readonly long[] Value=A007392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007392.Bytes);
public long this[int i]=>Value[i];

public static A007392Inst Instance=new A007392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007391
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,3L,0L,8L,3L,15L,11L,27L,26L,49L,53L,88L,102L,156L,190L,275L,346L,484L,621L,851L,1105L,1495L,1956L,2625L,3451L,4608L,6076L,8088L,10684L,14195L,18772L,24912L,32967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007391Inst : IEnumerable<long>
{
public static readonly long[] Value=A007391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007391.Bytes);
public long this[int i]=>Value[i];

public static A007391Inst Instance=new A007391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007390
{
public static readonly long[] Value={ 0L,0L,0L,4L,5L,15L,21L,44L,66L,120L,187L,319L,507L,840L,1348L,2204L,3553L,5776L,9329L,15124L,24454L,39600L,64055L,103679L,167735L,271440L,439176L,710644L,1149821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007390Inst : IEnumerable<long>
{
public static readonly long[] Value=A007390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007390.Bytes);
public long this[int i]=>Value[i];

public static A007390Inst Instance=new A007390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007389
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,2L,7L,2L,9L,2L,11L,2L,13L,2L,15L,2L,17L,11L,19L,22L,21L,35L,23L,50L,25L,67L,36L,86L,58L,107L,93L,130L,143L,155L,210L,191L,296L,249L,403L,342L,533L,485L,688L,695L,879L,991L,1128L,1394L,1470L,1927L,1955L,2615L,2650L,3494L,3641L,4622L,5035L,6092L,6962L,8047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007389Inst : IEnumerable<long>
{
public static readonly long[] Value=A007389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007389.Bytes);
public long this[int i]=>Value[i];

public static A007389Inst Instance=new A007389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007388
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,2L,7L,2L,9L,2L,11L,2L,13L,9L,15L,18L,17L,29L,19L,42L,28L,57L,46L,74L,75L,93L,117L,121L,174L,167L,248L,242L,341L,359L,462L,533L,629L,781L,871L,1122L,1230L,1584L,1763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007388Inst : IEnumerable<long>
{
public static readonly long[] Value=A007388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007388.Bytes);
public long this[int i]=>Value[i];

public static A007388Inst Instance=new A007388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007387
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,2L,7L,2L,9L,7L,11L,14L,13L,23L,20L,34L,34L,47L,57L,67L,91L,101L,138L,158L,205L,249L,306L,387L,464L,592L,713L,898L,1100L,1362L,1692L,2075L,2590L,3175L,3952L,4867L,6027L,7457L,9202L,11409L,14069L,17436L,21526L,26638L,32935L,40707L,50371L,62233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007387Inst : IEnumerable<long>
{
public static readonly long[] Value=A007387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007387.Bytes);
public long this[int i]=>Value[i];

public static A007387Inst Instance=new A007387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007386
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,3L,0L,6L,0L,10L,0L,15L,1L,21L,4L,28L,10L,36L,20L,45L,35L,56L,56L,71L,84L,93L,120L,126L,165L,175L,221L,246L,292L,346L,385L,483L,511L,666L,686L,906L,932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007386Inst : IEnumerable<long>
{
public static readonly long[] Value=A007386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007386.Bytes);
public long this[int i]=>Value[i];

public static A007386Inst Instance=new A007386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007385
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,3L,0L,6L,0L,10L,1L,15L,4L,21L,10L,28L,20L,37L,35L,50L,56L,70L,84L,101L,121L,148L,171L,217L,241L,315L,342L,451L,490L,638L,707L,896L,1022L,1256L,1473L,1765L,2111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007385Inst : IEnumerable<long>
{
public static readonly long[] Value=A007385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007385.Bytes);
public long this[int i]=>Value[i];

public static A007385Inst Instance=new A007385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007384
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,3L,0L,6L,1L,10L,4L,15L,10L,22L,20L,33L,35L,51L,57L,80L,90L,125L,141L,193L,221L,295L,346L,449L,539L,684L,834L,1045L,1283L,1600L,1967L,2451L,3012L,3752L,4612L,5738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007384Inst : IEnumerable<long>
{
public static readonly long[] Value=A007384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007384.Bytes);
public long this[int i]=>Value[i];

public static A007384Inst Instance=new A007384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007383
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,1L,6L,4L,11L,10L,20L,21L,36L,41L,64L,77L,113L,141L,199L,254L,350L,453L,615L,803L,1080L,1418L,1896L,2498L,3328L,4394L,5841L,7722L,10251L,13563L,17990L,23814L,31571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007383Inst : IEnumerable<long>
{
public static readonly long[] Value=A007383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007383.Bytes);
public long this[int i]=>Value[i];

public static A007383Inst Instance=new A007383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007382
{
public static readonly long[] Value={ 0L,0L,3L,4L,11L,16L,32L,49L,87L,137L,231L,369L,608L,978L,1595L,2574L,4179L,6754L,10944L,17699L,28655L,46355L,75023L,121379L,196416L,317796L,514227L,832024L,1346267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007382Inst : IEnumerable<long>
{
public static readonly long[] Value=A007382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007382.Bytes);
public long this[int i]=>Value[i];

public static A007382Inst Instance=new A007382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007381
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,1L,5L,2L,6L,4L,7L,7L,8L,11L,9L,16L,11L,22L,15L,29L,22L,37L,33L,46L,49L,57L,71L,72L,100L,94L,137L,127L,183L,176L,240L,247L,312L,347L,406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007381Inst : IEnumerable<long>
{
public static readonly long[] Value=A007381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007381.Bytes);
public long this[int i]=>Value[i];

public static A007381Inst Instance=new A007381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007380
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,2L,5L,4L,6L,7L,7L,11L,9L,16L,13L,22L,20L,29L,31L,38L,47L,51L,69L,71L,98L,102L,136L,149L,187L,218L,258L,316L,360L,452L,509L,639L,727L,897L,1043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007380Inst : IEnumerable<long>
{
public static readonly long[] Value=A007380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007380.Bytes);
public long this[int i]=>Value[i];

public static A007380Inst Instance=new A007380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007379
{
public static readonly long[] Value={ 0L,2L,4L,5L,8L,12L,7L,24L,16L,10L,36L,13L,20L,44L,15L,56L,32L,18L,68L,21L,48L,76L,23L,88L,28L,26L,100L,29L,96L,108L,31L,120L,64L,34L,132L,37L,40L,140L,39L,152L,144L,42L,164L,45L,52L,172L,47L,184L,80L,50L,196L,53L,176L,204L,55L,216L,60L,58L,228L,61L,224L,236L,63L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007379Inst : IEnumerable<long>
{
public static readonly long[] Value=A007379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007379.Bytes);
public long this[int i]=>Value[i];

public static A007379Inst Instance=new A007379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007378
{
public static readonly long[] Value={ 3L,4L,6L,7L,8L,10L,12L,13L,14L,15L,16L,18L,20L,22L,24L,25L,26L,27L,28L,29L,30L,31L,32L,34L,36L,38L,40L,42L,44L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,97L,98L,99L,100L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007378Inst : IEnumerable<long>
{
public static readonly long[] Value=A007378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007378.Bytes);
public long this[int i]=>Value[i];

public static A007378Inst Instance=new A007378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007377
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,13L,14L,15L,16L,18L,19L,24L,25L,27L,28L,31L,32L,33L,34L,35L,36L,37L,39L,49L,51L,67L,72L,76L,77L,81L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007377Inst : IEnumerable<long>
{
public static readonly long[] Value=A007377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007377.Bytes);
public long this[int i]=>Value[i];

public static A007377Inst Instance=new A007377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007376
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,0L,1L,1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,1L,7L,1L,8L,1L,9L,2L,0L,2L,1L,2L,2L,2L,3L,2L,4L,2L,5L,2L,6L,2L,7L,2L,8L,2L,9L,3L,0L,3L,1L,3L,2L,3L,3L,3L,4L,3L,5L,3L,6L,3L,7L,3L,8L,3L,9L,4L,0L,4L,1L,4L,2L,4L,3L,4L,4L,4L,5L,4L,6L,4L,7L,4L,8L,4L,9L,5L,0L,5L,1L,5L,2L,5L,3L,5L,4L,5L,5L,5L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007376Inst : IEnumerable<long>
{
public static readonly long[] Value=A007376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007376.Bytes);
public long this[int i]=>Value[i];

public static A007376Inst Instance=new A007376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007375
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,8L,1L,1L,1L,21L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007375Inst : IEnumerable<long>
{
public static readonly long[] Value=A007375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007375.Bytes);
public long this[int i]=>Value[i];

public static A007375Inst Instance=new A007375Inst();

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