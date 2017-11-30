using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A274384
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,34L,37L,40L,43L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274384Inst : IEnumerable<long>
{
public static readonly long[] Value=A274384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274384.Bytes);
public long this[int i]=>Value[i];

public static A274384Inst Instance=new A274384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274385
{
public static readonly BigInteger[] Value={ 2L,3L,7L,47L,383L,10321919L,51011754393599L,BigInteger.Parse("1130138339199322632554990773529330319359999999"),BigInteger.Parse("73562883979319395645666688474019139929848516028923903999999999"),BigInteger.Parse("4208832729023498248022825567687608993477547383960134557368319999999999") };
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
public class A274385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274385.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274385Inst Instance=new A274385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274386
{
public static readonly BigInteger[] Value={ 2L,3L,5L,11L,17L,19L,29L,79L,163L,281L,881L,209441L,4188799L,264539521L,2504902399L,72642169601L,254561089305599L,9927882482918401L,26582634158080001L,BigInteger.Parse("13106744139423334399999"),BigInteger.Parse("141383412854531380076544001"),BigInteger.Parse("427380210218181008588800001") };
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
public class A274386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274386.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274386Inst Instance=new A274386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274387
{
public static readonly BigInteger[] Value={ 1L,1L,3L,43L,1345L,71721L,5787931L,656778529L,99609347825L,19451450431009L,4752356577301171L,1419957082098657081L,BigInteger.Parse("509327639955159790777"),BigInteger.Parse("215968308944943346029577"),BigInteger.Parse("106859555896120941092549371"),BigInteger.Parse("61015970334444558798467062801"),BigInteger.Parse("39820542372512292977427634794721"),BigInteger.Parse("29454908124155520098406206592241281"),BigInteger.Parse("24512125500202005940687498958550124771"),BigInteger.Parse("22799363145943007981544986753209784020249"),BigInteger.Parse("23563018240183207044471748499194925348436201") };
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
public class A274387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274387Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274387.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274387.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274387Inst Instance=new A274387Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274420
{
public static readonly long[] Value={ 8L,2L,1L,6L,8L,5L,9L,8L,1L,7L,5L,0L,8L,7L,3L,8L,0L,6L,2L,9L,1L,3L,3L,9L,8L,3L,3L,8L,6L,0L,1L,0L,8L,5L,8L,2L,4L,9L,6L,9L,5L,0L,8L,3L,3L,9L,1L,7L,2L,5L,7L,5L,0L,3L,6L,8L,3L,5L,5L,7L,5L,7L,9L,1L,1L,5L,3L,3L,5L,1L,9L,6L,8L,1L,6L,3L,1L,9L,2L,6L,2L,3L,1L,2L,2L,4L,2L,9L,9L,0L,3L,4L,1L,4L,0L,6L,1L,1L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274420Inst : IEnumerable<long>
{
public static readonly long[] Value=A274420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274420.Bytes);
public long this[int i]=>Value[i];

public static A274420Inst Instance=new A274420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274421
{
public static readonly long[] Value={ 1L,0L,0L,3L,5L,2L,7L,8L,4L,7L,9L,7L,6L,8L,7L,8L,9L,1L,7L,1L,9L,1L,4L,7L,0L,0L,6L,8L,5L,1L,5L,8L,9L,0L,0L,2L,3L,8L,6L,5L,0L,3L,3L,3L,4L,9L,6L,0L,0L,2L,7L,5L,1L,3L,4L,0L,5L,4L,4L,5L,2L,5L,8L,0L,0L,6L,6L,3L,9L,1L,4L,1L,2L,4L,1L,3L,2L,6L,9L,5L,4L,1L,9L,0L,6L,3L,4L,9L,2L,4L,4L,6L,4L,1L,0L,3L,0L,3L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274421Inst : IEnumerable<long>
{
public static readonly long[] Value=A274421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274421.Bytes);
public long this[int i]=>Value[i];

public static A274421Inst Instance=new A274421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274422
{
public static readonly long[] Value={ 13L,17L,20L,23L,24L,34L,40L,82L,126L,200L,612L,1154L,1692L,2434L,2806L,3060L,3142L,4052L,4460L,4596L,5020L,5908L,6424L,7304L,7596L,8030L,8040L,9044L,11398L,12254L,12914L,13412L,13716L,16006L,16800L,18560L,22438L,23140L,24424L,24746L,25706L,28318L,29272L,30580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274422Inst : IEnumerable<long>
{
public static readonly long[] Value=A274422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274422.Bytes);
public long this[int i]=>Value[i];

public static A274422Inst Instance=new A274422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274423
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,44L,48L,66L,90L,108L,156L,206L,284L,854L,1002L,1188L,1194L,1212L,1320L,2234L,2460L,2792L,3336L,3478L,7096L,7164L,7218L,7236L,7752L,8304L,9164L,10272L,12090L,12594L,13322L,15530L,17038L,17162L,18026L,18212L,20412L,20494L,21966L,23374L,23518L,24664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274423Inst : IEnumerable<long>
{
public static readonly long[] Value=A274423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274423.Bytes);
public long this[int i]=>Value[i];

public static A274423Inst Instance=new A274423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274424
{
public static readonly long[] Value={ 13L,19L,48L,63L,67L,76L,94L,99L,123L,141L,143L,150L,179L,193L,247L,249L,285L,339L,404L,445L,517L,693L,711L,798L,969L,982L,1054L,1138L,1233L,1245L,1257L,1262L,1364L,1524L,1531L,1569L,1613L,1694L,1701L,1743L,1745L,1928L,2018L,2070L,2114L,2224L,2339L,2461L,2770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274424Inst : IEnumerable<long>
{
public static readonly long[] Value=A274424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274424.Bytes);
public long this[int i]=>Value[i];

public static A274424Inst Instance=new A274424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274425
{
public static readonly long[] Value={ 4L,6L,21L,18L,13L,11L,67L,48L,25L,149L,45L,174L,122L,31L,36L,139L,42L,64L,90L,57L,106L,325L,102L,216L,111L,258L,143L,321L,226L,472L,73L,60L,82L,184L,540L,135L,93L,264L,169L,130L,549L,53L,200L,180L,229L,99L,298L,622L,671L,358L,157L,117L,1487L,476L,1478L,85L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274425Inst : IEnumerable<long>
{
public static readonly long[] Value=A274425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274425.Bytes);
public long this[int i]=>Value[i];

public static A274425Inst Instance=new A274425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274426
{
public static readonly long[] Value={ 6L,10L,12L,15L,16L,21L,24L,26L,28L,33L,39L,40L,42L,44L,54L,63L,65L,68L,72L,77L,87L,102L,104L,105L,110L,116L,126L,141L,165L,168L,170L,178L,188L,198L,203L,228L,267L,272L,273L,275L,288L,304L,319L,329L,369L,432L,440L,442L,445L,466L,492L,517L,522L,532L,597L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274426Inst : IEnumerable<long>
{
public static readonly long[] Value=A274426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274426.Bytes);
public long this[int i]=>Value[i];

public static A274426Inst Instance=new A274426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274427
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,11L,12L,13L,16L,17L,18L,22L,23L,24L,25L,29L,30L,31L,32L,37L,38L,39L,40L,41L,46L,47L,48L,49L,50L,56L,57L,58L,59L,60L,61L,67L,68L,69L,70L,71L,72L,79L,80L,81L,82L,83L,84L,85L,92L,93L,94L,95L,96L,97L,98L,106L,107L,108L,109L,110L,111L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274427Inst : IEnumerable<long>
{
public static readonly long[] Value=A274427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274427.Bytes);
public long this[int i]=>Value[i];

public static A274427Inst Instance=new A274427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274428
{
public static readonly long[] Value={ 3L,6L,9L,10L,14L,15L,19L,20L,21L,26L,27L,28L,33L,34L,35L,36L,42L,43L,44L,45L,51L,52L,53L,54L,55L,62L,63L,64L,65L,66L,73L,74L,75L,76L,77L,78L,86L,87L,88L,89L,90L,91L,99L,100L,101L,102L,103L,104L,105L,114L,115L,116L,117L,118L,119L,120L,129L,130L,131L,132L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274428Inst : IEnumerable<long>
{
public static readonly long[] Value=A274428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274428.Bytes);
public long this[int i]=>Value[i];

public static A274428Inst Instance=new A274428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274429
{
public static readonly long[] Value={ 3L,4L,6L,7L,10L,11L,12L,15L,16L,18L,21L,24L,26L,28L,29L,33L,39L,40L,42L,44L,47L,54L,63L,65L,68L,72L,76L,77L,87L,102L,104L,105L,110L,116L,123L,126L,141L,165L,168L,170L,178L,188L,198L,199L,203L,228L,267L,272L,273L,275L,288L,304L,319L,322L,329L,369L,432L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274429Inst : IEnumerable<long>
{
public static readonly long[] Value=A274429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274429.Bytes);
public long this[int i]=>Value[i];

public static A274429Inst Instance=new A274429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274430
{
public static readonly long[] Value={ 3L,5L,8L,9L,12L,13L,17L,18L,19L,23L,24L,25L,30L,31L,32L,33L,38L,39L,40L,41L,47L,48L,49L,50L,51L,57L,58L,59L,60L,61L,68L,69L,70L,71L,72L,73L,80L,81L,82L,83L,84L,85L,93L,94L,95L,96L,97L,98L,99L,107L,108L,109L,110L,111L,112L,113L,122L,123L,124L,125L,126L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274430Inst : IEnumerable<long>
{
public static readonly long[] Value=A274430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274430.Bytes);
public long this[int i]=>Value[i];

public static A274430Inst Instance=new A274430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274431
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,10L,11L,14L,15L,16L,20L,21L,22L,26L,27L,28L,29L,34L,35L,36L,37L,42L,43L,44L,45L,46L,52L,53L,54L,55L,56L,62L,63L,64L,65L,66L,67L,74L,75L,76L,77L,78L,79L,86L,87L,88L,89L,90L,91L,92L,100L,101L,102L,103L,104L,105L,106L,114L,115L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274431Inst : IEnumerable<long>
{
public static readonly long[] Value=A274431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274431.Bytes);
public long this[int i]=>Value[i];

public static A274431Inst Instance=new A274431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274432
{
public static readonly long[] Value={ 3L,5L,9L,15L,17L,27L,31L,45L,51L,57L,85L,93L,105L,135L,153L,155L,171L,193L,255L,279L,285L,315L,355L,459L,465L,513L,525L,527L,579L,653L,765L,837L,855L,945L,965L,969L,1065L,1201L,1395L,1539L,1575L,1581L,1737L,1767L,1775L,1785L,1959L,2209L,2295L,2565L,2635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274432Inst : IEnumerable<long>
{
public static readonly long[] Value=A274432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274432.Bytes);
public long this[int i]=>Value[i];

public static A274432Inst Instance=new A274432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274433
{
public static readonly long[] Value={ 15L,27L,45L,51L,85L,93L,153L,155L,171L,279L,285L,315L,513L,525L,527L,579L,945L,965L,969L,1065L,1737L,1767L,1775L,1785L,1959L,3195L,3255L,3265L,3281L,3603L,5877L,5983L,5985L,6005L,6035L,6627L,10809L,11001L,11005L,11045L,11101L,12189L,19881L,20235L,20243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274433Inst : IEnumerable<long>
{
public static readonly long[] Value=A274433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274433.Bytes);
public long this[int i]=>Value[i];

public static A274433Inst Instance=new A274433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274434
{
public static readonly long[] Value={ 135L,255L,459L,465L,765L,837L,855L,1395L,1539L,1575L,1581L,2565L,2635L,2835L,2895L,2907L,4725L,4743L,4845L,5211L,5301L,5325L,5355L,8685L,8721L,8835L,8925L,9585L,9765L,9795L,9843L,15903L,15975L,16065L,16275L,16405L,17631L,17949L,17955L,18015L,18105L,29295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274434Inst : IEnumerable<long>
{
public static readonly long[] Value=A274434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274434.Bytes);
public long this[int i]=>Value[i];

public static A274434Inst Instance=new A274434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274435
{
public static readonly long[] Value={ 1L,3L,9L,14L,26L,27L,28L,35L,38L,42L,52L,56L,62L,65L,74L,76L,77L,78L,81L,84L,86L,95L,98L,104L,105L,112L,114L,119L,122L,124L,126L,134L,143L,146L,148L,152L,155L,156L,158L,161L,168L,172L,175L,185L,186L,194L,195L,196L,203L,206L,208L,209L,215L,218L,221L,222L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274435Inst : IEnumerable<long>
{
public static readonly long[] Value=A274435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274435.Bytes);
public long this[int i]=>Value[i];

public static A274435Inst Instance=new A274435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274564
{
public static readonly long[] Value={ 10L,11L,15L,19L,24L,33L,105L,33705L,33624064L,2199041081344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274564Inst : IEnumerable<long>
{
public static readonly long[] Value=A274564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274564.Bytes);
public long this[int i]=>Value[i];

public static A274564Inst Instance=new A274564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274565
{
public static readonly long[] Value={ 14L,176L,1376L,3230L,3770L,6848L,114256L,125696L,544310L,561824L,740870L,2075648L,4199030L,4607296L,8436950L,33468416L,134045696L,199272950L,624032630L,1113445430L,1550860550L,85905593344L,2199001235456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274565Inst : IEnumerable<long>
{
public static readonly long[] Value=A274565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274565.Bytes);
public long this[int i]=>Value[i];

public static A274565Inst Instance=new A274565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274566
{
public static readonly long[] Value={ 11L,12L,14L,22L,40L,42L,46L,154L,190L,2656L,6490L,44650L,318250L,1360810L,1503370L,1788490L,3214090L,103712410L,3915380170L,6077111050L,9796360330L,10828121356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274566Inst : IEnumerable<long>
{
public static readonly long[] Value=A274566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274566.Bytes);
public long this[int i]=>Value[i];

public static A274566Inst Instance=new A274566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274567
{
public static readonly long[] Value={ 3L,81L,51L,291L,1251L,339L,62499L,1971L,5201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274567Inst : IEnumerable<long>
{
public static readonly long[] Value=A274567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274567.Bytes);
public long this[int i]=>Value[i];

public static A274567Inst Instance=new A274567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274568
{
public static readonly long[] Value={ 2L,0L,2L,3L,7L,2L,3L,2L,9L,2L,3L,13L,2L,7L,3L,2L,15L,2L,3L,19L,2L,9L,3L,7L,2L,21L,2L,3L,27L,2L,13L,3L,2L,7L,9L,2L,3L,33L,2L,15L,3L,2L,7L,2L,3L,37L,2L,9L,19L,3L,13L,2L,39L,2L,3L,7L,49L,2L,21L,3L,2L,9L,15L,2L,3L,7L,2L,3L,2L,13L,27L,51L,2L,3L,55L,2L,7L,9L,3L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274568Inst : IEnumerable<long>
{
public static readonly long[] Value=A274568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274568.Bytes);
public long this[int i]=>Value[i];

public static A274568Inst Instance=new A274568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274569
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,2L,9L,1L,-29L,-24L,88L,153L,-234L,-796L,327L,3509L,1301L,-13924L,-16511L,47366L,109639L,-121886L,-583921L,79027L,2691465L,1808431L,-10775705L,-16965876L,35686874L,107103382L,-77820607L,-560120299L,-95094380L,2536045800L,2521002564L,-9832805334L,-19928899203L,29983217002L,118838292930L,-44109504096L,-600237397739L,-285632368107L,2622720919077L,3530864633371L,-9611558966277L,-24857829812388L,25472208656701L,140445352832736L,-5891793579597L,-680872708032455L,-537359624615144L,2838471301330439L,4957200244969051L,-9600812793387365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274569Inst : IEnumerable<long>
{
public static readonly long[] Value=A274569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274569.Bytes);
public long this[int i]=>Value[i];

public static A274569Inst Instance=new A274569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274570
{
public static readonly long[] Value={ 1L,1L,1L,7L,2L,1L,127L,20L,3L,1L,4377L,470L,39L,4L,1L,245481L,19912L,1125L,64L,5L,1L,20391523L,1326382L,56505L,2188L,95L,6L,1L,2354116899L,127677580L,4354923L,127056L,3755L,132L,7L,1L,360734454993L,16767030632L,476265591L,11117244L,247465L,5922L,175L,8L,1L,70865037282673L,2880746218304L,70056231213L,1360983976L,24228925L,436632L,8785L,224L,9L,1L,17367953099244051L,627213971899610L,13329387478113L,221585119536L,3281909155L,47290506L,716457L,12440L,279L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274570Inst : IEnumerable<long>
{
public static readonly long[] Value=A274570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274570.Bytes);
public long this[int i]=>Value[i];

public static A274570Inst Instance=new A274570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274571
{
public static readonly BigInteger[] Value={ 1L,1L,7L,127L,4377L,245481L,20391523L,2354116899L,360734454993L,70865037282673L,17367953099244051L,5195706189463681299L,BigInteger.Parse("1863485648739527246569"),BigInteger.Parse("789370246456579516316121"),BigInteger.Parse("389929989984983783920348611"),BigInteger.Parse("222178771969671609391720410691"),BigInteger.Parse("144648509476124539709343154760897"),BigInteger.Parse("106712830948451223242311469280356609"),BigInteger.Parse("88557950557114913966623605248882438755"),BigInteger.Parse("82132537612235618834557329353828430430755") };
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
public class A274571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274571Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274571.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274571.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274571Inst Instance=new A274571Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274572
{
public static readonly BigInteger[] Value={ 1L,2L,20L,470L,19912L,1326382L,127677580L,16767030632L,2880746218304L,627213971899610L,168767535712912684L,BigInteger.Parse("54994347890521005100"),BigInteger.Parse("21342142821229037730064"),BigInteger.Parse("9726400286221416303901358"),BigInteger.Parse("5143644030714149522751534524"),BigInteger.Parse("3124088412968372614077895431788"),BigInteger.Parse("2159818183532141245447039295746240"),BigInteger.Parse("1686295004858842334963772859214802354"),BigInteger.Parse("1476540037893212558044217633785452773068"),BigInteger.Parse("1440964034588041764141738802548853847618732") };
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
public class A274572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274572Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274572.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274572.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274572Inst Instance=new A274572Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274573
{
public static readonly BigInteger[] Value={ 1L,3L,39L,1125L,56505L,4354923L,476265591L,70056231213L,13329387478113L,3184105899176739L,932720103991595919L,BigInteger.Parse("328710383679927689157"),BigInteger.Parse("137188135970104212440721"),BigInteger.Parse("66909975066823379752742835"),BigInteger.Parse("37706189062081696231083478647"),BigInteger.Parse("24312515006613477431766856702797"),BigInteger.Parse("17784145956730483348850500758855969"),BigInteger.Parse("14647274671009402833580157237962722147"),BigInteger.Parse("13492886769176913829412675003231182928079") };
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
public class A274573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274573Inst Instance=new A274573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274574
{
public static readonly BigInteger[] Value={ 1L,2L,39L,2188L,247465L,47290506L,13732594855L,5645761143968L,3124313624563281L,2240929551882269890L,BigInteger.Parse("2023001689428835457551"),BigInteger.Parse("2245340983227461222262600"),BigInteger.Parse("3005921392102922941037743561"),BigInteger.Parse("4777188534537036418050441999458"),BigInteger.Parse("8892651921874938986718539648539335"),BigInteger.Parse("19167346139929272962512547586833106016"),BigInteger.Parse("47363669252787891219004826832547428944065"),BigInteger.Parse("133017373943189884985366059167726505579520322"),BigInteger.Parse("421334607602498277189468756234637306051458074191"),BigInteger.Parse("1495034827615578030423476599123008111000477082402040"),BigInteger.Parse("5906697677063490360959940664316005473632429506949424681") };
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
public class A274574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274574Inst Instance=new A274574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274575
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,0L,0L,2L,-3L,-1L,-1L,1L,-1L,1L,1L,3L,-4L,-2L,-2L,0L,-2L,0L,0L,2L,-2L,0L,0L,2L,0L,2L,2L,4L,-5L,-3L,-3L,-1L,-3L,-1L,-1L,1L,-3L,-1L,-1L,1L,-1L,1L,1L,3L,-3L,-1L,-1L,1L,-1L,1L,1L,3L,-1L,1L,1L,3L,1L,3L,3L,5L,-6L,-4L,-4L,-2L,-4L,-2L,-2L,0L,-4L,-2L,-2L,0L,-2L,0L,0L,2L,-4L,-2L,-2L,0L,-2L,0L,0L,2L,-2L,0L,0L,2L,0L,2L,2L,4L,-4L,-2L,-2L,0L,-2L,0L,0L,2L,-2L,0L,0L,2L,0L,2L,2L,4L,-2L,0L,0L,2L,0L,2L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274575Inst : IEnumerable<long>
{
public static readonly long[] Value=A274575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274575.Bytes);
public long this[int i]=>Value[i];

public static A274575Inst Instance=new A274575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274576
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,2L,1L,2L,0L,3L,1L,3L,0L,4L,2L,4L,1L,5L,2L,5L,0L,6L,3L,6L,1L,7L,3L,7L,0L,8L,4L,8L,2L,9L,4L,9L,1L,10L,5L,10L,2L,11L,5L,11L,0L,12L,6L,12L,3L,13L,6L,13L,1L,14L,7L,14L,3L,15L,7L,15L,0L,16L,8L,16L,4L,17L,8L,17L,2L,18L,9L,18L,4L,19L,9L,19L,1L,20L,10L,20L,5L,21L,10L,21L,2L,22L,11L,22L,5L,23L,11L,23L,0L,24L,12L,24L,6L,25L,12L,25L,3L,26L,13L,26L,6L,27L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274576Inst : IEnumerable<long>
{
public static readonly long[] Value=A274576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274576.Bytes);
public long this[int i]=>Value[i];

public static A274576Inst Instance=new A274576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274577
{
public static readonly long[] Value={ 18L,72L,98L,162L,242L,245L,288L,392L,490L,605L,648L,722L,882L,968L,980L,1058L,1152L,1210L,1225L,1458L,1568L,1805L,1922L,1960L,2178L,2205L,2420L,2450L,2592L,2645L,2888L,3025L,3528L,3610L,3698L,3872L,3920L,4232L,4410L,4418L,4608L,4693L,4802L,4805L,4840L,4900L,5290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274577Inst : IEnumerable<long>
{
public static readonly long[] Value=A274577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274577.Bytes);
public long this[int i]=>Value[i];

public static A274577Inst Instance=new A274577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274578
{
public static readonly long[] Value={ 2305L,2629L,4117L,7060L,37444L,46081L,113320L,208545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274578Inst : IEnumerable<long>
{
public static readonly long[] Value=A274578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274578.Bytes);
public long this[int i]=>Value[i];

public static A274578Inst Instance=new A274578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274579
{
public static readonly long[] Value={ 0L,1L,7L,27L,540L,2002L,10660L,39501L,779247L,2887450L,15372280L,56960982L,1123674201L,4163701465L,22166817667L,82137697110L,1620337419162L,6004054625647L,31964535704101L,118442502272205L,2336525434757970L,8657842606482076L,46092838318496542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274579Inst : IEnumerable<long>
{
public static readonly long[] Value=A274579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274579.Bytes);
public long this[int i]=>Value[i];

public static A274579Inst Instance=new A274579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274596
{
public static readonly long[] Value={ 1L,3L,7L,19L,44L,98L,213L,448L,918L,1832L,3584L,6882L,13012L,24220L,44480L,80678L,144697L,256775L,451305L,786008L,1357414L,2325540L,3954366L,6676369L,11196599L,18657454L,30901434L,50884452L,83327163L,135733071L,219978688L,354780782L,569519349L,910130189L,1448166991L,2294680459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274596Inst : IEnumerable<long>
{
public static readonly long[] Value=A274596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274596.Bytes);
public long this[int i]=>Value[i];

public static A274596Inst Instance=new A274596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274597
{
public static readonly long[] Value={ 1L,4L,10L,28L,68L,158L,350L,750L,1559L,3170L,6292L,12252L,23445L,44164L,81995L,150288L,272150L,487388L,863887L,1516592L,2638648L,4552488L,7792566L,13239698L,22336630L,37433466L,62337628L,103186612L,169824540L,277967860L,452594316L,733229626L,1182159039L,1897140990L,3031012912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274597Inst : IEnumerable<long>
{
public static readonly long[] Value=A274597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274597.Bytes);
public long this[int i]=>Value[i];

public static A274597Inst Instance=new A274597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274598
{
public static readonly long[] Value={ 1L,5L,14L,40L,103L,247L,567L,1252L,2668L,5539L,11214L,22247L,43300L,82871L,156152L,290202L,532430L,965395L,1731351L,3073660L,5404984L,9420512L,16282463L,27922063L,47527430L,80331385L,134873275L,225015223L,373141724L,615224276L,1008792896L,1645443771L,2670372299L,4312780664L,6933014899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274598Inst : IEnumerable<long>
{
public static readonly long[] Value=A274598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274598.Bytes);
public long this[int i]=>Value[i];

public static A274598Inst Instance=new A274598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274599
{
public static readonly long[] Value={ 1L,6L,19L,56L,152L,378L,898L,2042L,4476L,9526L,19740L,39978L,79342L,154650L,296489L,560022L,1043404L,1919708L,3491081L,6280514L,11185375L,19734004L,34509347L,59847208L,102976946L,175877782L,298279841L,502496682L,841161007L,1399559416L,2315201903L,3808746574L,6232651705L,10147431024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274599Inst : IEnumerable<long>
{
public static readonly long[] Value=A274599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274599.Bytes);
public long this[int i]=>Value[i];

public static A274599Inst Instance=new A274599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274600
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,2L,7L,59L,616L,6992L,90847L,1352549L,22591681L,417527582L,8465505412L,186906393764L,4463901355096L,114672825810272L,3153127461349327L,92405864554182329L,2875362251645606611L,BigInteger.Parse("94680648376734042062"),BigInteger.Parse("3289274269898822961967"),BigInteger.Parse("120235993277078434540619") };
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
public class A274600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274600Inst Instance=new A274600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274601
{
public static readonly long[] Value={ 1L,4L,3L,2L,13L,12L,11L,10L,9L,8L,7L,6L,5L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,121L,120L,119L,118L,117L,116L,115L,114L,113L,112L,111L,110L,109L,108L,107L,106L,105L,104L,103L,102L,101L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274601Inst : IEnumerable<long>
{
public static readonly long[] Value=A274601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274601.Bytes);
public long this[int i]=>Value[i];

public static A274601Inst Instance=new A274601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274602
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,2L,3L,11L,9L,3L,4L,19L,20L,13L,4L,5L,29L,35L,29L,17L,5L,6L,41L,54L,51L,38L,21L,6L,7L,55L,77L,79L,67L,47L,25L,7L,8L,71L,104L,113L,104L,83L,56L,29L,8L,9L,89L,135L,153L,149L,129L,99L,65L,33L,9L,10L,109L,170L,199L,202L,185L,154L,115L,74L,37L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274602Inst : IEnumerable<long>
{
public static readonly long[] Value=A274602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274602.Bytes);
public long this[int i]=>Value[i];

public static A274602Inst Instance=new A274602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274603
{
public static readonly BigInteger[] Value={ 45L,4455L,436590L,42781410L,4192141635L,410787098865L,40252943547180L,3944377680524820L,386508759747885225L,BigInteger.Parse("37873914077612227275"),BigInteger.Parse("3711257070846250387770"),BigInteger.Parse("363665319028854925774230"),BigInteger.Parse("35635490007756936475486815"),BigInteger.Parse("3491914355441150919671933685") };
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
public class A274603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274603Inst Instance=new A274603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274604
{
public static readonly long[] Value={ 0L,1L,0L,2L,3L,3L,1L,4L,3L,5L,5L,6L,8L,7L,4L,8L,9L,9L,7L,10L,10L,11L,10L,12L,10L,13L,14L,14L,17L,15L,11L,16L,15L,17L,17L,18L,20L,19L,16L,20L,20L,21L,20L,22L,23L,23L,21L,24L,26L,25L,22L,26L,25L,27L,27L,28L,25L,29L,31L,30L,34L,31L,26L,32L,33L,33L,31L,34L,34L,35L,34L,36L,34L,37L,38L,38L,41L,39L,35L,40L,40L,41L,40L,42L,43L,43L,41L,44L,43L,45L,45L,46L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274604Inst : IEnumerable<long>
{
public static readonly long[] Value=A274604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274604.Bytes);
public long this[int i]=>Value[i];

public static A274604Inst Instance=new A274604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274605
{
public static readonly long[] Value={ 3L,6L,8L,14L,60L,72L,216L,328L,361L,23268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274605Inst : IEnumerable<long>
{
public static readonly long[] Value=A274605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274605.Bytes);
public long this[int i]=>Value[i];

public static A274605Inst Instance=new A274605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274606
{
public static readonly long[] Value={ 1L,10L,2L,11L,5L,12L,60L,3L,30L,6L,31L,15L,32L,160L,4L,20L,21L,210L,7L,70L,14L,71L,35L,72L,360L,8L,40L,41L,410L,82L,16L,80L,81L,810L,9L,90L,18L,91L,45L,92L,460L,23L,230L,46L,231L,115L,22L,110L,55L,25L,50L,51L,510L,17L,170L,34L,171L,85L,172L,860L,43L,430L,86L,431L,215L,42L,211L,105L,100L,101L,1010L,202L,200L,201L,2010L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274606Inst : IEnumerable<long>
{
public static readonly long[] Value=A274606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274606.Bytes);
public long this[int i]=>Value[i];

public static A274606Inst Instance=new A274606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274607
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,7L,10L,12L,16L,11L,15L,20L,24L,32L,13L,25L,30L,40L,48L,64L,17L,35L,50L,60L,80L,96L,128L,19L,55L,75L,100L,120L,160L,192L,256L,23L,77L,125L,150L,200L,240L,320L,384L,512L,29L,121L,175L,250L,300L,400L,480L,640L,768L,1024L,31L,143L,275L,375L,500L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274607Inst : IEnumerable<long>
{
public static readonly long[] Value=A274607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274607.Bytes);
public long this[int i]=>Value[i];

public static A274607Inst Instance=new A274607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274608
{
public static readonly long[] Value={ 2L,3L,6L,5L,10L,30L,7L,15L,42L,210L,11L,22L,70L,330L,2310L,13L,35L,110L,462L,2730L,30030L,17L,55L,165L,770L,4290L,39270L,510510L,19L,77L,231L,1155L,6006L,46410L,570570L,9699690L,23L,91L,385L,1430L,10010L,72930L,746130L,11741730L,223092870L,29L,143L,455L,2145L,15015L,102102L,903210L,14804790L,281291010L,6469693230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274608Inst : IEnumerable<long>
{
public static readonly long[] Value=A274608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274608.Bytes);
public long this[int i]=>Value[i];

public static A274608Inst Instance=new A274608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274609
{
public static readonly long[] Value={ 2L,3L,31L,331L,1171L,2011L,2281L,3181L,4621L,4861L,6151L,6211L,6961L,7951L,8521L,9151L,11251L,12211L,13411L,15661L,17491L,18121L,19141L,20641L,22531L,23071L,23581L,24631L,25411L,26041L,26161L,26431L,26641L,27091L,27271L,27361L,27691L,28201L,28621L,29221L,31891L,33151L,34261L,35491L,36451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274609Inst : IEnumerable<long>
{
public static readonly long[] Value=A274609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274609.Bytes);
public long this[int i]=>Value[i];

public static A274609Inst Instance=new A274609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274610
{
public static readonly long[] Value={ 1L,22L,118L,358L,1678L,3478L,5038L,6238L,10198L,17158L,19318L,22798L,32758L,36478L,52438L,58078L,72358L,109558L,143638L,177238L,212518L,229438L,248998L,259078L,326038L,410878L,434278L,502678L,737878L,863038L,982078L,1062958L,1100398L,1274638L,1442398L,1515358L,1559998L,1635838L,1907158L,2042038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274610Inst : IEnumerable<long>
{
public static readonly long[] Value=A274610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274610.Bytes);
public long this[int i]=>Value[i];

public static A274610Inst Instance=new A274610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274611
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,1L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,3L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,5L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,7L,114L,116L,118L,120L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274611Inst : IEnumerable<long>
{
public static readonly long[] Value=A274611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274611.Bytes);
public long this[int i]=>Value[i];

public static A274611Inst Instance=new A274611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274644
{
public static readonly BigInteger[] Value={ 1L,6L,71L,1266L,30206L,902796L,32420011L,1359292626L,65164480466L,3515569641156L,210779736073446L,13903319821066836L,1000559812125494272L,BigInteger.Parse("78012524487061307392"),BigInteger.Parse("6550837823204595073024"),BigInteger.Parse("589404446176366091567104"),BigInteger.Parse("56568586570039156279345152"),BigInteger.Parse("5768723174387470083567910912"),BigInteger.Parse("622900652040379384928709640192") };
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
public class A274644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274644.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274644Inst Instance=new A274644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274645
{
public static readonly BigInteger[] Value={ 1L,20L,1301L,177260L,41385102L,14760468600L,7465847167005L,5083351577582300L,4483012419041095680L,BigInteger.Parse("4971032496120058085376"),BigInteger.Parse("6769339545226095791964160"),BigInteger.Parse("11105730970797793499164966912"),BigInteger.Parse("21604722570792867452576610648064") };
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
public class A274645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274645.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274645Inst Instance=new A274645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274646
{
public static readonly BigInteger[] Value={ 1L,70L,26599L,29609650L,72574079902L,332014782982540L,2545213373338499072L,BigInteger.Parse("30302687687176712355840"),BigInteger.Parse("529556871638491591748878336"),BigInteger.Parse("13004213964445490176628310933504"),BigInteger.Parse("433440210434110194677894532074307584") };
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
public class A274646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274646Inst Instance=new A274646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274647
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,62L,42L,63L,41L,18L,66L,91L,65L,38L,94L,123L,93L,124L,92L,59L,127L,162L,126L,89L,51L,90L,50L,132L,174L,131L,87L,177L,223L,176L,128L,79L,29L,80L,28L,81L,27L,82L,26L,83L,141L,200L,140L,201L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274647Inst : IEnumerable<long>
{
public static readonly long[] Value=A274647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274647.Bytes);
public long this[int i]=>Value[i];

public static A274647Inst Instance=new A274647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274648
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,5L,45L,66L,44L,67L,19L,69L,17L,71L,15L,73L,103L,72L,40L,106L,38L,108L,36L,110L,34L,112L,32L,114L,30L,116L,28L,118L,26L,120L,168L,119L,169L,16L,68L,121L,175L,65L,177L,63L,179L,61L,181L,59L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274648Inst : IEnumerable<long>
{
public static readonly long[] Value=A274648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274648.Bytes);
public long this[int i]=>Value[i];

public static A274648Inst Instance=new A274648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274649
{
public static readonly long[] Value={ 5L,3L,30915397L,11339869L,3L,5L,859L,3L,41L,233L,3L,7L,4175194313L,3L,307L,5L,3L,1459L,7L,3L,5L,9907L,3L,647L,13L,3L,31L,11L,3L,193L,5L,3L,7L,2939L,3L,5L,3167L,3L,11L,7L,3L,1321L,86629L,3L,17L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274649Inst : IEnumerable<long>
{
public static readonly long[] Value=A274649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274649.Bytes);
public long this[int i]=>Value[i];

public static A274649Inst Instance=new A274649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274650
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,1L,2L,4L,3L,5L,5L,1L,0L,2L,3L,4L,3L,5L,1L,6L,7L,6L,7L,2L,0L,5L,4L,8L,8L,5L,9L,4L,7L,2L,10L,6L,7L,10L,8L,3L,0L,6L,9L,5L,4L,11L,6L,12L,7L,1L,8L,3L,10L,9L,13L,9L,8L,4L,11L,2L,0L,1L,12L,6L,7L,10L,10L,11L,7L,12L,4L,3L,2L,9L,8L,14L,13L,15L,12L,9L,10L,6L,8L,1L,0L,11L,7L,4L,16L,14L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274650Inst : IEnumerable<long>
{
public static readonly long[] Value=A274650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274650.Bytes);
public long this[int i]=>Value[i];

public static A274650Inst Instance=new A274650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274651
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,2L,3L,5L,4L,6L,6L,2L,1L,3L,4L,5L,4L,6L,2L,7L,8L,7L,8L,3L,1L,6L,5L,9L,9L,6L,10L,5L,8L,3L,11L,7L,8L,11L,9L,4L,1L,7L,10L,6L,5L,12L,7L,13L,8L,2L,9L,4L,11L,10L,14L,10L,9L,5L,12L,3L,1L,2L,13L,7L,8L,11L,11L,12L,8L,13L,5L,4L,3L,10L,9L,15L,14L,16L,13L,10L,11L,7L,9L,2L,1L,12L,8L,5L,17L,15L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274651Inst : IEnumerable<long>
{
public static readonly long[] Value=A274651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274651.Bytes);
public long this[int i]=>Value[i];

public static A274651Inst Instance=new A274651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274652
{
public static readonly long[] Value={ 0L,3L,6L,12L,13L,25L,36L,43L,57L,67L,100L,134L,115L,163L,153L,186L,185L,248L,277L,258L,306L,366L,370L,381L,528L,471L,607L,662L,610L,706L,778L,760L,783L,782L,950L,970L,975L,1194L,1206L,1175L,1301L,1393L,1438L,1261L,1584L,1549L,1592L,1645L,1776L,1783L,2010L,1956L,1953L,2353L,2441L,2258L,2468L,2342L,2635L,2663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274652Inst : IEnumerable<long>
{
public static readonly long[] Value=A274652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274652.Bytes);
public long this[int i]=>Value[i];

public static A274652Inst Instance=new A274652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274653
{
public static readonly BigInteger[] Value={ 0L,1L,21L,185L,18655L,307503L,12548151L,305496477L,138343008375L,4464248592375L,323592065474535L,13015087974100485L,2301190559547593805L,BigInteger.Parse("110887163426713235625"),BigInteger.Parse("11570760017278599886875"),BigInteger.Parse("649837647729572203369125"),BigInteger.Parse("1250848387902442801195686375"),BigInteger.Parse("80233244659365977333374518375") };
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
public class A274653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274653Inst Instance=new A274653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274654
{
public static readonly long[] Value={ 1L,2L,32L,128L,4096L,16384L,131072L,524288L,33554432L,134217728L,1073741824L,4294967296L,68719476736L,274877906944L,2199023255552L,8796093022208L,1125899906842624L,4503599627370496L,36028797018963968L,144115188075855872L,2305843009213693952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274654Inst : IEnumerable<long>
{
public static readonly long[] Value=A274654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274654.Bytes);
public long this[int i]=>Value[i];

public static A274654Inst Instance=new A274654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274655
{
public static readonly BigInteger[] Value={ 0L,1L,21L,185L,18655L,102501L,1394239L,33944053L,3074289075L,99205524275L,7190934788323L,4590859955591L,2435122285235549L,23468182735812325L,38870446014205425L,145536272272236993L,BigInteger.Parse("280137373064011153371"),BigInteger.Parse("1633533514217325226737"),BigInteger.Parse("74200692627870055029475") };
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
public class A274655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274655Inst Instance=new A274655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274656
{
public static readonly BigInteger[] Value={ 1L,2L,64L,768L,98304L,655360L,10485760L,293601280L,30064771072L,1082331758592L,86586540687360L,60473139527680L,34832528367943680L,362258295026614272L,644014746713980928L,2576058986855923712L,BigInteger.Parse("5275768805080931762176"),BigInteger.Parse("32613843522318487257088") };
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
public class A274656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274656Inst Instance=new A274656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274657
{
public static readonly BigInteger[] Value={ 1L,1L,9L,75L,3675L,59535L,2401245L,57972915L,13043905875L,418854310875L,30241281245175L,1212400457192925L,213786613951685775L,10278202593831046875UL,BigInteger.Parse("1070401384414690453125"),BigInteger.Parse("60013837619516978071875"),BigInteger.Parse("57673297952355815927071875"),BigInteger.Parse("3694483615889146090857721875") };
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
public class A274657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274657.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274657Inst Instance=new A274657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274658
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,1L,7L,1L,3L,9L,1L,11L,1L,13L,1L,3L,5L,15L,1L,17L,1L,19L,1L,3L,7L,21L,1L,23L,1L,5L,25L,1L,3L,9L,27L,1L,29L,1L,31L,1L,3L,11L,33L,1L,5L,7L,35L,1L,37L,1L,3L,13L,39L,1L,41L,1L,43L,1L,3L,5L,9L,15L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274658Inst : IEnumerable<long>
{
public static readonly long[] Value=A274658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274658.Bytes);
public long this[int i]=>Value[i];

public static A274658Inst Instance=new A274658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274659
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,1L,-1L,-2L,0L,1L,2L,1L,-2L,0L,1L,2L,3L,0L,-2L,0L,1L,-4L,-2L,3L,0L,-2L,0L,1L,-4L,-5L,1L,3L,0L,-2L,0L,1L,7L,3L,-6L,0L,3L,0L,-2L,0L,1L,7L,9L,-2L,-6L,0L,3L,0L,-2L,0L,1L,-11L,-5L,11L,1L,-6L,0L,3L,0L,-2L,0L,1L,-11L,-15L,3L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L,17L,9L,-17L,-2L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274659Inst : IEnumerable<long>
{
public static readonly long[] Value=A274659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274659.Bytes);
public long this[int i]=>Value[i];

public static A274659Inst Instance=new A274659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274804
{
public static readonly BigInteger[] Value={ 1L,1L,4L,14L,69L,367L,2284L,15430L,115146L,924555L,7991892L,73547322L,718621516L,7410375897L,80405501540L,914492881330L,10873902417225L,134808633318271L,1738734267608613L,23282225008741565L,323082222240744379L,4638440974576329923L,BigInteger.Parse("68794595993688306903") };
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
public class A274804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274804Inst Instance=new A274804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274805
{
public static readonly BigInteger[] Value={ 1L,2L,-3L,-6L,45L,11L,-1372L,4298L,59244L,-573463L,-2432023L,75984243L,-136498141L,-10881169822L,100704750342L,1514280063802L,-36086469752977L,-102642110690866L,11883894518252419L,-77863424962770751L,-3705485804176583500L,BigInteger.Parse("71306510264347489177") };
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
public class A274805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274805Inst Instance=new A274805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274806
{
public static readonly BigInteger[] Value={ 1L,0L,0L,48L,960L,92160L,862848000L,300286741708800L,BigInteger.Parse("1835082219864832081920") };
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
public class A274806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274806Inst Instance=new A274806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274807
{
public static readonly long[] Value={ 21735L,58695L,93015L,94094L,111111L,123255L,137240L,140504L,159159L,162944L,175959L,178815L,190280L,202215L,214136L,215270L,224895L,226610L,233624L,239624L,239784L,242535L,246375L,248744L,250263L,251559L,258687L,259064L,259335L,260337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274807Inst : IEnumerable<long>
{
public static readonly long[] Value=A274807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274807.Bytes);
public long this[int i]=>Value[i];

public static A274807Inst Instance=new A274807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274808
{
public static readonly long[] Value={ 2035980763136L,218010592018431L,413918027251712L,921717810593792L,957141387771903L,1017635547447296L,1119195504115712L,1842969898713087L,2057374251679743L,2435402979278847L,2913421405257728L,3039120499474431L,3129396016513023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274808Inst : IEnumerable<long>
{
public static readonly long[] Value=A274808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274808.Bytes);
public long this[int i]=>Value[i];

public static A274808Inst Instance=new A274808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274809
{
public static readonly long[] Value={ 223244L,261855L,285075L,346724L,395675L,556100L,607724L,748475L,775424L,790075L,830907L,875924L,912950L,934724L,938475L,940653L,971424L,1137824L,1187900L,1239524L,1374075L,1384299L,1413675L,1462527L,1466675L,1531647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274809Inst : IEnumerable<long>
{
public static readonly long[] Value=A274809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274809.Bytes);
public long this[int i]=>Value[i];

public static A274809Inst Instance=new A274809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274810
{
public static readonly long[] Value={ 9399153082499072L,20164508489351168L,21992587709382656L,25039386409435136L,25537472011436031L,26756191491457023L,45443223518445567L,47474422651813887L,59772891590033408L,64241529683443712L,73381925783601152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274810Inst : IEnumerable<long>
{
public static readonly long[] Value=A274810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274810.Bytes);
public long this[int i]=>Value[i];

public static A274810Inst Instance=new A274810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274811
{
public static readonly long[] Value={ 458864L,614384L,879375L,948752L,1003023L,1057455L,1080624L,1083375L,1101680L,1171664L,1174095L,1207791L,1271295L,1275344L,1283120L,1346960L,1420496L,1428272L,1460624L,1477359L,1524015L,1562895L,1609712L,1677104L,1686015L,1827440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274811Inst : IEnumerable<long>
{
public static readonly long[] Value=A274811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274811.Bytes);
public long this[int i]=>Value[i];

public static A274811Inst Instance=new A274811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274812
{
public static readonly long[] Value={ 41680575L,146109375L,173996991L,210075200L,301241024L,307619775L,345691071L,387121599L,491184575L,503761599L,580150592L,613216575L,735890624L,960710463L,1079589951L,1182852800L,1187518400L,1406368575L,1413366975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274812Inst : IEnumerable<long>
{
public static readonly long[] Value=A274812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274812.Bytes);
public long this[int i]=>Value[i];

public static A274812Inst Instance=new A274812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274813
{
public static readonly long[] Value={ 701443071L,1064240127L,1112542208L,2515428351L,2563730432L,3531189248L,4329413631L,4813143039L,5538737151L,5901534207L,6627128319L,6868993023L,7159159808L,7642889216L,7957384191L,8803910655L,10134166527L,11270859776L,13447642112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274813Inst : IEnumerable<long>
{
public static readonly long[] Value=A274813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274813.Bytes);
public long this[int i]=>Value[i];

public static A274813Inst Instance=new A274813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274814
{
public static readonly BigInteger[] Value={ 2503092614937444351L,BigInteger.Parse("23558004745831448576"),BigInteger.Parse("34092301537081556991"),BigInteger.Parse("39615852614588039168"),BigInteger.Parse("40936630136879448063"),BigInteger.Parse("74890469244315631616"),BigInteger.Parse("87526152813173276672"),BigInteger.Parse("97270719381369782271") };
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
public class A274814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274814Inst Instance=new A274814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274815
{
public static readonly long[] Value={ 201824L,441440L,477224L,538460L,633555L,667575L,705159L,708344L,775124L,796575L,801800L,840735L,846944L,850815L,994175L,1037475L,1068704L,1165724L,1210824L,1235168L,1241954L,1248884L,1259180L,1266264L,1283975L,1290860L,1316600L,1339974L,1386315L,1391775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274815Inst : IEnumerable<long>
{
public static readonly long[] Value=A274815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274815.Bytes);
public long this[int i]=>Value[i];

public static A274815Inst Instance=new A274815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274816
{
public static readonly long[] Value={ 2707370000L,22155470000L,23657996592L,32479730000L,53873960624L,68830910000L,71740379375L,75117480624L,103837490000L,129539709999L,129565220624L,157312019375L,163086669999L,173918639375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274816Inst : IEnumerable<long>
{
public static readonly long[] Value=A274816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274816.Bytes);
public long this[int i]=>Value[i];

public static A274816Inst Instance=new A274816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274817
{
public static readonly long[] Value={ 1L,-1L,4L,8L,19L,32L,64L,125L,256L,512L,1027L,2048L,4096L,8189L,16384L,32768L,65539L,131072L,262144L,524285L,1048576L,2097152L,4194307L,8388608L,16777216L,33554429L,67108864L,134217728L,268435459L,536870912L,1073741824L,2147483645L,4294967296L,8589934592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274817Inst : IEnumerable<long>
{
public static readonly long[] Value=A274817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274817.Bytes);
public long this[int i]=>Value[i];

public static A274817Inst Instance=new A274817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274818
{
public static readonly long[] Value={ 1L,0L,4L,3L,0L,0L,12L,16L,10L,0L,28L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274818Inst : IEnumerable<long>
{
public static readonly long[] Value=A274818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274818.Bytes);
public long this[int i]=>Value[i];

public static A274818Inst Instance=new A274818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274819
{
public static readonly long[] Value={ 1L,0L,4L,3L,0L,0L,12L,16L,10L,6L,21L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274819Inst : IEnumerable<long>
{
public static readonly long[] Value=A274819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274819.Bytes);
public long this[int i]=>Value[i];

public static A274819Inst Instance=new A274819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275140
{
public static readonly long[] Value={ 16L,432L,1216L,6464L,32384L,165568L,841536L,4283968L,21800000L,110943552L,564600384L,2873300800L,14622480448L,74415076672L,378704836160L,1927261993792L,9808004727872L,49913793159488L,254015655387712L,1292707868694336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275140Inst : IEnumerable<long>
{
public static readonly long[] Value=A275140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275140.Bytes);
public long this[int i]=>Value[i];

public static A275140Inst Instance=new A275140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275141
{
public static readonly long[] Value={ 32L,1296L,2816L,17872L,107472L,663904L,4055152L,24875600L,152379136L,933805200L,5721947536L,35062147296L,214849132208L,1316520434704L,8067189289984L,49432958970960L,302908230284368L,1856117667993184L,11373652262370288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275141Inst : IEnumerable<long>
{
public static readonly long[] Value=A275141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275141.Bytes);
public long this[int i]=>Value[i];

public static A275141Inst Instance=new A275141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275142
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,5L,4L,16L,36L,14L,8L,48L,80L,216L,41L,16L,144L,224L,400L,1296L,122L,32L,432L,528L,1088L,2000L,7776L,365L,64L,1296L,1216L,2320L,5248L,10000L,46656L,1094L,128L,3888L,2816L,6464L,9744L,25344L,50000L,279936L,3281L,256L,11664L,6544L,17872L,32384L,41360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275142Inst : IEnumerable<long>
{
public static readonly long[] Value=A275142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275142.Bytes);
public long this[int i]=>Value[i];

public static A275142Inst Instance=new A275142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275143
{
public static readonly long[] Value={ 5L,36L,80L,224L,528L,1216L,2816L,6544L,15216L,35376L,82240L,191184L,444448L,1033216L,2401936L,5583824L,12980816L,30176736L,70152400L,163084544L,379125568L,881360016L,2048913456L,4763145904L,11072970816L,25741534096L,59841806560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275143Inst : IEnumerable<long>
{
public static readonly long[] Value=A275143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275143.Bytes);
public long this[int i]=>Value[i];

public static A275143Inst Instance=new A275143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275144
{
public static readonly long[] Value={ 14L,216L,400L,1088L,2320L,6464L,17872L,49792L,139664L,392448L,1102416L,3095808L,8693584L,24414784L,68567696L,192568832L,540817040L,1518847552L,4265581328L,11979603776L,33643929040L,94486756224L,265359817104L,745245528576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275144Inst : IEnumerable<long>
{
public static readonly long[] Value=A275144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275144.Bytes);
public long this[int i]=>Value[i];

public static A275144Inst Instance=new A275144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275145
{
public static readonly long[] Value={ 41L,1296L,2000L,5248L,9744L,32384L,107472L,362176L,1220752L,4108688L,13848016L,46763600L,158042960L,534108640L,1804746272L,6098041456L,20605419360L,69627945984L,235280517632L,795033992240L,2686484835680L,9077858469008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275145Inst : IEnumerable<long>
{
public static readonly long[] Value=A275145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275145.Bytes);
public long this[int i]=>Value[i];

public static A275145Inst Instance=new A275145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275146
{
public static readonly long[] Value={ 122L,7776L,10000L,25344L,41360L,165568L,663904L,2695808L,10930304L,44604864L,182448928L,745425056L,3044211024L,12443779056L,50916573248L,208404032016L,852924441248L,3490340288512L,14283233460800L,58452748415536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275146Inst : IEnumerable<long>
{
public static readonly long[] Value=A275146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275146.Bytes);
public long this[int i]=>Value[i];

public static A275146Inst Instance=new A275146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275147
{
public static readonly long[] Value={ 365L,46656L,50000L,122368L,175120L,841536L,4055152L,19906560L,98050624L,485275472L,2393975472L,11827067056L,58618143280L,290834622960L,1442223151168L,7149923428256L,35460798018688L,175959368070992L,873276392285488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275147Inst : IEnumerable<long>
{
public static readonly long[] Value=A275147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275147.Bytes);
public long this[int i]=>Value[i];

public static A275147Inst Instance=new A275147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275148
{
public static readonly long[] Value={ 1L,3L,5L,24L,26L,29L,41L,290L,314L,626L,1784L,6041L,7556L,7589L,8876L,26171L,52454L,153089L,159731L,218084L,576239L,1478531L,2677289L,2934539L,3085781L,3569114L,3802301L,4692866L,24307841L,25051934L,54168539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275148Inst : IEnumerable<long>
{
public static readonly long[] Value=A275148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275148.Bytes);
public long this[int i]=>Value[i];

public static A275148Inst Instance=new A275148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275149
{
public static readonly long[] Value={ 3L,9L,7L,2L,1L,3L,0L,9L,6L,8L,8L,4L,2L,4L,0L,0L,4L,1L,4L,8L,5L,6L,5L,4L,0L,7L,0L,2L,2L,7L,3L,9L,8L,7L,3L,4L,2L,2L,9L,8L,7L,3L,7L,0L,9L,9L,5L,2L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275149Inst : IEnumerable<long>
{
public static readonly long[] Value=A275149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275149.Bytes);
public long this[int i]=>Value[i];

public static A275149Inst Instance=new A275149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275150
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,3L,4L,3L,2L,3L,3L,2L,1L,2L,4L,3L,4L,3L,2L,2L,3L,3L,3L,3L,4L,5L,2L,3L,2L,3L,5L,4L,4L,5L,3L,4L,3L,2L,3L,2L,2L,5L,5L,4L,2L,2L,5L,3L,5L,5L,3L,5L,5L,2L,3L,3L,4L,4L,2L,2L,4L,4L,6L,3L,5L,4L,2L,3L,4L,5L,5L,4L,4L,5L,5L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275150Inst : IEnumerable<long>
{
public static readonly long[] Value=A275150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275150.Bytes);
public long this[int i]=>Value[i];

public static A275150Inst Instance=new A275150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275151
{
public static readonly long[] Value={ 8L,25L,128L,729L,4232L,24649L,143648L,837225L,4879688L,28440889L,165765632L,966152889L,5631151688L,32820757225L,191293391648L,1114939592649L,6498344164232L,37875125392729L,220752408192128L,1286639323760025L,7499083534368008L,43707861882448009L,254748087760320032L,1484780664679472169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275151Inst : IEnumerable<long>
{
public static readonly long[] Value=A275151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275151.Bytes);
public long this[int i]=>Value[i];

public static A275151Inst Instance=new A275151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275152
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,6L,7L,9L,11L,10L,13L,12L,14L,15L,16L,17L,19L,18L,20L,21L,25L,32L,22L,26L,23L,29L,24L,27L,33L,34L,37L,36L,40L,28L,30L,31L,35L,38L,41L,42L,45L,49L,48L,39L,43L,50L,57L,44L,52L,46L,53L,64L,47L,58L,51L,65L,68L,66L,54L,55L,72L,56L,59L,81L,61L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275152Inst : IEnumerable<long>
{
public static readonly long[] Value=A275152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275152.Bytes);
public long this[int i]=>Value[i];

public static A275152Inst Instance=new A275152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275153
{
public static readonly long[] Value={ 9L,0L,0L,0L,7L,9L,9L,10L,4L,9L,9L,3L,9L,16L,9L,9L,20L,4L,9L,18L,3L,9L,34L,9L,9L,40L,4L,9L,27L,3L,9L,61L,9L,9L,80L,4L,9L,36L,3L,9L,97L,9L,9L,160L,4L,9L,45L,3L,9L,142L,9L,9L,320L,4L,9L,54L,3L,9L,196L,9L,9L,640L,4L,9L,63L,3L,9L,259L,9L,9L,1280L,4L,9L,72L,3L,9L,331L,9L,9L,2560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275153Inst : IEnumerable<long>
{
public static readonly long[] Value=A275153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275153.Bytes);
public long this[int i]=>Value[i];

public static A275153Inst Instance=new A275153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275154
{
public static readonly long[] Value={ 1L,216L,729L,1072L,1736L,1737L,2465L,2800L,2808L,3619L,3276L,4257L,4131L,4662L,4473L,5292L,5265L,5328L,6084L,5481L,6202L,5985L,6777L,6840L,7056L,7372L,7659L,7560L,7588L,7380L,7596L,7722L,8037L,8190L,8576L,8064L,8316L,9297L,9549L,8380L,9045L,9261L,9451L,9360L,8919L,10044L,9108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275154Inst : IEnumerable<long>
{
public static readonly long[] Value=A275154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275154.Bytes);
public long this[int i]=>Value[i];

public static A275154Inst Instance=new A275154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275155
{
public static readonly long[] Value={ 18L,64L,338L,1936L,11250L,65536L,381938L,2226064L,12974418L,75620416L,440748050L,2568867856L,14972459058L,87265886464L,508622859698L,2964471271696L,17278204770450L,100704757350976L,586950339335378L,3420997278661264L,19939033332632178L,116213202717131776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275155Inst : IEnumerable<long>
{
public static readonly long[] Value=A275155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275155.Bytes);
public long this[int i]=>Value[i];

public static A275155Inst Instance=new A275155Inst();

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