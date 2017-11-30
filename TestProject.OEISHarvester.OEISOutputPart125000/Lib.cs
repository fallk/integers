using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A154305
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,-6L,0L,1L,1L,0L,20L,0L,-26L,0L,20L,0L,1L,1L,0L,-88L,0L,92L,0L,-872L,0L,1990L,0L,-872L,0L,92L,0L,-88L,0L,1L,1L,0L,336L,0L,-3336L,0L,6961L,0L,-77796L,0L,-647088L,0L,2618568L,0L,-3600784L,0L,3346502L,0L,-3600784L,0L,2618568L,0L,-647088L,0L,-77796L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154305Inst : IEnumerable<long>
{
public static readonly long[] Value=A154305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154305.Bytes);
public long this[int i]=>Value[i];

public static A154305Inst Instance=new A154305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154306
{
public static readonly BigInteger[] Value={ 1L,32L,540L,7680L,105000L,1451520L,20744640L,309657600L,4849891200L,79833600000L,1381360780800L,25107347865600L,478826764416000L,9568689242112000L,200074178304000000L,4370687116443648000L,BigInteger.Parse("99607063051431936000") };
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
public class A154306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154306Inst Instance=new A154306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154307
{
public static readonly BigInteger[] Value={ 1L,80L,2430L,53760L,1050000L,19595520L,363031200L,6812467200L,130947062400L,2594592000000L,53182390060800L,1129830653952000L,24898991749632000L,569337009905664000L,13505007035520000000UL,BigInteger.Parse("332172220849717248000") };
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
public class A154307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154307Inst Instance=new A154307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154308
{
public static readonly BigInteger[] Value={ 1L,192L,10206L,344064L,9450000L,235146240L,5590680480L,130799370240L,3064161260160L,72648576000000L,1755018872006400L,43385497111756800L,1100535435333734400L,BigInteger.Parse("28694585299245465600"),BigInteger.Parse("769785401024640000000") };
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
public class A154308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154308Inst Instance=new A154308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154309
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,7L,9L,9L,0L,6L,0L,4L,7L,0L,3L,0L,7L,2L,0L,1L,3L,2L,2L,7L,0L,8L,8L,4L,7L,5L,2L,2L,3L,1L,5L,7L,7L,8L,7L,6L,1L,4L,5L,4L,6L,7L,2L,6L,3L,6L,7L,9L,1L,2L,3L,1L,7L,9L,4L,8L,7L,8L,4L,1L,9L,4L,7L,6L,1L,8L,3L,9L,5L,5L,4L,4L,3L,4L,1L,7L,6L,6L,7L,1L,5L,7L,9L,2L,1L,7L,6L,7L,6L,0L,3L,8L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154309Inst : IEnumerable<long>
{
public static readonly long[] Value=A154309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154309.Bytes);
public long this[int i]=>Value[i];

public static A154309Inst Instance=new A154309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154310
{
public static readonly long[] Value={ 1L,5L,1L,8L,7L,3L,7L,2L,4L,7L,4L,7L,7L,9L,0L,3L,9L,1L,4L,7L,4L,4L,2L,9L,8L,7L,5L,0L,1L,7L,6L,8L,0L,5L,1L,3L,4L,3L,9L,6L,5L,2L,3L,3L,5L,3L,3L,9L,0L,3L,3L,4L,6L,9L,5L,9L,9L,3L,9L,9L,9L,9L,1L,0L,0L,4L,5L,7L,3L,1L,7L,8L,9L,9L,6L,9L,6L,4L,8L,3L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154310Inst : IEnumerable<long>
{
public static readonly long[] Value=A154310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154310.Bytes);
public long this[int i]=>Value[i];

public static A154310Inst Instance=new A154310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154311
{
public static readonly long[] Value={ 5L,6L,9L,18L,26L,27L,28L,29L,36L,38L,47L,48L,49L,53L,54L,58L,64L,65L,66L,67L,68L,69L,79L,82L,83L,84L,86L,89L,96L,97L,98L,99L,126L,156L,169L,170L,172L,173L,174L,177L,178L,179L,185L,186L,187L,188L,189L,190L,191L,192L,193L,194L,196L,197L,198L,199L,216L,252L,255L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154311Inst : IEnumerable<long>
{
public static readonly long[] Value=A154311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154311.Bytes);
public long this[int i]=>Value[i];

public static A154311Inst Instance=new A154311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154312
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,3L,0L,0L,3L,5L,0L,0L,0L,7L,9L,0L,0L,0L,0L,15L,17L,0L,0L,0L,0L,0L,31L,33L,0L,0L,0L,0L,0L,0L,63L,65L,0L,0L,0L,0L,0L,0L,0L,127L,129L,0L,0L,0L,0L,0L,0L,0L,0L,255L,257L,0L,0L,0L,0L,0L,0L,0L,0L,0L,511L,513L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1023L,1025L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154312Inst : IEnumerable<long>
{
public static readonly long[] Value=A154312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154312.Bytes);
public long this[int i]=>Value[i];

public static A154312Inst Instance=new A154312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154313
{
public static readonly long[] Value={ 1L,2L,7L,13L,16L,29L,32L,38L,53L,54L,56L,63L,66L,68L,69L,76L,88L,94L,126L,156L,175L,176L,182L,183L,191L,192L,212L,213L,218L,227L,248L,252L,255L,258L,259L,280L,282L,286L,291L,293L,294L,295L,298L,306L,307L,321L,323L,324L,325L,326L,331L,334L,335L,338L,345L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154313Inst : IEnumerable<long>
{
public static readonly long[] Value=A154313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154313.Bytes);
public long this[int i]=>Value[i];

public static A154313Inst Instance=new A154313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154314
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,22L,23L,24L,25L,26L,27L,28L,30L,31L,36L,37L,39L,40L,41L,43L,44L,49L,50L,52L,53L,54L,56L,60L,62L,67L,68L,70L,71L,72L,74L,76L,77L,78L,79L,80L,81L,82L,84L,85L,90L,91L,93L,94L,108L,109L,111L,112L,117L,118L,120L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154314Inst : IEnumerable<long>
{
public static readonly long[] Value=A154314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154314.Bytes);
public long this[int i]=>Value[i];

public static A154314Inst Instance=new A154314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154315
{
public static readonly long[] Value={ 1L,5L,8L,10L,14L,15L,19L,23L,27L,28L,38L,39L,43L,46L,47L,50L,56L,61L,70L,77L,83L,85L,92L,97L,100L,104L,112L,113L,115L,120L,126L,127L,135L,136L,143L,144L,146L,149L,155L,156L,157L,158L,161L,163L,166L,167L,170L,173L,175L,177L,183L,184L,185L,189L,192L,195L,201L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154315Inst : IEnumerable<long>
{
public static readonly long[] Value=A154315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154315.Bytes);
public long this[int i]=>Value[i];

public static A154315Inst Instance=new A154315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154316
{
public static readonly long[] Value={ 2L,3L,17L,41L,53L,109L,131L,163L,241L,251L,263L,307L,317L,337L,347L,383L,457L,491L,701L,911L,1039L,1049L,1091L,1093L,1153L,1163L,1301L,1303L,1361L,1433L,1571L,1601L,1613L,1627L,1637L,1811L,1831L,1871L,1901L,1913L,1931L,1933L,1973L,2017L,2027L,2131L,2141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154316Inst : IEnumerable<long>
{
public static readonly long[] Value=A154316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154316.Bytes);
public long this[int i]=>Value[i];

public static A154316Inst Instance=new A154316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154317
{
public static readonly long[] Value={ 1L,3L,15L,17L,19L,22L,25L,37L,47L,77L,82L,91L,97L,98L,104L,110L,135L,136L,139L,147L,157L,159L,162L,180L,190L,197L,233L,237L,239L,249L,260L,266L,270L,278L,282L,293L,299L,310L,316L,327L,334L,346L,353L,369L,380L,402L,404L,413L,415L,417L,426L,429L,452L,474L,489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154317Inst : IEnumerable<long>
{
public static readonly long[] Value=A154317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154317.Bytes);
public long this[int i]=>Value[i];

public static A154317Inst Instance=new A154317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154318
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,14L,16L,18L,21L,25L,34L,35L,41L,48L,61L,65L,70L,74L,89L,91L,94L,100L,109L,114L,120L,129L,138L,149L,155L,156L,157L,160L,171L,181L,182L,195L,200L,204L,208L,212L,216L,227L,233L,234L,240L,241L,243L,250L,257L,264L,265L,268L,273L,276L,280L,289L,292L,295L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154318Inst : IEnumerable<long>
{
public static readonly long[] Value=A154318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154318.Bytes);
public long this[int i]=>Value[i];

public static A154318Inst Instance=new A154318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154319
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,23L,31L,37L,41L,43L,71L,73L,101L,131L,151L,163L,167L,173L,181L,197L,211L,233L,251L,263L,277L,283L,317L,353L,373L,383L,401L,431L,433L,467L,491L,547L,557L,571L,587L,593L,607L,643L,653L,701L,727L,733L,761L,823L,857L,881L,907L,911L,937L,983L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154319Inst : IEnumerable<long>
{
public static readonly long[] Value=A154319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154319.Bytes);
public long this[int i]=>Value[i];

public static A154319Inst Instance=new A154319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154320
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,19L,23L,29L,53L,67L,79L,83L,89L,97L,107L,113L,137L,167L,179L,199L,229L,233L,239L,269L,277L,283L,313L,359L,379L,383L,397L,419L,457L,463L,487L,547L,563L,577L,599L,607L,617L,619L,647L,673L,677L,683L,709L,727L,733L,739L,787L,797L,809L,823L,827L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154320Inst : IEnumerable<long>
{
public static readonly long[] Value=A154320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154320.Bytes);
public long this[int i]=>Value[i];

public static A154320Inst Instance=new A154320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154321
{
public static readonly long[] Value={ 3L,5L,7L,13L,23L,167L,233L,277L,283L,383L,547L,607L,727L,733L,823L,1087L,1427L,1597L,1823L,2297L,3253L,3313L,3533L,3593L,3863L,4027L,4133L,4363L,6257L,6737L,7477L,7577L,7907L,9043L,9227L,11317L,11497L,11833L,11867L,12373L,12503L,12637L,12743L,13367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154321Inst : IEnumerable<long>
{
public static readonly long[] Value=A154321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154321.Bytes);
public long this[int i]=>Value[i];

public static A154321Inst Instance=new A154321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154322
{
public static readonly long[] Value={ 1L,2L,4L,10L,26L,62L,133L,260L,471L,802L,1298L,2014L,3016L,4382L,6203L,8584L,11645L,15522L,20368L,26354L,33670L,42526L,53153L,65804L,80755L,98306L,118782L,142534L,169940L,201406L,237367L,278288L,324665L,377026L,435932L,501978L,575794L,658046L,749437L,850708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154322Inst : IEnumerable<long>
{
public static readonly long[] Value=A154322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154322.Bytes);
public long this[int i]=>Value[i];

public static A154322Inst Instance=new A154322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154323
{
public static readonly long[] Value={ 1L,2L,10L,37L,101L,226L,442L,785L,1297L,2026L,3026L,4357L,6085L,8282L,11026L,14401L,18497L,23410L,29242L,36101L,44101L,53362L,64010L,76177L,90001L,105626L,123202L,142885L,164837L,189226L,216226L,246017L,278785L,314722L,354026L,396901L,443557L,494210L,549082L,608401L,672401L,741322L,815410L,894917L,980101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154323Inst : IEnumerable<long>
{
public static readonly long[] Value=A154323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154323.Bytes);
public long this[int i]=>Value[i];

public static A154323Inst Instance=new A154323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154324
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,12L,23L,43L,74L,124L,195L,300L,441L,637L,890L,1226L,1647L,2187L,2848L,3673L,4664L,5874L,7305L,9021L,11024L,13390L,16121L,19306L,22947L,27147L,31908L,37348L,43469L,50405L,58158L,66879L,76570L,87400L,99371L,112671L,127302L,143472L,161183L,180664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154324Inst : IEnumerable<long>
{
public static readonly long[] Value=A154324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154324.Bytes);
public long this[int i]=>Value[i];

public static A154324Inst Instance=new A154324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154325
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154325Inst : IEnumerable<long>
{
public static readonly long[] Value=A154325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154325.Bytes);
public long this[int i]=>Value[i];

public static A154325Inst Instance=new A154325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154326
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,0L,0L,3L,1L,0L,1L,0L,0L,2L,1L,0L,0L,2L,0L,0L,3L,1L,0L,0L,0L,1L,0L,0L,2L,1L,0L,0L,1L,0L,2L,0L,0L,3L,1L,1L,1L,0L,1L,0L,1L,0L,0L,6L,1L,0L,0L,1L,0L,1L,0L,4L,0L,0L,2L,1L,0L,1L,2L,2L,0L,1L,0L,1L,0L,0L,5L,1L,0L,0L,0L,3L,1L,0L,1L,0L,2L,0L,0L,5L,1L,0L,0L,0L,1L,2L,2L,0L,2L,0L,2L,0L,0L,2L,1L,0L,0L,1L,0L,2L,2L,5L,0L,1L,0L,4L,0L,0L,3L,1L,1L,1L,0L,1L,0L,1L,3L,4L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154326Inst : IEnumerable<long>
{
public static readonly long[] Value=A154326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154326.Bytes);
public long this[int i]=>Value[i];

public static A154326Inst Instance=new A154326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154327
{
public static readonly long[] Value={ 1L,1L,2L,5L,8L,15L,24L,41L,66L,109L,176L,287L,464L,753L,1218L,1973L,3192L,5167L,8360L,13529L,21890L,35421L,57312L,92735L,150048L,242785L,392834L,635621L,1028456L,1664079L,2692536L,4356617L,7049154L,11405773L,18454928L,29860703L,48315632L,78176337L,126491970L,204668309L,331160280L,535828591L,866988872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154327Inst : IEnumerable<long>
{
public static readonly long[] Value=A154327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154327.Bytes);
public long this[int i]=>Value[i];

public static A154327Inst Instance=new A154327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154328
{
public static readonly ulong[] Value={ 1L,10L,11L,12L,20L,111L,112L,120L,1000L,1001L,1002L,1003L,1004L,1005L,1006L,1007L,1008L,1009L,1010L,1011L,1012L,1013L,1014L,1015L,1016L,10000L,10000000000000000000UL,10000000800000000000UL,10000000800000000001UL,10000000800000000002UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154328Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A154328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154328.Bytes);
public ulong this[int i]=>Value[i];

public static A154328Inst Instance=new A154328Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154329
{
public static readonly long[] Value={ 2L,5L,6L,8L,9L,26L,27L,28L,71L,72L,73L,487L,488L,489L,490L,491L,492L,493L,494L,495L,496L,497L,498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154329Inst : IEnumerable<long>
{
public static readonly long[] Value=A154329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154329.Bytes);
public long this[int i]=>Value[i];

public static A154329Inst Instance=new A154329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154330
{
public static readonly BigInteger[] Value={ 10L,20L,111L,120L,1000L,10000L,10000000000000000000UL,10000000800000000000UL,13999999999999999999UL,BigInteger.Parse("99999999911111111111"),BigInteger.Parse("111110000000000000000"),BigInteger.Parse("111112999999999999999"),BigInteger.Parse("999999999999999999999"),BigInteger.Parse("9999999999999999999999") };
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
public class A154330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154330Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154330.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154330.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154330Inst Instance=new A154330Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154331
{
public static readonly long[] Value={ 1L,3L,4L,6L,11L,13L,17L,20L,29L,39L,94L,108L,136L,154L,158L,172L,214L,227L,245L,256L,262L,283L,288L,290L,308L,315L,328L,357L,358L,371L,403L,413L,414L,420L,475L,491L,510L,522L,536L,543L,546L,556L,559L,561L,581L,585L,622L,630L,633L,647L,666L,669L,676L,699L,735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154331Inst : IEnumerable<long>
{
public static readonly long[] Value=A154331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154331.Bytes);
public long this[int i]=>Value[i];

public static A154331Inst Instance=new A154331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154332
{
public static readonly long[] Value={ 3L,2L,32L,15L,17L,4L,7L,6L,35L,8L,11L,10L,14L,21L,12L,28L,65L,9L,56L,18L,136L,568L,23L,99L,101L,20L,13L,27L,34L,30L,143L,145L,38L,16L,19L,47L,195L,91L,197L,175L,26L,51L,59L,799L,69L,62L,163L,255L,257L,66L,31L,717L,2904L,33L,377L,79L,323L,325L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154332Inst : IEnumerable<long>
{
public static readonly long[] Value=A154332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154332.Bytes);
public long this[int i]=>Value[i];

public static A154332Inst Instance=new A154332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154333
{
public static readonly long[] Value={ 1L,4L,2L,15L,4L,20L,19L,28L,53L,39L,35L,47L,81L,40L,11L,127L,13L,56L,135L,79L,45L,39L,67L,135L,249L,152L,83L,48L,53L,104L,207L,7L,216L,100L,26L,431L,28L,116L,270L,496L,277L,104L,546L,503L,524L,615L,139L,368L,685L,391L,155L,732L,652L,648L,726L,55L,293L,631L,170L,704L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154333Inst : IEnumerable<long>
{
public static readonly long[] Value=A154333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154333.Bytes);
public long this[int i]=>Value[i];

public static A154333Inst Instance=new A154333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154334
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,17L,17L,1L,1L,51L,148L,51L,1L,1L,147L,992L,992L,147L,1L,1L,421L,5867L,12982L,5867L,421L,1L,1L,1213L,32475L,137671L,137671L,32475L,1213L,1L,1L,3527L,173110L,1286761L,2415602L,1286761L,173110L,3527L,1L,1L,10343L,902090L,11081582L,35361824L,35361824L,11081582L,902090L,10343L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154334Inst : IEnumerable<long>
{
public static readonly long[] Value=A154334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154334.Bytes);
public long this[int i]=>Value[i];

public static A154334Inst Instance=new A154334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154335
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,35L,35L,1L,1L,126L,394L,126L,1L,1L,417L,3062L,3062L,417L,1L,1L,1324L,19895L,44680L,19895L,1324L,1L,1L,4111L,117021L,503827L,503827L,117021L,4111L,1L,1L,12602L,648616L,4882342L,9193838L,4882342L,648616L,12602L,1L,1L,38333L,3464840L,42960752L,137516234L,137516234L,42960752L,3464840L,38333L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154335Inst : IEnumerable<long>
{
public static readonly long[] Value=A154335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154335.Bytes);
public long this[int i]=>Value[i];

public static A154335Inst Instance=new A154335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154336
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,47L,47L,1L,1L,176L,558L,176L,1L,1L,597L,4442L,4442L,597L,1L,1L,1926L,29247L,65812L,29247L,1926L,1L,1L,6043L,173385L,747931L,747931L,173385L,6043L,1L,1L,18652L,965620L,7279396L,13712662L,7279396L,965620L,18652L,1L,1L,56993L,5173340L,64213532L,205619174L,205619174L,64213532L,5173340L,56993L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154336Inst : IEnumerable<long>
{
public static readonly long[] Value=A154336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154336.Bytes);
public long this[int i]=>Value[i];

public static A154336Inst Instance=new A154336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154337
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,29L,29L,1L,1L,101L,312L,101L,1L,1L,327L,2372L,2372L,327L,1L,1L,1023L,15219L,34114L,15219L,1023L,1L,1L,3145L,88839L,381775L,381775L,88839L,3145L,1L,1L,9577L,490114L,3683815L,6934426L,3683815L,490114L,9577L,1L,1L,29003L,2610590L,32334362L,103464764L,103464764L,32334362L,2610590L,29003L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154337Inst : IEnumerable<long>
{
public static readonly long[] Value=A154337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154337.Bytes);
public long this[int i]=>Value[i];

public static A154337Inst Instance=new A154337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154338
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,-1L,-1L,1L,1L,-24L,-98L,-24L,1L,1L,-123L,-1078L,-1078L,-123L,1L,1L,-482L,-8161L,-18716L,-8161L,-482L,1L,1L,-1685L,-52071L,-228485L,-228485L,-52071L,-1685L,1L,1L,-5548L,-302396L,-2308820L,-4362634L,-2308820L,-302396L,-5548L,1L,1L,-17647L,-1660660L,-20797588L,-66792586L,-66792586L,-20797588L,-1660660L,-17647L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154338Inst : IEnumerable<long>
{
public static readonly long[] Value=A154338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154338.Bytes);
public long this[int i]=>Value[i];

public static A154338Inst Instance=new A154338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154339
{
public static readonly long[] Value={ 1L,1L,6L,7L,3L,5L,8L,7L,5L,9L,7L,3L,6L,3L,9L,6L,3L,4L,6L,6L,8L,9L,8L,0L,1L,2L,0L,3L,6L,2L,2L,2L,6L,4L,2L,4L,7L,9L,3L,0L,8L,8L,3L,2L,9L,3L,3L,6L,2L,4L,1L,5L,6L,7L,3L,2L,1L,9L,6L,1L,2L,0L,8L,7L,4L,8L,3L,7L,2L,6L,5L,9L,4L,3L,7L,4L,1L,9L,7L,4L,5L,8L,6L,9L,5L,8L,7L,8L,6L,7L,6L,3L,8L,7L,1L,5L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154339Inst : IEnumerable<long>
{
public static readonly long[] Value=A154339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154339.Bytes);
public long this[int i]=>Value[i];

public static A154339Inst Instance=new A154339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154340
{
public static readonly long[] Value={ 1L,10L,83L,660L,5189L,40670L,318487L,2493480L,19520521L,152816050L,1196311643L,9365243580L,73315137869L,573942237830L,4493065034527L,35173632302160L,275354217434641L,2155590425209690L,16874882555708003L,132103788328515300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154340Inst : IEnumerable<long>
{
public static readonly long[] Value=A154340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154340.Bytes);
public long this[int i]=>Value[i];

public static A154340Inst Instance=new A154340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154341
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-3L,1L,1L,-7L,6L,0L,1L,-15L,25L,0L,-6L,1L,-31L,90L,0L,-90L,30L,1L,-63L,301L,0L,-840L,630L,-90L,1L,-127L,966L,0L,-6300L,7980L,-2520L,0L,1L,-255L,3025L,0L,-41706L,79380L,-41580L,0L,2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154341Inst : IEnumerable<long>
{
public static readonly long[] Value=A154341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154341.Bytes);
public long this[int i]=>Value[i];

public static A154341Inst Instance=new A154341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154342
{
public static readonly long[] Value={ 1L,2L,-1L,4L,-5L,1L,8L,-19L,9L,0L,16L,-65L,55L,0L,-6L,32L,-211L,285L,0L,-120L,30L,64L,-665L,1351L,0L,-1470L,810L,-90L,128L,-2059L,6069L,0L,-14280L,13020L,-3150L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154342Inst : IEnumerable<long>
{
public static readonly long[] Value=A154342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154342.Bytes);
public long this[int i]=>Value[i];

public static A154342Inst Instance=new A154342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154343
{
public static readonly long[] Value={ 1L,3L,-2L,9L,-16L,4L,27L,-98L,60L,0L,81L,-544L,616L,0L,-96L,243L,-2882L,5400L,0L,-3360L,960L,729L,-14896L,43564L,0L,-72480L,46080L,-5760L,2187L,-75938L,334740L,0L,-1246560L,1323840L,-362880L,0L,6561L,-384064L,2495056L,0L,-18801216L,29675520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154343Inst : IEnumerable<long>
{
public static readonly long[] Value=A154343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154343.Bytes);
public long this[int i]=>Value[i];

public static A154343Inst Instance=new A154343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154344
{
public static readonly long[] Value={ 1L,0L,-2L,0L,-3L,3L,0L,-4L,12L,0L,0L,-5L,35L,0L,-30L,0L,-6L,90L,0L,-360L,180L,0L,-7L,217L,0L,-2730L,3150L,-630L,0L,-8L,504L,0L,-16800L,33600L,-15120L,0L,0L,-9L,1143L,0L,-91854L,283500L,-215460L,0L,22680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154344Inst : IEnumerable<long>
{
public static readonly long[] Value=A154344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154344.Bytes);
public long this[int i]=>Value[i];

public static A154344Inst Instance=new A154344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154345
{
public static readonly long[] Value={ 1L,4L,-2L,12L,-15L,3L,32L,-76L,36L,0L,80L,-325L,275L,0L,-30L,192L,-1266L,1710L,0L,-720L,180L,448L,-4655L,9457L,0L,-10290L,5670L,-630L,1024L,-16472L,48552L,0L,-114240L,104160L,-25200L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154345Inst : IEnumerable<long>
{
public static readonly long[] Value=A154345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154345.Bytes);
public long this[int i]=>Value[i];

public static A154345Inst Instance=new A154345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154346
{
public static readonly long[] Value={ 1L,12L,116L,1056L,9424L,83520L,738368L,6521856L,57587968L,508443648L,4488860672L,39629905920L,349870772224L,3088811900928L,27269361188864L,240745601040384L,2125405099196416L,18763984361226240L,165656469557215232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154346Inst : IEnumerable<long>
{
public static readonly long[] Value=A154346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154346.Bytes);
public long this[int i]=>Value[i];

public static A154346Inst Instance=new A154346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154347
{
public static readonly long[] Value={ 1L,14L,155L,1596L,15989L,158410L,1562191L,15375864L,151212265L,1486561286L,14612155139L,143621159220L,1411597868381L,13873902629314L,136359124206775L,1340197731092976L,13172044142823889L,129460511024722430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154347Inst : IEnumerable<long>
{
public static readonly long[] Value=A154347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154347.Bytes);
public long this[int i]=>Value[i];

public static A154347Inst Instance=new A154347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154348
{
public static readonly long[] Value={ 1L,16L,200L,2304L,25664L,281600L,3068416L,33325056L,361369600L,3915710464L,42414669824L,459354931200L,4974457389056L,53867442077696L,583309459456000L,6316374594945024L,68396663789584384L,740629643316428800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154348Inst : IEnumerable<long>
{
public static readonly long[] Value=A154348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154348.Bytes);
public long this[int i]=>Value[i];

public static A154348Inst Instance=new A154348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154349
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,8L,18L,0L,34L,170L,1643L,3603L,0L,25118L,139063L,474559L,284490L,984006L,6536387L,24265729L,18678366L,96214018L,277799290L,1282283434L,2077807072L,1899874612L,19252363859L,44221482383L,1967547352L,29743945396L,1265868622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154349Inst : IEnumerable<long>
{
public static readonly long[] Value=A154349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154349.Bytes);
public long this[int i]=>Value[i];

public static A154349Inst Instance=new A154349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154350
{
public static readonly long[] Value={ 1L,18L,251L,3204L,39349L,474390L,5666543L,67367304L,798953833L,9463355802L,112016774627L,1325476969740L,15681360907549L,185504677544862L,2194344849556439L,25956365831240976L,307027410944717521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154350Inst : IEnumerable<long>
{
public static readonly long[] Value=A154350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154350.Bytes);
public long this[int i]=>Value[i];

public static A154350Inst Instance=new A154350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154351
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,3L,2L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154351Inst : IEnumerable<long>
{
public static readonly long[] Value=A154351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154351.Bytes);
public long this[int i]=>Value[i];

public static A154351Inst Instance=new A154351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154352
{
public static readonly long[] Value={ 0L,1L,1L,0L,-1L,-1L,0L,-21L,-21L,0L,21L,21L,0L,-903L,-903L,0L,903L,903L,0L,-38829L,-38829L,0L,38829L,38829L,0L,-1669647L,-1669647L,0L,1669647L,1669647L,0L,-71794821L,-71794821L,0L,71794821L,71794821L,0L,-3087177303L,-3087177303L,0L,3087177303L,3087177303L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154352Inst : IEnumerable<long>
{
public static readonly long[] Value=A154352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154352.Bytes);
public long this[int i]=>Value[i];

public static A154352Inst Instance=new A154352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154353
{
public static readonly long[] Value={ 1L,1L,5L,15L,5L,16L,101L,101L,16L,42L,483L,1008L,483L,42L,99L,1926L,7197L,7197L,1926L,99L,219L,6912L,42549L,75645L,42549L,6912L,219L,466L,23272L,224068L,647239L,647239L,224068L,23272L,466L,968L,75306L,1094544L,4847007L,7830372L,4847007L,1094544L,75306L,968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154353Inst : IEnumerable<long>
{
public static readonly long[] Value=A154353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154353.Bytes);
public long this[int i]=>Value[i];

public static A154353Inst Instance=new A154353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154354
{
public static readonly long[] Value={ 2L,13L,41L,269L,2153L,3181L,4409L,9293L,11321L,21433L,27689L,46829L,51257L,70969L,87853L,100109L,106537L,119993L,141677L,157133L,165161L,256441L,277097L,367721L,430861L,444089L,457517L,650281L,858217L,895673L,914701L,1033069L,1053497L,1137209L,1224121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154354Inst : IEnumerable<long>
{
public static readonly long[] Value=A154354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154354.Bytes);
public long this[int i]=>Value[i];

public static A154354Inst Instance=new A154354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154355
{
public static readonly long[] Value={ 13L,2L,41L,130L,269L,458L,697L,986L,1325L,1714L,2153L,2642L,3181L,3770L,4409L,5098L,5837L,6626L,7465L,8354L,9293L,10282L,11321L,12410L,13549L,14738L,15977L,17266L,18605L,19994L,21433L,22922L,24461L,26050L,27689L,29378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154355Inst : IEnumerable<long>
{
public static readonly long[] Value=A154355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154355.Bytes);
public long this[int i]=>Value[i];

public static A154355Inst Instance=new A154355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154356
{
public static readonly long[] Value={ 2L,13L,557L,1129L,1901L,5417L,8761L,10733L,15277L,23593L,30137L,41453L,59341L,74857L,80429L,86201L,92173L,104717L,118061L,179437L,253613L,284729L,306473L,352361L,364333L,414221L,453737L,523597L,598457L,798521L,1068329L,1217933L,1285049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154356Inst : IEnumerable<long>
{
public static readonly long[] Value=A154356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154356.Bytes);
public long this[int i]=>Value[i];

public static A154356Inst Instance=new A154356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154357
{
public static readonly long[] Value={ 2L,13L,74L,185L,346L,557L,818L,1129L,1490L,1901L,2362L,2873L,3434L,4045L,4706L,5417L,6178L,6989L,7850L,8761L,9722L,10733L,11794L,12905L,14066L,15277L,16538L,17849L,19210L,20621L,22082L,23593L,25154L,26765L,28426L,30137L,31898L,33709L,35570L,37481L,39442L,41453L,43514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154357Inst : IEnumerable<long>
{
public static readonly long[] Value=A154357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154357.Bytes);
public long this[int i]=>Value[i];

public static A154357Inst Instance=new A154357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154358
{
public static readonly long[] Value={ 649L,99L,2049L,6499L,13449L,22899L,34849L,49299L,66249L,85699L,107649L,132099L,159049L,188499L,220449L,254899L,291849L,331299L,373249L,417699L,464649L,514099L,566049L,620499L,677449L,736899L,798849L,863299L,930249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154358Inst : IEnumerable<long>
{
public static readonly long[] Value=A154358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154358.Bytes);
public long this[int i]=>Value[i];

public static A154358Inst Instance=new A154358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154359
{
public static readonly long[] Value={ 99L,649L,3699L,9249L,17299L,27849L,40899L,56449L,74499L,95049L,118099L,143649L,171699L,202249L,235299L,270849L,308899L,349449L,392499L,438049L,486099L,536649L,589699L,645249L,703299L,763849L,826899L,892449L,960499L,1031049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154359Inst : IEnumerable<long>
{
public static readonly long[] Value=A154359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154359.Bytes);
public long this[int i]=>Value[i];

public static A154359Inst Instance=new A154359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154360
{
public static readonly long[] Value={ -180L,70L,320L,570L,820L,1070L,1320L,1570L,1820L,2070L,2320L,2570L,2820L,3070L,3320L,3570L,3820L,4070L,4320L,4570L,4820L,5070L,5320L,5570L,5820L,6070L,6320L,6570L,6820L,7070L,7320L,7570L,7820L,8070L,8320L,8570L,8820L,9070L,9320L,9570L,9820L,10070L,10320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154360Inst : IEnumerable<long>
{
public static readonly long[] Value=A154360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154360.Bytes);
public long this[int i]=>Value[i];

public static A154360Inst Instance=new A154360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154361
{
public static readonly long[] Value={ -70L,180L,430L,680L,930L,1180L,1430L,1680L,1930L,2180L,2430L,2680L,2930L,3180L,3430L,3680L,3930L,4180L,4430L,4680L,4930L,5180L,5430L,5680L,5930L,6180L,6430L,6680L,6930L,7180L,7430L,7680L,7930L,8180L,8430L,8680L,8930L,9180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154361Inst : IEnumerable<long>
{
public static readonly long[] Value=A154361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154361.Bytes);
public long this[int i]=>Value[i];

public static A154361Inst Instance=new A154361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154362
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,18L,24L,28L,32L,36L,42L,44L,48L,56L,60L,66L,72L,84L,88L,96L,108L,112L,114L,116L,120L,122L,124L,128L,136L,138L,144L,148L,152L,160L,162L,168L,192L,198L,216L,222L,224L,228L,232L,234L,240L,244L,248L,256L,270L,280L,288L,296L,306L,312L,318L,336L,342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154362Inst : IEnumerable<long>
{
public static readonly long[] Value=A154362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154362.Bytes);
public long this[int i]=>Value[i];

public static A154362Inst Instance=new A154362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154363
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,67L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154363Inst : IEnumerable<long>
{
public static readonly long[] Value=A154363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154363.Bytes);
public long this[int i]=>Value[i];

public static A154363Inst Instance=new A154363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154364
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,3L,2L,2L,1L,4L,2L,2L,2L,4L,3L,4L,5L,4L,3L,4L,3L,5L,4L,2L,3L,4L,4L,3L,4L,4L,3L,4L,4L,7L,4L,4L,3L,6L,3L,6L,5L,6L,4L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154364Inst : IEnumerable<long>
{
public static readonly long[] Value=A154364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154364.Bytes);
public long this[int i]=>Value[i];

public static A154364Inst Instance=new A154364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154365
{
public static readonly long[] Value={ 2L,5L,6L,13L,22L,27L,32L,37L,41L,57L,59L,64L,65L,71L,79L,87L,103L,107L,135L,152L,155L,166L,196L,215L,235L,237L,253L,261L,286L,287L,306L,307L,316L,348L,366L,372L,373L,386L,393L,404L,423L,438L,448L,459L,490L,507L,524L,539L,568L,577L,586L,591L,632L,653L,668L,669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154365Inst : IEnumerable<long>
{
public static readonly long[] Value=A154365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154365.Bytes);
public long this[int i]=>Value[i];

public static A154365Inst Instance=new A154365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154366
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,9L,12L,15L,16L,17L,20L,21L,23L,25L,26L,28L,31L,33L,35L,38L,40L,43L,45L,46L,49L,50L,52L,55L,56L,58L,60L,61L,62L,63L,66L,67L,68L,69L,70L,72L,77L,78L,81L,82L,83L,84L,88L,90L,91L,92L,93L,94L,95L,96L,97L,98L,100L,101L,102L,104L,105L,106L,108L,110L,111L,115L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154366Inst : IEnumerable<long>
{
public static readonly long[] Value=A154366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154366.Bytes);
public long this[int i]=>Value[i];

public static A154366Inst Instance=new A154366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154367
{
public static readonly long[] Value={ 18L,30L,36L,39L,44L,53L,54L,73L,76L,86L,112L,113L,116L,126L,132L,134L,141L,160L,163L,175L,191L,194L,197L,211L,214L,219L,231L,233L,250L,258L,265L,276L,279L,294L,295L,301L,308L,311L,312L,320L,325L,331L,333L,335L,338L,340L,341L,350L,351L,361L,376L,383L,385L,394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154367Inst : IEnumerable<long>
{
public static readonly long[] Value=A154367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154367.Bytes);
public long this[int i]=>Value[i];

public static A154367Inst Instance=new A154367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154368
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,4L,3L,3L,5L,2L,3L,0L,6L,8L,3L,6L,7L,6L,9L,2L,0L,6L,5L,0L,5L,1L,5L,7L,9L,4L,2L,3L,2L,8L,4L,3L,0L,8L,2L,9L,7L,2L,9L,1L,8L,8L,3L,8L,7L,0L,6L,8L,2L,7L,1L,8L,0L,1L,1L,9L,0L,9L,7L,4L,9L,9L,7L,5L,5L,3L,0L,9L,1L,6L,3L,0L,1L,9L,4L,2L,4L,0L,8L,0L,7L,6L,4L,7L,4L,5L,4L,2L,5L,8L,8L,9L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154368Inst : IEnumerable<long>
{
public static readonly long[] Value=A154368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154368.Bytes);
public long this[int i]=>Value[i];

public static A154368Inst Instance=new A154368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154369
{
public static readonly long[] Value={ 15L,33L,35L,45L,51L,65L,69L,75L,85L,87L,99L,115L,119L,123L,133L,135L,141L,143L,153L,159L,161L,165L,175L,177L,185L,207L,213L,215L,217L,225L,231L,235L,245L,249L,255L,259L,261L,265L,267L,297L,303L,319L,321L,323L,325L,329L,335L,339L,345L,357L,363L,365L,369L,375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154369Inst : IEnumerable<long>
{
public static readonly long[] Value=A154369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154369.Bytes);
public long this[int i]=>Value[i];

public static A154369Inst Instance=new A154369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154370
{
public static readonly long[] Value={ 5L,7L,8L,11L,16L,18L,19L,23L,25L,27L,28L,30L,34L,36L,39L,42L,43L,50L,53L,54L,56L,57L,60L,62L,65L,72L,74L,76L,82L,83L,89L,91L,93L,95L,98L,102L,105L,108L,111L,114L,115L,119L,122L,128L,132L,134L,138L,139L,143L,147L,151L,153L,159L,161L,163L,170L,175L,176L,178L,182L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154370Inst : IEnumerable<long>
{
public static readonly long[] Value=A154370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154370.Bytes);
public long this[int i]=>Value[i];

public static A154370Inst Instance=new A154370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154371
{
public static readonly long[] Value={ 10L,14L,15L,20L,26L,28L,30L,35L,38L,40L,42L,45L,50L,52L,56L,60L,62L,70L,75L,76L,78L,80L,84L,86L,90L,98L,100L,104L,112L,114L,120L,122L,124L,126L,130L,135L,140L,143L,146L,150L,152L,156L,160L,168L,172L,175L,180L,182L,186L,190L,196L,200L,206L,208L,210L,218L,224L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154371Inst : IEnumerable<long>
{
public static readonly long[] Value=A154371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154371.Bytes);
public long this[int i]=>Value[i];

public static A154371Inst Instance=new A154371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154372
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,12L,9L,1L,1L,32L,54L,16L,1L,1L,80L,270L,160L,25L,1L,1L,192L,1215L,1280L,375L,36L,1L,1L,448L,5103L,8960L,4375L,756L,49L,1L,1L,1024L,20412L,57344L,43750L,12096L,1372L,64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154372Inst : IEnumerable<long>
{
public static readonly long[] Value=A154372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154372.Bytes);
public long this[int i]=>Value[i];

public static A154372Inst Instance=new A154372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154373
{
public static readonly long[] Value={ 6L,12L,18L,22L,24L,34L,36L,44L,46L,48L,54L,58L,66L,68L,72L,74L,82L,88L,92L,94L,96L,102L,106L,108L,110L,116L,118L,132L,134L,136L,138L,142L,144L,148L,154L,158L,162L,164L,166L,170L,174L,176L,178L,184L,188L,192L,194L,198L,202L,204L,212L,214L,216L,220L,222L,226L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154373Inst : IEnumerable<long>
{
public static readonly long[] Value=A154373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154373.Bytes);
public long this[int i]=>Value[i];

public static A154373Inst Instance=new A154373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154374
{
public static readonly long[] Value={ 1151L,4801L,10951L,19601L,30751L,44401L,60551L,79201L,100351L,124001L,150151L,178801L,209951L,243601L,279751L,318401L,359551L,403201L,449351L,498001L,549151L,602801L,658951L,717601L,778751L,842401L,908551L,977201L,1048351L,1122001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154374Inst : IEnumerable<long>
{
public static readonly long[] Value=A154374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154374.Bytes);
public long this[int i]=>Value[i];

public static A154374Inst Instance=new A154374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154375
{
public static readonly long[] Value={ 1351L,5201L,11551L,20401L,31751L,45601L,61951L,80801L,102151L,126001L,152351L,181201L,212551L,246401L,282751L,321601L,362951L,406801L,453151L,502001L,553351L,607201L,663551L,722401L,783751L,847601L,913951L,982801L,1054151L,1128001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154375Inst : IEnumerable<long>
{
public static readonly long[] Value=A154375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154375.Bytes);
public long this[int i]=>Value[i];

public static A154375Inst Instance=new A154375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154376
{
public static readonly long[] Value={ 23L,96L,219L,392L,615L,888L,1211L,1584L,2007L,2480L,3003L,3576L,4199L,4872L,5595L,6368L,7191L,8064L,8987L,9960L,10983L,12056L,13179L,14352L,15575L,16848L,18171L,19544L,20967L,22440L,23963L,25536L,27159L,28832L,30555L,32328L,34151L,36024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154376Inst : IEnumerable<long>
{
public static readonly long[] Value=A154376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154376.Bytes);
public long this[int i]=>Value[i];

public static A154376Inst Instance=new A154376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154377
{
public static readonly long[] Value={ 27L,104L,231L,408L,635L,912L,1239L,1616L,2043L,2520L,3047L,3624L,4251L,4928L,5655L,6432L,7259L,8136L,9063L,10040L,11067L,12144L,13271L,14448L,15675L,16952L,18279L,19656L,21083L,22560L,24087L,25664L,27291L,28968L,30695L,32472L,34299L,36176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154377Inst : IEnumerable<long>
{
public static readonly long[] Value=A154377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154377.Bytes);
public long this[int i]=>Value[i];

public static A154377Inst Instance=new A154377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154378
{
public static readonly long[] Value={ 240L,490L,740L,990L,1240L,1490L,1740L,1990L,2240L,2490L,2740L,2990L,3240L,3490L,3740L,3990L,4240L,4490L,4740L,4990L,5240L,5490L,5740L,5990L,6240L,6490L,6740L,6990L,7240L,7490L,7740L,7990L,8240L,8490L,8740L,8990L,9240L,9490L,9740L,9990L,10240L,10490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154378Inst : IEnumerable<long>
{
public static readonly long[] Value=A154378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154378.Bytes);
public long this[int i]=>Value[i];

public static A154378Inst Instance=new A154378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154379
{
public static readonly long[] Value={ 260L,510L,760L,1010L,1260L,1510L,1760L,2010L,2260L,2510L,2760L,3010L,3260L,3510L,3760L,4010L,4260L,4510L,4760L,5010L,5260L,5510L,5760L,6010L,6260L,6510L,6760L,7010L,7260L,7510L,7760L,8010L,8260L,8510L,8760L,9010L,9260L,9510L,9760L,10010L,10260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154379Inst : IEnumerable<long>
{
public static readonly long[] Value=A154379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154379.Bytes);
public long this[int i]=>Value[i];

public static A154379Inst Instance=new A154379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154380
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,5L,9L,5L,1L,15L,29L,20L,7L,1L,52L,102L,77L,35L,9L,1L,203L,392L,302L,157L,54L,11L,1L,877L,1641L,1235L,683L,277L,77L,13L,1L,4140L,7451L,5324L,2987L,1329L,445L,104L,15L,1L,21147L,36525L,24329L,13391L,6230L,2340L,669L,135L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154380Inst : IEnumerable<long>
{
public static readonly long[] Value=A154380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154380.Bytes);
public long this[int i]=>Value[i];

public static A154380Inst Instance=new A154380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154381
{
public static readonly long[] Value={ 1L,2L,6L,20L,72L,276L,1120L,4804L,21796L,104784L,534788L,2901580L,16742440L,102654356L,667519492L,4590552960L,33278208004L,253436345340L,2020974497112L,16823488830836L,145798111066964L,1312272490908464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154381Inst : IEnumerable<long>
{
public static readonly long[] Value=A154381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154381.Bytes);
public long this[int i]=>Value[i];

public static A154381Inst Instance=new A154381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154382
{
public static readonly long[] Value={ 0L,2L,6L,2L,10L,4L,28L,20L,180L,1800L,1789L,1777L,23101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154382Inst : IEnumerable<long>
{
public static readonly long[] Value=A154382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154382.Bytes);
public long this[int i]=>Value[i];

public static A154382Inst Instance=new A154382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154383
{
public static readonly long[] Value={ 1L,0L,4L,2L,16L,8L,64L,32L,256L,128L,1024L,512L,4096L,2048L,16384L,8192L,65536L,32768L,262144L,131072L,1048576L,524288L,4194304L,2097152L,16777216L,8388608L,67108864L,33554432L,268435456L,134217728L,1073741824L,536870912L,4294967296L,2147483648L,17179869184L,8589934592L,68719476736L,34359738368L,274877906944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154383Inst : IEnumerable<long>
{
public static readonly long[] Value=A154383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154383.Bytes);
public long this[int i]=>Value[i];

public static A154383Inst Instance=new A154383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154384
{
public static readonly long[] Value={ 1L,9L,21L,25L,27L,45L,49L,63L,65L,69L,81L,85L,87L,111L,115L,117L,119L,133L,135L,153L,155L,159L,171L,175L,177L,195L,201L,203L,205L,207L,209L,221L,225L,243L,245L,247L,249L,261L,265L,267L,285L,287L,289L,315L,319L,333L,335L,339L,351L,355L,357L,371L,375L,377L,391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154384Inst : IEnumerable<long>
{
public static readonly long[] Value=A154384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154384.Bytes);
public long this[int i]=>Value[i];

public static A154384Inst Instance=new A154384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154385
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,37L,53L,73L,127L,137L,157L,173L,223L,227L,229L,233L,239L,251L,257L,263L,271L,277L,283L,293L,307L,313L,317L,331L,337L,347L,353L,359L,367L,373L,379L,383L,397L,433L,457L,503L,521L,523L,547L,557L,563L,571L,577L,587L,593L,653L,673L,677L,727L,733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154385Inst : IEnumerable<long>
{
public static readonly long[] Value=A154385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154385.Bytes);
public long this[int i]=>Value[i];

public static A154385Inst Instance=new A154385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154386
{
public static readonly long[] Value={ 11L,19L,41L,61L,89L,101L,103L,107L,109L,113L,131L,139L,149L,151L,163L,167L,179L,181L,191L,193L,197L,199L,211L,241L,269L,281L,311L,349L,389L,401L,409L,419L,421L,431L,439L,443L,449L,461L,463L,467L,479L,487L,491L,499L,509L,541L,569L,599L,601L,607L,613L,617L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154386Inst : IEnumerable<long>
{
public static readonly long[] Value=A154386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154386.Bytes);
public long this[int i]=>Value[i];

public static A154386Inst Instance=new A154386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154387
{
public static readonly long[] Value={ 4L,6L,8L,15L,20L,22L,24L,26L,28L,33L,35L,39L,40L,42L,44L,46L,48L,51L,55L,57L,60L,62L,64L,66L,68L,75L,77L,80L,82L,84L,86L,88L,91L,93L,95L,99L,105L,110L,112L,114L,116L,118L,121L,123L,125L,129L,130L,132L,134L,136L,138L,141L,143L,145L,147L,150L,152L,154L,156L,158L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154387Inst : IEnumerable<long>
{
public static readonly long[] Value=A154387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154387.Bytes);
public long this[int i]=>Value[i];

public static A154387Inst Instance=new A154387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154388
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154388Inst : IEnumerable<long>
{
public static readonly long[] Value=A154388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154388.Bytes);
public long this[int i]=>Value[i];

public static A154388Inst Instance=new A154388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154389
{
public static readonly long[] Value={ 1L,9L,10L,39L,49L,69L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,110L,111L,119L,129L,159L,169L,189L,190L,192L,194L,195L,196L,198L,209L,219L,249L,259L,279L,289L,290L,291L,292L,294L,295L,296L,297L,298L,299L,309L,319L,329L,339L,369L,390L,391L,392L,393L,394L,395L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154389Inst : IEnumerable<long>
{
public static readonly long[] Value=A154389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154389.Bytes);
public long this[int i]=>Value[i];

public static A154389Inst Instance=new A154389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154390
{
public static readonly long[] Value={ 12L,15L,20L,21L,22L,25L,27L,30L,32L,33L,35L,45L,50L,51L,52L,54L,55L,57L,70L,72L,74L,75L,76L,77L,102L,105L,112L,115L,117L,120L,121L,122L,123L,125L,130L,132L,133L,135L,145L,147L,150L,152L,153L,154L,155L,170L,171L,172L,174L,175L,176L,177L,200L,201L,202L,203L,205L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154390Inst : IEnumerable<long>
{
public static readonly long[] Value=A154390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154390.Bytes);
public long this[int i]=>Value[i];

public static A154390Inst Instance=new A154390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154391
{
public static readonly long[] Value={ 2L,10L,12L,38L,42L,44L,50L,52L,56L,142L,150L,154L,166L,170L,172L,178L,180L,184L,202L,204L,210L,212L,226L,232L,240L,542L,558L,570L,598L,602L,614L,618L,620L,654L,662L,666L,678L,682L,684L,690L,692L,696L,714L,716L,722L,724L,738L,744L,752L,796L,806L,810L,812L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154391Inst : IEnumerable<long>
{
public static readonly long[] Value=A154391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154391.Bytes);
public long this[int i]=>Value[i];

public static A154391Inst Instance=new A154391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154392
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,4L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,10L,12L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154392Inst : IEnumerable<long>
{
public static readonly long[] Value=A154392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154392.Bytes);
public long this[int i]=>Value[i];

public static A154392Inst Instance=new A154392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154393
{
public static readonly long[] Value={ 1L,9L,34L,182L,836L,4025L,19001L,90358L,428481L,2034035L,9651787L,45806244L,217378076L,1031612713L,4895689348L,23233383508L,110258103799L,523249458736L,2483172990911L,11784338112247L,55924666344750L,265400424550505L,1259504788813791L,5977203382848010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154393Inst : IEnumerable<long>
{
public static readonly long[] Value=A154393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154393.Bytes);
public long this[int i]=>Value[i];

public static A154393Inst Instance=new A154393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154394
{
public static readonly long[] Value={ 1L,0L,6L,9L,6L,6L,6L,9L,6L,4L,4L,2L,4L,2L,6L,8L,7L,0L,9L,1L,3L,8L,6L,0L,1L,7L,7L,3L,9L,4L,7L,9L,5L,6L,4L,1L,3L,1L,9L,7L,6L,1L,9L,5L,4L,0L,9L,3L,9L,6L,6L,2L,1L,8L,3L,0L,3L,7L,1L,7L,8L,1L,1L,7L,1L,8L,2L,3L,8L,6L,7L,1L,7L,9L,9L,0L,0L,0L,8L,0L,9L,7L,0L,9L,0L,5L,9L,8L,1L,3L,0L,2L,3L,3L,2L,5L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154394Inst : IEnumerable<long>
{
public static readonly long[] Value=A154394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154394.Bytes);
public long this[int i]=>Value[i];

public static A154394Inst Instance=new A154394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154395
{
public static readonly long[] Value={ 1L,0L,3L,2L,2L,1L,1L,5L,5L,5L,1L,8L,2L,7L,1L,2L,9L,0L,6L,1L,4L,8L,6L,1L,9L,9L,8L,6L,0L,2L,7L,6L,9L,4L,0L,2L,6L,8L,2L,4L,9L,0L,5L,6L,2L,2L,7L,8L,2L,3L,2L,8L,0L,6L,0L,1L,9L,8L,2L,4L,2L,5L,5L,5L,8L,7L,2L,6L,2L,8L,4L,1L,4L,1L,1L,9L,5L,2L,7L,7L,2L,4L,5L,4L,8L,0L,1L,0L,6L,4L,4L,9L,1L,3L,3L,3L,2L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154395Inst : IEnumerable<long>
{
public static readonly long[] Value=A154395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154395.Bytes);
public long this[int i]=>Value[i];

public static A154395Inst Instance=new A154395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154396
{
public static readonly long[] Value={ 9L,7L,1L,9L,1L,8L,7L,7L,1L,4L,0L,2L,9L,2L,1L,4L,0L,2L,5L,2L,0L,1L,0L,1L,5L,7L,9L,8L,2L,1L,0L,3L,3L,4L,8L,3L,8L,3L,0L,6L,2L,3L,7L,6L,3L,7L,0L,7L,3L,7L,8L,4L,2L,8L,2L,5L,4L,3L,3L,5L,1L,2L,9L,3L,7L,4L,9L,1L,9L,2L,9L,6L,9L,1L,1L,0L,3L,5L,7L,0L,8L,9L,3L,0L,2L,8L,2L,4L,6L,8L,4L,5L,2L,6L,5L,7L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154396Inst : IEnumerable<long>
{
public static readonly long[] Value=A154396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154396.Bytes);
public long this[int i]=>Value[i];

public static A154396Inst Instance=new A154396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154397
{
public static readonly long[] Value={ 9L,4L,7L,1L,5L,7L,2L,4L,1L,1L,8L,3L,1L,8L,4L,3L,0L,3L,8L,7L,3L,0L,8L,7L,8L,2L,2L,4L,5L,5L,6L,1L,1L,8L,0L,1L,3L,1L,0L,6L,9L,3L,6L,9L,3L,2L,4L,1L,3L,1L,3L,0L,4L,5L,0L,2L,9L,1L,6L,0L,6L,5L,1L,6L,8L,0L,6L,2L,1L,8L,9L,3L,9L,8L,2L,4L,7L,6L,3L,6L,6L,5L,7L,5L,2L,1L,8L,0L,7L,9L,5L,5L,0L,0L,4L,6L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154397Inst : IEnumerable<long>
{
public static readonly long[] Value=A154397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154397.Bytes);
public long this[int i]=>Value[i];

public static A154397Inst Instance=new A154397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154398
{
public static readonly long[] Value={ 9L,2L,5L,1L,0L,9L,9L,2L,9L,5L,3L,5L,2L,7L,3L,0L,4L,0L,0L,9L,9L,2L,0L,3L,1L,6L,3L,5L,6L,4L,1L,7L,3L,6L,8L,3L,4L,0L,7L,1L,0L,9L,1L,0L,0L,4L,4L,7L,7L,5L,9L,3L,4L,2L,3L,8L,4L,6L,1L,5L,8L,8L,1L,4L,6L,0L,7L,1L,3L,7L,9L,6L,6L,5L,8L,2L,5L,6L,3L,2L,5L,0L,3L,6L,8L,4L,4L,1L,3L,2L,5L,7L,0L,2L,8L,8L,7L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154398Inst : IEnumerable<long>
{
public static readonly long[] Value=A154398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154398.Bytes);
public long this[int i]=>Value[i];

public static A154398Inst Instance=new A154398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154399
{
public static readonly long[] Value={ 9L,0L,5L,3L,1L,4L,5L,8L,3L,1L,1L,9L,0L,3L,3L,7L,2L,8L,0L,8L,5L,4L,6L,0L,3L,5L,9L,6L,8L,0L,9L,0L,9L,0L,7L,9L,4L,9L,0L,9L,5L,4L,6L,7L,5L,7L,6L,3L,8L,5L,4L,4L,7L,1L,2L,0L,2L,0L,4L,0L,2L,5L,9L,7L,5L,4L,8L,4L,1L,5L,8L,6L,0L,0L,1L,6L,2L,6L,3L,0L,5L,3L,6L,2L,5L,3L,2L,5L,1L,4L,6L,5L,4L,0L,2L,1L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154399Inst : IEnumerable<long>
{
public static readonly long[] Value=A154399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154399.Bytes);
public long this[int i]=>Value[i];

public static A154399Inst Instance=new A154399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154400
{
public static readonly long[] Value={ 8L,8L,7L,4L,1L,1L,5L,7L,6L,1L,9L,4L,0L,9L,6L,4L,1L,0L,1L,4L,2L,8L,3L,3L,7L,6L,9L,8L,2L,2L,9L,8L,4L,8L,6L,9L,4L,5L,9L,8L,6L,0L,7L,9L,9L,3L,4L,2L,2L,3L,7L,8L,6L,3L,3L,1L,6L,5L,1L,7L,1L,1L,7L,6L,0L,4L,2L,9L,0L,4L,3L,1L,6L,3L,2L,5L,5L,2L,1L,7L,5L,8L,1L,0L,8L,4L,7L,7L,4L,4L,3L,4L,9L,3L,3L,1L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154400Inst : IEnumerable<long>
{
public static readonly long[] Value=A154400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154400.Bytes);
public long this[int i]=>Value[i];

public static A154400Inst Instance=new A154400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154401
{
public static readonly long[] Value={ 8L,7L,1L,1L,1L,6L,4L,9L,3L,0L,2L,6L,3L,4L,3L,5L,7L,8L,4L,4L,9L,3L,9L,1L,2L,8L,5L,3L,6L,2L,0L,6L,4L,4L,4L,3L,3L,9L,2L,0L,9L,0L,3L,2L,5L,7L,7L,7L,5L,2L,9L,4L,2L,7L,1L,7L,6L,0L,8L,5L,9L,7L,8L,1L,9L,7L,6L,0L,8L,6L,7L,3L,3L,3L,4L,4L,6L,6L,9L,3L,3L,0L,1L,0L,1L,1L,2L,7L,3L,0L,0L,6L,3L,1L,7L,9L,9L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154401Inst : IEnumerable<long>
{
public static readonly long[] Value=A154401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154401.Bytes);
public long this[int i]=>Value[i];

public static A154401Inst Instance=new A154401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154402
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,2L,1L,3L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,3L,1L,1L,3L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,3L,1L,2L,4L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,3L,1L,2L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,2L,1L,3L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154402Inst : IEnumerable<long>
{
public static readonly long[] Value=A154402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154402.Bytes);
public long this[int i]=>Value[i];

public static A154402Inst Instance=new A154402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154403
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,11L,11L,12L,14L,14L,15L,17L,18L,19L,22L,23L,24L,27L,28L,30L,33L,35L,37L,40L,42L,44L,48L,50L,53L,58L,60L,63L,68L,71L,74L,80L,84L,87L,93L,97L,101L,107L,112L,117L,124L,129L,135L,143L,148L,155L,164L,170L,177L,187L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154403Inst : IEnumerable<long>
{
public static readonly long[] Value=A154403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154403.Bytes);
public long this[int i]=>Value[i];

public static A154403Inst Instance=new A154403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154404
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,3L,5L,5L,5L,4L,6L,5L,6L,5L,7L,6L,6L,9L,9L,8L,8L,6L,8L,10L,9L,6L,9L,7L,5L,8L,10L,8L,8L,7L,6L,9L,9L,8L,8L,7L,6L,9L,9L,13L,10L,9L,8L,12L,10L,10L,10L,9L,9L,11L,9L,11L,9L,10L,8L,11L,13L,11L,10L,12L,11L,11L,10L,10L,7L,8L,10L,14L,10L,16L,11L,9L,11L,11L,10L,12L,10L,7L,9L,16L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154404Inst : IEnumerable<long>
{
public static readonly long[] Value=A154404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154404.Bytes);
public long this[int i]=>Value[i];

public static A154404Inst Instance=new A154404Inst();

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