using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A275799
{
public static readonly long[] Value={ 1L,22L,140L,578L,1785L,4612L,10416L,21340L,40425L,72010L,121836L,197582L,308945L,468328L,690880L,995352L,1404081L,1944030L,2646700L,3549370L,4694921L,6133292L,7921200L,10123828L,12814425L,16076242L,20001996L,24696070L,30273825L,36864080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275799Inst : IEnumerable<long>
{
public static readonly long[] Value=A275799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275799.Bytes);
public long this[int i]=>Value[i];

public static A275799Inst Instance=new A275799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275800
{
public static readonly long[] Value={ 5L,13L,17L,139L,173L,179L,467L,907L,1553L,1619L,1867L,2099L,2819L,2957L,3203L,3779L,3947L,4139L,4157L,4283L,4547L,4723L,5483L,6653L,6899L,7013L,7187L,7523L,7643L,8147L,8387L,8563L,8573L,8753L,9533L,9587L,10589L,10853L,10883L,10979L,11003L,12107L,12227L,13037L,13229L,13829L,14243L,14549L,14699L,14867L,15299L,16217L,16547L,16649L,17387L,18443L,18587L,19259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275800Inst : IEnumerable<long>
{
public static readonly long[] Value=A275800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275800.Bytes);
public long this[int i]=>Value[i];

public static A275800Inst Instance=new A275800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275801
{
public static readonly BigInteger[] Value={ 1L,0L,1L,4L,53L,936L,25325L,933980L,45504649L,2824517520L,217690037497L,20394614883316L,2282650939846781L,300814135522967736L,BigInteger.Parse("46103574973075123877"),BigInteger.Parse("8130996533576437261772"),BigInteger.Parse("1635028654501420083152785"),BigInteger.Parse("371853339350614571322913824"),BigInteger.Parse("94969025880924845123887493233") };
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
public class A275801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275801Inst Instance=new A275801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275802
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,16L,19L,28L,37L,41L,44L,53L,311L,490L,1252L,4360L,4732L,5575L,6833L,8878L,11171L,11396L,13079L,14903L,76615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275802Inst : IEnumerable<long>
{
public static readonly long[] Value=A275802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275802.Bytes);
public long this[int i]=>Value[i];

public static A275802Inst Instance=new A275802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275803
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,2L,2L,3L,4L,3L,4L,2L,3L,3L,4L,2L,4L,2L,3L,2L,4L,3L,4L,2L,2L,2L,3L,2L,3L,3L,3L,4L,5L,4L,5L,3L,4L,4L,5L,3L,5L,3L,4L,3L,5L,4L,5L,2L,2L,3L,4L,3L,4L,3L,3L,4L,5L,4L,5L,2L,3L,4L,5L,3L,5L,2L,3L,3L,5L,4L,5L,2L,3L,3L,4L,2L,4L,2L,3L,4L,5L,3L,5L,3L,4L,4L,5L,3L,5L,2L,4L,3L,5L,3L,5L,2L,3L,2L,4L,3L,4L,2L,3L,3L,5L,4L,5L,2L,4L,3L,5L,3L,5L,3L,4L,3L,5L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275803Inst : IEnumerable<long>
{
public static readonly long[] Value=A275803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275803.Bytes);
public long this[int i]=>Value[i];

public static A275803Inst Instance=new A275803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275804
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,16L,18L,20L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,36L,37L,40L,42L,44L,48L,49L,50L,51L,52L,60L,61L,64L,66L,68L,72L,73L,76L,78L,79L,82L,90L,96L,98L,102L,104L,108L,120L,121L,122L,123L,124L,126L,127L,128L,129L,130L,132L,133L,136L,138L,140L,144L,145L,146L,147L,148L,150L,151L,152L,153L,154L,156L,157L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275804Inst : IEnumerable<long>
{
public static readonly long[] Value=A275804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275804.Bytes);
public long this[int i]=>Value[i];

public static A275804Inst Instance=new A275804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275805
{
public static readonly long[] Value={ 5L,11L,14L,15L,17L,19L,21L,22L,23L,29L,35L,38L,39L,41L,43L,45L,46L,47L,53L,54L,55L,56L,57L,58L,59L,62L,63L,65L,67L,69L,70L,71L,74L,75L,77L,80L,81L,83L,84L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,97L,99L,100L,101L,103L,105L,106L,107L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,125L,131L,134L,135L,137L,139L,141L,142L,143L,149L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275805Inst : IEnumerable<long>
{
public static readonly long[] Value=A275805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275805.Bytes);
public long this[int i]=>Value[i];

public static A275805Inst Instance=new A275805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275806
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,3L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,2L,3L,2L,3L,3L,3L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275806Inst : IEnumerable<long>
{
public static readonly long[] Value=A275806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275806.Bytes);
public long this[int i]=>Value[i];

public static A275806Inst Instance=new A275806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275807
{
public static readonly long[] Value={ 1L,2L,9L,4L,6L,4L,75L,50L,27L,8L,12L,8L,45L,20L,27L,8L,18L,8L,30L,20L,18L,8L,12L,8L,735L,490L,441L,196L,294L,196L,375L,250L,81L,16L,24L,16L,135L,40L,81L,16L,54L,16L,60L,40L,36L,16L,24L,16L,525L,350L,189L,56L,84L,56L,375L,250L,81L,16L,24L,16L,225L,100L,81L,16L,36L,16L,150L,100L,54L,16L,24L,16L,315L,140L,189L,56L,126L,56L,225L,100L,81L,16L,36L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275807Inst : IEnumerable<long>
{
public static readonly long[] Value=A275807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275807.Bytes);
public long this[int i]=>Value[i];

public static A275807Inst Instance=new A275807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275808
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,0L,4L,5L,6L,7L,5L,4L,2L,3L,0L,1L,3L,2L,1L,0L,3L,2L,0L,1L,8L,9L,10L,11L,9L,8L,12L,13L,14L,15L,13L,12L,10L,11L,8L,9L,11L,10L,9L,8L,11L,10L,8L,9L,4L,5L,6L,7L,5L,4L,0L,1L,2L,3L,1L,0L,6L,7L,4L,5L,7L,6L,5L,4L,7L,6L,4L,5L,2L,3L,0L,1L,3L,2L,6L,7L,4L,5L,7L,6L,0L,1L,2L,3L,1L,0L,3L,2L,1L,0L,2L,3L,1L,0L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275808Inst : IEnumerable<long>
{
public static readonly long[] Value=A275808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275808.Bytes);
public long this[int i]=>Value[i];

public static A275808Inst Instance=new A275808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275809
{
public static readonly long[] Value={ 0L,5L,14L,19L,22L,54L,59L,74L,84L,89L,93L,97L,100L,111L,114L,119L,264L,269L,278L,283L,286L,366L,371L,408L,413L,422L,427L,430L,440L,463L,466L,482L,492L,497L,501L,536L,552L,557L,566L,571L,574L,579L,589L,592L,596L,601L,604L,615L,618L,623L,655L,658L,675L,685L,688L,692L,696L,701L,710L,715L,718L,1560L,1565L,1574L,1579L,1582L,1614L,1619L,1634L,1644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275809Inst : IEnumerable<long>
{
public static readonly long[] Value=A275809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275809.Bytes);
public long this[int i]=>Value[i];

public static A275809Inst Instance=new A275809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275810
{
public static readonly long[] Value={ 5L,9L,5L,3L,32L,5L,15L,10L,5L,4L,4L,3L,11L,3L,5L,145L,5L,9L,5L,3L,80L,5L,37L,5L,9L,5L,3L,10L,23L,3L,16L,10L,5L,4L,35L,16L,5L,9L,5L,3L,5L,10L,3L,4L,5L,3L,11L,3L,5L,32L,3L,17L,10L,3L,4L,4L,5L,9L,5L,3L,842L,5L,9L,5L,3L,32L,5L,15L,10L,5L,4L,4L,3L,11L,3L,5L,505L,5L,9L,5L,3L,194L,5L,9L,5L,3L,32L,5L,15L,10L,5L,4L,4L,3L,11L,3L,5L,31L,5L,111L,10L,5L,4L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275810Inst : IEnumerable<long>
{
public static readonly long[] Value=A275810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275810.Bytes);
public long this[int i]=>Value[i];

public static A275810Inst Instance=new A275810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275811
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,3L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,3L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,3L,3L,2L,2L,1L,2L,2L,2L,2L,3L,1L,2L,1L,2L,2L,3L,1L,2L,1L,2L,2L,3L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275811Inst : IEnumerable<long>
{
public static readonly long[] Value=A275811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275811.Bytes);
public long this[int i]=>Value[i];

public static A275811Inst Instance=new A275811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275844
{
public static readonly long[] Value={ 2L,4L,6L,7L,8L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275844Inst : IEnumerable<long>
{
public static readonly long[] Value=A275844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275844.Bytes);
public long this[int i]=>Value[i];

public static A275844Inst Instance=new A275844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275845
{
public static readonly long[] Value={ 0L,1L,4L,2L,6L,3L,12L,8L,16L,5L,15L,10L,18L,21L,22L,7L,20L,13L,24L,27L,28L,9L,26L,17L,48L,30L,52L,33L,34L,11L,60L,32L,64L,23L,56L,36L,66L,61L,70L,39L,40L,14L,73L,38L,78L,29L,67L,42L,72L,80L,76L,74L,85L,45L,84L,46L,88L,19L,89L,44L,90L,97L,94L,35L,81L,49L,87L,99L,93L,91L,105L,53L,96L,104L,100L,54L,109L,25L,108L,110L,112L,51L,111L,121L,114L,117L,118L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275845Inst : IEnumerable<long>
{
public static readonly long[] Value=A275845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275845.Bytes);
public long this[int i]=>Value[i];

public static A275845Inst Instance=new A275845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275846
{
public static readonly long[] Value={ 0L,1L,3L,5L,2L,9L,4L,15L,7L,21L,11L,29L,6L,17L,41L,10L,8L,23L,12L,57L,16L,13L,14L,33L,18L,77L,22L,19L,20L,45L,25L,101L,31L,27L,28L,63L,35L,129L,43L,39L,40L,87L,47L,165L,59L,53L,55L,111L,24L,65L,213L,81L,26L,71L,75L,141L,34L,89L,269L,105L,30L,37L,95L,99L,32L,183L,36L,46L,113L,341L,38L,135L,48L,42L,51L,119L,50L,125L,44L,231L,49L,64L,143L,431L,54L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275846Inst : IEnumerable<long>
{
public static readonly long[] Value=A275846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275846.Bytes);
public long this[int i]=>Value[i];

public static A275846Inst Instance=new A275846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275847
{
public static readonly long[] Value={ 0L,1L,4L,2L,3L,5L,18L,6L,12L,7L,8L,9L,16L,10L,22L,11L,13L,14L,15L,17L,19L,20L,21L,23L,96L,24L,48L,25L,26L,27L,72L,28L,52L,29L,30L,31L,60L,32L,64L,33L,34L,35L,36L,37L,38L,39L,40L,41L,90L,42L,66L,43L,44L,45L,114L,46L,70L,47L,49L,50L,76L,51L,84L,53L,54L,55L,56L,57L,58L,59L,61L,62L,88L,63L,94L,65L,67L,68L,100L,69L,108L,71L,73L,74L,112L,75L,118L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275847Inst : IEnumerable<long>
{
public static readonly long[] Value=A275847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275847.Bytes);
public long this[int i]=>Value[i];

public static A275847Inst Instance=new A275847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275848
{
public static readonly long[] Value={ 0L,1L,3L,4L,2L,5L,7L,9L,10L,11L,13L,15L,8L,16L,17L,18L,12L,19L,6L,20L,21L,22L,14L,23L,25L,27L,28L,29L,31L,33L,34L,35L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,51L,52L,53L,55L,57L,26L,58L,59L,61L,32L,63L,64L,65L,66L,67L,68L,69L,36L,70L,71L,73L,38L,75L,50L,76L,77L,79L,56L,81L,30L,82L,83L,85L,60L,87L,88L,89L,90L,91L,92L,93L,62L,94L,95L,96L,72L,97L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275848Inst : IEnumerable<long>
{
public static readonly long[] Value=A275848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275848.Bytes);
public long this[int i]=>Value[i];

public static A275848Inst Instance=new A275848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275849
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,2L,1L,1L,0L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,2L,2L,1L,2L,2L,2L,1L,1L,0L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,2L,2L,1L,2L,2L,3L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,2L,3L,2L,2L,2L,2L,1L,2L,1L,1L,1L,3L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275849Inst : IEnumerable<long>
{
public static readonly long[] Value=A275849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275849.Bytes);
public long this[int i]=>Value[i];

public static A275849Inst Instance=new A275849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275850
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,0L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,0L,3L,3L,3L,3L,2L,2L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,3L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,3L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275850Inst : IEnumerable<long>
{
public static readonly long[] Value=A275850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275850.Bytes);
public long this[int i]=>Value[i];

public static A275850Inst Instance=new A275850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275851
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,1L,1L,0L,0L,0L,2L,1L,0L,0L,1L,0L,3L,1L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,1L,1L,0L,0L,0L,2L,1L,0L,0L,1L,0L,3L,1L,2L,1L,2L,1L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,3L,2L,2L,1L,1L,1L,1L,0L,1L,0L,0L,0L,2L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,3L,2L,1L,1L,2L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,2L,1L,0L,0L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275851Inst : IEnumerable<long>
{
public static readonly long[] Value=A275851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275851.Bytes);
public long this[int i]=>Value[i];

public static A275851Inst Instance=new A275851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275852
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,15L,16L,17L,20L,21L,23L,27L,29L,31L,33L,35L,39L,40L,41L,44L,45L,47L,55L,57L,59L,61L,63L,64L,65L,67L,68L,69L,71L,79L,81L,82L,83L,87L,88L,89L,92L,93L,94L,95L,103L,104L,105L,107L,110L,111L,112L,113L,116L,117L,119L,127L,129L,131L,135L,136L,137L,140L,141L,143L,147L,149L,151L,153L,155L,159L,160L,161L,164L,165L,167L,175L,177L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275852Inst : IEnumerable<long>
{
public static readonly long[] Value=A275852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275852.Bytes);
public long this[int i]=>Value[i];

public static A275852Inst Instance=new A275852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275853
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,1L,4L,3L,3L,3L,3L,2L,4L,3L,4L,4L,4L,3L,4L,4L,3L,3L,3L,3L,4L,3L,3L,3L,3L,2L,4L,3L,4L,4L,4L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,2L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,4L,3L,3L,3L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275853Inst : IEnumerable<long>
{
public static readonly long[] Value=A275853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275853.Bytes);
public long this[int i]=>Value[i];

public static A275853Inst Instance=new A275853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275854
{
public static readonly BigInteger[] Value={ 1L,2L,16L,343L,14641L,1048576L,113379904L,17249876309L,3512479453921L,922190162669056L,303305489096114176L,BigInteger.Parse("122130132904968017083"),BigInteger.Parse("59091511031674153381441"),BigInteger.Parse("33825307664249166246182912"),BigInteger.Parse("22609039557544243501245546496"),BigInteger.Parse("17449402268886407318558803753801") };
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
public class A275854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275854Inst Instance=new A275854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275855
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275855Inst : IEnumerable<long>
{
public static readonly long[] Value=A275855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275855.Bytes);
public long this[int i]=>Value[i];

public static A275855Inst Instance=new A275855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275856
{
public static readonly long[] Value={ 1L,1L,3L,8L,24L,74L,231L,723L,2265L,7098L,22246L,69724L,218533L,684941L,2146791L,6728628L,21089356L,66099798L,207174811L,649342415L,2035216397L,6378923798L,19993288618L,62664424664L,196407414185L,615594454969L,1929441078187L,6047395073408L,18954187089376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275856Inst : IEnumerable<long>
{
public static readonly long[] Value=A275856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275856.Bytes);
public long this[int i]=>Value[i];

public static A275856Inst Instance=new A275856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275857
{
public static readonly long[] Value={ 1L,2L,6L,18L,56L,175L,548L,1717L,5381L,16865L,52859L,165674L,519267L,1627524L,5101104L,15988252L,50111546L,157063265L,492279150L,1542937247L,4835986551L,15157302067L,47507122597L,148900291588L,466694163381L,1462746914806L,4584648158602L,14369538930774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275857Inst : IEnumerable<long>
{
public static readonly long[] Value=A275857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275857.Bytes);
public long this[int i]=>Value[i];

public static A275857Inst Instance=new A275857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275858
{
public static readonly long[] Value={ 1L,1L,-1L,-4L,-4L,4L,17L,17L,-17L,-72L,-72L,72L,305L,305L,-305L,-1292L,-1292L,1292L,5473L,5473L,-5473L,-23184L,-23184L,23184L,98209L,98209L,-98209L,-416020L,-416020L,416020L,1762289L,1762289L,-1762289L,-7465176L,-7465176L,7465176L,31622993L,31622993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275858Inst : IEnumerable<long>
{
public static readonly long[] Value=A275858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275858.Bytes);
public long this[int i]=>Value[i];

public static A275858Inst Instance=new A275858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275859
{
public static readonly long[] Value={ 1L,1L,5L,19L,76L,304L,1220L,4898L,19667L,78971L,317103L,1273309L,5112902L,20530578L,82439414L,331030964L,1329236757L,5337477605L,21432349833L,86060430295L,345570957936L,1387621309348L,5571917587224L,22373730779190L,89840494074695L,360749597608127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275859Inst : IEnumerable<long>
{
public static readonly long[] Value=A275859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275859.Bytes);
public long this[int i]=>Value[i];

public static A275859Inst Instance=new A275859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275908
{
public static readonly long[] Value={ 1L,5L,20L,75L,288L,1105L,4234L,16226L,62188L,238340L,913452L,3500857L,13417236L,51422337L,197079099L,755317101L,2894796675L,11094476468L,42520225774L,162961236161L,624558407329L,2393656389397L,9173827208656L,35159225871899L,134749776270503L,516436347919005L,1979272313718089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275908Inst : IEnumerable<long>
{
public static readonly long[] Value=A275908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275908.Bytes);
public long this[int i]=>Value[i];

public static A275908Inst Instance=new A275908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275909
{
public static readonly long[] Value={ 1L,5L,20L,75L,288L,1094L,4171L,15897L,60565L,230816L,879521L,3351544L,12771524L,48667365L,185453453L,706693601L,2692945820L,10261812539L,39103937948L,149010523846L,567823518619L,2163763618201L,8245296020629L,31419747421972L,119728937140293L,456242317652464L,1738569283271528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275909Inst : IEnumerable<long>
{
public static readonly long[] Value=A275909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275909.Bytes);
public long this[int i]=>Value[i];

public static A275909Inst Instance=new A275909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275910
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,11L,12L,13L,14L,15L,16L,20L,21L,22L,23L,24L,25L,29L,30L,31L,32L,33L,34L,38L,39L,40L,41L,42L,43L,47L,48L,49L,50L,51L,52L,56L,57L,58L,59L,60L,61L,65L,66L,67L,68L,69L,70L,74L,75L,76L,77L,78L,79L,83L,84L,85L,86L,87L,88L,92L,93L,94L,95L,96L,97L,101L,102L,103L,104L,105L,106L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275910Inst : IEnumerable<long>
{
public static readonly long[] Value=A275910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275910.Bytes);
public long this[int i]=>Value[i];

public static A275910Inst Instance=new A275910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275911
{
public static readonly long[] Value={ 1L,2L,4L,16L,120L,210L,216L,256L,384L,2880L,6300L,7200L,15360L,15552L,26880L,27648L,32768L,49152L,73728L,83160L,120120L,189000L,510510L,921600L,1399680L,1966080L,2365440L,2822400L,2985984L,3440640L,4194304L,4860000L,5670000L,6291456L,6912000L,9437184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275911Inst : IEnumerable<long>
{
public static readonly long[] Value=A275911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275911.Bytes);
public long this[int i]=>Value[i];

public static A275911Inst Instance=new A275911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275912
{
public static readonly long[] Value={ 1L,2L,16L,166L,1934L,24076L,312900L,4191528L,57424848L,800511928L,11314617512L,161736519334L,2333709074866L,33940921354676L,496985854805560L,7320036386083320L,108370564070861790L,1611667048718909412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275912Inst : IEnumerable<long>
{
public static readonly long[] Value=A275912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275912.Bytes);
public long this[int i]=>Value[i];

public static A275912Inst Instance=new A275912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275913
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,15L,17L,33L,35L,51L,57L,65L,91L,105L,129L,165L,195L,205L,221L,255L,257L,385L,451L,561L,861L,897L,969L,1615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275913Inst : IEnumerable<long>
{
public static readonly long[] Value=A275913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275913.Bytes);
public long this[int i]=>Value[i];

public static A275913Inst Instance=new A275913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275914
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,15L,105L,35L,3L,15L,11L,165L,195L,91L,3003L,2145L,17L,51L,969L,1615L,1785L,19635L,37145L,245157L,255L,221L,53295L,4849845L,44863L,16269L,14325749295L,6678671L,33L,561L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275914Inst : IEnumerable<long>
{
public static readonly long[] Value=A275914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275914.Bytes);
public long this[int i]=>Value[i];

public static A275914Inst Instance=new A275914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275915
{
public static readonly long[] Value={ 9L,4L,4L,4L,61L,10L,10L,10L,116L,16L,16L,16L,169L,22L,22L,22L,119L,26L,26L,26L,259L,32L,32L,32L,314L,38L,38L,38L,367L,44L,44L,44L,421L,50L,50L,50L,476L,56L,56L,56L,529L,62L,62L,62L,319L,66L,66L,66L,619L,72L,72L,72L,674L,78L,78L,78L,727L,84L,84L,84L,782L,90L,90L,90L,835L,96L,96L,96L,489L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275915Inst : IEnumerable<long>
{
public static readonly long[] Value=A275915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275915.Bytes);
public long this[int i]=>Value[i];

public static A275915Inst Instance=new A275915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275916
{
public static readonly long[] Value={ 0L,21L,112L,276L,511L,708L,1063L,1491L,1990L,2561L,3205L,3920L,4437L,5272L,6180L,7159L,8211L,9334L,10123L,11366L,12682L,14069L,15528L,17060L,18663L,19772L,21495L,23291L,25158L,26443L,28430L,30490L,32621L,34824L,37100L,39447L,41052L,43519L,46059L,48670L,51354L,54109L,55986L,58861L,61809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275916Inst : IEnumerable<long>
{
public static readonly long[] Value=A275916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275916.Bytes);
public long this[int i]=>Value[i];

public static A275916Inst Instance=new A275916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275917
{
public static readonly long[] Value={ 9L,82L,228L,445L,630L,967L,1377L,1858L,2411L,3037L,3734L,4239L,5056L,5946L,6907L,7941L,9046L,9823L,11048L,12346L,13715L,15156L,16670L,18255L,19352L,21057L,22835L,24684L,25957L,27926L,29968L,32081L,34266L,36524L,38853L,40446L,42895L,45417L,48010L,50676L,53413L,55278L,58135L,61065L,64066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275917Inst : IEnumerable<long>
{
public static readonly long[] Value=A275917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275917.Bytes);
public long this[int i]=>Value[i];

public static A275917Inst Instance=new A275917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275918
{
public static readonly long[] Value={ 13L,92L,244L,467L,656L,999L,1415L,1902L,2461L,3093L,3796L,4305L,5128L,6024L,6991L,8031L,9142L,9923L,11154L,12458L,13833L,15280L,16800L,18391L,19492L,21203L,22987L,24842L,26119L,28094L,30142L,32261L,34452L,36716L,39051L,40648L,43103L,45631L,48230L,50902L,53645L,55514L,58377L,61313L,64320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275918Inst : IEnumerable<long>
{
public static readonly long[] Value=A275918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275918.Bytes);
public long this[int i]=>Value[i];

public static A275918Inst Instance=new A275918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275919
{
public static readonly long[] Value={ 17L,102L,260L,489L,682L,1031L,1453L,1946L,2511L,3149L,3858L,4371L,5200L,6102L,7075L,8121L,9238L,10023L,11260L,12570L,13951L,15404L,16930L,18527L,19632L,21349L,23139L,25000L,26281L,28262L,30316L,32441L,34638L,36908L,39249L,40850L,43311L,45845L,48450L,51128L,53877L,55750L,58619L,61561L,64574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275919Inst : IEnumerable<long>
{
public static readonly long[] Value=A275919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275919.Bytes);
public long this[int i]=>Value[i];

public static A275919Inst Instance=new A275919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275920
{
public static readonly long[] Value={ 3L,5L,11L,29L,37L,41L,43L,53L,67L,79L,83L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275920Inst : IEnumerable<long>
{
public static readonly long[] Value=A275920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275920.Bytes);
public long this[int i]=>Value[i];

public static A275920Inst Instance=new A275920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275921
{
public static readonly BigInteger[] Value={ 56L,9408L,11270400L,27206658048L,112681643083776L,746988383076286464L,BigInteger.Parse("7533492323047902093312"),BigInteger.Parse("111048869433803210653040640"),BigInteger.Parse("2315236533572491933131807916032"),BigInteger.Parse("66415035616070432053233927044726784"),BigInteger.Parse("2560483881619577552584872021599994249216") };
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
public class A275921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275921.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275921Inst Instance=new A275921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275922
{
public static readonly BigInteger[] Value={ 9408L,16942080L,335390189568L,12952605404381184L,BigInteger.Parse("870735405591003709440"),BigInteger.Parse("96299552373292505158778880"),BigInteger.Parse("16790769154925929673725062021120"),BigInteger.Parse("4453330421956050777867897829494620160"),BigInteger.Parse("1742101863056111789338065277444595027804160"),BigInteger.Parse("978514587314819902819845847828230416011100160000") };
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
public class A275922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275922.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275922Inst Instance=new A275922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275923
{
public static readonly long[] Value={ 1L,1L,2L,11L,156L,16756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275923Inst : IEnumerable<long>
{
public static readonly long[] Value=A275923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275923.Bytes);
public long this[int i]=>Value[i];

public static A275923Inst Instance=new A275923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275956
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,10L,11L,12L,13L,15L,17L,18L,20L,21L,24L,28L,29L,36L,38L,42L,43L,48L,49L,50L,53L,55L,56L,58L,59L,62L,66L,68L,69L,70L,72L,73L,75L,76L,78L,80L,82L,83L,88L,91L,92L,93L,94L,96L,98L,99L,102L,103L,108L,112L,120L,124L,125L,132L,134L,138L,139L,166L,167L,168L,174L,186L,187L,190L,191L,192L,194L,196L,197L,205L,207L,208L,209L,214L,215L,216L,217L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275956Inst : IEnumerable<long>
{
public static readonly long[] Value=A275956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275956.Bytes);
public long this[int i]=>Value[i];

public static A275956Inst Instance=new A275956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275957
{
public static readonly long[] Value={ 0L,1L,4L,3L,2L,5L,18L,19L,16L,9L,8L,17L,12L,7L,22L,21L,14L,11L,6L,13L,10L,15L,20L,23L,96L,97L,100L,99L,98L,101L,90L,91L,64L,33L,32L,65L,60L,31L,94L,93L,62L,35L,30L,61L,34L,63L,92L,95L,72L,73L,52L,27L,26L,53L,114L,115L,112L,105L,104L,113L,84L,79L,70L,45L,38L,59L,78L,85L,58L,39L,44L,71L,48L,25L,76L,75L,50L,29L,66L,43L,88L,81L,56L,41L,108L,103L,118L,117L,110L,107L,54L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275957Inst : IEnumerable<long>
{
public static readonly long[] Value=A275957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275957.Bytes);
public long this[int i]=>Value[i];

public static A275957Inst Instance=new A275957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275958
{
public static readonly long[] Value={ 0L,1L,4L,3L,2L,5L,18L,13L,10L,9L,20L,17L,12L,19L,16L,21L,8L,11L,6L,7L,22L,15L,14L,23L,96L,73L,52L,51L,98L,77L,42L,37L,34L,33L,44L,41L,108L,91L,64L,69L,104L,83L,102L,79L,70L,63L,110L,95L,72L,97L,76L,99L,50L,53L,90L,109L,82L,105L,68L,65L,36L,43L,40L,45L,32L,35L,78L,103L,94L,111L,62L,71L,48L,49L,100L,75L,74L,101L,66L,61L,106L,81L,92L,113L,60L,67L,112L,93L,80L,107L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275958Inst : IEnumerable<long>
{
public static readonly long[] Value=A275958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275958.Bytes);
public long this[int i]=>Value[i];

public static A275958Inst Instance=new A275958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275959
{
public static readonly long[] Value={ 0L,1L,12L,13L,360L,361L,372L,373L,20160L,20161L,20172L,20173L,20520L,20521L,20532L,20533L,1814400L,1814401L,1814412L,1814413L,1814760L,1814761L,1814772L,1814773L,1834560L,1834561L,1834572L,1834573L,1834920L,1834921L,1834932L,1834933L,239500800L,239500801L,239500812L,239500813L,239501160L,239501161L,239501172L,239501173L,239520960L,239520961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275959Inst : IEnumerable<long>
{
public static readonly long[] Value=A275959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275959.Bytes);
public long this[int i]=>Value[i];

public static A275959Inst Instance=new A275959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275960
{
public static readonly long[] Value={ 1L,5L,4L,27L,22L,18L,283L,256L,234L,216L,2783L,2500L,2244L,2010L,1794L,27381L,24598L,22098L,19854L,17844L,16050L,289573L,262192L,237594L,215496L,195642L,177798L,161748L,3294929L,3005356L,2743164L,2505570L,2290074L,2094432L,1916634L,1754886L,39857103L,36562174L,33556818L,30813654L,28308084L,26018010L,23923578L,22006944L,20252058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275960Inst : IEnumerable<long>
{
public static readonly long[] Value=A275960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275960.Bytes);
public long this[int i]=>Value[i];

public static A275960Inst Instance=new A275960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275961
{
public static readonly long[] Value={ 1L,4L,5L,18L,22L,27L,216L,234L,256L,283L,1794L,2010L,2244L,2500L,2783L,16050L,17844L,19854L,22098L,24598L,27381L,161748L,177798L,195642L,215496L,237594L,262192L,289573L,1754886L,1916634L,2094432L,2290074L,2505570L,2743164L,3005356L,3294929L,20252058L,22006944L,23923578L,26018010L,28308084L,30813654L,33556818L,36562174L,39857103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275961Inst : IEnumerable<long>
{
public static readonly long[] Value=A275961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275961.Bytes);
public long this[int i]=>Value[i];

public static A275961Inst Instance=new A275961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275962
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,2L,2L,0L,2L,0L,2L,0L,2L,2L,3L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,2L,2L,0L,2L,0L,2L,0L,2L,2L,3L,0L,0L,0L,0L,0L,2L,2L,2L,2L,2L,2L,4L,0L,0L,2L,2L,0L,2L,0L,2L,0L,2L,2L,3L,0L,0L,2L,2L,0L,2L,0L,0L,2L,2L,0L,2L,2L,2L,3L,3L,2L,4L,0L,2L,2L,4L,2L,3L,0L,2L,0L,2L,2L,3L,0L,2L,0L,2L,2L,3L,0L,2L,2L,4L,2L,3L,2L,3L,2L,3L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275962Inst : IEnumerable<long>
{
public static readonly long[] Value=A275962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275962.Bytes);
public long this[int i]=>Value[i];

public static A275962Inst Instance=new A275962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275963
{
public static readonly BigInteger[] Value={ 18L,234L,2244L,22098L,237594L,2743164L,33556818L,441925794L,12449045364L,267703255698L,5497712563434L,112804699752300L,2358022995718578L,51007863864388434L,1135446810698914644L,BigInteger.Parse("26241095309660220138"),BigInteger.Parse("626391138692542250154"),BigInteger.Parse("15519080113275337003404"),BigInteger.Parse("397364781519139001021778"),BigInteger.Parse("10545585096254938755221394"),BigInteger.Parse("289700229771377481566636364") };
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
public class A275963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275963Inst Instance=new A275963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275964
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,0L,2L,2L,3L,0L,2L,0L,0L,0L,2L,2L,2L,0L,0L,0L,2L,0L,0L,0L,2L,2L,3L,0L,2L,2L,3L,3L,4L,2L,3L,0L,2L,2L,3L,2L,4L,0L,2L,2L,3L,0L,2L,0L,0L,0L,2L,2L,2L,0L,2L,2L,3L,2L,4L,2L,2L,2L,4L,3L,3L,0L,0L,0L,2L,2L,2L,0L,0L,0L,2L,0L,0L,0L,2L,2L,3L,0L,2L,0L,0L,0L,2L,2L,2L,2L,2L,2L,4L,2L,2L,0L,0L,0L,2L,0L,0L,0L,2L,2L,3L,0L,2L,0L,0L,0L,2L,2L,2L,0L,0L,0L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275964Inst : IEnumerable<long>
{
public static readonly long[] Value=A275964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275964.Bytes);
public long this[int i]=>Value[i];

public static A275964Inst Instance=new A275964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275965
{
public static readonly BigInteger[] Value={ 1L,4L,18L,216L,1794L,16050L,161748L,1754886L,20252058L,257046648L,9715067802L,169069882650L,3334258948644L,65130972856014L,1314162130657122L,27756075741907992L,599859130159322082L,13631049605170919850UL,BigInteger.Parse("318062816759187443364"),BigInteger.Parse("7775218520916136276470"),BigInteger.Parse("195524294317191054759258"),BigInteger.Parse("5132224614520884668600904"),BigInteger.Parse("139264442985628101392954898") };
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
public class A275965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275965Inst Instance=new A275965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275966
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,0L,2L,-2L,0L,2L,0L,-2L,0L,0L,2L,0L,0L,0L,-2L,-2L,0L,4L,2L,-2L,0L,0L,0L,-2L,0L,0L,0L,-2L,0L,4L,0L,0L,0L,0L,2L,0L,0L,0L,-4L,-2L,0L,0L,2L,-2L,0L,2L,0L,0L,0L,0L,2L,0L,0L,4L,0L,-2L,0L,0L,2L,-4L,0L,0L,-4L,-2L,0L,4L,0L,-2L,0L,0L,0L,0L,0L,4L,0L,-2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275966Inst : IEnumerable<long>
{
public static readonly long[] Value=A275966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275966.Bytes);
public long this[int i]=>Value[i];

public static A275966Inst Instance=new A275966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275967
{
public static readonly long[] Value={ 9L,2L,5L,8L,3L,7L,0L,5L,7L,6L,1L,3L,8L,8L,6L,0L,0L,8L,3L,7L,6L,8L,9L,1L,2L,1L,2L,3L,3L,5L,4L,1L,1L,0L,9L,6L,8L,9L,2L,7L,8L,2L,9L,6L,1L,1L,6L,8L,3L,0L,0L,9L,2L,2L,1L,9L,6L,0L,1L,6L,8L,1L,5L,8L,4L,2L,3L,4L,9L,0L,9L,3L,1L,9L,5L,3L,2L,2L,9L,7L,9L,2L,1L,5L,1L,9L,2L,7L,2L,3L,5L,3L,1L,8L,4L,6L,6L,8L,9L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275967Inst : IEnumerable<long>
{
public static readonly long[] Value=A275967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275967.Bytes);
public long this[int i]=>Value[i];

public static A275967Inst Instance=new A275967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275968
{
public static readonly long[] Value={ 173L,409L,419L,421L,439L,487L,521L,557L,571L,617L,761L,887L,919L,1009L,1039L,1117L,1153L,1171L,1217L,1327L,1373L,1549L,1559L,1571L,1657L,1693L,1709L,1721L,1733L,1783L,1831L,1861L,1901L,1993L,1997L,2053L,2089L,2339L,2393L,2521L,2539L,2647L,2657L,2677L,2693L,2777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275968Inst : IEnumerable<long>
{
public static readonly long[] Value=A275968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275968.Bytes);
public long this[int i]=>Value[i];

public static A275968Inst Instance=new A275968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275969
{
public static readonly long[] Value={ 3L,5L,13L,17L,51L,85L,193L,257L,769L,1285L,3281L,4369L,12289L,21845L,49601L,65537L,196611L,327685L,786433L,1114129L,3158273L,5570645L,12648641L,16843009L,50397953L,84215045L,202113281L,286331153L,805384193L,1431655765L,3221225473L,8168859365L,12952273921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275969Inst : IEnumerable<long>
{
public static readonly long[] Value=A275969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275969.Bytes);
public long this[int i]=>Value[i];

public static A275969Inst Instance=new A275969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275970
{
public static readonly long[] Value={ 2L,6L,13L,26L,51L,100L,197L,390L,775L,1544L,3081L,6154L,12299L,24588L,49165L,98318L,196623L,393232L,786449L,1572882L,3145747L,6291476L,12582933L,25165846L,50331671L,100663320L,201326617L,402653210L,805306395L,1610612764L,3221225501L,6442450974L,12884901919L,25769803808L,51539607585L,103079215138L,206158430243L,412316860452L,824633720869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275970Inst : IEnumerable<long>
{
public static readonly long[] Value=A275970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275970.Bytes);
public long this[int i]=>Value[i];

public static A275970Inst Instance=new A275970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275971
{
public static readonly long[] Value={ 5L,15L,85L,165L,235L,485L,1665L,1885L,4835L,5765L,7585L,15085L,15885L,16665L,18365L,18915L,22885L,27115L,27885L,50235L,57665L,58115L,72335L,85635L,87885L,150915L,166665L,182415L,194235L,194365L,229635L,240365L,268835L,503515L,507665L,524915L,568835L,570415L,577515L,581165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275971Inst : IEnumerable<long>
{
public static readonly long[] Value=A275971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275971.Bytes);
public long this[int i]=>Value[i];

public static A275971Inst Instance=new A275971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276020
{
public static readonly BigInteger[] Value={ 1L,10L,90L,780L,6630L,55820L,469220L,3967000L,33951750L,295553500L,2622492940L,23701797800L,217528135900L,2018704327800L,18862262001800L,176834576018480L,1659586559786950L,15575074941839100L,146164364053448700L,1372547571923176200L,12910383388613518580UL,BigInteger.Parse("121770360957324308200"),BigInteger.Parse("1152648798132152849400") };
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
public class A276020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276020Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276020.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276020.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276020Inst Instance=new A276020Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276021
{
public static readonly BigInteger[] Value={ 1L,21L,693L,23940L,734643L,13697019L,-494620749L,-83079255420L,-6814815765975L,-444980496382695L,-25071954462140859L,-1226361084729855984L,BigInteger.Parse("-49426887403935395172"),BigInteger.Parse("-1287188243957889124740"),BigInteger.Parse("23935850133162849385308"),BigInteger.Parse("6798920856226697943604944"),BigInteger.Parse("650950202721260061404073891") };
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
public class A276021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276021Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276021.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276021.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276021Inst Instance=new A276021Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276022
{
public static readonly long[] Value={ 1L,6L,30L,144L,690L,3348L,16536L,83232L,426618L,2223180L,11756052L,62959680L,340881792L,1862954784L,10262937600L,56926831104L,317632207194L,1781352834300L,10034760283356L,56748881420640L,322033934657628L,1833043230774360L,10462349697348528L,59861990921495616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276022Inst : IEnumerable<long>
{
public static readonly long[] Value=A276022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276022.Bytes);
public long this[int i]=>Value[i];

public static A276022Inst Instance=new A276022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276023
{
public static readonly long[] Value={ 3L,2L,9L,8L,5L,0L,8L,9L,0L,2L,7L,3L,8L,7L,0L,6L,8L,6L,9L,3L,8L,2L,1L,0L,6L,5L,0L,3L,7L,4L,4L,5L,1L,1L,7L,0L,3L,6L,9L,4L,4L,7L,9L,0L,9L,1L,5L,6L,1L,8L,3L,4L,3L,8L,5L,3L,1L,9L,5L,4L,6L,5L,6L,1L,3L,5L,3L,5L,1L,0L,4L,4L,9L,3L,3L,1L,7L,1L,4L,5L,7L,9L,9L,8L,2L,9L,6L,2L,7L,0L,0L,0L,1L,2L,7L,9L,9L,7L,4L,7L,7L,5L,7L,6L,8L,6L,2L,9L,0L,0L,0L,5L,4L,6L,3L,5L,9L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276023Inst : IEnumerable<long>
{
public static readonly long[] Value=A276023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276023.Bytes);
public long this[int i]=>Value[i];

public static A276023Inst Instance=new A276023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276024
{
public static readonly long[] Value={ 1L,3L,7L,14L,27L,47L,81L,130L,210L,319L,492L,718L,1063L,1512L,2178L,3012L,4237L,5765L,7930L,10613L,14364L,18936L,25259L,32938L,43302L,55862L,72694L,92797L,119499L,151468L,193052L,242748L,307135L,383315L,481301L,597252L,744199L,918030L,1137607L,1395101L,1718237L,2098096L,2569047L,3121825L,3805722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276024Inst : IEnumerable<long>
{
public static readonly long[] Value=A276024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276024.Bytes);
public long this[int i]=>Value[i];

public static A276024Inst Instance=new A276024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276025
{
public static readonly BigInteger[] Value={ 2L,23L,337L,4447L,55579L,666667L,7777801L,88888901L,1000000007L,10101010101010101073UL,BigInteger.Parse("1111111111111111111189"),BigInteger.Parse("121212121212121212121327"),BigInteger.Parse("13131313131313131313131439"),BigInteger.Parse("1414141414141414141414141451"),BigInteger.Parse("151515151515151515151515151607"),BigInteger.Parse("16161616161616161616161616161709"),BigInteger.Parse("1717171717171717171717171717171741") };
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
public class A276025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276025Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276025.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276025.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276025Inst Instance=new A276025Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276026
{
public static readonly long[] Value={ 140L,204L,284L,380L,492L,620L,764L,924L,1100L,1292L,1500L,1724L,1964L,2220L,2492L,2780L,3084L,3404L,3740L,4092L,4460L,4844L,5244L,5660L,6092L,6540L,7004L,7484L,7980L,8492L,9020L,9564L,10124L,10700L,11292L,11900L,12524L,13164L,13820L,14492L,15180L,15884L,16604L,17340L,18092L,18860L,19644L,20444L,21260L,22092L,22940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276026Inst : IEnumerable<long>
{
public static readonly long[] Value=A276026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276026.Bytes);
public long this[int i]=>Value[i];

public static A276026Inst Instance=new A276026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276027
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,7L,18L,43L,93L,266L,702L,1687L,5136L,14405L,36898L,117016L,341842L,914064L,2983027L,8972121L,24743851L,82478973L,253555061L,715745648L,2424954125L,7582390623L,21796481477L,74805170349L,237095926682L,691568408221L,2398418942361L,7686495623620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276027Inst : IEnumerable<long>
{
public static readonly long[] Value=A276027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276027.Bytes);
public long this[int i]=>Value[i];

public static A276027Inst Instance=new A276027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276028
{
public static readonly long[] Value={ 1L,3L,10L,50L,259L,1540L,9594L,62649L,422598L,2960716L,21030711L,152470357L,1129502128L,8434189996L,63674017174L,488573782216L,3762932025753L,29178861276815L,229208503750838L,1803350026315019L,14248236439629534L,113825380196996557L,909507867095014380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276028Inst : IEnumerable<long>
{
public static readonly long[] Value=A276028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276028.Bytes);
public long this[int i]=>Value[i];

public static A276028Inst Instance=new A276028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276029
{
public static readonly BigInteger[] Value={ 1L,4L,27L,228L,2226L,23778L,270693L,3229106L,39922172L,507680620L,6604676830L,87549425068L,1178880306174L,16086844260290L,222045139578443L,3095457073064120L,43529719213465854L,616853383573066504L,8801227720060618544L,BigInteger.Parse("126344910516550743232") };
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
public class A276029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276029Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276029.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276029.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276029Inst Instance=new A276029Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276030
{
public static readonly long[] Value={ 2L,11L,131L,251L,491L,599L,1439L,3371L,5639L,5879L,6971L,7079L,8039L,8291L,9839L,10799L,11171L,12119L,14879L,16931L,17159L,18839L,23039L,23159L,25919L,50291L,53411L,53639L,59051L,69371L,74771L,74891L,75239L,81119L,81359L,117839L,119039L,126839L,130811L,131771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276030Inst : IEnumerable<long>
{
public static readonly long[] Value=A276030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276030.Bytes);
public long this[int i]=>Value[i];

public static A276030Inst Instance=new A276030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276031
{
public static readonly long[] Value={ 0L,1L,2L,5L,9L,14L,21L,30L,41L,54L,70L,89L,110L,135L,164L,195L,231L,272L,315L,364L,419L,476L,540L,611L,684L,765L,854L,945L,1045L,1154L,1265L,1386L,1517L,1650L,1794L,1949L,2106L,2275L,2456L,2639L,2835L,3044L,3255L,3480L,3719L,3960L,4216L,4487L,4760L,5049L,5354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276031Inst : IEnumerable<long>
{
public static readonly long[] Value=A276031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276031.Bytes);
public long this[int i]=>Value[i];

public static A276031Inst Instance=new A276031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276032
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,21L,22L,63L,64L,195L,196L,624L,625L,2054L,2055L,6916L,6917L,23712L,23713L,82498L,82499L,290510L,290511L,1033410L,1033411L,3707850L,3707851L,13402695L,13402696L,48760365L,48760366L,178405155L,178405156L,656043855L,656043856L,2423307045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276032Inst : IEnumerable<long>
{
public static readonly long[] Value=A276032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276032.Bytes);
public long this[int i]=>Value[i];

public static A276032Inst Instance=new A276032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276033
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,17L,22L,50L,64L,154L,196L,493L,625L,1626L,2055L,5487L,6917L,18851L,23713L,65703L,82499L,231725L,290511L,825399L,1033411L,2964951L,3707851L,10728256L,13402696L,39065521L,48760366L,143047486L,178405156L,526399066L,656043856L,1945668346L,2423307046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276033Inst : IEnumerable<long>
{
public static readonly long[] Value=A276033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276033.Bytes);
public long this[int i]=>Value[i];

public static A276033Inst Instance=new A276033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276034
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,0L,3L,2L,1L,2L,2L,2L,1L,2L,1L,0L,2L,1L,1L,2L,2L,3L,3L,2L,2L,2L,2L,3L,2L,1L,2L,4L,3L,1L,5L,3L,2L,5L,1L,2L,2L,2L,5L,2L,3L,4L,5L,3L,2L,5L,2L,1L,4L,0L,1L,5L,3L,1L,3L,5L,4L,4L,3L,2L,4L,3L,3L,4L,2L,3L,7L,2L,2L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276034Inst : IEnumerable<long>
{
public static readonly long[] Value=A276034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276034.Bytes);
public long this[int i]=>Value[i];

public static A276034Inst Instance=new A276034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276035
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,4L,3L,5L,11L,6L,13L,7L,15L,4L,17L,3L,19L,5L,7L,11L,23L,6L,5L,13L,6L,14L,29L,15L,31L,4L,33L,17L,35L,6L,37L,19L,13L,10L,41L,7L,43L,22L,15L,23L,47L,6L,7L,5L,51L,13L,53L,6L,11L,14L,19L,29L,59L,15L,61L,31L,21L,4L,65L,33L,67L,17L,69L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276035Inst : IEnumerable<long>
{
public static readonly long[] Value=A276035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276035.Bytes);
public long this[int i]=>Value[i];

public static A276035Inst Instance=new A276035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276148
{
public static readonly long[] Value={ 3L,9L,5L,27L,15L,15L,21L,81L,15L,45L,33L,45L,39L,63L,7L,243L,51L,25L,57L,135L,35L,99L,69L,135L,75L,117L,45L,189L,87L,21L,93L,729L,55L,153L,105L,75L,111L,171L,65L,405L,123L,105L,129L,297L,21L,207L,141L,405L,147L,225L,85L,351L,159L,75L,165L,567L,95L,261L,177L,63L,183L,279L,105L,2187L,195L,165L,201L,459L,115L,315L,213L,225L,219L,333L,35L,513L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276148Inst : IEnumerable<long>
{
public static readonly long[] Value=A276148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276148.Bytes);
public long this[int i]=>Value[i];

public static A276148Inst Instance=new A276148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276149
{
public static readonly long[] Value={ 0L,1L,4L,4L,2L,2L,18L,18L,18L,18L,18L,18L,12L,12L,12L,12L,12L,12L,6L,6L,6L,6L,6L,6L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,72L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276149Inst : IEnumerable<long>
{
public static readonly long[] Value=A276149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276149.Bytes);
public long this[int i]=>Value[i];

public static A276149Inst Instance=new A276149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276150
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,1L,2L,2L,3L,3L,4L,2L,3L,3L,4L,4L,5L,3L,4L,4L,5L,5L,6L,4L,5L,5L,6L,6L,7L,1L,2L,2L,3L,3L,4L,2L,3L,3L,4L,4L,5L,3L,4L,4L,5L,5L,6L,4L,5L,5L,6L,6L,7L,5L,6L,6L,7L,7L,8L,2L,3L,3L,4L,4L,5L,3L,4L,4L,5L,5L,6L,4L,5L,5L,6L,6L,7L,5L,6L,6L,7L,7L,8L,6L,7L,7L,8L,8L,9L,3L,4L,4L,5L,5L,6L,4L,5L,5L,6L,6L,7L,5L,6L,6L,7L,7L,8L,6L,7L,7L,8L,8L,9L,7L,8L,8L,9L,9L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276150Inst : IEnumerable<long>
{
public static readonly long[] Value=A276150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276150.Bytes);
public long this[int i]=>Value[i];

public static A276150Inst Instance=new A276150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276151
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,0L,6L,6L,8L,8L,10L,6L,12L,12L,14L,14L,16L,12L,18L,18L,20L,20L,22L,18L,24L,24L,26L,26L,28L,0L,30L,30L,32L,32L,34L,30L,36L,36L,38L,38L,40L,36L,42L,42L,44L,44L,46L,42L,48L,48L,50L,50L,52L,48L,54L,54L,56L,56L,58L,30L,60L,60L,62L,62L,64L,60L,66L,66L,68L,68L,70L,66L,72L,72L,74L,74L,76L,72L,78L,78L,80L,80L,82L,78L,84L,84L,86L,86L,88L,60L,90L,90L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276151Inst : IEnumerable<long>
{
public static readonly long[] Value=A276151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276151.Bytes);
public long this[int i]=>Value[i];

public static A276151Inst Instance=new A276151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276152
{
public static readonly long[] Value={ 2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,210L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,210L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,210L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L,2L,6L,2L,30L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276152Inst : IEnumerable<long>
{
public static readonly long[] Value=A276152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276152.Bytes);
public long this[int i]=>Value[i];

public static A276152Inst Instance=new A276152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276153
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276153Inst : IEnumerable<long>
{
public static readonly long[] Value=A276153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276153.Bytes);
public long this[int i]=>Value[i];

public static A276153Inst Instance=new A276153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276154
{
public static readonly long[] Value={ 0L,2L,6L,8L,12L,14L,30L,32L,36L,38L,42L,44L,60L,62L,66L,68L,72L,74L,90L,92L,96L,98L,102L,104L,120L,122L,126L,128L,132L,134L,210L,212L,216L,218L,222L,224L,240L,242L,246L,248L,252L,254L,270L,272L,276L,278L,282L,284L,300L,302L,306L,308L,312L,314L,330L,332L,336L,338L,342L,344L,420L,422L,426L,428L,432L,434L,450L,452L,456L,458L,462L,464L,480L,482L,486L,488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276154Inst : IEnumerable<long>
{
public static readonly long[] Value=A276154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276154.Bytes);
public long this[int i]=>Value[i];

public static A276154Inst Instance=new A276154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276155
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,10L,11L,13L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,33L,34L,35L,37L,39L,40L,41L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,63L,64L,65L,67L,69L,70L,71L,73L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,91L,93L,94L,95L,97L,99L,100L,101L,103L,105L,106L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276155Inst : IEnumerable<long>
{
public static readonly long[] Value=A276155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276155.Bytes);
public long this[int i]=>Value[i];

public static A276155Inst Instance=new A276155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276156
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,8L,9L,30L,31L,32L,33L,36L,37L,38L,39L,210L,211L,212L,213L,216L,217L,218L,219L,240L,241L,242L,243L,246L,247L,248L,249L,2310L,2311L,2312L,2313L,2316L,2317L,2318L,2319L,2340L,2341L,2342L,2343L,2346L,2347L,2348L,2349L,2520L,2521L,2522L,2523L,2526L,2527L,2528L,2529L,2550L,2551L,2552L,2553L,2556L,2557L,2558L,2559L,30030L,30031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276156Inst : IEnumerable<long>
{
public static readonly long[] Value=A276156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276156.Bytes);
public long this[int i]=>Value[i];

public static A276156Inst Instance=new A276156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276157
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,6L,3L,6L,3L,6L,1L,6L,3L,6L,3L,6L,1L,6L,3L,6L,3L,6L,1L,6L,3L,6L,3L,6L,1L,30L,15L,30L,15L,30L,5L,30L,15L,30L,15L,30L,5L,30L,15L,30L,15L,30L,5L,30L,15L,30L,15L,30L,5L,30L,15L,30L,15L,30L,1L,30L,15L,30L,15L,30L,5L,30L,15L,30L,15L,30L,5L,30L,15L,30L,15L,30L,5L,30L,15L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276157Inst : IEnumerable<long>
{
public static readonly long[] Value=A276157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276157.Bytes);
public long this[int i]=>Value[i];

public static A276157Inst Instance=new A276157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276158
{
public static readonly long[] Value={ 1L,2L,6L,3L,12L,12L,4L,18L,24L,18L,5L,24L,36L,36L,24L,6L,30L,48L,54L,48L,30L,7L,36L,60L,72L,72L,60L,36L,8L,42L,72L,90L,96L,90L,72L,42L,9L,48L,84L,108L,120L,120L,108L,84L,48L,10L,54L,96L,126L,144L,150L,144L,126L,96L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276158Inst : IEnumerable<long>
{
public static readonly long[] Value=A276158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276158.Bytes);
public long this[int i]=>Value[i];

public static A276158Inst Instance=new A276158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276159
{
public static readonly long[] Value={ 1L,16L,106L,416L,1211L,2912L,6132L,11712L,20757L,34672L,55198L,84448L,124943L,179648L,252008L,345984L,466089L,617424L,805714L,1037344L,1319395L,1659680L,2066780L,2550080L,3119805L,3787056L,4563846L,5463136L,6498871L,7686016L,9040592L,10579712L,12321617L,14285712L,16492602L,18964128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276159Inst : IEnumerable<long>
{
public static readonly long[] Value=A276159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276159.Bytes);
public long this[int i]=>Value[i];

public static A276159Inst Instance=new A276159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276160
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,33L,1153L,266337L,2149605893L,4007637093066433L,BigInteger.Parse("60303882185826956720761345"),BigInteger.Parse("1691732525726797389070758961468800814420801"),BigInteger.Parse("714126272449521825808382965880022542720530687818734820147878380094981") };
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
public class A276160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276160Inst Instance=new A276160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276161
{
public static readonly long[] Value={ 840L,5040L,11880L,175560L,570024L,5997600L,34234200L,70073640L,569729160L,1262451960L,6643717080L,6927399360L,59312218680L,657557188200L,1288881113520L,7994422608480L,9803968814640L,73148660184600L,130903460103024L,250036769127600L,1081389616791120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276161Inst : IEnumerable<long>
{
public static readonly long[] Value=A276161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276161.Bytes);
public long this[int i]=>Value[i];

public static A276161Inst Instance=new A276161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276162
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,3L,4L,1L,1L,1L,2L,3L,4L,1L,1L,2L,1L,8L,3L,8L,1L,1L,1L,6L,1L,8L,9L,8L,1L,1L,2L,1L,12L,5L,16L,9L,16L,1L,1L,1L,2L,1L,12L,5L,16L,9L,16L,1L,1L,2L,3L,8L,1L,72L,5L,64L,27L,32L,1L,1L,1L,2L,3L,8L,1L,72L,5L,64L,27L,32L,1L,1L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276162Inst : IEnumerable<long>
{
public static readonly long[] Value=A276162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276162.Bytes);
public long this[int i]=>Value[i];

public static A276162Inst Instance=new A276162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276163
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,9L,6L,16L,9L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276163Inst : IEnumerable<long>
{
public static readonly long[] Value=A276163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276163.Bytes);
public long this[int i]=>Value[i];

public static A276163Inst Instance=new A276163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276228
{
public static readonly long[] Value={ 3L,-1L,-3L,8L,-3L,-16L,30L,-1L,-75L,107L,42L,-331L,354L,350L,-1389L,1043L,2085L,-5560L,2433L,10772L,-21198L,2087L,51081L,-76453L,-23622L,227609L,-256818L,-222022L,963267L,-776041L,-1372515L,3887864L,-1918875L,-7229368L,14954982L,-2415121L,-34724211L,54509435L,12523866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276228Inst : IEnumerable<long>
{
public static readonly long[] Value=A276228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276228.Bytes);
public long this[int i]=>Value[i];

public static A276228Inst Instance=new A276228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276229
{
public static readonly long[] Value={ 0L,0L,1L,-1L,-1L,4L,-3L,-6L,16L,-7L,-31L,61L,-6L,-147L,220L,68L,-655L,739L,639L,-2772L,2233L,3950L,-11188L,5521L,20805L,-43035L,6946L,99929L,-156856L,-36056L,449697L,-534441L,-401009L,1919588L,-1652011L,-2588174L,7811784L,-4287447L,-13924295L,30310973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276229Inst : IEnumerable<long>
{
public static readonly long[] Value=A276229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276229.Bytes);
public long this[int i]=>Value[i];

public static A276229Inst Instance=new A276229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276230
{
public static readonly BigInteger[] Value={ 1L,2L,4L,12L,36L,144L,720L,3600L,25200L,176400L,1587600L,17463600L,192099600L,2497294800L,32464832400L,551902150800L,9382336563600L,178264394708400L,3387023499459600L,77901540487570800L,1791735431214128400L,BigInteger.Parse("44793385780353210000"),BigInteger.Parse("1299008187630243090000") };
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
public class A276230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276230Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276230.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276230Inst Instance=new A276230Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276231
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,37L,441L,4771L,79213L,1320649L,28318321L,636978151L,16863972621L,475580960317L,15055752973561L,508984025190187L,18802677669334861L,739723172361876241L,BigInteger.Parse("31282037176343362785"),BigInteger.Parse("1402437758091393319759"),BigInteger.Parse("66859536126516402568717"),BigInteger.Parse("3362832363918613596662341"),BigInteger.Parse("178500985406930615357763241"),BigInteger.Parse("9950984335825184802962609491"),BigInteger.Parse("582129154096893229447821411597"),BigInteger.Parse("35620632904151979409688095495897"),BigInteger.Parse("2277073896917989779381561818509201") };
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
public class A276231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276231Inst Instance=new A276231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276232
{
public static readonly BigInteger[] Value={ 1L,1L,5L,37L,369L,4641L,70513L,1256361L,25689569L,592998049L,15254145441L,432741923769L,13422771397489L,451956633181041L,16418360947494353L,640101032269166281L,BigInteger.Parse("26659869619363530177"),BigInteger.Parse("1181426235219348415041"),BigInteger.Parse("55506506359841719631425"),BigInteger.Parse("2756055067645593490566489"),BigInteger.Parse("144211201693287134720633681"),BigInteger.Parse("7931567651481815767204102801") };
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
public class A276232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276232Inst Instance=new A276232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276233
{
public static readonly long[] Value={ 257L,129L,259L,65L,261L,131L,263L,33L,265L,133L,267L,67L,269L,135L,271L,17L,273L,137L,275L,69L,277L,139L,279L,35L,281L,141L,283L,71L,285L,143L,287L,9L,289L,145L,291L,73L,293L,147L,295L,37L,297L,149L,299L,75L,301L,151L,303L,19L,305L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276233Inst : IEnumerable<long>
{
public static readonly long[] Value=A276233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276233.Bytes);
public long this[int i]=>Value[i];

public static A276233Inst Instance=new A276233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276234
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,11L,3L,13L,7L,15L,1L,17L,9L,19L,5L,21L,11L,23L,3L,25L,13L,27L,7L,29L,15L,31L,1L,33L,17L,35L,9L,37L,19L,39L,5L,41L,21L,43L,11L,45L,23L,47L,3L,49L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276234Inst : IEnumerable<long>
{
public static readonly long[] Value=A276234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276234.Bytes);
public long this[int i]=>Value[i];

public static A276234Inst Instance=new A276234Inst();

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