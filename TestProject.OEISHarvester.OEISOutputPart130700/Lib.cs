using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A160005
{
public static readonly BigInteger[] Value={ 1L,6L,-1214L,-22284L,4418796L,137932776L,-26789878344L,-1195235090064L,227240024969616L,13315791050457696L,-2476555534605433824L,BigInteger.Parse("-181306721338353802944"),BigInteger.Parse("32964798272794592262336"),BigInteger.Parse("2917389609712074597734016"),BigInteger.Parse("-518173634274639676676555904"),BigInteger.Parse("-54163359975609143520404615424") };
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
public class A160005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160005Inst Instance=new A160005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160006
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,2L,3L,1L,2L,4L,3L,1L,2L,4L,3L,1L,4L,2L,3L,5L,1L,2L,6L,3L,5L,4L,1L,2L,5L,3L,4L,7L,6L,1L,2L,5L,3L,7L,4L,6L,1L,2L,8L,3L,6L,4L,1L,5L,2L,7L,3L,6L,4L,9L,8L,5L,1L,2L,3L,6L,9L,4L,7L,5L,1L,2L,9L,3L,8L,4L,7L,5L,9L,1L,2L,6L,8L,3L,4L,11L,10L,7L,5L,1L,2L,6L,3L,10L,4L,7L,9L,5L,12L,8L,1L,6L,2L,10L,3L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160006Inst : IEnumerable<long>
{
public static readonly long[] Value=A160006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160006.Bytes);
public long this[int i]=>Value[i];

public static A160006Inst Instance=new A160006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160007
{
public static readonly long[] Value={ 7L,13L,19L,21L,25L,29L,31L,37L,41L,43L,49L,55L,57L,61L,67L,71L,73L,79L,81L,85L,89L,91L,97L,101L,103L,105L,109L,113L,115L,121L,127L,133L,139L,141L,145L,151L,157L,161L,163L,169L,175L,177L,181L,187L,193L,197L,199L,201L,205L,209L,211L,217L,221L,223L,225L,229L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160007Inst : IEnumerable<long>
{
public static readonly long[] Value=A160007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160007.Bytes);
public long this[int i]=>Value[i];

public static A160007Inst Instance=new A160007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160008
{
public static readonly BigInteger[] Value={ 1L,8L,-1186L,-29488L,4211596L,181132768L,-24873412856L,-1557483062848L,205182497987216L,17216290612377728L,-2170572777457158176L,BigInteger.Parse("-232568214874378865408"),BigInteger.Parse("27984829971040893996736"),BigInteger.Parse("3712401862884010133093888"),BigInteger.Parse("-425054272126342446382208896"),BigInteger.Parse("-68367466777480916900200711168") };
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
public class A160008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160008Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160008.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160008Inst Instance=new A160008Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160009
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,10L,13L,15L,16L,21L,24L,26L,30L,34L,39L,40L,42L,48L,55L,63L,65L,68L,78L,80L,89L,102L,104L,105L,110L,120L,126L,130L,144L,165L,168L,170L,178L,195L,204L,208L,210L,233L,240L,267L,272L,273L,275L,288L,312L,315L,330L,336L,340L,377L,390L,432L,440L,442L,445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160009Inst : IEnumerable<long>
{
public static readonly long[] Value=A160009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160009.Bytes);
public long this[int i]=>Value[i];

public static A160009Inst Instance=new A160009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160010
{
public static readonly BigInteger[] Value={ 1L,12L,-1106L,-43272L,3628236L,259898832L,-19557689016L,-2183933508192L,144922576791696L,23578406003420352L,-1347438116865535776L,BigInteger.Parse("-310899332445140829312"),BigInteger.Parse("14796482117559426968256"),BigInteger.Parse("4841047772087825563299072"),BigInteger.Parse("-182350261145286781474571136"),BigInteger.Parse("-86906539145280388735428613632") };
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
public class A160010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160010Inst Instance=new A160010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160011
{
public static readonly BigInteger[] Value={ 1L,14L,-1054L,-49756L,3255916L,294362824L,-16228395464L,-2434918716496L,107909598279056L,25859921540866784L,-851944079067245024L,BigInteger.Parse("-335176236367776230336"),BigInteger.Parse("7021763778025751855296"),BigInteger.Parse("5125948238409003981014144"),BigInteger.Parse("-42340386055192411914361984"),BigInteger.Parse("-90296859576930263434548587776") };
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
public class A160011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160011Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160011.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160011Inst Instance=new A160011Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160012
{
public static readonly BigInteger[] Value={ 1L,16L,-994L,-55904L,2833036L,324848576L,-12508897784L,-2636506684544L,67268748657296L,27441366823956736L,-317711553211272224L,BigInteger.Parse("-348100470150839555584"),BigInteger.Parse("-1201073665758439809344"),BigInteger.Parse("5202289873610458296810496"),BigInteger.Parse("102754085046341979650807936"),BigInteger.Parse("-89396007427441548519770753024") };
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
public class A160012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160012Inst Instance=new A160012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160013
{
public static readonly BigInteger[] Value={ 1L,18L,-926L,-61668L,2362476L,350864568L,-8449912776L,-2783582689968L,23832248370576L,28264807370350368L,240653738497326624L,BigInteger.Parse("-348978324836427720768"),BigInteger.Parse("-9590598751393940053824"),BigInteger.Parse("5062044095021324890551168"),BigInteger.Parse("246964023420535373904561024"),BigInteger.Parse("-84140419241303548854363341568") };
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
public class A160013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160013Inst Instance=new A160013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160014
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,6L,3L,1L,2L,2L,3L,1L,1L,5L,30L,15L,5L,5L,1L,6L,2L,3L,1L,5L,1L,1L,7L,42L,21L,35L,35L,7L,7L,1L,2L,2L,15L,1L,5L,1L,7L,1L,1L,3L,30L,3L,5L,5L,7L,7L,1L,1L,1L,10L,2L,3L,1L,35L,1L,7L,1L,1L,1L,1L,11L,66L,165L,385L,55L,77L,77L,11L,11L,11L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160014Inst : IEnumerable<long>
{
public static readonly long[] Value=A160014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160014.Bytes);
public long this[int i]=>Value[i];

public static A160014Inst Instance=new A160014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160015
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,22L,23L,30L,40L,50L,60L,70L,80L,90L,200L,311L,330L,331L,400L,500L,600L,700L,800L,900L,1000L,1111L,2000L,4000L,4001L,5000L,6000L,7000L,8000L,9000L,10000L,11111L,20000L,30000L,50000L,50001L,60000L,70000L,80000L,90000L,100000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160015Inst : IEnumerable<long>
{
public static readonly long[] Value=A160015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160015.Bytes);
public long this[int i]=>Value[i];

public static A160015Inst Instance=new A160015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160016
{
public static readonly long[] Value={ 0L,2L,1L,4L,6L,8L,3L,10L,12L,14L,5L,16L,18L,20L,7L,22L,24L,26L,9L,28L,30L,32L,11L,34L,36L,38L,13L,40L,42L,44L,15L,46L,48L,50L,17L,52L,54L,56L,19L,58L,60L,62L,21L,64L,66L,68L,23L,70L,72L,74L,25L,76L,78L,80L,27L,82L,84L,86L,29L,88L,90L,92L,31L,94L,96L,98L,33L,100L,102L,104L,35L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160016Inst : IEnumerable<long>
{
public static readonly long[] Value=A160016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160016.Bytes);
public long this[int i]=>Value[i];

public static A160016Inst Instance=new A160016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160017
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,4L,6L,7L,9L,8L,10L,11L,12L,13L,15L,14L,17L,16L,18L,19L,20L,21L,23L,22L,24L,25L,27L,26L,29L,28L,30L,31L,33L,32L,34L,35L,36L,37L,39L,38L,40L,41L,43L,42L,45L,44L,46L,47L,48L,49L,51L,50L,53L,52L,54L,55L,57L,56L,58L,59L,60L,61L,63L,62L,65L,64L,66L,67L,68L,69L,71L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160017Inst : IEnumerable<long>
{
public static readonly long[] Value=A160017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160017.Bytes);
public long this[int i]=>Value[i];

public static A160017Inst Instance=new A160017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160018
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,0L,2L,3L,0L,0L,2L,2L,0L,0L,4L,7L,0L,0L,2L,2L,0L,0L,4L,6L,0L,0L,4L,4L,0L,0L,8L,15L,0L,0L,2L,2L,0L,0L,4L,6L,0L,0L,4L,4L,0L,0L,8L,14L,0L,0L,4L,4L,0L,0L,8L,12L,0L,0L,8L,8L,0L,0L,16L,31L,0L,0L,2L,2L,0L,0L,4L,6L,0L,0L,4L,4L,0L,0L,8L,14L,0L,0L,4L,4L,0L,0L,8L,12L,0L,0L,8L,8L,0L,0L,16L,30L,0L,0L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160018Inst : IEnumerable<long>
{
public static readonly long[] Value=A160018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160018.Bytes);
public long this[int i]=>Value[i];

public static A160018Inst Instance=new A160018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160019
{
public static readonly long[] Value={ 1L,1L,3L,1L,0L,3L,1L,3L,5L,7L,1L,0L,2L,4L,3L,1L,3L,0L,2L,5L,7L,1L,0L,3L,2L,5L,4L,7L,1L,3L,5L,7L,9L,11L,13L,15L,1L,0L,2L,4L,6L,8L,10L,12L,3L,1L,3L,0L,2L,4L,6L,8L,10L,5L,7L,1L,0L,3L,2L,4L,6L,8L,10L,5L,12L,7L,1L,3L,5L,7L,0L,2L,4L,6L,9L,11L,13L,15L,1L,0L,2L,4L,3L,6L,8L,10L,5L,12L,14L,16L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160019Inst : IEnumerable<long>
{
public static readonly long[] Value=A160019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160019.Bytes);
public long this[int i]=>Value[i];

public static A160019Inst Instance=new A160019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160020
{
public static readonly long[] Value={ 1L,4L,4L,16L,10L,18L,22L,64L,46L,46L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160020Inst : IEnumerable<long>
{
public static readonly long[] Value=A160020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160020.Bytes);
public long this[int i]=>Value[i];

public static A160020Inst Instance=new A160020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160021
{
public static readonly BigInteger[] Value={ 35L,37L,49L,289L,65569L,4294967329L,BigInteger.Parse("18446744073709551649"),BigInteger.Parse("340282366920938463463374607431768211489"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639969") };
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
public class A160021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160021Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160021.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160021Inst Instance=new A160021Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160022
{
public static readonly long[] Value={ 3L,23L,47L,53L,67L,73L,89L,101L,103L,109L,151L,157L,179L,229L,521L,557L,569L,619L,661L,821L,977L,1013L,1087L,1129L,1277L,1321L,1451L,1559L,1607L,1627L,1741L,1867L,1871L,1949L,2137L,2389L,2441L,2797L,3271L,3313L,3643L,3677L,3769L,3847L,4001L,4027L,4133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160022Inst : IEnumerable<long>
{
public static readonly long[] Value=A160022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160022.Bytes);
public long this[int i]=>Value[i];

public static A160022Inst Instance=new A160022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160023
{
public static readonly long[] Value={ 11L,37L,71L,101L,149L,163L,191L,271L,293L,379L,409L,419L,647L,661L,709L,1153L,1193L,1231L,1277L,1523L,1583L,1619L,1667L,1693L,1753L,1777L,1787L,1913L,2089L,2099L,2161L,2213L,2441L,2473L,2531L,2551L,2609L,2711L,2749L,2909L,2953L,2999L,3221L,3257L,3469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160023Inst : IEnumerable<long>
{
public static readonly long[] Value=A160023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160023.Bytes);
public long this[int i]=>Value[i];

public static A160023Inst Instance=new A160023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160024
{
public static readonly long[] Value={ 7L,11L,13L,19L,23L,31L,41L,47L,61L,67L,73L,83L,101L,107L,127L,157L,163L,191L,193L,277L,281L,311L,337L,373L,379L,401L,409L,431L,443L,461L,491L,523L,541L,569L,607L,643L,673L,691L,719L,733L,743L,757L,769L,887L,929L,947L,953L,1031L,1039L,1087L,1093L,1097L,1103L,1109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160024Inst : IEnumerable<long>
{
public static readonly long[] Value=A160024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160024.Bytes);
public long this[int i]=>Value[i];

public static A160024Inst Instance=new A160024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160025
{
public static readonly long[] Value={ 3L,11L,13L,17L,31L,41L,43L,53L,83L,127L,167L,181L,193L,211L,241L,311L,337L,349L,421L,431L,487L,521L,557L,613L,617L,647L,701L,769L,811L,857L,953L,1021L,1151L,1249L,1289L,1303L,1373L,1453L,1459L,1471L,1523L,1553L,1567L,1579L,1613L,1663L,1669L,1747L,1823L,1831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160025Inst : IEnumerable<long>
{
public static readonly long[] Value=A160025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160025.Bytes);
public long this[int i]=>Value[i];

public static A160025Inst Instance=new A160025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160026
{
public static readonly long[] Value={ 13L,29L,37L,59L,89L,101L,107L,241L,263L,293L,373L,409L,569L,683L,821L,971L,1033L,1187L,1229L,1277L,1289L,1423L,1511L,1627L,1759L,1823L,1901L,1907L,1973L,2011L,2069L,2083L,2099L,2207L,2311L,2473L,2593L,2633L,2707L,2719L,2753L,2819L,3023L,3137L,3209L,3221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160026Inst : IEnumerable<long>
{
public static readonly long[] Value=A160026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160026.Bytes);
public long this[int i]=>Value[i];

public static A160026Inst Instance=new A160026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160027
{
public static readonly long[] Value={ 17L,19L,31L,271L,65551L,4294967311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160027Inst : IEnumerable<long>
{
public static readonly long[] Value=A160027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160027.Bytes);
public long this[int i]=>Value[i];

public static A160027Inst Instance=new A160027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160028
{
public static readonly BigInteger[] Value={ 83L,97L,337L,65617L,4294967377L,BigInteger.Parse("18446744073709551697"),BigInteger.Parse("340282366920938463463374607431768211537") };
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
public class A160028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160028Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160028.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160028Inst Instance=new A160028Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160029
{
public static readonly BigInteger[] Value={ 53L,67L,307L,65587L,BigInteger.Parse("18446744073709551667"),BigInteger.Parse("340282366920938463463374607431768211507") };
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
public class A160029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160029Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160029.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160029Inst Instance=new A160029Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160030
{
public static readonly BigInteger[] Value={ 389L,401L,641L,65921L,4294967681L,BigInteger.Parse("340282366920938463463374607431768211841") };
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
public class A160030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160030Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160030.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160030Inst Instance=new A160030Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160031
{
public static readonly long[] Value={ 5L,13L,19L,43L,71L,83L,97L,101L,107L,109L,127L,149L,179L,193L,197L,211L,233L,241L,311L,353L,383L,401L,421L,541L,577L,599L,607L,619L,641L,647L,683L,709L,727L,751L,769L,827L,877L,883L,941L,967L,991L,1009L,1061L,1097L,1109L,1187L,1289L,1373L,1381L,1409L,1439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160031Inst : IEnumerable<long>
{
public static readonly long[] Value=A160031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160031.Bytes);
public long this[int i]=>Value[i];

public static A160031Inst Instance=new A160031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160032
{
public static readonly BigInteger[] Value={ 97L,109L,349L,65629L,4294967389L,BigInteger.Parse("18446744073709551709") };
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
public class A160032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160032Inst Instance=new A160032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160033
{
public static readonly BigInteger[] Value={ 761L,773L,1013L,66293L,BigInteger.Parse("18446744073709552373"),BigInteger.Parse("340282366920938463463374607431768212213"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129640693") };
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
public class A160033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160033Inst Instance=new A160033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160034
{
public static readonly BigInteger[] Value={ 809L,811L,823L,1063L,66343L,BigInteger.Parse("18446744073709552423"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129640743") };
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
public class A160034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160034Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160034.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160034Inst Instance=new A160034Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160035
{
public static readonly long[] Value={ 1L,0L,-1L,0L,3L,0L,-5L,0L,7L,0L,-45L,0L,7601L,0L,-91L,0L,54255L,0L,-745739L,0L,3317609L,0L,-17944773L,0L,5436374093L,0L,-213827575L,0L,641235447783L,0L,-249859397004145L,0L,238988952277727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160035Inst : IEnumerable<long>
{
public static readonly long[] Value=A160035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160035.Bytes);
public long this[int i]=>Value[i];

public static A160035Inst Instance=new A160035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160036
{
public static readonly long[] Value={ 19L,27L,31L,38L,22L,7L,10L,28L,34L,28L,7L,27L,63L,28L,33L,4L,0L,9L,4L,6L,12L,4L,40L,4L,9L,11L,13L,7L,11L,31L,44L,30L,12L,8L,40L,20L,21L,58L,28L,7L,8L,6L,21L,27L,54L,45L,15L,18L,36L,5L,25L,47L,46L,8L,36L,9L,18L,18L,18L,4L,11L,44L,59L,7L,6L,14L,32L,56L,36L,12L,12L,18L,18L,14L,6L,24L,8L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160036Inst : IEnumerable<long>
{
public static readonly long[] Value=A160036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160036.Bytes);
public long this[int i]=>Value[i];

public static A160036Inst Instance=new A160036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160037
{
public static readonly BigInteger[] Value={ 1L,22L,-766L,-71852L,1291756L,387678632L,455454904L,-2897569732112L,-67731764516464L,27485598501757792L,1366665517848891424L,BigInteger.Parse("-313503339879296788672"),BigInteger.Parse("-25688724347766786430784"),BigInteger.Parse("4137398162538582528602752"),BigInteger.Parse("508464530227059095129500544"),BigInteger.Parse("-61218248179429894157699148032") };
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
public class A160037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160037Inst Instance=new A160037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160038
{
public static readonly BigInteger[] Value={ 1L,24L,-674L,-76176L,699276L,397662624L,5173427976L,-2858307408576L,-113866872595824L,25850269143460224L,1901408776146065376L,BigInteger.Parse("-277494553665747230976"),BigInteger.Parse("-32804239959986332463424"),BigInteger.Parse("3375116545946536485517824"),BigInteger.Parse("614071696452494778183067776"),BigInteger.Parse("-44326818839204513820168293376") };
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
public class A160038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160038Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160038.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160038Inst Instance=new A160038Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160039
{
public static readonly long[] Value={ 1L,3L,11L,25L,274L,294L,13068L,13698L,114064L,1062864L,120543840L,123870240L,19802759040L,20247546240L,289277533440L,4420892649600L,1223405590579200L,1243166003251200L,431565146817638400L,437647401838080000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160039Inst : IEnumerable<long>
{
public static readonly long[] Value=A160039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160039.Bytes);
public long this[int i]=>Value[i];

public static A160039Inst Instance=new A160039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160040
{
public static readonly long[] Value={ 123L,2407L,5224L,8350L,11166L,30843L,51174L,66026L,172451L,202774L,266109L,546322L,1082682L,1830188L,1882036L,2754207L,3351809L,14355351L,23539612L,23539621L,24322837L,63950931L,122924349L,161485470L,204868903L,204868930L,252704792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160040Inst : IEnumerable<long>
{
public static readonly long[] Value=A160040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160040.Bytes);
public long this[int i]=>Value[i];

public static A160040Inst Instance=new A160040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160041
{
public static readonly long[] Value={ 53L,73L,125L,193L,365L,697L,1105L,2117L,4057L,6437L,12337L,23645L,37517L,71905L,137813L,218665L,419093L,803233L,1274473L,2442653L,4681585L,7428173L,14236825L,27286277L,43294565L,82978297L,159036077L,252339217L,483632957L,926930185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160041Inst : IEnumerable<long>
{
public static readonly long[] Value=A160041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160041.Bytes);
public long this[int i]=>Value[i];

public static A160041Inst Instance=new A160041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160042
{
public static readonly long[] Value={ 1L,9L,1L,6L,5L,9L,8L,4L,6L,9L,1L,1L,5L,4L,9L,8L,9L,2L,8L,1L,7L,6L,1L,7L,5L,2L,6L,1L,2L,5L,4L,0L,9L,7L,6L,8L,2L,5L,8L,2L,3L,0L,3L,9L,3L,8L,5L,4L,2L,0L,5L,6L,5L,8L,4L,0L,3L,2L,3L,3L,5L,2L,1L,3L,2L,5L,5L,7L,0L,3L,6L,8L,8L,0L,0L,8L,7L,1L,0L,3L,2L,0L,5L,2L,8L,9L,5L,8L,2L,3L,6L,1L,0L,6L,7L,8L,2L,1L,4L,5L,4L,5L,8L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160042Inst : IEnumerable<long>
{
public static readonly long[] Value=A160042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160042.Bytes);
public long this[int i]=>Value[i];

public static A160042Inst Instance=new A160042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160043
{
public static readonly long[] Value={ 1L,5L,8L,6L,6L,7L,9L,0L,8L,4L,1L,4L,2L,6L,7L,5L,4L,1L,3L,3L,8L,7L,2L,4L,7L,7L,1L,6L,4L,6L,1L,9L,7L,7L,0L,9L,4L,6L,8L,6L,1L,6L,0L,3L,9L,0L,2L,1L,0L,0L,3L,1L,9L,8L,1L,2L,0L,9L,3L,0L,3L,2L,2L,5L,3L,4L,4L,2L,1L,0L,9L,0L,7L,5L,2L,2L,7L,4L,6L,6L,4L,7L,4L,0L,2L,5L,8L,9L,2L,9L,1L,9L,6L,0L,6L,6L,9L,9L,4L,0L,7L,1L,4L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160043Inst : IEnumerable<long>
{
public static readonly long[] Value=A160043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160043.Bytes);
public long this[int i]=>Value[i];

public static A160043Inst Instance=new A160043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160044
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,22L,23L,25L,26L,27L,28L,29L,30L,31L,34L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,70L,71L,72L,73L,74L,77L,78L,79L,80L,82L,83L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160044Inst : IEnumerable<long>
{
public static readonly long[] Value=A160044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160044.Bytes);
public long this[int i]=>Value[i];

public static A160044Inst Instance=new A160044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160045
{
public static readonly long[] Value={ 1340164183006357435L,3L,2L,1L,3L,4L,1L,1L,5L,1L,1L,1L,4L,14L,1L,2L,5L,2L,3L,1L,2L,1L,50L,785L,1L,1L,2L,34L,1L,2L,1L,3L,1L,3L,3L,1L,1L,1L,2L,2L,5L,3L,9L,1L,1L,1L,1L,1L,1L,8L,13L,2L,11L,444L,3L,1L,2L,86L,1L,25L,4L,2L,25L,18L,2L,1L,192L,1L,4L,1L,5L,3L,14L,4L,15L,2L,3L,8L,4L,2L,36L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160045Inst : IEnumerable<long>
{
public static readonly long[] Value=A160045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160045.Bytes);
public long this[int i]=>Value[i];

public static A160045Inst Instance=new A160045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160046
{
public static readonly long[] Value={ 0L,1L,3L,5L,15L,10L,77L,47L,75L,131L,1507L,142L,637L,353L,1089L,1487L,12937L,6989L,135451L,7255L,7381L,82451L,1925353L,84866L,430105L,1132133L,3437979L,1158863L,33980257L,1183745L,37068467L,4828073L,2436559L,41781863L,42142223L,42482563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160046Inst : IEnumerable<long>
{
public static readonly long[] Value=A160046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160046.Bytes);
public long this[int i]=>Value[i];

public static A160046Inst Instance=new A160046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160047
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,6L,3L,4L,6L,60L,5L,20L,10L,28L,35L,280L,140L,2520L,126L,120L,1260L,27720L,1155L,5544L,13860L,40040L,12870L,360360L,12012L,360360L,45045L,21840L,360360L,350064L,340340L,4084080L,2042040L,1989680L,1939938L,15519504L,369512L,5173168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160047Inst : IEnumerable<long>
{
public static readonly long[] Value=A160047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160047.Bytes);
public long this[int i]=>Value[i];

public static A160047Inst Instance=new A160047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160048
{
public static readonly long[] Value={ 0L,2L,5L,26L,77L,87L,223L,962L,4609L,4861L,55991L,58301L,785633L,811373L,835397L,3431678L,29889983L,30570663L,197698279L,201578155L,41054655L,13920029L,325333835L,990874363L,25128807667L,25472027467L,232222818803L,235091155703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160048Inst : IEnumerable<long>
{
public static readonly long[] Value=A160048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160048.Bytes);
public long this[int i]=>Value[i];

public static A160048Inst Instance=new A160048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160049
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,5L,10L,35L,140L,126L,1260L,1155L,13860L,12870L,12012L,45045L,360360L,340340L,2042040L,1939938L,369512L,117572L,2586584L,7436429L,178474296L,171609900L,1487285800L,1434168450L,40156716600L,38818159380L,1164544781400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160049Inst : IEnumerable<long>
{
public static readonly long[] Value=A160049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160049.Bytes);
public long this[int i]=>Value[i];

public static A160049Inst Instance=new A160049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160050
{
public static readonly long[] Value={ 0L,1L,5L,9L,7L,10L,27L,35L,22L,27L,65L,77L,45L,52L,119L,135L,76L,85L,189L,209L,115L,126L,275L,299L,162L,175L,377L,405L,217L,232L,495L,527L,280L,297L,629L,665L,351L,370L,779L,819L,430L,451L,945L,989L,517L,540L,1127L,1175L,612L,637L,1325L,1377L,715L,742L,1539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160050Inst : IEnumerable<long>
{
public static readonly long[] Value=A160050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160050.Bytes);
public long this[int i]=>Value[i];

public static A160050Inst Instance=new A160050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160051
{
public static readonly long[] Value={ 1L,0L,2L,3L,5L,4L,7L,6L,8L,9L,10L,12L,11L,13L,14L,15L,17L,16L,18L,19L,20L,21L,23L,22L,25L,24L,26L,27L,29L,28L,31L,33L,30L,35L,32L,34L,37L,36L,38L,39L,41L,40L,43L,42L,44L,45L,46L,47L,49L,48L,51L,53L,50L,52L,55L,54L,56L,57L,59L,58L,61L,60L,62L,63L,64L,66L,65L,67L,68L,69L,71L,70L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160051Inst : IEnumerable<long>
{
public static readonly long[] Value=A160051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160051.Bytes);
public long this[int i]=>Value[i];

public static A160051Inst Instance=new A160051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160052
{
public static readonly long[] Value={ 1L,1L,3L,0L,1L,3L,1L,3L,5L,7L,0L,2L,4L,1L,3L,0L,2L,1L,3L,5L,7L,0L,1L,3L,2L,4L,5L,7L,1L,3L,5L,7L,9L,11L,13L,15L,0L,2L,4L,6L,8L,10L,12L,1L,3L,0L,2L,4L,6L,8L,10L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,10L,12L,5L,7L,0L,2L,4L,6L,1L,3L,5L,7L,9L,11L,13L,15L,0L,2L,4L,1L,3L,6L,8L,10L,12L,14L,16L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160052Inst : IEnumerable<long>
{
public static readonly long[] Value=A160052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160052.Bytes);
public long this[int i]=>Value[i];

public static A160052Inst Instance=new A160052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160053
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,16L,17L,25L,36L,40L,49L,52L,64L,72L,73L,80L,81L,89L,97L,100L,116L,121L,136L,144L,145L,148L,169L,180L,193L,196L,225L,232L,233L,241L,244L,256L,260L,288L,289L,292L,305L,313L,324L,337L,360L,361L,369L,388L,400L,404L,409L,424L,441L,449L,457L,481L,484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160053Inst : IEnumerable<long>
{
public static readonly long[] Value=A160053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160053.Bytes);
public long this[int i]=>Value[i];

public static A160053Inst Instance=new A160053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160054
{
public static readonly long[] Value={ 7L,11L,23L,109L,211L,307L,1021L,4583L,42967L,297779L,1022443L,1459811L,10781809L,125211211L,11673806759L,3019843939831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160054Inst : IEnumerable<long>
{
public static readonly long[] Value=A160054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160054.Bytes);
public long this[int i]=>Value[i];

public static A160054Inst Instance=new A160054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160055
{
public static readonly long[] Value={ 65L,89L,149L,241L,445L,829L,1381L,2581L,4825L,8045L,15041L,28121L,46889L,87665L,163901L,273289L,510949L,955285L,1592845L,2978029L,5567809L,9283781L,17357225L,32451569L,54109841L,101165321L,189141605L,315375265L,589634701L,1102398061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160055Inst : IEnumerable<long>
{
public static readonly long[] Value=A160055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160055.Bytes);
public long this[int i]=>Value[i];

public static A160055Inst Instance=new A160055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160056
{
public static readonly long[] Value={ 1L,8L,6L,9L,6L,2L,8L,8L,7L,2L,1L,3L,1L,1L,2L,3L,5L,0L,6L,1L,7L,6L,0L,7L,7L,8L,2L,4L,9L,0L,7L,9L,4L,7L,4L,0L,7L,8L,6L,4L,3L,3L,9L,5L,3L,6L,6L,9L,4L,7L,3L,9L,5L,4L,0L,1L,5L,0L,7L,9L,2L,6L,8L,5L,3L,4L,3L,9L,4L,1L,1L,6L,9L,6L,1L,1L,3L,3L,1L,4L,1L,1L,5L,9L,2L,3L,1L,7L,7L,1L,2L,8L,2L,8L,7L,7L,4L,6L,7L,4L,7L,7L,3L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160056Inst : IEnumerable<long>
{
public static readonly long[] Value=A160056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160056.Bytes);
public long this[int i]=>Value[i];

public static A160056Inst Instance=new A160056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160057
{
public static readonly long[] Value={ 1L,6L,6L,7L,4L,0L,2L,9L,2L,2L,7L,9L,9L,5L,9L,0L,2L,2L,7L,9L,9L,1L,0L,4L,2L,7L,0L,7L,4L,0L,9L,0L,3L,8L,9L,1L,6L,1L,6L,2L,5L,1L,9L,7L,4L,5L,9L,1L,3L,0L,2L,5L,4L,6L,8L,8L,5L,4L,7L,2L,4L,4L,5L,6L,0L,7L,7L,8L,0L,4L,5L,8L,4L,0L,9L,3L,1L,3L,2L,1L,8L,6L,1L,0L,8L,1L,5L,0L,3L,2L,5L,4L,1L,8L,4L,6L,3L,3L,6L,3L,5L,2L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160057Inst : IEnumerable<long>
{
public static readonly long[] Value=A160057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160057.Bytes);
public long this[int i]=>Value[i];

public static A160057Inst Instance=new A160057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160058
{
public static readonly long[] Value={ 53L,157L,173L,211L,251L,257L,263L,293L,331L,337L,373L,509L,541L,547L,557L,563L,577L,587L,593L,607L,631L,653L,733L,787L,797L,839L,947L,953L,977L,997L,1039L,1069L,1103L,1123L,1129L,1181L,1187L,1223L,1237L,1249L,1259L,1327L,1361L,1367L,1399L,1409L,1459L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160058Inst : IEnumerable<long>
{
public static readonly long[] Value=A160058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160058.Bytes);
public long this[int i]=>Value[i];

public static A160058Inst Instance=new A160058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160059
{
public static readonly BigInteger[] Value={ 1L,26L,-574L,-79924L,74476L,401556376L,9974990776L,-2752323059824L,-158841568845424L,23393349808258976L,2395194744525753376L,BigInteger.Parse("-230141809245567612224"),BigInteger.Parse("-38917614777613866837824"),BigInteger.Parse("2440269154465553645576576"),BigInteger.Parse("695858238152329730899630976"),BigInteger.Parse("-24612396011186615794199674624") };
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
public class A160059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160059Inst Instance=new A160059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160060
{
public static readonly BigInteger[] Value={ 1L,28L,-466L,-83048L,-577844L,399060368L,14785215304L,-2578966731488L,-201581702391664L,20145379647913408L,2831864782047795424L,BigInteger.Parse("-172525031701579328128"),BigInteger.Parse("-43768841640801408267584"),BigInteger.Parse("1362347909581250490427648"),BigInteger.Parse("749389418131297898080214144"),BigInteger.Parse("-2858184709995542436237843968") };
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
public class A160060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160060Inst Instance=new A160060Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160061
{
public static readonly BigInteger[] Value={ 1L,32L,-226L,-87232L,-1943924L,373954432L,24116066824L,-2032944101632L,-276069795962224L,11495207545528832L,3473631846031942624L,BigInteger.Parse("-32533875246088236032"),BigInteger.Parse("-48803521890814034633024"),BigInteger.Parse("-1073704571814725567776768"),BigInteger.Parse("758698684427656844617783424"),BigInteger.Parse("43068187908442716463862509568") };
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
public class A160061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160061Inst Instance=new A160061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160062
{
public static readonly BigInteger[] Value={ 1L,34L,-94L,-88196L,-2646164L,351010424L,28472879416L,-1664500279856L,-305730704405104L,6250158848786464L,3651975825416159776L,BigInteger.Parse("46040192454318632384"),BigInteger.Parse("-48649301056025363418944"),BigInteger.Parse("-2344679122719641842004096"),BigInteger.Parse("710832051987944332929700736"),BigInteger.Parse("65200174415183839554681505024") };
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
public class A160062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160062Inst Instance=new A160062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160063
{
public static readonly BigInteger[] Value={ 1L,36L,46L,-88344L,-3352884L,321016176L,32512107336L,-1237185455904L,-329019615602544L,527148397348416L,3720448017833162976L,BigInteger.Parse("127346773675138667136"),BigInteger.Parse("-46571676392900998903104"),BigInteger.Parse("-3586781955271515967551744"),BigInteger.Parse("627665590994866657343577216"),BigInteger.Parse("85364645493066729096524299776") };
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
public class A160063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160063Inst Instance=new A160063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160064
{
public static readonly BigInteger[] Value={ 1L,38L,194L,-87628L,-4057364L,283960168L,36149011384L,-756038827408L,-345033325051504L,-5550878077877152L,3670691539870088224L,BigInteger.Parse("208872254488527752512"),BigInteger.Parse("-42534863002649658484544"),BigInteger.Parse("-4749408611428603310092672"),BigInteger.Parse("510713996558770024590318464"),BigInteger.Parse("102521782569233818861053861632") };
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
public class A160064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160064Inst Instance=new A160064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160065
{
public static readonly BigInteger[] Value={ 1L,42L,514L,-83412L,-5430804L,188966232L,41879106744L,341675743248L,-352091802793584L,-18204613149810528L,3196439029135777824L,BigInteger.Parse("361808103596334268608"),BigInteger.Parse("-28755096299570905798464"),BigInteger.Parse("-6634835598526992072655488"),BigInteger.Parse("188607219729893552173509504"),BigInteger.Parse("124031126202877890462758439168") };
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
public class A160065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160065Inst Instance=new A160065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160066
{
public static readonly BigInteger[] Value={ 1L,44L,686L,-79816L,-6084404L,131366224L,43807638856L,942289429664L,-341856105084784L,-24464562920370496L,2769440413707518176L,BigInteger.Parse("427662414707761999744"),BigInteger.Parse("-19262659441336846931264"),BigInteger.Parse("-7262493236035251261135616"),BigInteger.Parse("-6531486463827292856927104"),BigInteger.Parse("126806246226208496184168487424") };
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
public class A160066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160066Inst Instance=new A160066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160067
{
public static readonly BigInteger[] Value={ 1L,46L,866L,-75164L,-6705044L,67387976L,45006371896L,1564883287216L,-321821122878064L,-30452604524550944L,2219667824248876576L,BigInteger.Parse("482762276472335122496"),BigInteger.Parse("-8313367865694637285184"),BigInteger.Parse("-7623849068906980152558464"),BigInteger.Parse("-215604829352183231133449344") };
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
public class A160067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160067Inst Instance=new A160067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160068
{
public static readonly BigInteger[] Value={ 1L,48L,1054L,-69408L,-7284084L,-2596032L,45400915464L,2198714182272L,-291719729560944L,-35989688841645312L,1554341893161645024L,BigInteger.Parse("524479521392325361152"),BigInteger.Parse("3802815995858998255296"),BigInteger.Parse("-7684657653083648501025792"),BigInteger.Parse("-430659327280723849697798016") };
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
public class A160068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160068Inst Instance=new A160068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160069
{
public static readonly BigInteger[] Value={ 1L,1L,-337L,-1013L,340705L,1710281L,-574081169L,-4042531037L,1354233514817L,12285237438865L,-4107293114634449L,-45631395657998149L,15225284404552883233UL,BigInteger.Parse("200306225193393375577"),BigInteger.Parse("-66699593448411975550225"),BigInteger.Parse("-1014548651063549428780589"),BigInteger.Parse("337152390132385166610860161") };
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
public class A160069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160069Inst Instance=new A160069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160070
{
public static readonly BigInteger[] Value={ 1L,3L,-329L,-3015L,324561L,5049963L,-533358201L,-11841399567L,1226401304865L,35698348343763L,-3623617724368041L,-131531270575023063L,13078016887475307249UL,BigInteger.Parse("572724884114719465275"),BigInteger.Parse("-55746631551222341656281"),BigInteger.Parse("-2877374046284519534650143"),BigInteger.Parse("274003299825843713593394241") };
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
public class A160070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160070Inst Instance=new A160070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160071
{
public static readonly BigInteger[] Value={ 1L,5L,-313L,-4945L,292657L,8148925L,-453845705L,-18795248425L,979822695905L,55721465220725L,-2702013314839385L,-201848619020247425L,9036842409471596305L,BigInteger.Parse("863882210793481537325"),BigInteger.Parse("-35388474493250786477545"),BigInteger.Parse("-4264832993941008567009625"),BigInteger.Parse("158095400711076444606105025") };
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
public class A160071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160071Inst Instance=new A160071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160072
{
public static readonly BigInteger[] Value={ 1L,7L,-289L,-6755L,245761L,10853087L,-339364481L,-24385611803L,632237079425L,70364353871287L,-1430714718511841L,-247846519114532947L,3584471689625294209L,BigInteger.Parse("1030356783355922692495"),BigInteger.Parse("-8537671120722083906881"),BigInteger.Parse("-4935411996685280768234507"),BigInteger.Parse("8738108605264000030245121") };
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
public class A160072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160072Inst Instance=new A160072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160073
{
public static readonly BigInteger[] Value={ 1L,9L,-257L,-8397L,185025L,13017969L,-195530529L,-28160215893L,209183288577L,78027873371865L,65915296495551L,-263140974328443741L,-2613341841326452287L,BigInteger.Parse("1043779715304229742913"),BigInteger.Parse("20877041488526499035295"),BigInteger.Parse("-4751272239422876652146661"),BigInteger.Parse("-148608050501635239978265599") };
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
public class A160073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160073Inst Instance=new A160073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160074
{
public static readonly BigInteger[] Value={ 1L,11L,-217L,-9823L,111985L,14512531L,-29616809L,-29757197767L,-257255805343L,77633648903195L,1636542297788551L,-244399768017125039L,-8773061711366208047L,BigInteger.Parse("894781780252430869667"),BigInteger.Parse("48391432742519857724855"),BigInteger.Parse("-3701801623986784440290839"),BigInteger.Parse("-286064381868430307508214079") };
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
public class A160074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160074Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160074.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160074Inst Instance=new A160074Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160075
{
public static readonly BigInteger[] Value={ 1L,15L,-113L,-11835L,-62943L,15056775L,332225295L,-25551760275L,-1169321452095L,51552138002175L,4330357927305615L,-109290857537767275L,BigInteger.Parse("-17739633636788785695"),BigInteger.Parse("177189213621352281975"),BigInteger.Parse("80605788404370208573455"),BigInteger.Parse("370627467209314130296125"),BigInteger.Parse("-403111935202017245512974975") };
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
public class A160075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160075Inst Instance=new A160075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160076
{
public static readonly BigInteger[] Value={ 1L,17L,-49L,-12325L,-159839L,13946137L,507212239L,-19660157773L,-1534286839615L,27078190344737L,5127629801969359L,-4354576731731957L,BigInteger.Parse("-19138555408161520031"),BigInteger.Parse("-307693278714841022935"),BigInteger.Parse("78864026725309421626319"),BigInteger.Parse("2796693049208887888175843"),BigInteger.Parse("-352296833660767673546447999") };
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
public class A160076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160076Inst Instance=new A160076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160077
{
public static readonly BigInteger[] Value={ 1L,19L,23L,-12407L,-259055L,11852219L,662995111L,-11439393023L,-1785994900063L,-3001784367005L,5375962583018551L,112289320237829369L,BigInteger.Parse("-17854331799144214607"),BigInteger.Parse("-794677787068375998197"),BigInteger.Parse("63353055971140535017415"),BigInteger.Parse("4964123351859225388799089"),BigInteger.Parse("-226881650088357230151111359") };
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
public class A160077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160077Inst Instance=new A160077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160078
{
public static readonly long[] Value={ 22L,26L,28L,35L,37L,41L,45L,46L,47L,49L,60L,61L,67L,75L,77L,78L,84L,86L,89L,90L,93L,94L,95L,97L,105L,106L,108L,110L,116L,120L,122L,124L,125L,131L,135L,139L,141L,147L,149L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160078Inst : IEnumerable<long>
{
public static readonly long[] Value=A160078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160078.Bytes);
public long this[int i]=>Value[i];

public static A160078Inst Instance=new A160078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160079
{
public static readonly long[] Value={ 0L,1L,4L,2L,3L,5L,8L,7L,6L,10L,13L,11L,9L,14L,17L,16L,12L,19L,22L,20L,15L,23L,26L,25L,18L,28L,31L,29L,21L,32L,35L,34L,24L,37L,40L,38L,27L,41L,44L,43L,30L,46L,49L,47L,33L,50L,53L,52L,36L,55L,58L,56L,39L,59L,62L,61L,42L,64L,67L,65L,45L,68L,71L,70L,48L,73L,76L,74L,51L,77L,80L,79L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160079Inst : IEnumerable<long>
{
public static readonly long[] Value=A160079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160079.Bytes);
public long this[int i]=>Value[i];

public static A160079Inst Instance=new A160079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160080
{
public static readonly long[] Value={ 0L,1L,5L,2L,3L,9L,4L,13L,17L,6L,7L,21L,8L,25L,29L,10L,11L,33L,12L,37L,41L,14L,15L,45L,16L,49L,53L,18L,19L,57L,20L,61L,65L,22L,23L,69L,24L,73L,77L,26L,27L,81L,28L,85L,89L,30L,31L,93L,32L,97L,101L,34L,35L,105L,36L,109L,113L,38L,39L,117L,40L,121L,125L,42L,43L,129L,44L,133L,137L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160080Inst : IEnumerable<long>
{
public static readonly long[] Value=A160080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160080.Bytes);
public long this[int i]=>Value[i];

public static A160080Inst Instance=new A160080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160081
{
public static readonly long[] Value={ 0L,1L,6L,2L,3L,5L,8L,13L,11L,4L,10L,9L,14L,18L,7L,15L,12L,17L,19L,16L,20L,21L,26L,22L,23L,25L,28L,33L,31L,24L,30L,29L,34L,38L,27L,35L,32L,37L,39L,36L,40L,41L,46L,42L,43L,45L,48L,53L,51L,44L,50L,49L,54L,58L,47L,55L,52L,57L,59L,56L,60L,61L,66L,62L,63L,65L,68L,73L,71L,64L,70L,69L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160081Inst : IEnumerable<long>
{
public static readonly long[] Value=A160081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160081.Bytes);
public long this[int i]=>Value[i];

public static A160081Inst Instance=new A160081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160082
{
public static readonly BigInteger[] Value={ 1L,21L,103L,-12033L,-357135L,8768781L,787702551L,-1241334297L,-1889772255903L,-36328649434875L,4985785564324551L,227492331940693071L,BigInteger.Parse("-13759811757404126127"),BigInteger.Parse("-1211664945256937744643"),BigInteger.Parse("35015649011638037564535"),BigInteger.Parse("6468927150200228196505911"),BigInteger.Parse("-41681870334800058325568319") };
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
public class A160082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160082Inst Instance=new A160082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160083
{
public static readonly BigInteger[] Value={ 1L,23L,191L,-11155L,-450239L,4726063L,869603359L,10416421493L,-1817903853055L,-69977792337337L,3920574297234559L,326698146936593917L,-7062637857576430271L,BigInteger.Parse("-1487528354699082823585"),BigInteger.Parse("-3179921411888070331681"),BigInteger.Parse("6965845981962634303575557"),BigInteger.Parse("176336659143413105563860481") };
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
public class A160083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160083Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160083.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160083Inst Instance=new A160083Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160084
{
public static readonly BigInteger[] Value={ 1L,25L,287L,-9725L,-534143L,-205375L,897567295L,22855682875L,-1552252148095L,-100608070196375L,2206749279595615L,395224009253637875L,1675906409804450305L,BigInteger.Parse("-1561130921287643963375"),BigInteger.Parse("-46392205796871853724545"),BigInteger.Parse("6227466374611334891576875"),BigInteger.Parse("390895142755423670672865025") };
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
public class A160084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160084Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160084.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160084Inst Instance=new A160084Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160085
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,5L,1L,13L,3L,5L,1L,33L,1L,5L,5L,75L,1L,33L,1L,33L,5L,5L,1L,261L,3L,5L,13L,33L,1L,61L,1L,541L,5L,5L,5L,375L,1L,5L,5L,261L,1L,61L,1L,33L,33L,5L,1L,2405L,3L,33L,5L,33L,1L,261L,5L,261L,5L,5L,1L,717L,1L,5L,33L,4683L,5L,61L,1L,33L,5L,61L,1L,4549L,1L,5L,33L,33L,5L,61L,1L,2405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160085Inst : IEnumerable<long>
{
public static readonly long[] Value=A160085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160085.Bytes);
public long this[int i]=>Value[i];

public static A160085Inst Instance=new A160085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160086
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,7L,0L,3L,0L,3L,0L,0L,0L,25L,0L,0L,1L,3L,0L,6L,0L,36L,0L,0L,0L,36L,0L,0L,0L,25L,0L,6L,0L,3L,3L,0L,0L,152L,0L,3L,0L,3L,0L,25L,0L,25L,0L,0L,0L,69L,0L,0L,3L,171L,0L,6L,0L,3L,0L,6L,0L,279L,0L,0L,3L,3L,0L,6L,0L,152L,7L,0L,0L,69L,0L,0L,0L,25L,0L,69L,0L,3L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160086Inst : IEnumerable<long>
{
public static readonly long[] Value=A160086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160086.Bytes);
public long this[int i]=>Value[i];

public static A160086Inst Instance=new A160086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160087
{
public static readonly BigInteger[] Value={ 1L,2L,-1454L,-8740L,6342316L,63656312L,-46108171016L,-649081759408L,469281829870480L,8509453301475872L,-6140897264957486816L,BigInteger.Parse("-136349623665433187392"),BigInteger.Parse("98215011088057307180224"),BigInteger.Parse("2582003037826533660970880"),BigInteger.Parse("-1856403314087385132972023936") };
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
public class A160087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160087Inst Instance=new A160087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160088
{
public static readonly BigInteger[] Value={ 1L,4L,-1442L,-17432L,6237580L,126613744L,-44965503224L,-1287479045408L,453768009722512L,16832227624528960L,-5887014913080686624L,BigInteger.Parse("-268961938417954983296"),BigInteger.Parse("93340097422316232142528"),BigInteger.Parse("5079118464249805316316928"),BigInteger.Parse("-1748851732685582642764208000") };
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
public class A160088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160088Inst Instance=new A160088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160089
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,4L,3L,3L,4L,6L,5L,6L,7L,8L,8L,10L,11L,16L,16L,19L,21L,28L,29L,34L,41L,50L,56L,68L,80L,100L,114L,135L,158L,196L,225L,269L,320L,388L,455L,544L,644L,786L,921L,1111L,1321L,1600L,1891L,2274L,2711L,3280L,3895L,4694L,5591L,6780L,8051L,9729L,11624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160089Inst : IEnumerable<long>
{
public static readonly long[] Value=A160089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160089.Bytes);
public long this[int i]=>Value[i];

public static A160089Inst Instance=new A160089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160090
{
public static readonly long[] Value={ 485L,569L,689L,2221L,2845L,3649L,12841L,16501L,21205L,74825L,96161L,123581L,436109L,560465L,720281L,2541829L,3266629L,4198105L,14814865L,19039309L,24468349L,86347361L,110969225L,142611989L,503269301L,646776041L,831203585L,2933268445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160090Inst : IEnumerable<long>
{
public static readonly long[] Value=A160090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160090.Bytes);
public long this[int i]=>Value[i];

public static A160090Inst Instance=new A160090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160091
{
public static readonly long[] Value={ 1L,2L,8L,5L,1L,4L,9L,0L,0L,4L,1L,5L,1L,2L,4L,0L,2L,3L,7L,2L,1L,9L,2L,8L,3L,3L,9L,1L,6L,8L,6L,0L,9L,7L,0L,1L,9L,3L,5L,6L,9L,5L,3L,4L,8L,2L,0L,5L,3L,5L,1L,2L,6L,5L,9L,8L,6L,6L,4L,6L,9L,8L,3L,0L,0L,0L,8L,8L,8L,3L,5L,0L,2L,2L,9L,0L,2L,1L,9L,5L,3L,9L,4L,7L,7L,5L,7L,3L,8L,6L,3L,7L,9L,8L,6L,2L,8L,1L,9L,0L,5L,4L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160091Inst : IEnumerable<long>
{
public static readonly long[] Value=A160091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160091.Bytes);
public long this[int i]=>Value[i];

public static A160091Inst Instance=new A160091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160092
{
public static readonly long[] Value={ 3L,5L,2L,8L,9L,4L,1L,0L,4L,1L,5L,6L,2L,2L,2L,8L,1L,2L,9L,9L,4L,8L,6L,8L,2L,4L,4L,7L,6L,4L,2L,3L,8L,1L,0L,5L,6L,3L,0L,2L,0L,8L,3L,3L,2L,2L,0L,2L,2L,3L,8L,6L,8L,1L,8L,2L,5L,7L,5L,0L,5L,6L,5L,8L,3L,7L,4L,3L,4L,7L,1L,9L,7L,6L,9L,6L,6L,2L,6L,1L,7L,1L,7L,8L,5L,0L,7L,4L,4L,0L,0L,1L,8L,4L,2L,7L,8L,2L,8L,1L,4L,6L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160092Inst : IEnumerable<long>
{
public static readonly long[] Value=A160092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160092.Bytes);
public long this[int i]=>Value[i];

public static A160092Inst Instance=new A160092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160093
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160093Inst : IEnumerable<long>
{
public static readonly long[] Value=A160093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160093.Bytes);
public long this[int i]=>Value[i];

public static A160093Inst Instance=new A160093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160094
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160094Inst : IEnumerable<long>
{
public static readonly long[] Value=A160094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160094.Bytes);
public long this[int i]=>Value[i];

public static A160094Inst Instance=new A160094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160095
{
public static readonly long[] Value={ 3L,4L,6L,6L,7L,8L,8L,9L,10L,11L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,21L,21L,22L,22L,23L,23L,24L,25L,25L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,31L,31L,31L,32L,32L,33L,33L,33L,34L,35L,35L,35L,36L,37L,37L,37L,37L,38L,39L,40L,40L,40L,41L,41L,41L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160095Inst : IEnumerable<long>
{
public static readonly long[] Value=A160095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160095.Bytes);
public long this[int i]=>Value[i];

public static A160095Inst Instance=new A160095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160096
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160096Inst : IEnumerable<long>
{
public static readonly long[] Value=A160096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160096.Bytes);
public long this[int i]=>Value[i];

public static A160096Inst Instance=new A160096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160097
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,4L,1L,3L,3L,2L,1L,4L,1L,4L,3L,3L,1L,6L,1L,3L,2L,4L,1L,7L,1L,4L,3L,3L,3L,5L,1L,3L,3L,6L,1L,7L,1L,4L,4L,3L,1L,7L,1L,4L,3L,4L,1L,6L,3L,6L,3L,3L,1L,10L,1L,3L,4L,3L,3L,7L,1L,4L,3L,7L,1L,8L,1L,3L,4L,4L,3L,7L,1L,7L,2L,3L,1L,10L,3L,3L,3L,6L,1L,10L,3L,4L,3L,3L,3L,10L,1L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160097Inst : IEnumerable<long>
{
public static readonly long[] Value=A160097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160097.Bytes);
public long this[int i]=>Value[i];

public static A160097Inst Instance=new A160097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160098
{
public static readonly long[] Value={ 425L,601L,1261L,1289L,3005L,7141L,7309L,17429L,41585L,42565L,101569L,242369L,248081L,591985L,1412629L,1445921L,3450341L,8233405L,8427445L,20110061L,47987801L,49118749L,117210025L,279693401L,286285049L,683150089L,1630172605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160098Inst : IEnumerable<long>
{
public static readonly long[] Value=A160098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160098.Bytes);
public long this[int i]=>Value[i];

public static A160098Inst Instance=new A160098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160099
{
public static readonly long[] Value={ 2L,3L,8L,6L,2L,5L,8L,3L,5L,1L,2L,0L,1L,2L,5L,4L,1L,2L,7L,1L,1L,9L,9L,7L,6L,5L,1L,7L,0L,0L,4L,4L,1L,5L,6L,3L,5L,3L,4L,4L,6L,3L,0L,3L,5L,5L,9L,1L,9L,4L,0L,8L,1L,4L,4L,0L,7L,2L,9L,6L,5L,2L,7L,5L,3L,4L,1L,3L,0L,8L,1L,1L,3L,1L,4L,0L,0L,3L,4L,5L,1L,2L,8L,7L,7L,6L,4L,0L,5L,8L,1L,2L,7L,9L,4L,5L,7L,8L,6L,5L,8L,9L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160099Inst : IEnumerable<long>
{
public static readonly long[] Value=A160099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160099.Bytes);
public long this[int i]=>Value[i];

public static A160099Inst Instance=new A160099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160100
{
public static readonly long[] Value={ 1L,0L,2L,3L,5L,6L,7L,4L,0L,6L,2L,2L,5L,6L,7L,4L,6L,6L,7L,4L,0L,2L,2L,7L,7L,5L,3L,4L,9L,7L,0L,9L,6L,5L,4L,8L,3L,3L,9L,4L,2L,5L,8L,4L,5L,3L,4L,8L,8L,4L,8L,1L,0L,4L,2L,5L,0L,9L,2L,9L,8L,8L,2L,3L,7L,6L,0L,3L,0L,2L,0L,4L,3L,0L,3L,6L,5L,6L,2L,8L,4L,6L,9L,4L,9L,9L,2L,4L,8L,5L,0L,2L,3L,3L,6L,6L,3L,4L,3L,7L,6L,9L,1L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160100Inst : IEnumerable<long>
{
public static readonly long[] Value=A160100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160100.Bytes);
public long this[int i]=>Value[i];

public static A160100Inst Instance=new A160100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160101
{
public static readonly long[] Value={ 0L,1L,7L,2L,3L,5L,8L,13L,9L,4L,19L,11L,6L,17L,23L,10L,15L,25L,16L,29L,21L,14L,35L,31L,12L,37L,43L,20L,27L,41L,26L,49L,33L,22L,55L,47L,18L,53L,59L,28L,39L,61L,34L,65L,45L,32L,71L,67L,24L,73L,79L,38L,51L,77L,44L,85L,57L,40L,91L,83L,30L,89L,95L,46L,63L,97L,52L,101L,69L,50L,107L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160101Inst : IEnumerable<long>
{
public static readonly long[] Value=A160101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160101.Bytes);
public long this[int i]=>Value[i];

public static A160101Inst Instance=new A160101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160102
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,6L,11L,10L,13L,14L,17L,15L,19L,22L,21L,23L,29L,26L,31L,35L,33L,34L,37L,30L,41L,38L,39L,55L,43L,42L,47L,46L,51L,58L,77L,65L,53L,62L,57L,70L,59L,66L,61L,85L,91L,74L,67L,69L,71L,82L,87L,95L,73L,78L,119L,110L,93L,86L,79L,105L,83L,94L,143L,115L,133L,102L,89L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160102Inst : IEnumerable<long>
{
public static readonly long[] Value=A160102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160102.Bytes);
public long this[int i]=>Value[i];

public static A160102Inst Instance=new A160102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160103
{
public static readonly BigInteger[] Value={ 1L,8L,-1394L,-34480L,5821516L,247659488L,-40457575736L,-2490185806912L,392988531506320L,32189435503872128L,-4899280026394954016L,BigInteger.Parse("-508516209857615258368"),BigInteger.Parse("74506523384461350441664"),BigInteger.Parse("9493051794744527363939840"),BigInteger.Parse("-1336252229871124217359780736") };
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
public class A160103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160103Inst Instance=new A160103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160104
{
public static readonly BigInteger[] Value={ 1L,10L,-1358L,-42740L,5512492L,304384600L,-37142220680L,-3034178687600L,348731717384080L,38877977386007200L,-4187277821653825760L,BigInteger.Parse("-608713688504523233600"),BigInteger.Parse("61068424818638825202880"),BigInteger.Parse("11260738942261526747094400"),BigInteger.Parse("-1044883534589865025424443520") };
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
public class A160104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160104Inst Instance=new A160104Inst();

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