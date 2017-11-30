using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A156305
{
public static readonly long[] Value={ 1L,1L,5L,18L,87L,290L,1553L,5015L,25436L,94500L,431464L,1519749L,8024004L,26746757L,125190249L,498138920L,2221127601L,8020960187L,38836436844L,138444409552L,655009491676L,2512996318026L,10775473291178L,40824090856703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156305Inst : IEnumerable<long>
{
public static readonly long[] Value=A156305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156305.Bytes);
public long this[int i]=>Value[i];

public static A156305Inst Instance=new A156305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156306
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,292L,3468L,69664L,1208936L,32822456L,858979216L,28933584112L,836115182512L,40673697842208L,1381857061152896L,67261437417875776L,3297904559465926208L,BigInteger.Parse("192628214559932492928"),BigInteger.Parse("8815748379077085483264") };
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
public class A156306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156306Inst Instance=new A156306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156307
{
public static readonly long[] Value={ 11L,101L,211L,431L,523L,541L,743L,761L,853L,2011L,4013L,4211L,5023L,5113L,7043L,7151L,7331L,8017L,8053L,8161L,8233L,8431L,8521L,20011L,20101L,21001L,40013L,40031L,41201L,42101L,50023L,50131L,50221L,50311L,51031L,52021L,52201L,53101L,54001L,70061L,70223L,70241L,70313L,71411L,72221L,73013L,73121L,74021L,74201L,75011L,76001L,80071L,80107L,80233L,80251L,80341L,80611L,80701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156307Inst : IEnumerable<long>
{
public static readonly long[] Value=A156307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156307.Bytes);
public long this[int i]=>Value[i];

public static A156307Inst Instance=new A156307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156308
{
public static readonly long[] Value={ 1L,4L,1L,9L,6L,1L,16L,20L,8L,1L,25L,50L,35L,10L,1L,36L,105L,112L,54L,12L,1L,49L,196L,294L,210L,77L,14L,1L,64L,336L,672L,660L,352L,104L,16L,1L,81L,540L,1386L,1782L,1287L,546L,135L,18L,1L,100L,825L,2640L,4290L,4004L,2275L,800L,170L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156308Inst : IEnumerable<long>
{
public static readonly long[] Value=A156308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156308.Bytes);
public long this[int i]=>Value[i];

public static A156308Inst Instance=new A156308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156309
{
public static readonly long[] Value={ 2L,1L,1L,3L,2L,4L,8L,6L,5L,4L,0L,5L,1L,8L,7L,1L,1L,7L,7L,4L,5L,4L,2L,5L,6L,0L,9L,7L,4L,9L,0L,2L,1L,2L,7L,2L,1L,7L,6L,1L,9L,9L,1L,2L,4L,3L,6L,4L,9L,3L,6L,5L,6L,1L,9L,9L,0L,6L,9L,8L,8L,3L,6L,7L,5L,8L,0L,1L,1L,1L,6L,3L,8L,4L,8L,5L,3L,3L,3L,2L,7L,1L,5L,3L,1L,4L,2L,3L,0L,2L,2L,0L,7L,1L,2L,5L,2L,3L,7L,3L,8L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156309Inst : IEnumerable<long>
{
public static readonly long[] Value=A156309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156309.Bytes);
public long this[int i]=>Value[i];

public static A156309Inst Instance=new A156309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156310
{
public static readonly BigInteger[] Value={ 1L,-5L,-24L,845L,3480L,-105125L,-1277064L,216867085L,876529560L,-47866088075L,-967121260104L,129105476445815L,1565088635649240L,-123459873187325225L,-3492173223936699144L,BigInteger.Parse("2542850553653203214525"),BigInteger.Parse("10275255401480921258520"),BigInteger.Parse("-1059950027391240190578575") };
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
public class A156310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156310Inst Instance=new A156310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156311
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,1L,2L,2L,0L,1L,1L,1L,3L,2L,1L,1L,0L,1L,2L,0L,2L,3L,0L,1L,2L,1L,0L,2L,1L,3L,2L,2L,2L,0L,1L,1L,2L,3L,2L,1L,1L,2L,2L,0L,0L,1L,2L,1L,2L,1L,0L,2L,2L,2L,1L,3L,1L,1L,4L,3L,1L,1L,3L,2L,0L,1L,1L,1L,3L,3L,1L,1L,0L,3L,3L,2L,4L,0L,2L,1L,1L,2L,2L,2L,1L,0L,1L,3L,2L,3L,1L,2L,0L,2L,3L,1L,3L,1L,2L,5L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156311Inst : IEnumerable<long>
{
public static readonly long[] Value=A156311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156311.Bytes);
public long this[int i]=>Value[i];

public static A156311Inst Instance=new A156311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156312
{
public static readonly long[] Value={ 5L,11L,13L,17L,19L,23L,29L,37L,41L,43L,47L,53L,59L,61L,71L,73L,83L,89L,101L,103L,107L,113L,127L,131L,137L,139L,149L,157L,163L,167L,173L,179L,181L,191L,193L,197L,223L,227L,229L,233L,239L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,337L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156312Inst : IEnumerable<long>
{
public static readonly long[] Value=A156312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156312.Bytes);
public long this[int i]=>Value[i];

public static A156312Inst Instance=new A156312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156313
{
public static readonly long[] Value={ 2L,3L,7L,31L,67L,79L,97L,109L,151L,199L,211L,241L,331L,379L,409L,457L,499L,619L,631L,751L,757L,769L,877L,991L,1039L,1087L,1117L,1201L,1231L,1291L,1381L,1429L,1471L,1609L,1621L,1777L,1861L,1999L,2131L,2179L,2269L,2281L,2311L,2341L,2389L,2551L,2659L,2719L,2797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156313Inst : IEnumerable<long>
{
public static readonly long[] Value=A156313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156313.Bytes);
public long this[int i]=>Value[i];

public static A156313Inst Instance=new A156313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156314
{
public static readonly long[] Value={ 2L,5L,23L,47L,283L,557L,5147L,2273L,12899L,103703L,146417L,3369869L,5037233L,71067323L,6484133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156314Inst : IEnumerable<long>
{
public static readonly long[] Value=A156314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156314.Bytes);
public long this[int i]=>Value[i];

public static A156314Inst Instance=new A156314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156315
{
public static readonly BigInteger[] Value={ 1L,-3L,-28L,531L,4172L,-66603L,-1536388L,137550387L,1054950092L,-30363634053L,-1164035538148L,81898711469481L,1883763924236012L,-78317527982830503L,-4203233953065299908L,BigInteger.Parse("1613073155733338421699"),BigInteger.Parse("12367457841345960753932"),BigInteger.Parse("-672385944707015219005953") };
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
public class A156315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156315Inst Instance=new A156315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156316
{
public static readonly long[] Value={ 144L,169L,1089L,10404L,10609L,12544L,12769L,14884L,1004004L,1006009L,1022121L,1024144L,1026169L,1042441L,1044484L,1062961L,1214404L,1216609L,1236544L,1238769L,1256641L,1258884L,1444804L,1468944L,4048144L,4088484L,10036224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156316Inst : IEnumerable<long>
{
public static readonly long[] Value=A156316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156316.Bytes);
public long this[int i]=>Value[i];

public static A156316Inst Instance=new A156316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156317
{
public static readonly long[] Value={ 0L,1L,4L,9L,121L,144L,169L,484L,676L,1089L,10201L,10404L,10609L,12321L,12544L,12769L,14641L,14884L,40804L,44944L,69696L,94249L,698896L,1002001L,1004004L,1006009L,1022121L,1024144L,1026169L,1042441L,1044484L,1062961L,1214404L,1216609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156317Inst : IEnumerable<long>
{
public static readonly long[] Value=A156317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156317.Bytes);
public long this[int i]=>Value[i];

public static A156317Inst Instance=new A156317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156318
{
public static readonly BigInteger[] Value={ 1L,-1L,-30L,181L,4530L,-22801L,-1671390L,47118557L,1147915410L,-10402012471L,-1266647841150L,28057215721951L,2049828087259890L,-26830385433464341L,-4573773720319265310L,BigInteger.Parse("552614216749098904669"),BigInteger.Parse("13457722417096192133970"),BigInteger.Parse("-230349154057545039604411") };
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
public class A156318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156318Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156318.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156318.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156318Inst Instance=new A156318Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156319
{
public static readonly long[] Value={ 1L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,0L,0L,2L,1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156319Inst : IEnumerable<long>
{
public static readonly long[] Value=A156319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156319.Bytes);
public long this[int i]=>Value[i];

public static A156319Inst Instance=new A156319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156320
{
public static readonly long[] Value={ 3L,11L,5L,13L,11L,19L,23L,31L,29L,37L,53L,61L,59L,67L,71L,79L,89L,97L,101L,109L,131L,139L,149L,157L,173L,181L,191L,199L,233L,241L,263L,271L,269L,277L,359L,367L,389L,397L,401L,409L,431L,439L,449L,457L,479L,487L,491L,499L,563L,571L,569L,577L,593L,601L,599L,607L,653L,661L,683L,691L,701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156320Inst : IEnumerable<long>
{
public static readonly long[] Value=A156320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156320.Bytes);
public long this[int i]=>Value[i];

public static A156320Inst Instance=new A156320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156321
{
public static readonly long[] Value={ 0L,1L,4L,9L,20L,42L,85L,171L,343L,687L,1375L,2751L,5504L,11009L,22019L,44039L,88080L,176162L,352325L,704651L,1409303L,2818607L,5637215L,11274431L,22548863L,45097727L,90195455L,180390911L,360781823L,721563647L,1443127295L,2886254591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156321Inst : IEnumerable<long>
{
public static readonly long[] Value=A156321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156321.Bytes);
public long this[int i]=>Value[i];

public static A156321Inst Instance=new A156321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156322
{
public static readonly long[] Value={ 2592L,34425L,35721L,312325L,344250L,357210L,492205L,1492992L,1729665L,1769472L,3123250L,3365793L,3442500L,3472875L,3572100L,3639168L,4922050L,6718464L,6967296L,7587328L,10744475L,10756480L,13745725L,13942125L,14569245L,16746975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156322Inst : IEnumerable<long>
{
public static readonly long[] Value=A156322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156322.Bytes);
public long this[int i]=>Value[i];

public static A156322Inst Instance=new A156322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156323
{
public static readonly long[] Value={ 5L,17L,7L,19L,11L,23L,17L,29L,19L,31L,29L,41L,31L,43L,41L,53L,47L,59L,59L,71L,61L,73L,67L,79L,71L,83L,89L,101L,97L,109L,101L,113L,127L,139L,137L,149L,139L,151L,151L,163L,167L,179L,179L,191L,181L,193L,199L,211L,211L,223L,227L,239L,229L,241L,239L,251L,251L,263L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156323Inst : IEnumerable<long>
{
public static readonly long[] Value=A156323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156323.Bytes);
public long this[int i]=>Value[i];

public static A156323Inst Instance=new A156323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156324
{
public static readonly long[] Value={ 0L,1L,4L,8L,12L,18L,24L,32L,40L,49L,60L,72L,84L,98L,112L,128L,144L,161L,180L,200L,220L,242L,264L,287L,312L,338L,364L,391L,420L,450L,480L,511L,543L,576L,610L,645L,681L,718L,756L,795L,835L,876L,918L,961L,1005L,1050L,1096L,1143L,1191L,1240L,1290L,1341L,1393L,1446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156324Inst : IEnumerable<long>
{
public static readonly long[] Value=A156324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156324.Bytes);
public long this[int i]=>Value[i];

public static A156324Inst Instance=new A156324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156325
{
public static readonly BigInteger[] Value={ 1L,1L,4L,34L,482L,10056L,286372L,10591372L,491169996L,27826318000L,1887581200256L,150885500428224L,14028718134958936L,1500672248541122944L,BigInteger.Parse("182987661921689610000"),BigInteger.Parse("25231215606822797450176") };
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
public class A156325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156325Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156325.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156325.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156325Inst Instance=new A156325Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156326
{
public static readonly BigInteger[] Value={ 1L,1L,5L,58L,1181L,36696L,1601497L,92969920L,6908883417L,638746871680L,71860612355981L,9664570175364864L,1531263494465900725L,BigInteger.Parse("282321785979644121088"),BigInteger.Parse("59935663751282958139425") };
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
public class A156326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156326Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156326.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156326.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156326Inst Instance=new A156326Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156327
{
public static readonly BigInteger[] Value={ 1L,2L,14L,194L,4280L,134232L,5587408L,294882464L,19102334112L,1482726089600L,135370060595264L,14325189014356992L,1736329123715436544L,BigInteger.Parse("238698935851482530816"),BigInteger.Parse("36911830664814417907200") };
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
public class A156327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156327Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156327.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156327.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156327Inst Instance=new A156327Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156328
{
public static readonly long[] Value={ 5L,23L,11L,29L,13L,31L,19L,37L,23L,41L,29L,47L,41L,59L,43L,61L,53L,71L,61L,79L,71L,89L,79L,97L,83L,101L,89L,107L,109L,127L,113L,131L,131L,149L,139L,157L,149L,167L,163L,181L,173L,191L,179L,197L,181L,199L,193L,211L,211L,229L,223L,241L,233L,251L,239L,257L,251L,269L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156328Inst : IEnumerable<long>
{
public static readonly long[] Value=A156328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156328.Bytes);
public long this[int i]=>Value[i];

public static A156328Inst Instance=new A156328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156329
{
public static readonly BigInteger[] Value={ 4L,10L,84L,1140L,7140L,125580L,2929290L,161226780L,2875585020L,32451432090L,9117204216120L,173092525291140L,12728365882372140L,6235727798083743960L,BigInteger.Parse("843456728066008506450"),BigInteger.Parse("68313970807402942762140"),BigInteger.Parse("7219596660397839675355860") };
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
public class A156329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156329.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156329Inst Instance=new A156329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156330
{
public static readonly BigInteger[] Value={ 1L,-5L,-11L,415L,1705L,-120125L,-737891L,73544935L,602197585L,-77251102325L,-790660144571L,123981052932655L,1522721707926265L,-282190333761783725L,-4043468004740204051L,BigInteger.Parse("864617687280807347575"),BigInteger.Parse("14158848206836206915745"),BigInteger.Parse("-3431276846283480837508325") };
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
public class A156330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156330Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156330.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156330.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156330Inst Instance=new A156330Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156331
{
public static readonly long[] Value={ 8L,16L,40L,32L,56L,64L,64L,56L,32L,40L,16L,8L,8L,16L,40L,32L,56L,64L,64L,56L,32L,40L,16L,8L,8L,16L,40L,32L,56L,64L,64L,56L,32L,40L,16L,8L,8L,16L,40L,32L,56L,64L,64L,56L,32L,40L,16L,8L,8L,16L,40L,32L,56L,64L,64L,56L,32L,40L,16L,8L,8L,16L,40L,32L,56L,64L,64L,56L,32L,40L,16L,8L,8L,16L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156331Inst : IEnumerable<long>
{
public static readonly long[] Value=A156331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156331.Bytes);
public long this[int i]=>Value[i];

public static A156331Inst Instance=new A156331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156332
{
public static readonly BigInteger[] Value={ 1L,-1L,-35L,107L,6265L,-32041L,-2749355L,19696067L,2247032305L,-20698163281L,-2950725914675L,33220406931227L,5682862415856745L,-75612617322835321L,BigInteger.Parse("-15090424387627057595"),BigInteger.Parse("231673592430307689587"),BigInteger.Parse("52841539466887256047585"),BigInteger.Parse("-919407851749260210944161") };
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
public class A156332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156332.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156332Inst Instance=new A156332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156333
{
public static readonly long[] Value={ 1L,39L,57L,91L,115L,121L,133L,143L,145L,147L,153L,155L,161L,175L,189L,203L,205L,207L,225L,231L,235L,243L,253L,255L,261L,273L,279L,285L,295L,299L,301L,303L,323L,325L,327L,341L,343L,345L,351L,355L,377L,385L,387L,411L,415L,427L,429L,441L,445L,447L,451L,465L,481L,483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156333Inst : IEnumerable<long>
{
public static readonly long[] Value=A156333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156333.Bytes);
public long this[int i]=>Value[i];

public static A156333Inst Instance=new A156333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156334
{
public static readonly BigInteger[] Value={ 1L,2L,6L,20L,166L,1980L,91612L,4980968L,1083899526L,246514209900L,225675208005684L,210073940172966552L,BigInteger.Parse("787481680820307364188"),BigInteger.Parse("2977392786568558334126040"),BigInteger.Parse("45279192083837920124027862264") };
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
public class A156334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156334.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156334Inst Instance=new A156334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156335
{
public static readonly BigInteger[] Value={ 1L,2L,4L,16L,92L,1816L,47344L,4888640L,546663016L,245429690704L,113080892367776L,209848258185362560L,BigInteger.Parse("393950238751186551328"),BigInteger.Parse("2976605303522286162203456"),BigInteger.Parse("22642571073509592590956639360"),BigInteger.Parse("692351532949951721637759480882688") };
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
public class A156335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156335Inst Instance=new A156335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156336
{
public static readonly BigInteger[] Value={ 1L,3L,9L,99L,1917L,324567L,65546253L,121237985007L,231991261827633L,4053251131970038227L,BigInteger.Parse("71801958531451566872745"),BigInteger.Parse("11561440390042361895766055043"),BigInteger.Parse("1877401313066393527954697682635421") };
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
public class A156336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156336Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156336.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156336.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156336Inst Instance=new A156336Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156337
{
public static readonly BigInteger[] Value={ 1L,4L,16L,384L,17856L,13492992L,11507268608L,160888878129152L,2306486569154275328L,BigInteger.Parse("537309590223329223155712"),BigInteger.Parse("126767209261235580163634135040"),BigInteger.Parse("483356141899716284828508078471905280") };
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
public class A156337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156337Inst Instance=new A156337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156338
{
public static readonly BigInteger[] Value={ 1L,-11L,-12L,2123L,2172L,-360371L,-1102932L,1035689611L,1056359292L,-319185648221L,-1627743248052L,1202397156295313L,3679092612819612L,-1605938618222598671L,BigInteger.Parse("-11465642472931188372"),BigInteger.Parse("46198207000506361023707"),BigInteger.Parse("47119049550414874995132") };
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
public class A156338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156338Inst Instance=new A156338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156339
{
public static readonly long[] Value={ 1L,26L,169L,8788L,28561L,742586L,4826809L,501988136L,815730721L,21208998746L,137858491849L,7168641576148L,23298085122481L,605750213184506L,3937376385699289L,818974288225452112L,665416609183179841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156339Inst : IEnumerable<long>
{
public static readonly long[] Value=A156339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156339.Bytes);
public long this[int i]=>Value[i];

public static A156339Inst Instance=new A156339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156340
{
public static readonly BigInteger[] Value={ 1L,2L,6L,52L,2150L,423804L,358766428L,1257303170984L,18016913850523398L,BigInteger.Parse("1049450810327077624300"),BigInteger.Parse("247590106794776589832254260"),BigInteger.Parse("236013988752078034604114551553880") };
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
public class A156340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156340Inst Instance=new A156340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156341
{
public static readonly BigInteger[] Value={ 2L,18L,194L,2130L,23426L,257682L,2834498L,31179474L,342974210L,3772716306L,41499879362L,456498672978L,5021485402754L,55236339430290L,607599733733186L,6683597071065042L,73519567781715458L,808715245598870034L,8895867701587570370L,BigInteger.Parse("97854544717463274066") };
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
public class A156341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156341.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156341Inst Instance=new A156341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156342
{
public static readonly BigInteger[] Value={ 1L,-9L,-22L,1917L,4202L,-328329L,-2141062L,944408709L,2051257802L,-291080038239L,-3160876480102L,1096531750008567L,7144366876525802L,-1464544848936127149L,BigInteger.Parse("-22264942494437763142"),BigInteger.Parse("42130722382384803873093"),BigInteger.Parse("91499710761674098888202"),BigInteger.Parse("-24528149284612129806253059") };
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
public class A156342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156342.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156342Inst Instance=new A156342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156343
{
public static readonly long[] Value={ 13L,17L,29L,31L,43L,47L,59L,67L,71L,79L,83L,97L,1033L,1123L,1153L,1213L,1217L,1229L,1231L,1259L,1279L,1283L,1297L,1303L,1307L,1321L,1367L,1423L,1427L,1433L,1453L,1531L,1543L,1559L,1567L,1571L,1579L,1583L,1597L,1627L,1637L,1657L,1721L,1747L,1759L,1783L,1787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156343Inst : IEnumerable<long>
{
public static readonly long[] Value=A156343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156343.Bytes);
public long this[int i]=>Value[i];

public static A156343Inst Instance=new A156343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156344
{
public static readonly long[] Value={ 1L,2L,3L,1L,6L,2L,9L,3L,1L,14L,103L,2L,19L,7L,3L,1L,26L,10L,105L,2L,33L,13L,312L,3L,1L,42L,691L,241L,27190L,2L,51L,21L,11L,260L,3L,1L,62L,26L,14L,8L,151L,2L,73L,31L,17L,492L,268L,3L,1L,86L,2535L,869L,315546L,1065L,183L,2L,99L,43L,2226L,15L,350L,294L,3L,1L,114L,50L,1457L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156344Inst : IEnumerable<long>
{
public static readonly long[] Value=A156344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156344.Bytes);
public long this[int i]=>Value[i];

public static A156344Inst Instance=new A156344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156345
{
public static readonly long[] Value={ 0L,1L,9L,10L,12L,20L,21L,22L,34L,36L,38L,45L,54L,56L,58L,63L,65L,74L,76L,78L,85L,87L,90L,91L,92L,99L,100L,102L,110L,111L,112L,119L,120L,121L,122L,129L,134L,136L,138L,143L,145L,147L,154L,156L,158L,165L,174L,176L,178L,183L,185L,187L,190L,192L,200L,201L,202L,209L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156345Inst : IEnumerable<long>
{
public static readonly long[] Value=A156345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156345.Bytes);
public long this[int i]=>Value[i];

public static A156345Inst Instance=new A156345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156346
{
public static readonly long[] Value={ 1L,2L,-4L,4L,-2L,-1L,-1L,-2L,4L,-4L,2L,1L,1L,2L,-4L,4L,-2L,-1L,-1L,-2L,4L,-4L,2L,1L,1L,2L,-4L,4L,-2L,-1L,-1L,-2L,4L,-4L,2L,1L,1L,2L,-4L,4L,-2L,-1L,-1L,-2L,4L,-4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156346Inst : IEnumerable<long>
{
public static readonly long[] Value=A156346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156346.Bytes);
public long this[int i]=>Value[i];

public static A156346Inst Instance=new A156346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156347
{
public static readonly BigInteger[] Value={ 1L,-7L,-30L,1603L,5970L,-277207L,-3053790L,798236411L,2926843890L,-246057649537L,-4510293993150L,926939784063433L,10194432237557010L,-1238037038145567667L,BigInteger.Parse("-31770283512126257310"),BigInteger.Parse("35614753259364496078267"),BigInteger.Parse("130562740697866208097330"),BigInteger.Parse("-20734607702641977619141597") };
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
public class A156347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156347.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156347Inst Instance=new A156347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156348
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,2L,0L,1L,1L,0L,0L,0L,1L,1L,3L,3L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,4L,0L,4L,0L,0L,0L,1L,1L,0L,6L,0L,0L,0L,0L,0L,1L,1L,5L,0L,0L,5L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,6L,10L,10L,0L,6L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,7L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156348Inst : IEnumerable<long>
{
public static readonly long[] Value=A156348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156348.Bytes);
public long this[int i]=>Value[i];

public static A156348Inst Instance=new A156348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156349
{
public static readonly long[] Value={ 1L,3L,3L,3L,4L,4L,5L,7L,7L,8L,10L,10L,10L,11L,11L,11L,12L,14L,14L,15L,15L,15L,16L,16L,17L,19L,19L,19L,20L,20L,20L,21L,21L,22L,24L,24L,25L,27L,27L,27L,28L,28L,29L,31L,31L,32L,32L,32L,33L,33L,33L,34L,36L,36L,37L,39L,39L,39L,40L,40L,41L,43L,43L,44L,46L,46L,46L,47L,47L,47L,48L,48L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156349Inst : IEnumerable<long>
{
public static readonly long[] Value=A156349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156349.Bytes);
public long this[int i]=>Value[i];

public static A156349Inst Instance=new A156349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156350
{
public static readonly long[] Value={ 0L,0L,2L,3L,3L,5L,5L,5L,7L,7L,7L,9L,10L,10L,12L,13L,13L,13L,15L,15L,17L,18L,18L,20L,20L,20L,22L,23L,23L,25L,26L,26L,28L,28L,28L,30L,30L,30L,32L,33L,33L,35L,35L,35L,37L,37L,39L,40L,40L,42L,43L,43L,43L,45L,45L,45L,47L,48L,48L,50L,50L,50L,52L,52L,52L,54L,55L,55L,57L,58L,58L,60L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156350Inst : IEnumerable<long>
{
public static readonly long[] Value=A156350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156350.Bytes);
public long this[int i]=>Value[i];

public static A156350Inst Instance=new A156350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156351
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,5L,6L,7L,7L,8L,8L,9L,10L,10L,11L,11L,12L,13L,14L,14L,15L,16L,17L,17L,18L,18L,19L,20L,20L,21L,22L,23L,23L,24L,25L,25L,26L,26L,27L,28L,29L,29L,30L,31L,32L,32L,33L,34L,34L,35L,35L,36L,37L,37L,38L,38L,39L,40L,41L,41L,42L,43L,43L,44L,44L,45L,46L,46L,47L,48L,49L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156351Inst : IEnumerable<long>
{
public static readonly long[] Value=A156351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156351.Bytes);
public long this[int i]=>Value[i];

public static A156351Inst Instance=new A156351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156352
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,2L,1L,1L,2L,1L,1L,3L,2L,1L,3L,2L,1L,1L,2L,1L,3L,2L,1L,2L,1L,1L,3L,2L,1L,3L,2L,1L,2L,1L,1L,2L,1L,1L,3L,2L,1L,2L,1L,1L,2L,1L,3L,2L,1L,3L,2L,1L,1L,2L,1L,1L,3L,2L,1L,2L,1L,1L,2L,1L,1L,3L,2L,1L,3L,2L,1L,2L,1L,1L,2L,1L,3L,2L,1L,1L,2L,1L,1L,3L,2L,1L,2L,1L,1L,2L,1L,1L,3L,2L,1L,3L,2L,1L,1L,2L,1L,3L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156352Inst : IEnumerable<long>
{
public static readonly long[] Value=A156352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156352.Bytes);
public long this[int i]=>Value[i];

public static A156352Inst Instance=new A156352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156353
{
public static readonly long[] Value={ 2L,3L,3L,4L,8L,4L,5L,17L,17L,5L,6L,32L,54L,32L,6L,7L,57L,145L,145L,57L,7L,8L,100L,368L,512L,368L,100L,8L,9L,177L,945L,1649L,1649L,945L,177L,9L,10L,320L,2530L,5392L,6250L,5392L,2530L,320L,10L,11L,593L,7073L,18785L,23401L,23401L,18785L,7073L,593L,11L,12L,1124L,20412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156353Inst : IEnumerable<long>
{
public static readonly long[] Value=A156353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156353.Bytes);
public long this[int i]=>Value[i];

public static A156353Inst Instance=new A156353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156354
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,8L,4L,1L,1L,5L,17L,17L,5L,1L,1L,6L,32L,54L,32L,6L,1L,1L,7L,57L,145L,145L,57L,7L,1L,1L,8L,100L,368L,512L,368L,100L,8L,1L,1L,9L,177L,945L,1649L,1649L,945L,177L,9L,1L,1L,10L,320L,2530L,5392L,6250L,5392L,2530L,320L,10L,1L,1L,11L,593L,7073L,18785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156354Inst : IEnumerable<long>
{
public static readonly long[] Value=A156354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156354.Bytes);
public long this[int i]=>Value[i];

public static A156354Inst Instance=new A156354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156355
{
public static readonly BigInteger[] Value={ 1L,-5L,-36L,1205L,7380L,-210125L,-3788316L,605717365L,3632251860L,-186736727075L,-5597575643196L,703478041485935L,12652030729445940L,-939579102463130225L,BigInteger.Parse("-39429249910858374876"),BigInteger.Parse("27028984410938324178725"),BigInteger.Parse("162037938162912202729620"),BigInteger.Parse("-15736046106303802197669575") };
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
public class A156355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156355Inst Instance=new A156355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156356
{
public static readonly BigInteger[] Value={ 1L,-3L,-40L,747L,8360L,-131043L,-4302520L,378065739L,4126545320L,-116565742413L,-6359542622200L,439133717768817L,14374338172267880L,-586516393899525183L,BigInteger.Parse("-44796731270702196280"),BigInteger.Parse("16872389712291089019483"),BigInteger.Parse("184096079483869385248040"),BigInteger.Parse("-9822962739350459098477353") };
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
public class A156356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156356Inst Instance=new A156356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156357
{
public static readonly BigInteger[] Value={ 1L,-1L,-42L,253L,8862L,-44521L,-4567122L,128503301L,4381065822L,-39622534591L,-6751924073202L,149269450493623L,15261263326040382L,-199367620318290061L,BigInteger.Parse("-47560790129315921682"),BigInteger.Parse("5735233487231153087557"),BigInteger.Parse("195455226142518856384542"),BigInteger.Parse("-3339004511159041311768931") };
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
public class A156357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156357Inst Instance=new A156357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156358
{
public static readonly BigInteger[] Value={ 1L,-3L,-13L,333L,2717L,-131043L,-1599793L,109190253L,1777008857L,-156107958723L,-3175649491573L,341011318885773L,8324471625279797L,-1056450457249168803L,BigInteger.Parse("-30087334294452702553"),BigInteger.Parse("4405799115103013278893"),BigInteger.Parse("143400677661526320767537"),BigInteger.Parse("-23798518054913516311313283") };
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
public class A156358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156358Inst Instance=new A156358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156359
{
public static readonly long[] Value={ 1L,7L,196L,1372L,38416L,268912L,7529536L,52706752L,1475789056L,10330523392L,289254654976L,2024782584832L,56693912375296L,396857386627072L,11112006825558016L,77784047778906112L,2177953337809371136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156359Inst : IEnumerable<long>
{
public static readonly long[] Value=A156359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156359.Bytes);
public long this[int i]=>Value[i];

public static A156359Inst Instance=new A156359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156360
{
public static readonly BigInteger[] Value={ 1L,3L,15L,120L,1450L,25383L,591563L,17156364L,595635903L,24023004840L,1102221504614L,56652798990909L,3222918574782830L,200989079661549750L,13632214370613131094UL,BigInteger.Parse("998992560620311541814"),BigInteger.Parse("78653794343072884416393") };
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
public class A156360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156360Inst Instance=new A156360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156361
{
public static readonly long[] Value={ 1L,6L,42L,288L,2016L,14040L,98280L,686880L,4808160L,33638976L,235472832L,1647983232L,11535882624L,80745019776L,565215138432L,3956385876480L,27694701135360L,193860506096640L,1357023542676480L,9499115800977408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156361Inst : IEnumerable<long>
{
public static readonly long[] Value=A156361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156361.Bytes);
public long this[int i]=>Value[i];

public static A156361Inst Instance=new A156361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156362
{
public static readonly long[] Value={ 1L,7L,56L,441L,3528L,28126L,225008L,1798349L,14386792L,115060722L,920485776L,7363180314L,58905442512L,471228010428L,3769824083424L,30158239367445L,241265914939560L,1930119075851050L,15440952606808400L,123527424655229966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156362Inst : IEnumerable<long>
{
public static readonly long[] Value=A156362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156362.Bytes);
public long this[int i]=>Value[i];

public static A156362Inst Instance=new A156362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156363
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,25L,1L,13L,76L,350L,1L,28L,242L,1430L,6951L,1L,59L,783L,6023L,35659L,179487L,1L,122L,2527L,25782L,187092L,1108128L,5715424L,1L,249L,8070L,110960L,995595L,6963711L,41250694L,216627840L,1L,504L,25456L,476626L,5337322L,44302510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156363Inst : IEnumerable<long>
{
public static readonly long[] Value=A156363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156363.Bytes);
public long this[int i]=>Value[i];

public static A156363Inst Instance=new A156363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156364
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,19L,1L,4L,41L,274L,1L,5L,26L,812L,5521L,1L,6L,-370L,1000L,20490L,143828L,1L,7L,-3023L,-8607L,34062L,640356L,4607296L,1L,8L,-16977L,-97974L,-192901L,1249164L,23929389L,175377146L,1L,9L,-83108L,-703130L,-1227484L,-8076692L,53594570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156364Inst : IEnumerable<long>
{
public static readonly long[] Value=A156364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156364.Bytes);
public long this[int i]=>Value[i];

public static A156364Inst Instance=new A156364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156365
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,8L,4L,1L,22L,44L,8L,1L,52L,264L,208L,16L,1L,114L,1208L,2416L,912L,32L,1L,240L,4764L,19328L,19056L,3840L,64L,1L,494L,17172L,124952L,249904L,137376L,15808L,128L,1L,1004L,58432L,705872L,2499040L,2823488L,934912L,64256L,256L,1L,2026L,191360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156365Inst : IEnumerable<long>
{
public static readonly long[] Value=A156365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156365.Bytes);
public long this[int i]=>Value[i];

public static A156365Inst Instance=new A156365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156366
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,12L,9L,1L,33L,99L,27L,1L,78L,594L,702L,81L,1L,171L,2718L,8154L,4617L,243L,1L,360L,10719L,65232L,96471L,29160L,729L,1L,741L,38637L,421713L,1265139L,1043199L,180063L,2187L,1L,1506L,131472L,2382318L,12651390L,21440862L,10649232L,1097874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156366Inst : IEnumerable<long>
{
public static readonly long[] Value=A156366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156366.Bytes);
public long this[int i]=>Value[i];

public static A156366Inst Instance=new A156366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156367
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,10L,6L,1L,10L,30L,42L,24L,1L,15L,70L,168L,216L,120L,1L,21L,140L,504L,1080L,1320L,720L,1L,28L,252L,1260L,3960L,7920L,9360L,5040L,1L,36L,420L,2772L,11880L,34320L,65520L,75600L,40320L,1L,45L,660L,5544L,30888L,120120L,327600L,604800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156367Inst : IEnumerable<long>
{
public static readonly long[] Value=A156367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156367.Bytes);
public long this[int i]=>Value[i];

public static A156367Inst Instance=new A156367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156368
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,3L,1L,3L,8L,6L,6L,1L,16L,35L,38L,20L,10L,1L,96L,211L,213L,134L,50L,15L,1L,675L,1459L,1479L,915L,385L,105L,21L,1L,5413L,11584L,11692L,7324L,3130L,952L,196L,28L,1L,48800L,103605L,104364L,65784L,28764L,9090L,2100L,336L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156368Inst : IEnumerable<long>
{
public static readonly long[] Value=A156368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156368.Bytes);
public long this[int i]=>Value[i];

public static A156368Inst Instance=new A156368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156369
{
public static readonly BigInteger[] Value={ 1L,-2L,-33L,131L,7557L,-52441L,-4479453L,43772651L,4978712937L,-62592982321L,-8897903159673L,136734572412371L,23324631240713517L,-423603623547304201L,BigInteger.Parse("-84302829345075000693"),BigInteger.Parse("1766588227683291263291"),BigInteger.Parse("401799765855712694217297"),BigInteger.Parse("-9542464808808332243626081") };
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
public class A156369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156369Inst Instance=new A156369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156370
{
public static readonly BigInteger[] Value={ 1L,-1L,-45L,143L,10845L,-58081L,-6467985L,48571823L,7193829465L,-69471000001L,-12857719720725L,151763444497103L,33705032917690485L,-470164385248041121L,BigInteger.Parse("-121821103620727531065"),BigInteger.Parse("1960764928973430783983"),BigInteger.Parse("580617476571375848857905"),BigInteger.Parse("-10591336845363318048877441") };
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
public class A156370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156370Inst Instance=new A156370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156371
{
public static readonly BigInteger[] Value={ 1L,-13L,-14L,3289L,3346L,-742573L,-2261294L,2841057713L,2883394066L,-1165698195883L,-5915247142574L,5846368002800299L,17800139296816786L,BigInteger.Parse("-10395919849616208193"),BigInteger.Parse("-73854485270547639854"),BigInteger.Parse("398157508559884505493841"),BigInteger.Parse("404083217883271884575506") };
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
public class A156371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156371Inst Instance=new A156371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156372
{
public static readonly long[] Value={ 1L,30L,225L,13500L,50625L,1518750L,11390625L,1366875000L,2562890625L,76886718750L,576650390625L,34599023437500L,129746337890625L,3892390136718750L,29192926025390625L,7006302246093750000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156372Inst : IEnumerable<long>
{
public static readonly long[] Value=A156372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156372.Bytes);
public long this[int i]=>Value[i];

public static A156372Inst Instance=new A156372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156373
{
public static readonly BigInteger[] Value={ 1L,-11L,-26L,3047L,6526L,-693011L,-4422626L,2653213519L,5640623326L,-1088700064661L,-11571937158626L,5460237281533397L,34822316355378526L,BigInteger.Parse("-9709316239406483711"),BigInteger.Parse("-144481170209763933026"),BigInteger.Parse("371861035047540924172463"),BigInteger.Parse("790506057144236871772126") };
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
public class A156373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156373Inst Instance=new A156373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156374
{
public static readonly BigInteger[] Value={ 1L,-7L,-44L,2191L,11836L,-506527L,-8074484L,1942900127L,10305103996L,-797402505697L,-21142795144724L,3999364467835261L,63623475942107356L,-7111631398646944267L,BigInteger.Parse("-263980205025108291764"),BigInteger.Parse("272371329567319066087759"),BigInteger.Parse("1444326418174436931225916") };
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
public class A156374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156374Inst Instance=new A156374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156375
{
public static readonly BigInteger[] Value={ 1L,-1L,-56L,337L,15736L,-78961L,-10797416L,303433889L,13789711096L,-124562882671L,-28294304772776L,624760028475427L,85144736902198456L,-1110945491765125381L,BigInteger.Parse("-353274426316390204136"),BigInteger.Parse("42548577352019389726513"),BigInteger.Parse("1932885997799987667805816") };
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
public class A156375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156375Inst Instance=new A156375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156376
{
public static readonly long[] Value={ 19L,49L,79L,109L,139L,169L,199L,229L,259L,289L,319L,349L,379L,409L,439L,469L,499L,529L,559L,589L,619L,649L,679L,709L,739L,769L,799L,829L,859L,889L,919L,949L,979L,1009L,1039L,1069L,1099L,1129L,1159L,1189L,1219L,1249L,1279L,1309L,1339L,1369L,1399L,1429L,1459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156376Inst : IEnumerable<long>
{
public static readonly long[] Value=A156376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156376.Bytes);
public long this[int i]=>Value[i];

public static A156376Inst Instance=new A156376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156377
{
public static readonly BigInteger[] Value={ 1L,-7L,-15L,1001L,4065L,-514087L,-3125295L,559451081L,4534099905L,-1044682551367L,-10583199850575L,2980654783566761L,36234719616266145L,BigInteger.Parse("-12060793477105158247"),BigInteger.Parse("-171055019182265094255"),BigInteger.Parse("65695455336100321500041"),BigInteger.Parse("1064846988389856127270785") };
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
public class A156377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156377Inst Instance=new A156377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156378
{
public static readonly BigInteger[] Value={ 1L,-5L,-39L,835L,11505L,-435125L,-8895159L,474199315L,12911285985L,-885622708325L,-30138216644679L,2526871947738595L,103187680863514065L,BigInteger.Parse("-10224644684792712725"),BigInteger.Parse("-487123444685240541399"),BigInteger.Parse("55693916390925161098675"),BigInteger.Parse("3032427638617185383735745") };
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
public class A156378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156378Inst Instance=new A156378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156379
{
public static readonly BigInteger[] Value={ 1L,-3L,-55L,549L,17105L,-290163L,-13303015L,316777269L,19321588385L,-591738931683L,-45104637594775L,1688397003889989L,154431129354692465L,-6831886973961176403L,BigInteger.Parse("-729031676636458475335"),BigInteger.Parse("37213483871550478106709"),BigInteger.Parse("4538348625017228461697345") };
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
public class A156379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156379Inst Instance=new A156379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156380
{
public static readonly long[] Value={ 1L,4L,4L,1L,4L,6L,4L,0L,4L,8L,6L,4L,1L,6L,6L,0L,4L,10L,8L,4L,6L,6L,4L,0L,4L,16L,12L,5L,0L,12L,6L,0L,4L,8L,16L,6L,8L,6L,10L,0L,6L,22L,6L,4L,4L,12L,6L,0L,1L,10L,22L,11L,6L,12L,14L,0L,6L,8L,6L,10L,0L,12L,12L,0L,4L,18L,20L,4L,10L,12L,6L,0L,8L,10L,18L,13L,4L,12L,6L,0L,6L,24L,10L,10L,6L,12L,16L,0L,4L,28L,18L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156380Inst : IEnumerable<long>
{
public static readonly long[] Value=A156380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156380.Bytes);
public long this[int i]=>Value[i];

public static A156380Inst Instance=new A156380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156381
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,0L,2L,0L,2L,4L,0L,2L,1L,0L,0L,0L,2L,2L,4L,2L,0L,0L,2L,0L,2L,4L,0L,3L,0L,0L,0L,0L,2L,4L,4L,0L,4L,0L,2L,0L,0L,4L,0L,2L,2L,0L,0L,0L,1L,2L,4L,5L,0L,0L,4L,0L,0L,4L,0L,2L,0L,0L,0L,0L,2L,0L,6L,2L,2L,0L,0L,0L,4L,2L,0L,3L,2L,0L,0L,0L,0L,8L,2L,2L,0L,0L,2L,0L,2L,4L,0L,0L,0L,0L,0L,0L,2L,2L,2L,7L,4L,0L,4L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156381Inst : IEnumerable<long>
{
public static readonly long[] Value=A156381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156381.Bytes);
public long this[int i]=>Value[i];

public static A156381Inst Instance=new A156381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156382
{
public static readonly long[] Value={ 1L,10L,18L,10L,11L,42L,42L,10L,18L,68L,60L,42L,20L,68L,96L,42L,11L,84L,114L,68L,60L,130L,84L,42L,42L,142L,228L,158L,34L,210L,240L,52L,18L,174L,240L,210L,127L,110L,252L,130L,60L,276L,318L,142L,84L,390L,192L,84L,20L,198L,474L,324L,134L,180L,486L,174L,96L,286L,198L,300L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156382Inst : IEnumerable<long>
{
public static readonly long[] Value=A156382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156382.Bytes);
public long this[int i]=>Value[i];

public static A156382Inst Instance=new A156382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156383
{
public static readonly long[] Value={ 1L,6L,10L,6L,7L,22L,22L,6L,10L,28L,32L,22L,12L,28L,48L,22L,7L,44L,54L,28L,32L,54L,44L,22L,22L,58L,96L,58L,18L,86L,112L,28L,10L,74L,92L,86L,51L,50L,108L,54L,32L,108L,130L,58L,44L,130L,96L,44L,12L,82L,174L,116L,54L,92L,186L,74L,48L,106L,102L,116L,74L,114L,160L,106L,7L,164L,224L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156383Inst : IEnumerable<long>
{
public static readonly long[] Value=A156383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156383.Bytes);
public long this[int i]=>Value[i];

public static A156383Inst Instance=new A156383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156384
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,2L,2L,2L,4L,4L,2L,4L,4L,0L,2L,3L,4L,6L,4L,4L,2L,4L,2L,2L,6L,4L,6L,6L,2L,0L,4L,2L,6L,8L,2L,7L,6L,4L,2L,4L,4L,6L,6L,4L,6L,0L,4L,4L,6L,6L,4L,10L,4L,6L,6L,0L,6L,10L,4L,6L,6L,0L,6L,3L,4L,8L,8L,8L,4L,6L,2L,6L,10L,4L,6L,10L,4L,0L,4L,4L,8L,14L,6L,6L,8L,4L,6L,4L,6L,10L,6L,6L,6L,0L,2L,2L,12L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156384Inst : IEnumerable<long>
{
public static readonly long[] Value=A156384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156384.Bytes);
public long this[int i]=>Value[i];

public static A156384Inst Instance=new A156384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156385
{
public static readonly long[] Value={ 1L,26L,112L,112L,57L,291L,552L,240L,138L,868L,972L,704L,352L,876L,1912L,840L,347L,1308L,3704L,1844L,1239L,1872L,2772L,1320L,1104L,2832L,4884L,6416L,1840L,3758L,6232L,3240L,818L,5544L,11384L,8916L,7011L,4146L,8484L,4560L,2914L,6030L,12672L,11344L,5344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156385Inst : IEnumerable<long>
{
public static readonly long[] Value=A156385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156385.Bytes);
public long this[int i]=>Value[i];

public static A156385Inst Instance=new A156385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156386
{
public static readonly long[] Value={ 1L,6L,12L,12L,13L,7L,32L,0L,18L,68L,32L,48L,12L,12L,36L,0L,19L,76L,112L,76L,75L,20L,40L,0L,64L,112L,88L,204L,0L,38L,76L,0L,30L,184L,168L,116L,275L,18L,80L,0L,114L,194L,96L,204L,48L,99L,136L,0L,12L,210L,272L,452L,190L,86L,472L,0L,156L,256L,128L,400L,0L,126L,152L,0L,19L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156386Inst : IEnumerable<long>
{
public static readonly long[] Value=A156386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156386.Bytes);
public long this[int i]=>Value[i];

public static A156386Inst Instance=new A156386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156387
{
public static readonly long[] Value={ 1L,2L,0L,0L,5L,3L,0L,0L,2L,4L,0L,0L,0L,4L,0L,0L,7L,4L,0L,0L,7L,0L,0L,0L,0L,8L,0L,0L,0L,10L,0L,0L,6L,0L,0L,0L,15L,6L,0L,0L,6L,6L,0L,0L,0L,11L,0L,0L,0L,6L,0L,0L,10L,14L,0L,0L,0L,0L,0L,0L,0L,10L,0L,0L,7L,12L,0L,0L,28L,0L,0L,0L,10L,6L,0L,0L,0L,6L,0L,0L,17L,12L,0L,0L,0L,16L,0L,0L,0L,14L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156387Inst : IEnumerable<long>
{
public static readonly long[] Value=A156387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156387.Bytes);
public long this[int i]=>Value[i];

public static A156387Inst Instance=new A156387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156388
{
public static readonly long[] Value={ 1L,76L,820L,1760L,1082L,2962L,13751L,12160L,3910L,19436L,56610L,37760L,17550L,43300L,137096L,128000L,38042L,50500L,285470L,313880L,112892L,121382L,508190L,388720L,151919L,250472L,575670L,857040L,449790L,329252L,1521948L,1421120L,310150L,520580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156388Inst : IEnumerable<long>
{
public static readonly long[] Value=A156388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156388.Bytes);
public long this[int i]=>Value[i];

public static A156388Inst Instance=new A156388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156389
{
public static readonly long[] Value={ 1L,20L,84L,136L,110L,232L,635L,616L,308L,788L,1718L,1568L,926L,1412L,2952L,3200L,1430L,1804L,5414L,6024L,3154L,3552L,7838L,7232L,3923L,5024L,9866L,13400L,8094L,6888L,16076L,17304L,6308L,8852L,23020L,23480L,16008L,13276L,22640L,27472L,16570L,11736L,31662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156389Inst : IEnumerable<long>
{
public static readonly long[] Value=A156389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156389.Bytes);
public long this[int i]=>Value[i];

public static A156389Inst Instance=new A156389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156390
{
public static readonly long[] Value={ 1L,0L,12L,0L,12L,0L,7L,0L,24L,0L,54L,0L,18L,0L,24L,0L,36L,0L,90L,0L,78L,0L,42L,0L,31L,0L,126L,0L,78L,0L,24L,0L,72L,0L,168L,0L,150L,0L,90L,0L,114L,0L,174L,0L,114L,0L,72L,0L,66L,0L,366L,0L,336L,0L,127L,0L,120L,0L,432L,0L,186L,0L,96L,0L,132L,0L,186L,0L,450L,0L,210L,0L,246L,0L,438L,0L,264L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156390Inst : IEnumerable<long>
{
public static readonly long[] Value=A156390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156390.Bytes);
public long this[int i]=>Value[i];

public static A156390Inst Instance=new A156390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156391
{
public static readonly long[] Value={ 1L,232L,6912L,35150L,42354L,44124L,425674L,804511L,446508L,638012L,4465916L,5291400L,2246390L,3026820L,18106164L,25432912L,12496449L,5934606L,46859304L,91441740L,47944020L,17647254L,123856526L,218810112L,102258544L,46559350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156391Inst : IEnumerable<long>
{
public static readonly long[] Value=A156391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156391.Bytes);
public long this[int i]=>Value[i];

public static A156391Inst Instance=new A156391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156392
{
public static readonly long[] Value={ 1L,20L,132L,294L,440L,270L,1414L,635L,1716L,2096L,5108L,9108L,3066L,3096L,9216L,2952L,9131L,8172L,21624L,39000L,31638L,11364L,31206L,14100L,32236L,18704L,64560L,102762L,51947L,50136L,38544L,49526L,74688L,37944L,138156L,259560L,175374L,76680L,182640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156392Inst : IEnumerable<long>
{
public static readonly long[] Value=A156392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156392.Bytes);
public long this[int i]=>Value[i];

public static A156392Inst Instance=new A156392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156393
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,14L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,5L,13L,0L,0L,0L,42L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,4L,18L,0L,0L,0L,0L,0L,0L,6L,6L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156393Inst : IEnumerable<long>
{
public static readonly long[] Value=A156393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156393.Bytes);
public long this[int i]=>Value[i];

public static A156393Inst Instance=new A156393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156394
{
public static readonly long[] Value={ 1L,0L,0L,42L,54L,0L,0L,7L,60L,0L,0L,144L,90L,0L,0L,24L,201L,0L,0L,336L,660L,0L,0L,60L,210L,0L,0L,930L,163L,0L,0L,150L,804L,0L,0L,1092L,1830L,0L,0L,168L,714L,0L,0L,2382L,492L,0L,0L,414L,984L,0L,0L,2340L,3432L,0L,0L,343L,768L,0L,0L,3690L,408L,0L,0L,643L,3039L,0L,0L,3216L,7986L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156394Inst : IEnumerable<long>
{
public static readonly long[] Value=A156394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156394.Bytes);
public long this[int i]=>Value[i];

public static A156394Inst Instance=new A156394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156395
{
public static readonly long[] Value={ 1L,764L,66178L,848932L,2278938L,2078160L,18458342L,81439488L,89959563L,57507580L,541808498L,1392368488L,991288522L,558858552L,4464765998L,11457761672L,9230231522L,3733057244L,17604991124L,58741831848L,53004021504L,18669753424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156395Inst : IEnumerable<long>
{
public static readonly long[] Value=A156395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156395.Bytes);
public long this[int i]=>Value[i];

public static A156395Inst Instance=new A156395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156396
{
public static readonly long[] Value={ 1L,76L,954L,3924L,7010L,9312L,32990L,78688L,83987L,74764L,239978L,459944L,417378L,337208L,881382L,1651208L,1559914L,1022492L,2133044L,4562152L,4561976L,2742240L,5100574L,10606296L,10001476L,5884232L,10075588L,19311868L,20173552L,13485160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156396Inst : IEnumerable<long>
{
public static readonly long[] Value=A156396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156396.Bytes);
public long this[int i]=>Value[i];

public static A156396Inst Instance=new A156396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156397
{
public static readonly long[] Value={ 1L,12L,90L,276L,426L,480L,870L,1344L,1483L,1836L,3402L,4968L,5154L,5112L,9414L,12552L,9522L,8508L,16116L,20712L,19896L,19200L,27630L,39192L,36876L,24936L,42252L,64764L,58704L,50376L,70422L,82656L,78655L,66192L,78600L,114540L,136182L,112320L,137472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156397Inst : IEnumerable<long>
{
public static readonly long[] Value=A156397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156397.Bytes);
public long this[int i]=>Value[i];

public static A156397Inst Instance=new A156397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156398
{
public static readonly long[] Value={ 1L,2620L,708256L,24243520L,154294582L,253938600L,1164072896L,10953612400L,25250999564L,22620401127L,101930271184L,570443632816L,781505368112L,474109634808L,1937140499056L,9267607094192L,12532444401442L,7484174351906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156398Inst : IEnumerable<long>
{
public static readonly long[] Value=A156398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156398.Bytes);
public long this[int i]=>Value[i];

public static A156398Inst Instance=new A156398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156399
{
public static readonly long[] Value={ 1L,76L,1728L,9712L,34814L,40416L,130456L,149480L,644220L,297215L,1380432L,3924896L,4260776L,4171320L,5913728L,6328576L,17481322L,7436362L,23029656L,61580624L,75335814L,56271108L,62202832L,54904272L,183254724L,62428100L,176105168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156399Inst : IEnumerable<long>
{
public static readonly long[] Value=A156399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156399.Bytes);
public long this[int i]=>Value[i];

public static A156399Inst Instance=new A156399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156400
{
public static readonly long[] Value={ 1L,0L,0L,0L,18L,0L,0L,0L,0L,11L,0L,0L,64L,0L,0L,0L,42L,18L,0L,0L,42L,0L,0L,0L,72L,36L,0L,0L,0L,0L,0L,0L,96L,15L,0L,0L,257L,0L,0L,0L,120L,72L,0L,0L,240L,0L,0L,0L,172L,288L,0L,0L,204L,0L,0L,0L,216L,122L,0L,0L,0L,0L,0L,0L,138L,36L,0L,0L,1050L,0L,0L,0L,192L,294L,0L,0L,1320L,0L,0L,0L,186L,387L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156400Inst : IEnumerable<long>
{
public static readonly long[] Value=A156400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156400.Bytes);
public long this[int i]=>Value[i];

public static A156400Inst Instance=new A156400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156401
{
public static readonly long[] Value={ 1L,12L,0L,0L,2334L,2400L,0L,0L,10236L,6871L,0L,0L,19368L,51672L,0L,0L,78762L,62322L,0L,0L,352350L,244572L,0L,0L,568284L,268092L,0L,0L,590400L,1134048L,0L,0L,960648L,688347L,0L,0L,3730237L,3085200L,0L,0L,5025540L,1936344L,0L,0L,3311664L,7083564L,0L,0L,5061300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156401Inst : IEnumerable<long>
{
public static readonly long[] Value=A156401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156401.Bytes);
public long this[int i]=>Value[i];

public static A156401Inst Instance=new A156401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156402
{
public static readonly long[] Value={ 1L,9496L,8372754L,805036704L,12767337844L,45965640312L,139921844820L,2077266004944L,10095521906313L,17074878770018L,39015704748255L,356237015034240L,976681206480324L,1011861877473980L,1809280459234368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156402Inst : IEnumerable<long>
{
public static readonly long[] Value=A156402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156402.Bytes);
public long this[int i]=>Value[i];

public static A156402Inst Instance=new A156402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156403
{
public static readonly long[] Value={ 1L,312L,13290L,156128L,709332L,1578064L,4220548L,17605696L,42440517L,56568904L,102471151L,332810880L,624439948L,662224128L,977782336L,2727888448L,4701559354L,4686068520L,5468265896L,13526490400L,23873894500L,23882769984L,23258023832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156403Inst : IEnumerable<long>
{
public static readonly long[] Value=A156403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156403.Bytes);
public long this[int i]=>Value[i];

public static A156403Inst Instance=new A156403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156404
{
public static readonly long[] Value={ 1L,0L,810L,0L,23280L,0L,68180L,0L,175765L,0L,760131L,0L,2108280L,0L,3657680L,0L,5281910L,0L,13033260L,0L,29182380L,0L,37198440L,0L,46154300L,0L,85583500L,0L,202480300L,0L,193358000L,0L,232585695L,0L,373884780L,0L,747469740L,0L,798622160L,0L,860249751L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156404Inst : IEnumerable<long>
{
public static readonly long[] Value=A156404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156404.Bytes);
public long this[int i]=>Value[i];

public static A156404Inst Instance=new A156404Inst();

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