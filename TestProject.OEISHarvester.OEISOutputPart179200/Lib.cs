using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A209657
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3452L,9158L,28178L,76539L,240369L,665127L,2123408L,5964627L,19301713L,54897139L,179687084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209657Inst : IEnumerable<long>
{
public static readonly long[] Value=A209657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209657.Bytes);
public long this[int i]=>Value[i];

public static A209657Inst Instance=new A209657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209658
{
public static readonly long[] Value={ 1L,2L,3L,7L,15L,22L,42L,101L,297L,1002L,1255L,2436L,3718L,4565L,5604L,10143L,12310L,14883L,21637L,31185L,37338L,44583L,53174L,63261L,105558L,173525L,204226L,239943L,329931L,715220L,1121505L,1300156L,1505499L,1741630L,2323520L,2679689L,3554345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209658Inst : IEnumerable<long>
{
public static readonly long[] Value=A209658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209658.Bytes);
public long this[int i]=>Value[i];

public static A209658Inst Instance=new A209658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209659
{
public static readonly long[] Value={ 1L,5L,11L,30L,56L,77L,135L,176L,231L,385L,490L,627L,792L,1575L,1958L,3010L,6842L,8349L,17977L,26015L,75175L,89134L,124754L,147273L,281589L,386155L,451276L,526823L,614154L,831820L,966467L,2012558L,3087735L,5392783L,8118264L,9289091L,13848650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209659Inst : IEnumerable<long>
{
public static readonly long[] Value=A209659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209659.Bytes);
public long this[int i]=>Value[i];

public static A209659Inst Instance=new A209659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209660
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3452L,9158L,28178L,76539L,240370L,665128L,2123437L,5964658L,19302248L,54897742L,179695133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209660Inst : IEnumerable<long>
{
public static readonly long[] Value=A209660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209660.Bytes);
public long this[int i]=>Value[i];

public static A209660Inst Instance=new A209660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209661
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209661Inst : IEnumerable<long>
{
public static readonly long[] Value=A209661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209661.Bytes);
public long this[int i]=>Value[i];

public static A209661Inst Instance=new A209661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209662
{
public static readonly long[] Value={ 1L,2L,3L,4L,-5L,6L,7L,8L,9L,-10L,11L,12L,-13L,14L,-15L,16L,-17L,18L,19L,-20L,21L,22L,23L,24L,25L,-26L,27L,28L,-29L,-30L,31L,32L,33L,-34L,-35L,36L,-37L,38L,-39L,-40L,-41L,42L,43L,44L,-45L,46L,47L,48L,49L,50L,-51L,-52L,-53L,54L,-55L,56L,57L,-58L,59L,-60L,-61L,62L,63L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209662Inst : IEnumerable<long>
{
public static readonly long[] Value=A209662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209662.Bytes);
public long this[int i]=>Value[i];

public static A209662Inst Instance=new A209662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209663
{
public static readonly long[] Value={ 5L,13L,19L,23L,29L,43L,53L,79L,109L,113L,139L,149L,163L,173L,179L,223L,233L,239L,263L,313L,349L,379L,439L,443L,449L,491L,503L,523L,569L,613L,643L,659L,673L,691L,709L,733L,739L,743L,769L,809L,839L,859L,863L,919L,929L,953L,1013L,1033L,1069L,1091L,1153L,1163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209663Inst : IEnumerable<long>
{
public static readonly long[] Value=A209663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209663.Bytes);
public long this[int i]=>Value[i];

public static A209663Inst Instance=new A209663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209664
{
public static readonly long[] Value={ 1L,2L,6L,3L,14L,39L,5L,34L,129L,356L,7L,74L,399L,1444L,4055L,11L,166L,1245L,5876L,20455L,57786L,15L,350L,3783L,23604L,102455L,347010L,983535L,22L,746L,11514L,94852L,513230L,2083902L,6887986L,19520264L,30L,1546L,34734L,379908L,2567230L,12505470L,48219486L,156167944L,441967518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209664Inst : IEnumerable<long>
{
public static readonly long[] Value=A209664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209664.Bytes);
public long this[int i]=>Value[i];

public static A209664Inst Instance=new A209664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209665
{
public static readonly BigInteger[] Value={ 1L,1L,8L,56L,524L,5979L,85539L,1460752L,29112516L,661843866L,16890042828L,477756925128L,14830113520286L,501073056287725L,18303233207719437L,718663995114727640L,BigInteger.Parse("30181996254384621880"),BigInteger.Parse("1349979517537576728657"),BigInteger.Parse("64065538251202398110415"),BigInteger.Parse("3215056386968174418054634") };
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
public class A209665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209665Inst Instance=new A209665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209666
{
public static readonly long[] Value={ 1L,2L,7L,3L,18L,55L,5L,50L,216L,631L,7L,118L,729L,2780L,8001L,11L,301L,2621L,12954L,45865L,130453L,15L,684L,8535L,55196L,241870L,820554L,2323483L,22L,1621L,28689L,241634L,1307055L,5280204L,17353028L,48916087L,30L,3620L,91749L,1012196L,6783210L,32711022L,124991685L,401709720L,1129559068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209666Inst : IEnumerable<long>
{
public static readonly long[] Value=A209666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209666.Bytes);
public long this[int i]=>Value[i];

public static A209666Inst Instance=new A209666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209667
{
public static readonly BigInteger[] Value={ 1L,1L,9L,76L,902L,11635L,192205L,3450337L,73128340L,1696862300L,44414258862L,1264163699189L,39640715859359L,1340191402045395L,49097854149726795L,1924982506686743639L,BigInteger.Parse("80831323253459088871"),BigInteger.Parse("3607487926962810556542"),BigInteger.Parse("170964537623741430399076") };
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
public class A209667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209667Inst Instance=new A209667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209668
{
public static readonly BigInteger[] Value={ 1L,1L,7L,55L,631L,8001L,130453L,2323483L,48916087L,1129559068L,29442232007L,835245785452L,26113646252773L,880685234758941L,32191922753658129L,1259701078978200555L,BigInteger.Parse("52802268925363689079"),BigInteger.Parse("2352843030410455053891"),BigInteger.Parse("111343906794849929711260"),BigInteger.Parse("5567596199767400904172045") };
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
public class A209668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209668Inst Instance=new A209668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209669
{
public static readonly long[] Value={ 1L,1L,5L,1L,10L,37L,1L,21L,120L,405L,1L,42L,363L,1644L,5251L,1L,85L,1117L,6814L,27405L,84893L,1L,170L,3360L,27404L,138085L,514248L,1556535L,1L,341L,10164L,111045L,701960L,3145848L,11133493L,33175957L,1L,682L,30520L,445132L,3521405L,18956548L,78337448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209669Inst : IEnumerable<long>
{
public static readonly long[] Value=A209669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209669.Bytes);
public long this[int i]=>Value[i];

public static A209669Inst Instance=new A209669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209670
{
public static readonly BigInteger[] Value={ 1L,6L,48L,547L,7301L,120315L,2239803L,48278809L,1153934735L,30834749017L,900390736548L,28782727026031L,993911439932097L,37039780178206877L,1477457354215115765L,BigInteger.Parse("62950691931099382408"),BigInteger.Parse("2849385291187650049208"),BigInteger.Parse("136701569959985165325989"),BigInteger.Parse("6924379544998951633495956") };
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
public class A209670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209670Inst Instance=new A209670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209671
{
public static readonly BigInteger[] Value={ 1L,5L,37L,405L,5251L,84893L,1556535L,33175957L,785671039L,20841132255L,604829604655L,19236214748061L,661348833658423L,24554370466786319L,976242978063976162L,BigInteger.Parse("41477168810872793493"),BigInteger.Parse("1872694395510428040983"),BigInteger.Parse("89644070894632864643651"),BigInteger.Parse("4531712537608857605836563") };
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
public class A209671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209671Inst Instance=new A209671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209672
{
public static readonly BigInteger[] Value={ 1L,5L,26L,165L,1093L,8203L,64516L,550766L,4911215L,46480657L,457372449L,4714813700L,50312993309L,557792410015L,6377533006104L,75321602836350L,914532538185703L,11422271100356431L,146273502952981364L,1920759273853147991L,BigInteger.Parse("25802956138975439144"),BigInteger.Parse("354546559878617075950") };
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
public class A209672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209672Inst Instance=new A209672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209673
{
public static readonly BigInteger[] Value={ 1L,1L,4L,19L,116L,751L,5552L,43219L,366088L,3245311L,30569012L,299662672L,3079276708L,32773002718L,362512238272L,4136737592323L,48773665308176L,591313968267151L,7375591544495636L,94340754464144215L,1237506718985945656L,16608519982801477908UL,BigInteger.Parse("228013066931927465872") };
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
public class A209673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209673Inst Instance=new A209673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209674
{
public static readonly long[] Value={ -1L,4L,9L,9L,5L,0L,4L,3L,10L,11L,5L,3L,2L,6L,1L,5L,8L,7L,9L,6L,10L,7L,8L,1L,7L,4L,3L,10L,6L,4L,10L,2L,1L,8L,5L,8L,7L,6L,4L,3L,6L,1L,4L,7L,4L,3L,6L,4L,3L,7L,1L,9L,11L,5L,8L,6L,4L,3L,7L,2L,5L,8L,7L,4L,6L,4L,3L,7L,2L,6L,4L,10L,5L,6L,4L,3L,7L,2L,6L,9L,11L,7L,6L,4L,3L,7L,2L,6L,9L,8L,12L,6L,4L,3L,7L,2L,6L,9L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209674Inst : IEnumerable<long>
{
public static readonly long[] Value=A209674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209674.Bytes);
public long this[int i]=>Value[i];

public static A209674Inst Instance=new A209674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209675
{
public static readonly long[] Value={ 2L,4L,2L,8L,2L,4L,2L,9L,2L,4L,2L,8L,2L,4L,2L,10L,2L,4L,2L,8L,2L,4L,2L,9L,2L,4L,2L,8L,2L,4L,2L,12L,2L,4L,2L,8L,2L,4L,2L,9L,2L,4L,2L,8L,2L,4L,2L,10L,2L,4L,2L,8L,2L,4L,2L,9L,2L,4L,2L,8L,2L,4L,2L,16L,2L,4L,2L,8L,2L,4L,2L,9L,2L,4L,2L,8L,2L,4L,2L,10L,2L,4L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209675Inst : IEnumerable<long>
{
public static readonly long[] Value=A209675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209675.Bytes);
public long this[int i]=>Value[i];

public static A209675Inst Instance=new A209675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209676
{
public static readonly long[] Value={ 1L,12L,54L,88L,-99L,-540L,-418L,648L,594L,-836L,1056L,4104L,-209L,-4104L,-594L,-4256L,-6480L,4752L,-298L,-5016L,17226L,12100L,-5346L,1296L,-9063L,7128L,19494L,-29160L,-10032L,7668L,-34738L,-8712L,-22572L,-21812L,49248L,46872L,67562L,-2508L,-47520L,76912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209676Inst : IEnumerable<long>
{
public static readonly long[] Value=A209676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209676.Bytes);
public long this[int i]=>Value[i];

public static A209676Inst Instance=new A209676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209677
{
public static readonly BigInteger[] Value={ 1L,14L,1243L,6716352L,268997909000L,1568091719977974635L,BigInteger.Parse("70570762532647014868797563"),BigInteger.Parse("841333288100321854075145135825724005"),BigInteger.Parse("79538689762318826508394939059605661254128283987") };
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
public class A209677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209677Inst Instance=new A209677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209678
{
public static readonly BigInteger[] Value={ 1L,14L,608L,246038L,166075313L,1008907523438L,10215188674804688L,BigInteger.Parse("930859067991577148438"),BigInteger.Parse("141374220951220779418945313"),BigInteger.Parse("193240888262699902868270874023438") };
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
public class A209678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209678Inst Instance=new A209678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209679
{
public static readonly BigInteger[] Value={ 1L,15L,1243L,2143147L,6713848491L,336865786047147L,BigInteger.Parse("29579506766774446763"),BigInteger.Parse("41557077253870074781674155"),BigInteger.Parse("102173227506131465827954312522411"),BigInteger.Parse("4019288788864555869108044364449353214635") };
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
public class A209679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209679Inst Instance=new A209679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209680
{
public static readonly BigInteger[] Value={ 1L,15L,1508L,6716352L,66825091608L,16894558898454012L,BigInteger.Parse("7697358649459140517788"),BigInteger.Parse("87677668153076602430717324907"),BigInteger.Parse("1797666180378975423054345009058355238"),BigInteger.Parse("921444360078430965633564486047727718449222837") };
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
public class A209680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209680Inst Instance=new A209680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209681
{
public static readonly BigInteger[] Value={ 1L,15L,1549L,11315839L,268997909000L,250057183645608263L,BigInteger.Parse("431066310742284246294717"),BigInteger.Parse("26767947592293738225917871688575"),BigInteger.Parse("3047486118401281699024754722202652309976") };
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
public class A209681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209681Inst Instance=new A209681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209682
{
public static readonly BigInteger[] Value={ 1L,15L,1551L,13575355L,584728215424L,1568091719977974635L,BigInteger.Parse("8230385298024619110939311"),BigInteger.Parse("2126394147054521999411737472214659"),BigInteger.Parse("1020701618427502395624813185662022237910866") };
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
public class A209682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209682Inst Instance=new A209682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209683
{
public static readonly BigInteger[] Value={ 1L,15L,1551L,14164693L,847881355388L,5219870359015849505L,BigInteger.Parse("70570762532647014868797563"),BigInteger.Parse("62256944108221643391817947390337742"),BigInteger.Parse("103256072887229091159525820942838733556042886") };
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
public class A209683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209683Inst Instance=new A209683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209684
{
public static readonly long[] Value={ 1L,1L,8L,1L,14L,96L,1L,15L,608L,4608L,1L,15L,1243L,246038L,331776L,1L,15L,1508L,2143147L,166075313L,95551488L,1L,15L,1549L,6716352L,6713848491L,1008907523438L,41278242816L,1L,15L,1551L,11315839L,66825091608L,336865786047147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209684Inst : IEnumerable<long>
{
public static readonly long[] Value=A209684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209684.Bytes);
public long this[int i]=>Value[i];

public static A209684Inst Instance=new A209684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209685
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209685Inst : IEnumerable<long>
{
public static readonly long[] Value=A209685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209685.Bytes);
public long this[int i]=>Value[i];

public static A209685Inst Instance=new A209685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209686
{
public static readonly long[] Value={ -1L,6L,8L,14L,7L,6L,13L,16L,6L,7L,5L,0L,3L,8L,6L,13L,16L,6L,7L,7L,15L,11L,7L,6L,13L,16L,6L,7L,9L,1L,9L,15L,6L,13L,16L,6L,7L,12L,1L,10L,4L,6L,13L,16L,6L,7L,9L,1L,2L,4L,6L,13L,16L,6L,7L,5L,1L,20L,13L,-1L,13L,16L,6L,7L,4L,1L,12L,2L,5L,3L,16L,6L,7L,10L,1L,3L,11L,15L,6L,13L,6L,7L,19L,1L,14L,6L,2L,7L,5L,9L,7L,9L,1L,12L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209686Inst : IEnumerable<long>
{
public static readonly long[] Value=A209686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209686.Bytes);
public long this[int i]=>Value[i];

public static A209686Inst Instance=new A209686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209687
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,5L,0L,1L,5L,12L,0L,1L,6L,18L,29L,0L,1L,7L,26L,58L,70L,0L,1L,8L,35L,98L,175L,169L,0L,1L,9L,45L,149L,339L,507L,408L,0L,1L,10L,56L,212L,574L,1108L,1428L,985L,0L,1L,11L,68L,288L,894L,2066L,3476L,3940L,2378L,0L,1L,12L,81L,378L,1314L,3492L,7074L,10572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209687Inst : IEnumerable<long>
{
public static readonly long[] Value=A209687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209687.Bytes);
public long this[int i]=>Value[i];

public static A209687Inst Instance=new A209687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209688
{
public static readonly long[] Value={ 1L,3L,4L,2L,5L,5L,2L,6L,9L,7L,2L,7L,14L,16L,9L,2L,8L,20L,30L,25L,11L,2L,9L,27L,50L,55L,36L,13L,2L,10L,35L,77L,105L,91L,49L,15L,2L,11L,44L,112L,182L,196L,140L,64L,17L,2L,12L,54L,156L,294L,378L,336L,204L,81L,19L,2L,13L,65L,210L,450L,672L,714L,540L,285L,100L,21L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209688Inst : IEnumerable<long>
{
public static readonly long[] Value=A209688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209688.Bytes);
public long this[int i]=>Value[i];

public static A209688Inst Instance=new A209688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209689
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,3L,0L,1L,6L,4L,0L,1L,4L,13L,5L,0L,1L,3L,13L,24L,6L,0L,1L,3L,9L,35L,40L,7L,0L,1L,3L,8L,28L,81L,62L,8L,0L,1L,3L,8L,22L,82L,167L,91L,9L,0L,1L,3L,8L,21L,64L,217L,315L,128L,10L,0L,1L,3L,8L,21L,56L,188L,519L,554L,174L,11L,0L,1L,3L,8L,21L,55L,155L,529L,1136L,921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209689Inst : IEnumerable<long>
{
public static readonly long[] Value=A209689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209689.Bytes);
public long this[int i]=>Value[i];

public static A209689Inst Instance=new A209689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209690
{
public static readonly long[] Value={ 1L,2L,1L,1L,4L,1L,1L,3L,7L,1L,1L,2L,9L,11L,1L,1L,2L,6L,22L,16L,1L,1L,2L,5L,19L,46L,22L,1L,1L,2L,5L,14L,54L,86L,29L,1L,1L,2L,5L,13L,42L,135L,148L,37L,1L,1L,2L,5L,13L,35L,124L,302L,239L,46L,1L,1L,2L,5L,13L,34L,99L,341L,617L,367L,56L,1L,1L,2L,5L,13L,34L,90L,287L,860L,1171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209690Inst : IEnumerable<long>
{
public static readonly long[] Value=A209690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209690.Bytes);
public long this[int i]=>Value[i];

public static A209690Inst Instance=new A209690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209691
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,4L,0L,1L,8L,8L,0L,1L,5L,24L,16L,0L,1L,4L,21L,64L,32L,0L,1L,4L,15L,77L,160L,64L,0L,1L,4L,14L,58L,253L,384L,128L,0L,1L,4L,14L,49L,221L,765L,896L,256L,0L,1L,4L,14L,48L,177L,800L,2173L,2048L,512L,0L,1L,4L,14L,48L,165L,654L,2723L,5885L,4608L,1024L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209691Inst : IEnumerable<long>
{
public static readonly long[] Value=A209691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209691.Bytes);
public long this[int i]=>Value[i];

public static A209691Inst Instance=new A209691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209692
{
public static readonly long[] Value={ 1L,2L,2L,1L,6L,4L,1L,4L,16L,8L,1L,3L,16L,40L,16L,1L,3L,11L,56L,96L,32L,1L,3L,10L,43L,176L,224L,64L,1L,3L,10L,35L,163L,512L,512L,128L,1L,3L,10L,34L,128L,579L,1408L,1152L,256L,1L,3L,10L,34L,117L,477L,1923L,3712L,2560L,512L,1L,3L,10L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209692Inst : IEnumerable<long>
{
public static readonly long[] Value=A209692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209692.Bytes);
public long this[int i]=>Value[i];

public static A209692Inst Instance=new A209692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209693
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,3L,0L,4L,9L,4L,0L,5L,17L,19L,5L,0L,6L,27L,49L,34L,6L,0L,7L,39L,98L,115L,55L,7L,0L,8L,53L,170L,284L,236L,83L,8L,0L,9L,69L,269L,585L,706L,440L,119L,9L,0L,10L,87L,399L,1070L,1706L,1568L,763L,164L,10L,0L,11L,107L,564L,1799L,3577L,4395L,3193L,1250L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209693Inst : IEnumerable<long>
{
public static readonly long[] Value=A209693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209693.Bytes);
public long this[int i]=>Value[i];

public static A209693Inst Instance=new A209693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209694
{
public static readonly long[] Value={ 1L,3L,1L,4L,6L,1L,5L,13L,10L,1L,6L,22L,32L,15L,1L,7L,33L,71L,66L,21L,1L,8L,46L,131L,186L,121L,28L,1L,9L,61L,216L,415L,422L,204L,36L,1L,10L,78L,330L,801L,1121L,862L,323L,45L,1L,11L,97L,477L,1400L,2507L,2689L,1625L,487L,55L,1L,12L,118L,661L,2276L,4977L,6902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209694Inst : IEnumerable<long>
{
public static readonly long[] Value=A209694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209694.Bytes);
public long this[int i]=>Value[i];

public static A209694Inst Instance=new A209694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209695
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,5L,1L,8L,18L,12L,1L,11L,40L,58L,29L,1L,14L,71L,164L,175L,70L,1L,17L,111L,357L,601L,507L,169L,1L,20L,160L,664L,1550L,2048L,1428L,408L,1L,23L,218L,1112L,3346L,6106L,6632L,3940L,985L,1L,26L,285L,1728L,6394L,15012L,22442L,20680L,10701L,2378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209695Inst : IEnumerable<long>
{
public static readonly long[] Value=A209695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209695.Bytes);
public long this[int i]=>Value[i];

public static A209695Inst Instance=new A209695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209696
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,7L,1L,9L,23L,17L,1L,12L,48L,76L,41L,1L,15L,82L,204L,233L,99L,1L,18L,125L,428L,765L,682L,239L,1L,21L,177L,775L,1907L,2649L,1935L,577L,1L,24L,238L,1272L,4010L,7656L,8680L,5368L,1393L,1L,27L,308L,1946L,7506L,18358L,28548L,27312L,14641L,3363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209696Inst : IEnumerable<long>
{
public static readonly long[] Value=A209696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209696.Bytes);
public long this[int i]=>Value[i];

public static A209696Inst Instance=new A209696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209697
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,4L,0L,3L,6L,8L,0L,4L,10L,16L,16L,0L,5L,15L,30L,40L,32L,0L,6L,21L,50L,84L,96L,64L,0L,7L,28L,77L,154L,224L,224L,128L,0L,8L,36L,112L,258L,448L,576L,512L,256L,0L,9L,45L,156L,405L,810L,1248L,1440L,1152L,512L,0L,10L,55L,210L,605L,1362L,2420L,3360L,3520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209697Inst : IEnumerable<long>
{
public static readonly long[] Value=A209697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209697.Bytes);
public long this[int i]=>Value[i];

public static A209697Inst Instance=new A209697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209698
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,4L,7L,10L,8L,5L,11L,20L,24L,16L,6L,16L,35L,54L,56L,32L,7L,22L,56L,104L,140L,128L,64L,8L,29L,84L,181L,294L,352L,288L,128L,9L,37L,120L,293L,552L,800L,864L,640L,256L,10L,46L,165L,449L,957L,1610L,2112L,2080L,1408L,512L,11L,56L,220L,659L,1562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209698Inst : IEnumerable<long>
{
public static readonly long[] Value=A209698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209698.Bytes);
public long this[int i]=>Value[i];

public static A209698Inst Instance=new A209698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209699
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,4L,0L,3L,4L,8L,0L,4L,5L,12L,16L,0L,5L,6L,19L,28L,32L,0L,6L,7L,28L,45L,68L,64L,0L,7L,8L,39L,66L,123L,156L,128L,0L,8L,9L,52L,91L,200L,301L,356L,256L,0L,9L,10L,67L,120L,303L,510L,747L,796L,512L,0L,10L,11L,84L,153L,436L,795L,1356L,1789L,1764L,1024L,0L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209699Inst : IEnumerable<long>
{
public static readonly long[] Value=A209699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209699.Bytes);
public long this[int i]=>Value[i];

public static A209699Inst Instance=new A209699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209700
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,4L,2L,8L,8L,5L,2L,14L,16L,16L,6L,2L,22L,26L,40L,32L,7L,2L,32L,38L,78L,88L,64L,8L,2L,44L,52L,134L,178L,200L,128L,9L,2L,58L,68L,212L,310L,446L,440L,256L,10L,2L,74L,86L,316L,492L,846L,1042L,968L,512L,11L,2L,92L,106L,450L,732L,1452L,2062L,2462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209700Inst : IEnumerable<long>
{
public static readonly long[] Value=A209700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209700.Bytes);
public long this[int i]=>Value[i];

public static A209700Inst Instance=new A209700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209701
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,5L,0L,3L,7L,12L,0L,4L,11L,23L,29L,0L,5L,16L,41L,70L,70L,0L,6L,22L,66L,140L,204L,169L,0L,7L,29L,99L,247L,455L,577L,408L,0L,8L,37L,141L,401L,875L,1423L,1597L,985L,0L,9L,46L,193L,613L,1529L,2965L,4321L,4348L,2378L,0L,10L,56L,256L,895L,2495L,5549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209701Inst : IEnumerable<long>
{
public static readonly long[] Value=A209701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209701.Bytes);
public long this[int i]=>Value[i];

public static A209701Inst Instance=new A209701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209702
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,7L,4L,8L,16L,17L,5L,12L,30L,47L,41L,6L,17L,50L,99L,134L,99L,7L,23L,77L,181L,315L,373L,239L,8L,30L,112L,302L,628L,968L,1020L,577L,9L,38L,156L,472L,1128L,2090L,2898L,2751L,1393L,10L,47L,210L,702L,1882L,4020L,6738L,8495L,7338L,3363L,11L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209702Inst : IEnumerable<long>
{
public static readonly long[] Value=A209702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209702.Bytes);
public long this[int i]=>Value[i];

public static A209702Inst Instance=new A209702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209703
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,3L,0L,4L,6L,5L,0L,5L,10L,14L,8L,0L,6L,15L,28L,28L,13L,0L,7L,21L,48L,66L,55L,21L,0L,8L,28L,75L,129L,149L,104L,34L,0L,9L,36L,110L,225L,326L,319L,193L,55L,0L,10L,45L,154L,363L,626L,774L,661L,352L,89L,0L,11L,55L,208L,553L,1099L,1625L,1761L,1332L,634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209703Inst : IEnumerable<long>
{
public static readonly long[] Value=A209703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209703.Bytes);
public long this[int i]=>Value[i];

public static A209703Inst Instance=new A209703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209704
{
public static readonly long[] Value={ 1L,3L,1L,4L,3L,2L,5L,6L,8L,3L,6L,10L,18L,14L,5L,7L,15L,33L,38L,27L,8L,8L,21L,54L,81L,83L,49L,13L,9L,28L,82L,150L,197L,170L,89L,21L,10L,36L,118L,253L,401L,448L,342L,159L,34L,11L,45L,163L,399L,736L,999L,987L,671L,282L,55L,12L,55L,218L,598L,1253L,1988L,2387L,2106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209704Inst : IEnumerable<long>
{
public static readonly long[] Value=A209704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209704.Bytes);
public long this[int i]=>Value[i];

public static A209704Inst Instance=new A209704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209705
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,4L,0L,4L,10L,8L,0L,5L,18L,28L,16L,0L,6L,28L,64L,72L,32L,0L,7L,40L,120L,200L,176L,64L,0L,8L,54L,200L,440L,576L,416L,128L,0L,9L,70L,308L,840L,1456L,1568L,960L,256L,0L,10L,88L,448L,1456L,3136L,4480L,4096L,2176L,512L,0L,11L,108L,624L,2352L,6048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209705Inst : IEnumerable<long>
{
public static readonly long[] Value=A209705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209705.Bytes);
public long this[int i]=>Value[i];

public static A209705Inst Instance=new A209705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209706
{
public static readonly long[] Value={ 1L,3L,2L,4L,7L,4L,5L,14L,18L,8L,6L,23L,46L,44L,16L,7L,34L,92L,136L,104L,32L,8L,47L,160L,320L,376L,240L,64L,9L,62L,254L,640L,1016L,992L,544L,128L,10L,79L,378L,1148L,2296L,3024L,2528L,1216L,256L,11L,98L,536L,1904L,4592L,7616L,8576L,6272L,2688L,512L,12L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209706Inst : IEnumerable<long>
{
public static readonly long[] Value=A209706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209706.Bytes);
public long this[int i]=>Value[i];

public static A209706Inst Instance=new A209706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209707
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3452L,9158L,28178L,76539L,240370L,665129L,2123438L,5964689L,19302281L,54898345L,179695808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209707Inst : IEnumerable<long>
{
public static readonly long[] Value=A209707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209707.Bytes);
public long this[int i]=>Value[i];

public static A209707Inst Instance=new A209707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209708
{
public static readonly BigInteger[] Value={ 24L,2710L,1277340L,2744311427L,26024000948100L,1105092894348108870L,BigInteger.Parse("208427296314737259382008"),BigInteger.Parse("175434641568425738606430293927") };
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
public class A209708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209708.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209708Inst Instance=new A209708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209709
{
public static readonly long[] Value={ 24L,175L,1241L,8876L,63280L,451762L,3223192L,23003132L,164145204L,1171382040L,8359002576L,59650984184L,425673977552L,3037655024816L,21676983770448L,154689108964032L,1103876214994624L,7877368106279456L,56213657087788288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209709Inst : IEnumerable<long>
{
public static readonly long[] Value=A209709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209709.Bytes);
public long this[int i]=>Value[i];

public static A209709Inst Instance=new A209709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209710
{
public static readonly long[] Value={ 175L,2710L,40600L,614935L,9278940L,140274002L,2118517533L,32012611741L,483591817235L,7306527081148L,110382673709151L,1667687996584917L,25195038977801100L,380647562549584423L,5750778390043860484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209710Inst : IEnumerable<long>
{
public static readonly long[] Value=A209710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209710.Bytes);
public long this[int i]=>Value[i];

public static A209710Inst Instance=new A209710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209711
{
public static readonly BigInteger[] Value={ 1241L,40600L,1277340L,40731729L,1293734407L,41170011836L,1308905451923L,41634764453267L,1323986099952192L,42109275322473077L,1339166789310809335L,BigInteger.Parse("42590485464466221295"),BigInteger.Parse("1354499017164946512850"),BigInteger.Parse("43077595330733889824289") };
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
public class A209711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209711Inst Instance=new A209711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209712
{
public static readonly BigInteger[] Value={ 8876L,614935L,40731729L,2744311427L,183988612894L,12365282426546L,830023337140244L,55752055566749390L,3743494074063656049L,BigInteger.Parse("251407614309375778551"),BigInteger.Parse("16882345627898370229840"),BigInteger.Parse("1133739174494213238538448") };
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
public class A209712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209712Inst Instance=new A209712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209713
{
public static readonly BigInteger[] Value={ 63280L,9278940L,1293734407L,183988612894L,26024000948100L,3690894707522275L,522757733883587522L,BigInteger.Parse("74095286689410395475"),BigInteger.Parse("10497954243766841570370"),BigInteger.Parse("1487704397822521872822441"),BigInteger.Parse("210801722411081467285442780") };
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
public class A209713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209713Inst Instance=new A209713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209714
{
public static readonly BigInteger[] Value={ 451762L,140274002L,41170011836L,12365282426546L,3690894707522275L,1105092894348108870L,BigInteger.Parse("330369121707817687620"),BigInteger.Parse("98846625956052689351148"),BigInteger.Parse("29561564907274388361999040"),BigInteger.Parse("8843044595935413687485979415") };
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
public class A209714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209714Inst Instance=new A209714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209715
{
public static readonly BigInteger[] Value={ 3223192L,2118517533L,1308905451923L,830023337140244L,522757733883587522L,BigInteger.Parse("330369121707817687620"),BigInteger.Parse("208427296314737259382008"),BigInteger.Parse("131618147804621095447618893"),BigInteger.Parse("83072099151587827914461601665") };
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
public class A209715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209715.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209715Inst Instance=new A209715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209716
{
public static readonly long[] Value={ 24L,175L,175L,1241L,2710L,1241L,8876L,40600L,40600L,8876L,63280L,614935L,1277340L,614935L,63280L,451762L,9278940L,40731729L,40731729L,9278940L,451762L,3223192L,140274002L,1293734407L,2744311427L,1293734407L,140274002L,3223192L,23003132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209716Inst : IEnumerable<long>
{
public static readonly long[] Value=A209716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209716.Bytes);
public long this[int i]=>Value[i];

public static A209716Inst Instance=new A209716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209717
{
public static readonly long[] Value={ 1L,2L,5L,12L,33L,87L,227L,583L,1538L,4067L,10633L,27837L,72387L,188811L,493437L,1288622L,3355810L,8740288L,22783725L,59403150L,154824944L,403509362L,1051651919L,2740858097L,7144656505L,18623531350L,48542955448L,126526434447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209717Inst : IEnumerable<long>
{
public static readonly long[] Value=A209717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209717.Bytes);
public long this[int i]=>Value[i];

public static A209717Inst Instance=new A209717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209718
{
public static readonly long[] Value={ 2L,13L,115L,1468L,19993L,242036L,2830612L,33559479L,405001256L,4768478349L,55177233176L,632269120829L,7270703713269L,83723657505339L,959510778223080L,10972846708863116L,125671067783934260L,1441312273531923562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209718Inst : IEnumerable<long>
{
public static readonly long[] Value=A209718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209718.Bytes);
public long this[int i]=>Value[i];

public static A209718Inst Instance=new A209718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209719
{
public static readonly long[] Value={ 5L,115L,5822L,411940L,29021568L,1712295424L,100332786038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209719Inst : IEnumerable<long>
{
public static readonly long[] Value=A209719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209719.Bytes);
public long this[int i]=>Value[i];

public static A209719Inst Instance=new A209719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209720
{
public static readonly long[] Value={ 1L,2L,2L,5L,13L,5L,12L,115L,115L,12L,33L,1468L,5822L,1468L,33L,87L,19993L,411940L,411940L,19993L,87L,227L,242036L,29021568L,152691350L,29021568L,242036L,227L,583L,2830612L,1712295424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209720Inst : IEnumerable<long>
{
public static readonly long[] Value=A209720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209720.Bytes);
public long this[int i]=>Value[i];

public static A209720Inst Instance=new A209720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209721
{
public static readonly long[] Value={ 3L,4L,5L,7L,9L,13L,17L,25L,33L,49L,65L,97L,129L,193L,257L,385L,513L,769L,1025L,1537L,2049L,3073L,4097L,6145L,8193L,12289L,16385L,24577L,32769L,49153L,65537L,98305L,131073L,196609L,262145L,393217L,524289L,786433L,1048577L,1572865L,2097153L,3145729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209721Inst : IEnumerable<long>
{
public static readonly long[] Value=A209721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209721.Bytes);
public long this[int i]=>Value[i];

public static A209721Inst Instance=new A209721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209722
{
public static readonly long[] Value={ 4L,5L,6L,8L,10L,14L,18L,26L,34L,50L,66L,98L,130L,194L,258L,386L,514L,770L,1026L,1538L,2050L,3074L,4098L,6146L,8194L,12290L,16386L,24578L,32770L,49154L,65538L,98306L,131074L,196610L,262146L,393218L,524290L,786434L,1048578L,1572866L,2097154L,3145730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209722Inst : IEnumerable<long>
{
public static readonly long[] Value=A209722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209722.Bytes);
public long this[int i]=>Value[i];

public static A209722Inst Instance=new A209722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209723
{
public static readonly long[] Value={ 6L,7L,8L,10L,12L,16L,20L,28L,36L,52L,68L,100L,132L,196L,260L,388L,516L,772L,1028L,1540L,2052L,3076L,4100L,6148L,8196L,12292L,16388L,24580L,32772L,49156L,65540L,98308L,131076L,196612L,262148L,393220L,524292L,786436L,1048580L,1572868L,2097156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209723Inst : IEnumerable<long>
{
public static readonly long[] Value=A209723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209723.Bytes);
public long this[int i]=>Value[i];

public static A209723Inst Instance=new A209723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209724
{
public static readonly long[] Value={ 8L,9L,10L,12L,14L,18L,22L,30L,38L,54L,70L,102L,134L,198L,262L,390L,518L,774L,1030L,1542L,2054L,3078L,4102L,6150L,8198L,12294L,16390L,24582L,32774L,49158L,65542L,98310L,131078L,196614L,262150L,393222L,524294L,786438L,1048582L,1572870L,2097158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209724Inst : IEnumerable<long>
{
public static readonly long[] Value=A209724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209724.Bytes);
public long this[int i]=>Value[i];

public static A209724Inst Instance=new A209724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209725
{
public static readonly long[] Value={ 12L,13L,14L,16L,18L,22L,26L,34L,42L,58L,74L,106L,138L,202L,266L,394L,522L,778L,1034L,1546L,2058L,3082L,4106L,6154L,8202L,12298L,16394L,24586L,32778L,49162L,65546L,98314L,131082L,196618L,262154L,393226L,524298L,786442L,1048586L,1572874L,2097162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209725Inst : IEnumerable<long>
{
public static readonly long[] Value=A209725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209725.Bytes);
public long this[int i]=>Value[i];

public static A209725Inst Instance=new A209725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209726
{
public static readonly long[] Value={ 16L,17L,18L,20L,22L,26L,30L,38L,46L,62L,78L,110L,142L,206L,270L,398L,526L,782L,1038L,1550L,2062L,3086L,4110L,6158L,8206L,12302L,16398L,24590L,32782L,49166L,65550L,98318L,131086L,196622L,262158L,393230L,524302L,786446L,1048590L,1572878L,2097166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209726Inst : IEnumerable<long>
{
public static readonly long[] Value=A209726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209726.Bytes);
public long this[int i]=>Value[i];

public static A209726Inst Instance=new A209726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209727
{
public static readonly long[] Value={ 2L,3L,3L,4L,4L,4L,6L,5L,5L,6L,8L,7L,6L,7L,8L,12L,9L,8L,8L,9L,12L,16L,13L,10L,10L,10L,13L,16L,24L,17L,14L,12L,12L,14L,17L,24L,32L,25L,18L,16L,14L,16L,18L,25L,32L,48L,33L,26L,20L,18L,18L,20L,26L,33L,48L,64L,49L,34L,28L,22L,22L,22L,28L,34L,49L,64L,96L,65L,50L,36L,30L,26L,26L,30L,36L,50L,65L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209727Inst : IEnumerable<long>
{
public static readonly long[] Value=A209727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209727.Bytes);
public long this[int i]=>Value[i];

public static A209727Inst Instance=new A209727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209728
{
public static readonly BigInteger[] Value={ 22L,1096L,137888L,47572464L,45147495264L,121396901813560L,914481225452329872L,BigInteger.Parse("19676655455650623737848") };
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
public class A209728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209728Inst Instance=new A209728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209729
{
public static readonly long[] Value={ 22L,124L,696L,3912L,21976L,123480L,693752L,3897880L,21900088L,123045592L,691329528L,3884227224L,21823477432L,122614931544L,688910387576L,3870634114072L,21747107494456L,122185841630680L,686499566270712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209729Inst : IEnumerable<long>
{
public static readonly long[] Value=A209729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209729.Bytes);
public long this[int i]=>Value[i];

public static A209729Inst Instance=new A209729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209730
{
public static readonly long[] Value={ 124L,1096L,9712L,86744L,775096L,6933120L,62007896L,554698328L,4961776976L,44385441816L,397039390488L,3551673425792L,31770878566904L,284202098661272L,2542285677573168L,22741649976952728L,203432011675276088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209730Inst : IEnumerable<long>
{
public static readonly long[] Value=A209730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209730.Bytes);
public long this[int i]=>Value[i];

public static A209730Inst Instance=new A209730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209731
{
public static readonly ulong[] Value={ 696L,9712L,137888L,1995752L,28927984L,420545824L,6111765608L,88883321584L,1292321119496L,18793764804064L,273281958853584L,3974120752445352L,57789976679148952L,840380963807821656L,12220602110589974744UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209731Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A209731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209731.Bytes);
public ulong this[int i]=>Value[i];

public static A209731Inst Instance=new A209731Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209732
{
public static readonly BigInteger[] Value={ 3912L,86744L,1995752L,47572464L,1138541280L,27425792944L,660346502176L,15926642688032L,383927816903616L,9260294185296568L,223295813816665920L,5385580739872287984L,BigInteger.Parse("129876262463016021256"),BigInteger.Parse("3132320639165421379936") };
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
public class A209732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209732Inst Instance=new A209732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209733
{
public static readonly BigInteger[] Value={ 21976L,775096L,28927984L,1138541280L,45147495264L,1809791149768L,72515584004736L,2914488537817408L,117033599127615880L,4704742675739474176L,BigInteger.Parse("189030631236371886792"),BigInteger.Parse("7598451666243980931808"),BigInteger.Parse("305353336500744007552616") };
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
public class A209733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209733.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209733Inst Instance=new A209733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209734
{
public static readonly BigInteger[] Value={ 123480L,6933120L,420545824L,27425792944L,1809791149768L,121396901813560L,8142073013529816L,548770608436244800L,BigInteger.Parse("36942499122761432872"),BigInteger.Parse("2491439485029085248096"),BigInteger.Parse("167889440702169327824712") };
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
public class A209734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209734Inst Instance=new A209734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209735
{
public static readonly BigInteger[] Value={ 693752L,62007896L,6111765608L,660346502176L,72515584004736L,8142073013529816L,914481225452329872L,BigInteger.Parse("103429210168484832664"),BigInteger.Parse("11680327691835359996376"),BigInteger.Parse("1322584722099506691068936"),BigInteger.Parse("149590064327411189639443688") };
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
public class A209735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209735Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209735.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209735.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209735Inst Instance=new A209735Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209736
{
public static readonly long[] Value={ 22L,124L,124L,696L,1096L,696L,3912L,9712L,9712L,3912L,21976L,86744L,137888L,86744L,21976L,123480L,775096L,1995752L,1995752L,775096L,123480L,693752L,6933120L,28927984L,47572464L,28927984L,6933120L,693752L,3897880L,62007896L,420545824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209736Inst : IEnumerable<long>
{
public static readonly long[] Value=A209736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209736.Bytes);
public long this[int i]=>Value[i];

public static A209736Inst Instance=new A209736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209737
{
public static readonly BigInteger[] Value={ 1L,6L,2025L,20611956L,3309942226828L,6126537051572916244L,BigInteger.Parse("126664397726626418134051983") };
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
public class A209737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209737Inst Instance=new A209737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209738
{
public static readonly BigInteger[] Value={ 2L,6L,57L,700L,10594L,183240L,3412100L,65953664L,1298076552L,25767620512L,513555943312L,10254450363264L,204934235829536L,4097247120151424L,81931587030997056L,1638507658307430400L,BigInteger.Parse("32769000295781617792") };
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
public class A209738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209738.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209738Inst Instance=new A209738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209739
{
public static readonly BigInteger[] Value={ 5L,57L,2025L,103373L,6262064L,404495219L,26715084257L,1777603386801L,118573281463225L,7915782848604211L,528589085007311295L,BigInteger.Parse("35300530985616790273"),BigInteger.Parse("2357529150039721810029"),BigInteger.Parse("157447991892723989479547") };
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
public class A209739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209739Inst Instance=new A209739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209740
{
public static readonly BigInteger[] Value={ 15L,700L,103373L,20611956L,4474325828L,991613495404L,220845828478730L,49242046909442868L,10982471712866182098UL,BigInteger.Parse("2449579228342732267816"),BigInteger.Parse("546373088082223670747386"),BigInteger.Parse("121867698385924682716244064") };
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
public class A209740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209740Inst Instance=new A209740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209741
{
public static readonly BigInteger[] Value={ 52L,10594L,6262064L,4474325828L,3309942226828L,2462887498725440L,1834383283218723590L,BigInteger.Parse("1366486932112899379170"),BigInteger.Parse("1017964144833296194871291"),BigInteger.Parse("758335528163948847329102970"),BigInteger.Parse("564924804927465477617885477572") };
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
public class A209741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209741Inst Instance=new A209741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209742
{
public static readonly BigInteger[] Value={ 203L,183240L,404495219L,991613495404L,2462887498725440L,6126537051572916244L,BigInteger.Parse("15242797658314710633378"),BigInteger.Parse("37924827001459049241306782"),BigInteger.Parse("94359067187520965488130465180"),BigInteger.Parse("234770648430435211602772504683016") };
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
public class A209742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209742Inst Instance=new A209742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209743
{
public static readonly BigInteger[] Value={ 876L,3412100L,26715084257L,220845828478730L,1834383283218723590L,BigInteger.Parse("15242797658314710633378"),BigInteger.Parse("126664397726626418134051983"),BigInteger.Parse("1052557322792113887592378377140"),BigInteger.Parse("8746556030412972768884396379035027") };
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
public class A209743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A209743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A209743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A209743Inst Instance=new A209743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209744
{
public static readonly long[] Value={ 1L,2L,2L,5L,6L,5L,15L,57L,57L,15L,52L,700L,2025L,700L,52L,203L,10594L,103373L,103373L,10594L,203L,876L,183240L,6262064L,20611956L,6262064L,183240L,876L,4111L,3412100L,404495219L,4474325828L,4474325828L,404495219L,3412100L,4111L,20648L,65953664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209744Inst : IEnumerable<long>
{
public static readonly long[] Value=A209744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209744.Bytes);
public long this[int i]=>Value[i];

public static A209744Inst Instance=new A209744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209745
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,4L,3L,12L,16L,8L,5L,25L,49L,44L,16L,8L,50L,127L,166L,112L,32L,13L,96L,301L,513L,504L,272L,64L,21L,180L,670L,1408L,1808L,1424L,640L,128L,34L,331L,1427L,3562L,5641L,5816L,3824L,1472L,256L,55L,600L,2939L,8494L,15981L,20330L,17520L,9888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209745Inst : IEnumerable<long>
{
public static readonly long[] Value=A209745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209745.Bytes);
public long this[int i]=>Value[i];

public static A209745Inst Instance=new A209745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209746
{
public static readonly long[] Value={ 1L,2L,2L,3L,7L,4L,5L,17L,20L,8L,8L,37L,65L,52L,16L,13L,75L,176L,210L,128L,32L,21L,146L,428L,679L,616L,304L,64L,34L,276L,971L,1921L,2312L,1696L,704L,128L,55L,511L,2097L,4970L,7449L,7240L,4464L,1600L,256L,89L,931L,4366L,12056L,21622L,26146L,21344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209746Inst : IEnumerable<long>
{
public static readonly long[] Value=A209746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209746.Bytes);
public long this[int i]=>Value[i];

public static A209746Inst Instance=new A209746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209747
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,2L,5L,10L,6L,2L,9L,20L,18L,8L,2L,15L,40L,44L,28L,10L,2L,25L,76L,102L,80L,40L,12L,2L,41L,142L,222L,210L,130L,54L,14L,2L,67L,260L,466L,512L,380L,196L,70L,16L,2L,109L,470L,948L,1188L,1022L,630L,280L,88L,18L,2L,177L,840L,1884L,2648L,2590L,1848L,980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209747Inst : IEnumerable<long>
{
public static readonly long[] Value=A209747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209747.Bytes);
public long this[int i]=>Value[i];

public static A209747Inst Instance=new A209747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209748
{
public static readonly long[] Value={ 1L,3L,5L,2L,9L,6L,2L,15L,16L,8L,2L,25L,36L,26L,10L,2L,41L,76L,70L,38L,12L,2L,67L,152L,172L,118L,52L,14L,2L,109L,294L,394L,328L,182L,68L,16L,2L,177L,554L,860L,840L,562L,264L,86L,18L,2L,287L,1024L,1808L,2028L,1584L,894L,366L,106L,20L,2L,465L,1864L,3692L,4676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209748Inst : IEnumerable<long>
{
public static readonly long[] Value=A209748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209748.Bytes);
public long this[int i]=>Value[i];

public static A209748Inst Instance=new A209748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209749
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,2L,8L,9L,4L,3L,11L,21L,17L,5L,3L,17L,37L,47L,29L,6L,4L,21L,63L,101L,95L,46L,7L,4L,29L,93L,193L,241L,178L,69L,8L,5L,34L,138L,329L,519L,522L,314L,99L,9L,5L,44L,186L,533L,999L,1264L,1050L,527L,137L,10L,6L,50L,255L,805L,1776L,2710L,2845L,1991L,848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209749Inst : IEnumerable<long>
{
public static readonly long[] Value=A209749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209749.Bytes);
public long this[int i]=>Value[i];

public static A209749Inst Instance=new A209749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209750
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,1L,3L,6L,7L,1L,3L,11L,15L,11L,1L,4L,14L,32L,32L,16L,1L,4L,21L,51L,79L,61L,22L,1L,5L,25L,84L,152L,174L,107L,29L,1L,5L,34L,118L,277L,393L,352L,176L,37L,1L,6L,39L,172L,447L,796L,915L,666L,275L,46L,1L,6L,50L,225L,705L,1446L,2060L,1965L,1193L,412L,56L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209750Inst : IEnumerable<long>
{
public static readonly long[] Value=A209750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209750.Bytes);
public long this[int i]=>Value[i];

public static A209750Inst Instance=new A209750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209751
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,4L,2L,10L,15L,8L,3L,14L,35L,39L,16L,3L,22L,63L,108L,95L,32L,4L,27L,109L,235L,309L,223L,64L,4L,38L,160L,454L,782L,838L,511L,128L,5L,44L,242L,770L,1688L,2408L,2183L,1151L,256L,5L,58L,322L,1264L,3226L,5776L,7009L,5512L,2559L,512L,6L,65L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209751Inst : IEnumerable<long>
{
public static readonly long[] Value=A209751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209751.Bytes);
public long this[int i]=>Value[i];

public static A209751Inst Instance=new A209751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209752
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,4L,3L,9L,16L,8L,3L,16L,33L,40L,16L,4L,20L,67L,105L,96L,32L,4L,30L,103L,242L,305L,224L,64L,5L,35L,169L,441L,793L,833L,512L,128L,5L,48L,230L,792L,1664L,2424L,2177L,1152L,256L,6L,54L,338L,1230L,3272L,5736L,7031L,5505L,2560L,512L,6L,70L,430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209752Inst : IEnumerable<long>
{
public static readonly long[] Value=A209752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209752.Bytes);
public long this[int i]=>Value[i];

public static A209752Inst Instance=new A209752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209753
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,3L,5L,14L,12L,4L,9L,30L,40L,23L,5L,15L,63L,107L,93L,39L,6L,25L,124L,264L,300L,190L,61L,7L,41L,238L,604L,858L,722L,354L,90L,8L,67L,445L,1319L,2242L,2364L,1559L,615L,127L,9L,109L,818L,2772L,5500L,6966L,5783L,3101L,1011L,173L,10L,177L,1482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209753Inst : IEnumerable<long>
{
public static readonly long[] Value=A209753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209753.Bytes);
public long this[int i]=>Value[i];

public static A209753Inst Instance=new A209753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209754
{
public static readonly long[] Value={ 1L,3L,1L,5L,6L,1L,9L,16L,10L,1L,15L,39L,38L,15L,1L,25L,84L,117L,76L,21L,1L,41L,172L,308L,286L,136L,28L,1L,67L,337L,744L,894L,612L,225L,36L,1L,109L,642L,1685L,2496L,2228L,1191L,351L,45L,1L,177L,1196L,3646L,6423L,7088L,4978L,2157L,523L,55L,1L,287L,2191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209754Inst : IEnumerable<long>
{
public static readonly long[] Value=A209754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209754.Bytes);
public long this[int i]=>Value[i];

public static A209754Inst Instance=new A209754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209755
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,3L,7L,8L,5L,4L,11L,17L,17L,8L,5L,16L,31L,41L,33L,13L,6L,22L,51L,83L,91L,63L,21L,7L,29L,78L,150L,205L,195L,117L,34L,8L,37L,113L,250L,406L,483L,403L,214L,55L,9L,46L,157L,392L,734L,1039L,1091L,812L,386L,89L,10L,56L,211L,586L,1239L,2023L,2536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209755Inst : IEnumerable<long>
{
public static readonly long[] Value=A209755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209755.Bytes);
public long this[int i]=>Value[i];

public static A209755Inst Instance=new A209755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A209756
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,4L,4L,6L,3L,5L,7L,13L,11L,5L,6L,11L,24L,28L,22L,8L,7L,16L,40L,59L,63L,41L,13L,8L,22L,62L,110L,146L,132L,76L,21L,9L,29L,91L,188L,296L,337L,271L,138L,34L,10L,37L,128L,301L,546L,743L,754L,541L,248L,55L,11L,46L,174L,458L,938L,1477L,1793L,1632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A209756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A209756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A209756Inst : IEnumerable<long>
{
public static readonly long[] Value=A209756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A209756.Bytes);
public long this[int i]=>Value[i];

public static A209756Inst Instance=new A209756Inst();

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