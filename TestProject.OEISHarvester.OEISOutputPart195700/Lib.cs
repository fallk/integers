using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A226157
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,-2L,14L,33L,-62L,-132L,254L,14585L,-5110L,-313266L,2828954L,38669001L,-573370L,-404801672L,237036478L,117650567067L,-11499383114L,-24255028327410L,1281647882998L,8203584532193105L,-3584085584926L,-418397193140056356L,3965530936622474L,BigInteger.Parse("405233976502715850633") };
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
public class A226157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226157.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226157Inst Instance=new A226157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226158
{
public static readonly BigInteger[] Value={ 0L,-1L,-1L,0L,1L,0L,-3L,0L,17L,0L,-155L,0L,2073L,0L,-38227L,0L,929569L,0L,-28820619L,0L,1109652905L,0L,-51943281731L,0L,2905151042481L,0L,-191329672483963L,0L,14655626154768697L,0L,-1291885088448017715L,0L,BigInteger.Parse("129848163681107301953") };
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
public class A226158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226158Inst Instance=new A226158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226159
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,-37L,41L,43L,47L,53L,-59L,61L,-67L,71L,73L,79L,83L,89L,97L,-101L,-103L,107L,109L,113L,127L,-131L,137L,139L,-149L,151L,-157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,-233L,239L,241L,251L,-257L,-263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226159Inst : IEnumerable<long>
{
public static readonly long[] Value=A226159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226159.Bytes);
public long this[int i]=>Value[i];

public static A226159Inst Instance=new A226159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226160
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,23L,42L,79L,146L,271L,503L,934L,1732L,3214L,5963L,11063L,20524L,38078L,70646L,131067L,243166L,451140L,836989L,1552846L,2880960L,5344978L,9916415L,18397696L,34132822L,63325839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226160Inst : IEnumerable<long>
{
public static readonly long[] Value=A226160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226160.Bytes);
public long this[int i]=>Value[i];

public static A226160Inst Instance=new A226160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226161
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,11L,19L,31L,51L,83L,137L,227L,373L,616L,1015L,1674L,2759L,4550L,7501L,12367L,20390L,33617L,55425L,91380L,150661L,248397L,409538L,675214L,1113239L,1835421L,3026097L,4989191L,8225785L,13562027L,22360003L,36865412L,60780790L,100210581L,165219316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226161Inst : IEnumerable<long>
{
public static readonly long[] Value=A226161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226161.Bytes);
public long this[int i]=>Value[i];

public static A226161Inst Instance=new A226161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226162
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,-1L,-1L,0L,1L,-1L,-1L,-1L,0L,1L,1L,1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,-1L,1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,-1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,0L,1L,1L,-1L,1L,0L,-1L,-1L,-1L,1L,0L,-1L,-1L,1L,-1L,0L,1L,-1L,1L,1L,0L,-1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226162Inst : IEnumerable<long>
{
public static readonly long[] Value=A226162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226162.Bytes);
public long this[int i]=>Value[i];

public static A226162Inst Instance=new A226162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226163
{
public static readonly BigInteger[] Value={ 0L,-1L,0L,0L,-8L,-72L,0L,0L,-2061248L,0L,-18150912L,2581719040L,0L,0L,6237406973952L,0L,311692729699401728L,0L,0L,BigInteger.Parse("2675112340760315428864"),0L,0L,BigInteger.Parse("-149670892669766097645487521792"),BigInteger.Parse("162894623351898578070944297779200"),BigInteger.Parse("273248864699809403831952842162176"),0L,0L,BigInteger.Parse("-13518055482368485085619549462056665088"),BigInteger.Parse("4364947372586985974930810143672643878912") };
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
public class A226163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226163Inst Instance=new A226163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226164
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,3L,4L,4L,5L,4L,5L,5L,6L,5L,6L,5L,6L,6L,7L,6L,7L,6L,7L,7L,8L,7L,8L,7L,8L,7L,8L,8L,9L,8L,9L,8L,9L,8L,9L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,11L,12L,11L,12L,11L,12L,11L,12L,11L,12L,11L,12L,12L,13L,12L,13L,12L,13L,12L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226164Inst : IEnumerable<long>
{
public static readonly long[] Value=A226164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226164.Bytes);
public long this[int i]=>Value[i];

public static A226164Inst Instance=new A226164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226165
{
public static readonly long[] Value={ 5L,13L,17L,21L,29L,33L,37L,41L,5L,53L,57L,61L,65L,69L,73L,77L,85L,89L,93L,97L,101L,105L,109L,113L,13L,5L,129L,133L,137L,141L,145L,149L,17L,157L,161L,165L,173L,177L,181L,185L,21L,193L,197L,201L,205L,209L,213L,217L,221L,229L,233L,237L,241L,5L,249L,253L,257L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226165Inst : IEnumerable<long>
{
public static readonly long[] Value=A226165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226165.Bytes);
public long this[int i]=>Value[i];

public static A226165Inst Instance=new A226165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226166
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,2L,3L,1L,5L,1L,1L,1L,5L,1L,2L,3L,1L,3L,3L,1L,2L,1L,9L,3L,1L,1L,3L,1L,3L,7L,2L,1L,1L,9L,3L,1L,3L,1L,7L,2L,7L,5L,1L,1L,4L,1L,2L,5L,2L,2L,2L,7L,1L,2L,3L,1L,5L,1L,4L,1L,5L,1L,5L,3L,1L,1L,5L,1L,4L,6L,3L,5L,6L,3L,2L,2L,1L,15L,3L,1L,7L,1L,2L,3L,6L,5L,2L,3L,8L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226166Inst : IEnumerable<long>
{
public static readonly long[] Value=A226166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226166.Bytes);
public long this[int i]=>Value[i];

public static A226166Inst Instance=new A226166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226167
{
public static readonly long[] Value={ 1L,3L,1L,12L,5L,1L,60L,27L,7L,1L,360L,168L,48L,9L,1L,2520L,1200L,360L,75L,11L,1L,20160L,9720L,3000L,660L,108L,13L,1L,181440L,88200L,27720L,6300L,1092L,147L,15L,1L,1814400L,887040L,282240L,65520L,11760L,1680L,192L,17L,1L,19958400L,9797760L,3144960L,740880L,136080L,20160L,2448L,243L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226167Inst : IEnumerable<long>
{
public static readonly long[] Value=A226167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226167.Bytes);
public long this[int i]=>Value[i];

public static A226167Inst Instance=new A226167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226168
{
public static readonly long[] Value={ 42L,70L,84L,126L,140L,168L,231L,252L,280L,294L,336L,350L,378L,490L,504L,560L,588L,672L,693L,700L,756L,882L,980L,1008L,1120L,1134L,1176L,1344L,1400L,1512L,1617L,1750L,1764L,1960L,2016L,2058L,2079L,2240L,2268L,2352L,2450L,2541L,2646L,2688L,2800L,3024L,3402L,3430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226168Inst : IEnumerable<long>
{
public static readonly long[] Value=A226168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226168.Bytes);
public long this[int i]=>Value[i];

public static A226168Inst Instance=new A226168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226169
{
public static readonly long[] Value={ 1L,2L,4L,6L,24L,40L,48L,72L,120L,144L,180L,216L,252L,288L,324L,336L,360L,432L,504L,576L,648L,720L,756L,780L,840L,960L,1008L,1056L,1080L,1092L,1200L,1260L,1296L,1344L,1380L,1440L,1512L,1584L,1620L,1680L,1728L,1764L,1800L,1944L,2016L,2196L,2304L,2352L,2448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226169Inst : IEnumerable<long>
{
public static readonly long[] Value=A226169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226169.Bytes);
public long this[int i]=>Value[i];

public static A226169Inst Instance=new A226169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226170
{
public static readonly BigInteger[] Value={ 0L,1L,2L,5L,26L,134L,894L,6474L,55152L,510768L,5334480L,60090480L,745035840L,9881421120L,141972324480L,2166467990400L,35410730342400L,611048958105600L,11198955424204800L,215604729694771200L,4379675205233664000L,BigInteger.Parse("93061582839880704000"),BigInteger.Parse("2075454840671815680000") };
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
public class A226170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226170Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226170.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226170.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226170Inst Instance=new A226170Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226171
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,0L,2L,6L,2L,4L,2L,8L,2L,2L,2L,6L,2L,8L,2L,7L,5L,2L,2L,14L,2L,2L,2L,2L,2L,2L,2L,6L,2L,3L,2L,8L,2L,2L,2L,12L,2L,3L,2L,2L,2L,2L,2L,14L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,8L,2L,2L,2L,6L,2L,3L,2L,3L,3L,2L,2L,14L,2L,2L,2L,2L,2L,2L,2L,8L,5L,2L,2L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226171Inst : IEnumerable<long>
{
public static readonly long[] Value=A226171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226171.Bytes);
public long this[int i]=>Value[i];

public static A226171Inst Instance=new A226171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226172
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,2L,5L,2L,8L,1L,9L,8L,11L,0L,7L,9L,15L,12L,17L,9L,9L,0L,21L,27L,34L,0L,62L,13L,27L,20L,29L,8L,11L,0L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226172Inst : IEnumerable<long>
{
public static readonly long[] Value=A226172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226172.Bytes);
public long this[int i]=>Value[i];

public static A226172Inst Instance=new A226172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226173
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,0L,2L,1L,1L,3L,1L,0L,4L,0L,1L,3L,1L,3L,4L,0L,1L,10L,2L,0L,8L,2L,1L,10L,1L,0L,2L,0L,1L,16L,1L,0L,2L,8L,1L,8L,1L,0L,13L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226173Inst : IEnumerable<long>
{
public static readonly long[] Value=A226173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226173.Bytes);
public long this[int i]=>Value[i];

public static A226173Inst Instance=new A226173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226174
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,1L,1L,4L,1L,1L,10L,1L,0L,5L,5L,1L,8L,1L,8L,5L,0L,1L,40L,6L,0L,21L,3L,1L,18L,1L,7L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226174Inst : IEnumerable<long>
{
public static readonly long[] Value=A226174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226174.Bytes);
public long this[int i]=>Value[i];

public static A226174Inst Instance=new A226174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226175
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,19L,21L,31L,37L,51L,53L,79L,81L,105L,121L,153L,155L,207L,209L,267L,293L,349L,351L,453L,465L,549L,587L,699L,701L,875L,877L,1031L,1089L,1247L,1279L,1547L,1549L,1761L,1847L,2137L,2139L,2529L,2531L,2887L,3041L,3395L,3397L,3973L,3995L,4501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226175Inst : IEnumerable<long>
{
public static readonly long[] Value=A226175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226175.Bytes);
public long this[int i]=>Value[i];

public static A226175Inst Instance=new A226175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226176
{
public static readonly long[] Value={ 12L,18L,60L,72L,108L,180L,228L,240L,348L,600L,828L,882L,1152L,1620L,1668L,1788L,2088L,2340L,2688L,3120L,3168L,3252L,3360L,3372L,3528L,3852L,4050L,4128L,4548L,4788L,4932L,5280L,5520L,5652L,5868L,6660L,6828L,6948L,6960L,7212L,7308L,8292L,8388L,8628L,9012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226176Inst : IEnumerable<long>
{
public static readonly long[] Value=A226176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226176.Bytes);
public long this[int i]=>Value[i];

public static A226176Inst Instance=new A226176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226177
{
public static readonly long[] Value={ 1L,-2L,-2L,0L,-2L,4L,-2L,0L,0L,4L,-2L,0L,-2L,4L,4L,0L,-2L,0L,-2L,0L,4L,4L,-2L,0L,0L,4L,0L,0L,-2L,-8L,-2L,0L,4L,4L,4L,0L,-2L,4L,4L,0L,-2L,-8L,-2L,0L,0L,4L,-2L,0L,0L,0L,4L,0L,-2L,0L,4L,0L,4L,4L,-2L,0L,-2L,4L,0L,0L,4L,-8L,-2L,0L,4L,-8L,-2L,0L,-2L,4L,0L,0L,4L,-8L,-2L,0L,0L,4L,-2L,0L,4L,4L,4L,0L,-2L,0L,4L,0L,4L,4L,4L,0L,-2L,0L,0L,0L,-2L,-8L,-2L,0L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226177Inst : IEnumerable<long>
{
public static readonly long[] Value=A226177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226177.Bytes);
public long this[int i]=>Value[i];

public static A226177Inst Instance=new A226177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226178
{
public static readonly long[] Value={ 2L,6L,12L,76L,181L,1099L,1820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226178Inst : IEnumerable<long>
{
public static readonly long[] Value=A226178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226178.Bytes);
public long this[int i]=>Value[i];

public static A226178Inst Instance=new A226178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226179
{
public static readonly long[] Value={ 1L,2L,10L,19L,20L,34L,51L,127L,128L,129L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,140L,141L,142L,143L,144L,145L,146L,147L,148L,149L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,160L,161L,162L,163L,164L,165L,166L,167L,168L,169L,170L,171L,172L,173L,174L,175L,176L,177L,178L,179L,180L,181L,182L,183L,184L,185L,186L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226179Inst : IEnumerable<long>
{
public static readonly long[] Value=A226179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226179.Bytes);
public long this[int i]=>Value[i];

public static A226179Inst Instance=new A226179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226180
{
public static readonly BigInteger[] Value={ 1L,9L,75L,2205L,25515L,1715175L,79053975L,9577693125L,184530220875L,35266981624875L,4092826025413125L,66711917764366875L,BigInteger.Parse("92454016466921484375"),BigInteger.Parse("35047468562280596296875"),BigInteger.Parse("7641646200968365570359375"),BigInteger.Parse("3798425171964103092990703125"),BigInteger.Parse("133435000395771234460221796875") };
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
public class A226180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226180Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226180.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226180Inst Instance=new A226180Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226181
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,41L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,113L,131L,137L,139L,149L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,227L,233L,239L,257L,263L,269L,271L,281L,293L,311L,313L,317L,337L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226181Inst : IEnumerable<long>
{
public static readonly long[] Value=A226181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226181.Bytes);
public long this[int i]=>Value[i];

public static A226181Inst Instance=new A226181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226182
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,2L,4L,2L,2L,3L,2L,3L,2L,2L,4L,3L,2L,2L,3L,5L,2L,3L,2L,3L,2L,2L,4L,3L,2L,5L,4L,3L,2L,3L,2L,3L,2L,2L,4L,3L,2L,2L,2L,7L,2L,3L,2L,2L,2L,5L,4L,3L,2L,4L,4L,2L,2L,3L,2L,5L,6L,3L,4L,3L,2L,4L,8L,2L,2L,5L,4L,7L,2L,2L,4L,3L,2L,2L,4L,5L,2L,3L,2L,2L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226182Inst : IEnumerable<long>
{
public static readonly long[] Value=A226182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226182.Bytes);
public long this[int i]=>Value[i];

public static A226182Inst Instance=new A226182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226183
{
public static readonly long[] Value={ 4L,11L,22L,36L,54L,75L,100L,129L,161L,197L,236L,278L,325L,375L,428L,485L,546L,610L,677L,749L,823L,902L,984L,1069L,1158L,1251L,1347L,1447L,1550L,1657L,1767L,1881L,1999L,2120L,2245L,2373L,2505L,2640L,2779L,2922L,3068L,3217L,3370L,3527L,3687L,3851L,4019L,4190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226183Inst : IEnumerable<long>
{
public static readonly long[] Value=A226183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226183.Bytes);
public long this[int i]=>Value[i];

public static A226183Inst Instance=new A226183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226184
{
public static readonly long[] Value={ 3L,9L,19L,32L,49L,69L,93L,121L,152L,187L,225L,266L,312L,361L,413L,469L,529L,592L,658L,729L,802L,880L,961L,1045L,1133L,1225L,1320L,1419L,1521L,1627L,1736L,1849L,1966L,2086L,2210L,2337L,2468L,2602L,2740L,2882L,3027L,3175L,3327L,3483L,3642L,3805L,3972L,4142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226184Inst : IEnumerable<long>
{
public static readonly long[] Value=A226184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226184.Bytes);
public long this[int i]=>Value[i];

public static A226184Inst Instance=new A226184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226185
{
public static readonly long[] Value={ 1L,3L,6L,10L,14L,19L,26L,33L,41L,50L,59L,70L,82L,94L,108L,122L,137L,153L,170L,188L,206L,226L,246L,268L,290L,313L,337L,362L,388L,415L,442L,471L,500L,531L,562L,594L,627L,661L,695L,731L,767L,805L,843L,882L,922L,963L,1005L,1048L,1092L,1136L,1181L,1228L,1275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226185Inst : IEnumerable<long>
{
public static readonly long[] Value=A226185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226185.Bytes);
public long this[int i]=>Value[i];

public static A226185Inst Instance=new A226185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226186
{
public static readonly long[] Value={ 12L,21L,34L,57L,75L,115L,232L,299L,322L,371L,376L,398L,511L,579L,597L,637L,713L,731L,736L,759L,763L,795L,893L,938L,957L,975L,992L,1112L,1121L,1137L,1157L,1173L,1175L,1211L,1299L,1317L,1355L,1371L,1389L,1398L,1469L,1474L,1496L,1517L,1535L,1649L,1694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226186Inst : IEnumerable<long>
{
public static readonly long[] Value=A226186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226186.Bytes);
public long this[int i]=>Value[i];

public static A226186Inst Instance=new A226186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226187
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,11L,16L,22L,31L,43L,60L,83L,116L,162L,227L,316L,441L,616L,859L,1199L,1674L,2336L,3260L,4550L,6349L,8861L,12367L,17259L,24088L,33617L,46916L,65477L,91380L,127531L,177984L,248397L,346666L,483812L,675214L,942336L,1315136L,1835421L,2561536L,3574912L,4989191L,6962977L,9717617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226187Inst : IEnumerable<long>
{
public static readonly long[] Value=A226187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226187.Bytes);
public long this[int i]=>Value[i];

public static A226187Inst Instance=new A226187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226188
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,31L,60L,116L,227L,441L,859L,1674L,3260L,6349L,12367L,24088L,46916L,91380L,177984L,346666L,675214L,1315136L,2561536L,4989191L,9717617L,18927334L,36865412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226188Inst : IEnumerable<long>
{
public static readonly long[] Value=A226188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226188.Bytes);
public long this[int i]=>Value[i];

public static A226188Inst Instance=new A226188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226189
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,11L,13L,15L,18L,21L,24L,27L,31L,35L,39L,44L,49L,55L,61L,68L,75L,83L,92L,101L,112L,122L,134L,147L,161L,175L,191L,208L,227L,246L,267L,289L,313L,339L,366L,396L,427L,460L,495L,533L,573L,616L,661L,709L,760L,815L,872L,934L,998L,1067L,1140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226189Inst : IEnumerable<long>
{
public static readonly long[] Value=A226189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226189.Bytes);
public long this[int i]=>Value[i];

public static A226189Inst Instance=new A226189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226190
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,6L,7L,7L,8L,8L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,26L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,38L,38L,39L,39L,40L,40L,41L,42L,42L,43L,43L,44L,44L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226190Inst : IEnumerable<long>
{
public static readonly long[] Value=A226190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226190.Bytes);
public long this[int i]=>Value[i];

public static A226190Inst Instance=new A226190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226191
{
public static readonly long[] Value={ 27L,35L,69L,77L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226191Inst : IEnumerable<long>
{
public static readonly long[] Value=A226191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226191.Bytes);
public long this[int i]=>Value[i];

public static A226191Inst Instance=new A226191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226192
{
public static readonly long[] Value={ 1L,-1L,2L,-3L,0L,-2L,1L,0L,4L,-2L,1L,-2L,2L,0L,2L,-1L,0L,-2L,4L,-2L,0L,-3L,0L,-4L,2L,0L,0L,0L,3L,-2L,2L,0L,2L,-4L,0L,-2L,3L,0L,4L,-2L,0L,0L,2L,0L,2L,-1L,2L,-4L,0L,0L,2L,-2L,0L,-6L,2L,-1L,2L,-2L,0L,0L,4L,0L,0L,-4L,0L,-2L,1L,0L,4L,0L,0L,-2L,2L,-4L,2L,-2L,0L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226192Inst : IEnumerable<long>
{
public static readonly long[] Value=A226192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226192.Bytes);
public long this[int i]=>Value[i];

public static A226192Inst Instance=new A226192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226193
{
public static readonly long[] Value={ 1L,1L,5L,13L,19L,5L,41L,73L,116L,19L,109L,65L,155L,41L,95L,669L,271L,116L,341L,247L,205L,109L,505L,365L,1084L,155L,1574L,533L,811L,95L,929L,4193L,545L,271L,779L,1508L,1331L,341L,775L,1387L,1639L,205L,1805L,1417L,2204L,505L,2161L,3345L,4388L,1084L,1355L,2015L,2755L,1574L,2071L,2993L,1705L,811L,3421L,1235L,3659L,929L,4756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226193Inst : IEnumerable<long>
{
public static readonly long[] Value=A226193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226193.Bytes);
public long this[int i]=>Value[i];

public static A226193Inst Instance=new A226193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226194
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,-1L,1L,-1L,0L,0L,2L,0L,1L,-1L,1L,-2L,0L,0L,1L,-1L,0L,-1L,1L,0L,1L,-2L,0L,-2L,1L,0L,1L,0L,1L,-1L,1L,0L,1L,0L,0L,-1L,3L,-1L,0L,-1L,0L,-2L,1L,0L,1L,-1L,1L,0L,1L,0L,0L,-2L,0L,-1L,0L,-1L,2L,-2L,0L,-1L,0L,0L,2L,-1L,1L,-1L,2L,0L,0L,0L,0L,-1L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226194Inst : IEnumerable<long>
{
public static readonly long[] Value=A226194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226194.Bytes);
public long this[int i]=>Value[i];

public static A226194Inst Instance=new A226194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226195
{
public static readonly long[] Value={ 1L,10L,21L,22L,100L,210L,220L,311L,321L,332L,333L,1000L,2100L,2200L,3110L,3210L,3320L,3330L,4111L,4211L,4321L,4331L,4422L,4432L,4443L,4444L,10000L,21000L,22000L,31100L,32100L,33200L,33300L,41110L,42110L,43210L,43310L,44220L,44320L,44430L,44440L,51111L,52111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226195Inst : IEnumerable<long>
{
public static readonly long[] Value=A226195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226195.Bytes);
public long this[int i]=>Value[i];

public static A226195Inst Instance=new A226195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226196
{
public static readonly long[] Value={ 15L,55L,105L,120L,253L,595L,1225L,1485L,2080L,2211L,3321L,4371L,5460L,6786L,7381L,7503L,10731L,11935L,12246L,16290L,18915L,24531L,24753L,27966L,36585L,44850L,51360L,55278L,55945L,56953L,60031L,64980L,68265L,69006L,70125L,75078L,86736L,87153L,92235L,94830L,98790L,111628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226196Inst : IEnumerable<long>
{
public static readonly long[] Value=A226196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226196.Bytes);
public long this[int i]=>Value[i];

public static A226196Inst Instance=new A226196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226197
{
public static readonly long[] Value={ 1L,1L,7L,9L,56L,79L,470L,697L,4048L,6196L,35443L,55455L,313912L,499178L,2804012L,4514873L,25211936L,40999516L,227881004L,373585604L,2068564064L,3414035527L,18844224462L,31278197839L,172186125456L,287191809724L,1577401391626L,2642070371194L,14483100716176L,24347999094724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226197Inst : IEnumerable<long>
{
public static readonly long[] Value=A226197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226197.Bytes);
public long this[int i]=>Value[i];

public static A226197Inst Instance=new A226197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226198
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1L,4L,20L,102L,630L,4480L,36288L,329890L,3326400L,36846276L,444787200L,5811886080L,81729648000L,1230752346352L,19760412672000L,336967037143578L,6082255020441600L,115852476579840000L,2322315553259520000L,BigInteger.Parse("48869596859895986086") };
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
public class A226198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226198Inst Instance=new A226198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226199
{
public static readonly long[] Value={ 1L,8L,51L,346L,2405L,16812L,117655L,823550L,5764809L,40353616L,282475259L,1977326754L,13841287213L,96889010420L,678223072863L,4747561509958L,33232930569617L,232630513987224L,1628413597910467L,11398895185373162L,79792266297612021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226199Inst : IEnumerable<long>
{
public static readonly long[] Value=A226199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226199.Bytes);
public long this[int i]=>Value[i];

public static A226199Inst Instance=new A226199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226200
{
public static readonly long[] Value={ 1L,7L,38L,219L,1300L,7781L,46662L,279943L,1679624L,10077705L,60466186L,362797067L,2176782348L,13060694029L,78364164110L,470184984591L,2821109907472L,16926659444753L,101559956668434L,609359740010515L,3656158440062996L,21936950640377877L,131621703842267158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226200Inst : IEnumerable<long>
{
public static readonly long[] Value=A226200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226200.Bytes);
public long this[int i]=>Value[i];

public static A226200Inst Instance=new A226200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226201
{
public static readonly long[] Value={ 1L,9L,66L,515L,4100L,32773L,262150L,2097159L,16777224L,134217737L,1073741834L,8589934603L,68719476748L,549755813901L,4398046511118L,35184372088847L,281474976710672L,2251799813685265L,18014398509482002L,144115188075855891L,1152921504606846996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226201Inst : IEnumerable<long>
{
public static readonly long[] Value=A226201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226201.Bytes);
public long this[int i]=>Value[i];

public static A226201Inst Instance=new A226201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226202
{
public static readonly long[] Value={ 1L,10L,83L,732L,6565L,59054L,531447L,4782976L,43046729L,387420498L,3486784411L,31381059620L,282429536493L,2541865828342L,22876792454975L,205891132094664L,1853020188851857L,16677181699666586L,150094635296999139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226202Inst : IEnumerable<long>
{
public static readonly long[] Value=A226202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226202.Bytes);
public long this[int i]=>Value[i];

public static A226202Inst Instance=new A226202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226203
{
public static readonly long[] Value={ 1L,-3L,-1L,1L,1L,3L,-1L,1L,3L,3L,5L,1L,3L,5L,5L,7L,3L,5L,7L,7L,9L,5L,7L,9L,9L,11L,7L,9L,11L,11L,13L,9L,11L,13L,13L,15L,11L,13L,15L,15L,17L,13L,15L,17L,17L,19L,15L,17L,19L,19L,21L,17L,19L,21L,21L,23L,19L,21L,23L,23L,25L,21L,23L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226203Inst : IEnumerable<long>
{
public static readonly long[] Value=A226203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226203.Bytes);
public long this[int i]=>Value[i];

public static A226203Inst Instance=new A226203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226204
{
public static readonly long[] Value={ 9L,9L,3L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226204Inst : IEnumerable<long>
{
public static readonly long[] Value=A226204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226204.Bytes);
public long this[int i]=>Value[i];

public static A226204Inst Instance=new A226204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226205
{
public static readonly long[] Value={ 1L,0L,3L,5L,16L,39L,105L,272L,715L,1869L,4896L,12815L,33553L,87840L,229971L,602069L,1576240L,4126647L,10803705L,28284464L,74049691L,193864605L,507544128L,1328767775L,3478759201L,9107509824L,23843770275L,62423800997L,163427632720L,427859097159L,1120149658761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226205Inst : IEnumerable<long>
{
public static readonly long[] Value=A226205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226205.Bytes);
public long this[int i]=>Value[i];

public static A226205Inst Instance=new A226205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226206
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,2L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,3L,1L,3L,0L,1L,0L,1L,1L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,1L,1L,0L,1L,1L,5L,0L,7L,0L,5L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,7L,7L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226206Inst : IEnumerable<long>
{
public static readonly long[] Value=A226206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226206.Bytes);
public long this[int i]=>Value[i];

public static A226206Inst Instance=new A226206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226207
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,2L,1L,1L,2L,3L,1L,0L,1L,3L,3L,2L,2L,2L,2L,3L,3L,2L,1L,0L,1L,2L,3L,4L,2L,1L,3L,3L,1L,2L,4L,4L,3L,3L,3L,0L,3L,3L,3L,4L,4L,3L,2L,1L,2L,2L,1L,2L,3L,4L,4L,3L,2L,4L,4L,0L,4L,4L,2L,3L,4L,4L,3L,2L,4L,1L,4L,4L,1L,4L,2L,3L,4L,5L,3L,4L,4L,1L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226207Inst : IEnumerable<long>
{
public static readonly long[] Value=A226207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226207.Bytes);
public long this[int i]=>Value[i];

public static A226207Inst Instance=new A226207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226208
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,4L,5L,2L,4L,6L,2L,7L,2L,4L,6L,2L,8L,2L,4L,9L,2L,4L,6L,2L,8L,2L,4L,10L,2L,4L,6L,2L,11L,2L,4L,6L,2L,8L,2L,4L,10L,2L,4L,6L,2L,12L,2L,4L,6L,2L,8L,2L,4L,13L,2L,4L,6L,2L,8L,2L,4L,10L,2L,4L,6L,2L,12L,2L,4L,6L,2L,8L,2L,4L,14L,2L,4L,6L,2L,8L,2L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226208Inst : IEnumerable<long>
{
public static readonly long[] Value=A226208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226208.Bytes);
public long this[int i]=>Value[i];

public static A226208Inst Instance=new A226208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226209
{
public static readonly long[] Value={ 2L,1L,1L,3L,4L,3L,5L,4L,6L,6L,7L,7L,4L,6L,6L,8L,8L,4L,9L,9L,4L,6L,6L,8L,8L,4L,10L,10L,4L,6L,6L,11L,11L,4L,6L,6L,8L,8L,4L,10L,10L,4L,6L,6L,12L,12L,4L,6L,6L,8L,8L,4L,13L,13L,4L,6L,6L,8L,8L,4L,10L,10L,4L,6L,6L,12L,12L,4L,6L,6L,8L,8L,4L,14L,14L,4L,6L,6L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226209Inst : IEnumerable<long>
{
public static readonly long[] Value=A226209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226209.Bytes);
public long this[int i]=>Value[i];

public static A226209Inst Instance=new A226209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226210
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,3L,6L,2L,5L,8L,11L,12L,6L,9L,12L,15L,16L,19L,20L,21L,13L,16L,19L,22L,23L,26L,27L,28L,31L,32L,33L,34L,35L,25L,28L,31L,34L,35L,38L,39L,40L,43L,44L,45L,46L,47L,50L,51L,52L,53L,54L,55L,56L,57L,45L,48L,51L,54L,55L,58L,59L,60L,63L,64L,65L,66L,67L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226210Inst : IEnumerable<long>
{
public static readonly long[] Value=A226210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226210.Bytes);
public long this[int i]=>Value[i];

public static A226210Inst Instance=new A226210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226211
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,5L,6L,5L,7L,7L,8L,8L,7L,7L,9L,9L,8L,10L,10L,10L,9L,9L,9L,11L,11L,11L,11L,10L,12L,12L,12L,12L,12L,11L,11L,11L,11L,13L,13L,13L,13L,13L,13L,13L,12L,12L,14L,14L,14L,14L,14L,14L,14L,14L,13L,13L,13L,13L,13L,13L,13L,15L,15L,15L,15L,15L,15L,15L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226211Inst : IEnumerable<long>
{
public static readonly long[] Value=A226211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226211.Bytes);
public long this[int i]=>Value[i];

public static A226211Inst Instance=new A226211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226212
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,4L,4L,3L,5L,5L,4L,6L,6L,5L,5L,7L,7L,7L,6L,8L,8L,8L,8L,7L,7L,7L,9L,9L,9L,9L,9L,8L,8L,10L,10L,10L,10L,10L,10L,9L,9L,9L,9L,9L,11L,11L,11L,11L,11L,11L,11L,11L,10L,10L,10L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,11L,11L,11L,11L,11L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226212Inst : IEnumerable<long>
{
public static readonly long[] Value=A226212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226212.Bytes);
public long this[int i]=>Value[i];

public static A226212Inst Instance=new A226212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226213
{
public static readonly long[] Value={ 1L,1L,2L,5L,7L,7L,6L,7L,12L,14L,17L,12L,17L,22L,20L,25L,25L,28L,30L,31L,33L,31L,36L,34L,39L,39L,32L,42L,45L,42L,48L,45L,51L,51L,43L,54L,57L,55L,60L,52L,63L,63L,60L,66L,63L,70L,72L,67L,75L,70L,78L,79L,81L,82L,84L,82L,87L,83L,88L,86L,91L,94L,88L,97L,89L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226213Inst : IEnumerable<long>
{
public static readonly long[] Value=A226213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226213.Bytes);
public long this[int i]=>Value[i];

public static A226213Inst Instance=new A226213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226214
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,6L,4L,6L,10L,9L,11L,12L,9L,11L,13L,12L,8L,6L,10L,15L,12L,14L,16L,16L,13L,15L,15L,11L,17L,11L,13L,18L,18L,15L,17L,17L,19L,19L,19L,16L,16L,18L,18L,18L,14L,14L,8L,12L,14L,16L,21L,21L,21L,21L,18L,18L,20L,20L,20L,22L,22L,22L,22L,22L,19L,19L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226214Inst : IEnumerable<long>
{
public static readonly long[] Value=A226214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226214.Bytes);
public long this[int i]=>Value[i];

public static A226214Inst Instance=new A226214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226215
{
public static readonly long[] Value={ 1L,2L,5L,11L,18L,20L,36L,45L,49L,53L,69L,83L,94L,105L,116L,122L,122L,146L,164L,178L,191L,204L,217L,229L,244L,253L,265L,263L,293L,309L,328L,339L,357L,372L,385L,400L,415L,430L,447L,462L,476L,490L,504L,516L,541L,536L,573L,580L,600L,618L,636L,654L,671L,686L,704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226215Inst : IEnumerable<long>
{
public static readonly long[] Value=A226215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226215.Bytes);
public long this[int i]=>Value[i];

public static A226215Inst Instance=new A226215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226216
{
public static readonly long[] Value={ 3L,7L,31L,73L,127L,601L,683L,1103L,1801L,2731L,5419L,8191L,43691L,61681L,65537L,121369L,122921L,131071L,178481L,262657L,524287L,2099863L,2796203L,6700417L,10567201L,13264529L,20394401L,48544121L,97685839L,112901153L,160465489L,164511353L,420778751L,536903681L,616318177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226216Inst : IEnumerable<long>
{
public static readonly long[] Value=A226216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226216.Bytes);
public long this[int i]=>Value[i];

public static A226216Inst Instance=new A226216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226217
{
public static readonly long[] Value={ 11L,13L,17L,19L,41L,43L,47L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,401L,409L,419L,421L,431L,433L,439L,443L,449L,457L,461L,463L,467L,479L,487L,491L,499L,907L,911L,919L,929L,937L,941L,947L,953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226217Inst : IEnumerable<long>
{
public static readonly long[] Value=A226217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226217.Bytes);
public long this[int i]=>Value[i];

public static A226217Inst Instance=new A226217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226218
{
public static readonly long[] Value={ 23L,11L,23L,23L,17L,19L,23L,23L,47L,41L,29L,31L,47L,47L,47L,41L,71L,71L,71L,83L,47L,53L,47L,71L,59L,71L,71L,83L,59L,167L,71L,59L,149L,167L,71L,167L,83L,71L,167L,79L,89L,251L,167L,149L,149L,83L,269L,89L,167L,251L,251L,113L,239L,149L,167L,109L,127L,269L,251L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226218Inst : IEnumerable<long>
{
public static readonly long[] Value=A226218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226218.Bytes);
public long this[int i]=>Value[i];

public static A226218Inst Instance=new A226218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226219
{
public static readonly long[] Value={ 2L,11L,6L,11L,6L,3L,6L,11L,6L,11L,11L,101L,26L,87L,51L,21L,26L,69L,51L,63L,6L,58L,51L,97L,26L,5L,51L,101L,26L,79L,11L,101L,26L,101L,51L,21L,26L,101L,51L,87L,6L,59L,34L,101L,26L,21L,51L,74L,26L,51L,3L,69L,26L,29L,51L,21L,26L,101L,51L,27L,6L,92L,51L,26L,26L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226219Inst : IEnumerable<long>
{
public static readonly long[] Value=A226219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226219.Bytes);
public long this[int i]=>Value[i];

public static A226219Inst Instance=new A226219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226220
{
public static readonly long[] Value={ 3L,6L,12L,19L,37L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226220Inst : IEnumerable<long>
{
public static readonly long[] Value=A226220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226220.Bytes);
public long this[int i]=>Value[i];

public static A226220Inst Instance=new A226220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226221
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,18L,25L,27L,32L,35L,36L,42L,45L,49L,50L,54L,55L,64L,70L,75L,77L,81L,88L,91L,95L,98L,99L,100L,104L,105L,108L,110L,115L,117L,119L,121L,125L,128L,130L,135L,136L,140L,143L,147L,150L,152L,153L,155L,156L,160L,161L,162L,169L,171L,175L,180L,184L,187L,189L,190L,198L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226221Inst : IEnumerable<long>
{
public static readonly long[] Value=A226221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226221.Bytes);
public long this[int i]=>Value[i];

public static A226221Inst Instance=new A226221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226222
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,3L,4L,5L,5L,5L,6L,6L,7L,7L,8L,9L,9L,9L,10L,10L,11L,11L,11L,12L,13L,13L,13L,14L,15L,16L,16L,16L,17L,18L,18L,18L,18L,19L,20L,21L,21L,21L,21L,22L,22L,23L,23L,24L,25L,25L,25L,26L,26L,27L,27L,28L,29L,30L,30L,30L,31L,32L,32L,32L,32L,33L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226222Inst : IEnumerable<long>
{
public static readonly long[] Value=A226222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226222.Bytes);
public long this[int i]=>Value[i];

public static A226222Inst Instance=new A226222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226223
{
public static readonly BigInteger[] Value={ 1L,7L,40L,345L,3226L,38503L,529614L,8219025L,141633028L,2677676931L,55021969234L,1219667932585L,28986449652564L,734758590703803L,19777243624646566L,563105619051710817L,16902630001714260832UL,BigInteger.Parse("533291777845757001523"),BigInteger.Parse("17638752528002502032130"),BigInteger.Parse("610137644831701323189321") };
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
public class A226223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226223.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226223Inst Instance=new A226223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226224
{
public static readonly long[] Value={ 1L,25L,9L,64L,100L,144L,49L,64L,81L,225L,121L,441L,169L,441L,441L,256L,289L,324L,361L,1296L,1296L,484L,529L,1089L,625L,676L,729L,2401L,841L,2601L,961L,1024L,3025L,1156L,2500L,4096L,1369L,1444L,4356L,3136L,1681L,4900L,1849L,5929L,3025L,2116L,2209L,6561L,2401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226224Inst : IEnumerable<long>
{
public static readonly long[] Value=A226224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226224.Bytes);
public long this[int i]=>Value[i];

public static A226224Inst Instance=new A226224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226225
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,2L,6L,0L,0L,4L,0L,0L,0L,2L,4L,0L,0L,0L,0L,0L,0L,4L,2L,0L,0L,0L,0L,0L,0L,2L,8L,0L,0L,6L,0L,0L,0L,0L,4L,0L,0L,4L,0L,0L,0L,4L,2L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,6L,4L,0L,0L,4L,0L,0L,0L,0L,10L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226225Inst : IEnumerable<long>
{
public static readonly long[] Value=A226225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226225.Bytes);
public long this[int i]=>Value[i];

public static A226225Inst Instance=new A226225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226226
{
public static readonly BigInteger[] Value={ 1L,0L,1L,2L,12L,64L,470L,3828L,36456L,387840L,4603392L,60061440L,855664656L,13207470912L,219609303888L,3912940891104L,74377769483520L,1502277409668096L,32130095812624512L,725400731911792896L,17240044059713320704UL,BigInteger.Parse("430231117562438446080"),BigInteger.Parse("11248105572520779755520") };
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
public class A226226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226226Inst Instance=new A226226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226227
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,9L,12L,15L,17L,19L,24L,25L,28L,31L,32L,35L,36L,39L,49L,51L,56L,57L,60L,63L,65L,68L,71L,72L,73L,76L,79L,96L,99L,100L,103L,113L,115L,120L,121L,124L,127L,128L,131L,136L,137L,140L,143L,145L,147L,152L,153L,156L,159L,193L,196L,199L,200L,201L,204L,207L,224L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226227Inst : IEnumerable<long>
{
public static readonly long[] Value=A226227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226227.Bytes);
public long this[int i]=>Value[i];

public static A226227Inst Instance=new A226227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226228
{
public static readonly long[] Value={ 3L,6L,7L,12L,14L,24L,27L,28L,31L,48L,51L,54L,55L,56L,59L,62L,96L,99L,102L,103L,108L,110L,112L,115L,118L,119L,124L,127L,192L,195L,198L,199L,204L,206L,216L,219L,220L,223L,224L,227L,230L,231L,236L,238L,248L,251L,254L,384L,387L,390L,391L,396L,398L,408L,411L,412L,415L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226228Inst : IEnumerable<long>
{
public static readonly long[] Value=A226228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226228.Bytes);
public long this[int i]=>Value[i];

public static A226228Inst Instance=new A226228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226229
{
public static readonly long[] Value={ 3L,7L,12L,24L,28L,31L,51L,56L,96L,99L,103L,115L,124L,127L,199L,204L,224L,227L,231L,248L,384L,387L,396L,408L,412L,415L,455L,460L,499L,508L,775L,792L,796L,799L,819L,824L,896L,899L,908L,920L,924L,927L,992L,995L,999L,1016L,1539L,1548L,1587L,1592L,1632L,1635L,1639L,1651L,1660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226229Inst : IEnumerable<long>
{
public static readonly long[] Value=A226229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226229.Bytes);
public long this[int i]=>Value[i];

public static A226229Inst Instance=new A226229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226230
{
public static readonly long[] Value={ 8L,9L,25L,32L,81L,125L,128L,169L,289L,343L,512L,625L,1681L,2048L,2197L,3125L,3721L,4913L,8192L,32761L,32768L,50653L,66049L,78125L,97969L,131072L,177241L,357911L,524288L,707281L,1030301L,1419857L,1442401L,1953125L,2097152L,2476099L,3031081L,3463321L,6355441L,7645373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226230Inst : IEnumerable<long>
{
public static readonly long[] Value=A226230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226230.Bytes);
public long this[int i]=>Value[i];

public static A226230Inst Instance=new A226230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226231
{
public static readonly long[] Value={ 25L,125L,512L,3125L,4913L,50653L,78125L,7645373L,48828125L,69343957L,310288733L,410338673L,1220703125L,4103684801L,24820429213L,164296466333L,296709280757L,762939453125L,1772000266301L,10368641602001L,11392143817501L,19073486328125L,29724740184833L,72079590632113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226231Inst : IEnumerable<long>
{
public static readonly long[] Value=A226231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226231.Bytes);
public long this[int i]=>Value[i];

public static A226231Inst Instance=new A226231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226232
{
public static readonly long[] Value={ 9L,16L,128L,243L,512L,841L,1024L,1849L,5041L,6561L,8192L,32041L,65536L,76729L,157609L,177147L,187489L,310249L,524288L,734449L,1104601L,4108729L,4194304L,4782969L,5067001L,7778521L,11498881L,12823561L,31956409L,33554432L,38651089L,65302561L,78552769L,90459121L,129140163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226232Inst : IEnumerable<long>
{
public static readonly long[] Value=A226232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226232.Bytes);
public long this[int i]=>Value[i];

public static A226232Inst Instance=new A226232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226233
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226233Inst : IEnumerable<long>
{
public static readonly long[] Value=A226233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226233.Bytes);
public long this[int i]=>Value[i];

public static A226233Inst Instance=new A226233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226234
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,126L,1L,1L,16L,1820L,11440L,1L,1L,25L,12650L,2042975L,2042975L,1L,1L,36L,58905L,94143280L,7307872110L,600805296L,1L,1L,49L,211876L,2054455634L,3348108992991L,63205303218876L,262596783764L,1L,1L,64L,635376L,27540584512L,488526937079580L,401038568751465792L,1118770292985239888L,159518999862720L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226234Inst : IEnumerable<long>
{
public static readonly long[] Value=A226234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226234.Bytes);
public long this[int i]=>Value[i];

public static A226234Inst Instance=new A226234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226235
{
public static readonly long[] Value={ 1L,-12L,66L,-220L,495L,-804L,1068L,-1596L,3279L,-6952L,12276L,-17844L,23653L,-34080L,57168L,-98428L,154332L,-215724L,285388L,-395784L,600459L,-931888L,1365696L,-1853076L,2426189L,-3277896L,4689534L,-6815008L,9538632L,-12664440L,16403188L,-21690876L,29812932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226235Inst : IEnumerable<long>
{
public static readonly long[] Value=A226235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226235.Bytes);
public long this[int i]=>Value[i];

public static A226235Inst Instance=new A226235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226236
{
public static readonly BigInteger[] Value={ 1L,3L,105L,11025L,5439105L,11193473025L,89273960290305L,2926331900465537025L,BigInteger.Parse("380704455834655419367425"),BigInteger.Parse("200503685263248842050957082625"),BigInteger.Parse("418936006416927720918846481798529025"),BigInteger.Parse("3516831926000321799217446305276779638554625") };
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
public class A226236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226236Inst Instance=new A226236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226237
{
public static readonly long[] Value={ 0L,4L,6L,8L,20L,12L,28L,32L,36L,40L,66L,72L,78L,56L,90L,64L,136L,144L,76L,120L,168L,132L,184L,240L,200L,156L,270L,168L,232L,360L,186L,320L,396L,136L,350L,432L,370L,380L,546L,320L,410L,672L,430L,352L,810L,368L,470L,672L,294L,600L,816L,520L,636L,864L,660L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226237Inst : IEnumerable<long>
{
public static readonly long[] Value=A226237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226237.Bytes);
public long this[int i]=>Value[i];

public static A226237Inst Instance=new A226237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226238
{
public static readonly BigInteger[] Value={ 2L,12L,84L,780L,9330L,137256L,2396744L,48427560L,1111111110L,28531167060L,810554586204L,25239592216020L,854769755812154L,31278135027204240L,1229782938247303440L,BigInteger.Parse("51702516367896047760"),BigInteger.Parse("2314494592664502210318"),BigInteger.Parse("109912203092239643840220") };
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
public class A226238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226238Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226238.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226238Inst Instance=new A226238Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226239
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,22L,33L,44L,59L,76L,101L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226239Inst : IEnumerable<long>
{
public static readonly long[] Value=A226239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226239.Bytes);
public long this[int i]=>Value[i];

public static A226239Inst Instance=new A226239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226240
{
public static readonly long[] Value={ 1L,2L,0L,4L,2L,0L,0L,0L,2L,6L,0L,4L,4L,0L,0L,0L,2L,4L,0L,4L,0L,0L,0L,0L,4L,2L,0L,8L,0L,0L,0L,0L,2L,8L,0L,0L,6L,0L,0L,0L,0L,4L,0L,4L,4L,0L,0L,0L,4L,2L,0L,8L,0L,0L,0L,0L,0L,8L,0L,4L,0L,0L,0L,0L,2L,0L,0L,4L,4L,0L,0L,0L,6L,4L,0L,4L,4L,0L,0L,0L,0L,10L,0L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226240Inst : IEnumerable<long>
{
public static readonly long[] Value=A226240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226240.Bytes);
public long this[int i]=>Value[i];

public static A226240Inst Instance=new A226240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226241
{
public static readonly long[] Value={ 89L,101L,103L,107L,109L,151L,163L,227L,251L,257L,263L,269L,281L,307L,389L,401L,409L,457L,503L,509L,521L,557L,563L,569L,587L,601L,607L,701L,709L,809L,821L,827L,857L,863L,881L,887L,907L,1009L,1013L,1019L,1021L,1031L,1033L,1039L,1049L,1051L,1061L,1063L,1069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226241Inst : IEnumerable<long>
{
public static readonly long[] Value=A226241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226241.Bytes);
public long this[int i]=>Value[i];

public static A226241Inst Instance=new A226241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226242
{
public static readonly long[] Value={ 1L,1L,1L,11L,13L,77L,29L,459L,341L,3349L,251L,32891L,28271L,395243L,420983L,74587L,158183L,2833255L,853661L,3407275L,77976391L,27223837L,28399557L,1814074083L,5665315119L,29397421371L,27452509171L,85332099113L,88200436013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226242Inst : IEnumerable<long>
{
public static readonly long[] Value=A226242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226242.Bytes);
public long this[int i]=>Value[i];

public static A226242Inst Instance=new A226242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226243
{
public static readonly long[] Value={ 1L,2L,2L,24L,30L,180L,70L,1120L,840L,8400L,630L,83160L,72072L,1009008L,1081080L,192192L,408408L,7351344L,2217072L,8868288L,203693490L,71131060L,74364290L,4759314560L,14872858000L,77338861600L,72282089880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226243Inst : IEnumerable<long>
{
public static readonly long[] Value=A226243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226243.Bytes);
public long this[int i]=>Value[i];

public static A226243Inst Instance=new A226243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226244
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,11L,12L,16L,20L,21L,22L,23L,24L,32L,40L,42L,43L,44L,46L,47L,48L,64L,66L,68L,72L,78L,80L,82L,83L,85L,88L,90L,92L,94L,96L,128L,130L,138L,149L,151L,152L,159L,162L,165L,168L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226244Inst : IEnumerable<long>
{
public static readonly long[] Value=A226244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226244.Bytes);
public long this[int i]=>Value[i];

public static A226244Inst Instance=new A226244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226245
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,12L,15L,18L,20L,24L,31L,35L,38L,41L,43L,48L,63L,77L,80L,81L,84L,87L,90L,96L,115L,118L,121L,124L,135L,152L,157L,160L,165L,171L,174L,179L,184L,192L,223L,235L,253L,269L,278L,286L,298L,311L,314L,320L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226245Inst : IEnumerable<long>
{
public static readonly long[] Value=A226245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226245.Bytes);
public long this[int i]=>Value[i];

public static A226245Inst Instance=new A226245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226246
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,7L,4L,8L,10L,10L,5L,8L,11L,14L,13L,6L,10L,14L,14L,16L,16L,7L,12L,13L,16L,19L,20L,19L,8L,14L,16L,20L,20L,22L,24L,22L,9L,14L,17L,18L,21L,22L,25L,28L,25L,10L,16L,20L,20L,26L,24L,28L,30L,30L,28L,11L,18L,21L,22L,25L,26L,29L,30L,33L,34L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226246Inst : IEnumerable<long>
{
public static readonly long[] Value=A226246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226246.Bytes);
public long this[int i]=>Value[i];

public static A226246Inst Instance=new A226246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226247
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,1L,5L,4L,3L,2L,2L,3L,1L,6L,5L,4L,3L,3L,5L,2L,5L,3L,1L,7L,6L,5L,4L,4L,7L,3L,8L,5L,2L,7L,5L,3L,1L,1L,8L,7L,6L,5L,5L,9L,4L,11L,7L,3L,11L,8L,5L,2L,2L,9L,7L,5L,3L,3L,4L,1L,9L,8L,7L,6L,6L,11L,5L,14L,9L,4L,15L,11L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226247Inst : IEnumerable<long>
{
public static readonly long[] Value=A226247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226247.Bytes);
public long this[int i]=>Value[i];

public static A226247Inst Instance=new A226247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226248
{
public static readonly long[] Value={ 0L,1L,2L,-1L,3L,-1L,4L,-1L,1L,5L,-1L,2L,3L,-2L,6L,-1L,3L,5L,-3L,5L,-2L,7L,-1L,4L,7L,-4L,8L,-3L,7L,-2L,1L,8L,-1L,5L,9L,-5L,11L,-4L,11L,-3L,2L,9L,-2L,3L,4L,-3L,9L,-1L,6L,11L,-6L,14L,-5L,15L,-4L,3L,14L,-3L,5L,7L,-5L,11L,-2L,5L,8L,-5L,7L,-3L,10L,-1L,7L,13L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226248Inst : IEnumerable<long>
{
public static readonly long[] Value=A226248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226248.Bytes);
public long this[int i]=>Value[i];

public static A226248Inst Instance=new A226248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226249
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,10L,12L,13L,15L,17L,18L,20L,22L,24L,25L,27L,29L,31L,32L,34L,35L,37L,39L,41L,42L,44L,45L,47L,49L,50L,52L,54L,56L,57L,59L,60L,62L,64L,65L,67L,69L,71L,72L,74L,76L,78L,79L,81L,82L,84L,86L,87L,89L,91L,93L,94L,96L,98L,100L,101L,103L,104L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226249Inst : IEnumerable<long>
{
public static readonly long[] Value=A226249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226249.Bytes);
public long this[int i]=>Value[i];

public static A226249Inst Instance=new A226249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226250
{
public static readonly long[] Value={ 1L,4L,6L,8L,11L,14L,16L,19L,21L,23L,26L,28L,30L,33L,36L,38L,40L,43L,46L,48L,51L,53L,55L,58L,61L,63L,66L,68L,70L,73L,75L,77L,80L,83L,85L,88L,90L,92L,95L,97L,99L,102L,105L,107L,109L,112L,115L,117L,120L,122L,124L,127L,129L,131L,134L,137L,139L,141L,144L,147L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226250Inst : IEnumerable<long>
{
public static readonly long[] Value=A226250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226250.Bytes);
public long this[int i]=>Value[i];

public static A226250Inst Instance=new A226250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226251
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,1L,3L,4L,7L,1L,1L,2L,3L,5L,8L,1L,3L,4L,7L,1L,1L,2L,3L,5L,8L,1L,3L,4L,7L,1L,1L,2L,3L,5L,8L,1L,3L,4L,7L,1L,1L,2L,3L,5L,8L,1L,3L,4L,7L,1L,1L,2L,3L,5L,8L,1L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226251Inst : IEnumerable<long>
{
public static readonly long[] Value=A226251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226251.Bytes);
public long this[int i]=>Value[i];

public static A226251Inst Instance=new A226251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226252
{
public static readonly long[] Value={ 1L,7L,21L,42L,77L,126L,175L,253L,357L,434L,567L,735L,833L,1057L,1302L,1400L,1708L,2037L,2191L,2597L,3003L,3151L,3619L,4242L,4389L,4935L,5691L,5740L,6594L,7434L,7371L,8400L,9303L,9506L,10626L,11592L,11585L,12761L,14427L,14203L,15519L,17241L,16808L,18788L,20559L,19950L,21882L,23898L,23786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226252Inst : IEnumerable<long>
{
public static readonly long[] Value=A226252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226252.Bytes);
public long this[int i]=>Value[i];

public static A226252Inst Instance=new A226252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226253
{
public static readonly long[] Value={ 1L,9L,36L,93L,198L,378L,633L,990L,1521L,2173L,2979L,4113L,5370L,6858L,8955L,11055L,13446L,16830L,20031L,23724L,28836L,33381L,38520L,45729L,52203L,59121L,68922L,77461L,86283L,99747L,110547L,121500L,138870L,152034L,166725L,188568L,204156L,221760L,248310L,268713L,289422L,321786L,345570L,369036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226253Inst : IEnumerable<long>
{
public static readonly long[] Value=A226253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226253.Bytes);
public long this[int i]=>Value[i];

public static A226253Inst Instance=new A226253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226254
{
public static readonly long[] Value={ 1L,10L,45L,130L,300L,612L,1105L,1830L,2925L,4420L,6341L,9000L,12325L,16290L,21645L,27932L,34980L,44370L,54900L,66430L,81702L,98050L,115440L,138330L,162565L,187800L,220545L,254800L,289265L,334890L,382058L,427350L,488700L,550420L,609960L,691812L,770185L,845750L,949365L,1049400L,1145580L,1274580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226254Inst : IEnumerable<long>
{
public static readonly long[] Value=A226254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226254.Bytes);
public long this[int i]=>Value[i];

public static A226254Inst Instance=new A226254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226255
{
public static readonly long[] Value={ 1L,11L,55L,176L,440L,957L,1848L,3245L,5412L,8580L,12892L,18888L,26895L,36916L,50160L,66935L,86658L,111870L,142582L,177320L,221100L,272690L,329065L,399102L,480040L,566808L,672969L,793760L,920326L,1074040L,1248412L,1425974L,1640595L,1882145L,2123385L,2418339L,2743928L,3062895L,3453978L,3880855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226255Inst : IEnumerable<long>
{
public static readonly long[] Value=A226255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226255.Bytes);
public long this[int i]=>Value[i];

public static A226255Inst Instance=new A226255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226256
{
public static readonly BigInteger[] Value={ 1L,1L,77L,17017L,52055003L,1509595087L,3603403472669L,10151817126357907L,BigInteger.Parse("20516822412369330047"),BigInteger.Parse("905797192683693552245003"),BigInteger.Parse("11169385182982625192733131993"),BigInteger.Parse("5636477922794232040441965063013"),BigInteger.Parse("616692686010839721776795839509315343"),BigInteger.Parse("266648429851302313546720724144758580231") };
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
public class A226256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A226256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226256Inst Instance=new A226256Inst();

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