using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A177805
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,14L,16L,28L,32L,49L,56L,64L,98L,112L,128L,136L,196L,224L,256L,272L,343L,392L,448L,452L,512L,544L,686L,784L,812L,896L,904L,952L,1024L,1088L,1372L,1568L,1624L,1792L,1808L,1904L,2048L,2176L,2312L,2401L,2744L,3136L,3164L,3248L,3584L,3616L,3808L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177805Inst : IEnumerable<long>
{
public static readonly long[] Value=A177805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177805.Bytes);
public long this[int i]=>Value[i];

public static A177805Inst Instance=new A177805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177806
{
public static readonly long[] Value={ 1L,2L,0L,4L,4L,0L,1L,6L,6L,0L,5L,4L,9L,3L,0L,6L,9L,5L,11L,7L,0L,13L,15L,2L,9L,8L,16L,0L,14L,2L,16L,7L,11L,10L,5L,0L,3L,6L,16L,12L,8L,2L,18L,9L,0L,19L,21L,4L,20L,2L,5L,17L,11L,7L,0L,1L,25L,5L,25L,5L,5L,25L,25L,1L,1L,0L,13L,28L,2L,12L,27L,15L,32L,20L,29L,23L,6L,0L,37L,40L,16L,31L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177806Inst : IEnumerable<long>
{
public static readonly long[] Value=A177806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177806.Bytes);
public long this[int i]=>Value[i];

public static A177806Inst Instance=new A177806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177807
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,18L,20L,24L,32L,36L,40L,42L,48L,54L,60L,64L,72L,78L,80L,84L,96L,100L,108L,116L,120L,126L,128L,144L,156L,160L,162L,168L,180L,192L,200L,216L,220L,232L,234L,240L,252L,256L,288L,294L,300L,312L,320L,324L,336L,342L,348L,360L,378L,384L,400L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177807Inst : IEnumerable<long>
{
public static readonly long[] Value=A177807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177807.Bytes);
public long this[int i]=>Value[i];

public static A177807Inst Instance=new A177807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177808
{
public static readonly long[] Value={ 1L,1L,1L,1L,70L,1L,1L,495L,495L,1L,1L,1820L,12870L,1820L,1L,1L,4845L,125970L,125970L,4845L,1L,1L,10626L,735471L,2704156L,735471L,10626L,1L,1L,20475L,3108105L,30421755L,30421755L,3108105L,20475L,1L,1L,35960L,10518300L,225792840L,601080390L,225792840L,10518300L,35960L,1L,1L,58905L,30260340L,1251677700L,7307872110L,7307872110L,1251677700L,30260340L,58905L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177808Inst : IEnumerable<long>
{
public static readonly long[] Value=A177808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177808.Bytes);
public long this[int i]=>Value[i];

public static A177808Inst Instance=new A177808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177809
{
public static readonly long[] Value={ 1L,1L,1L,1L,252L,1L,1L,3003L,3003L,1L,1L,15504L,184756L,15504L,1L,1L,53130L,3268760L,3268760L,53130L,1L,1L,142506L,30045015L,155117520L,30045015L,142506L,1L,1L,324632L,183579396L,3247943160L,3247943160L,183579396L,324632L,1L,1L,658008L,847660528L,40225345056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177809Inst : IEnumerable<long>
{
public static readonly long[] Value=A177809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177809.Bytes);
public long this[int i]=>Value[i];

public static A177809Inst Instance=new A177809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177810
{
public static readonly long[] Value={ 1L,1L,1L,1L,924L,1L,1L,18564L,18564L,1L,1L,134596L,2704156L,134596L,1L,1L,593775L,86493225L,86493225L,593775L,1L,1L,1947792L,1251677700L,9075135300L,1251677700L,1947792L,1L,1L,5245786L,11058116888L,353697121050L,353697121050L,11058116888L,5245786L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177810Inst : IEnumerable<long>
{
public static readonly long[] Value=A177810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177810.Bytes);
public long this[int i]=>Value[i];

public static A177810Inst Instance=new A177810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177811
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,156190L,1L,1L,423281535L,423281535L,1L,1L,473353301060L,114890380658550L,473353301060L,1L,1L,382493246941965L,5119020713873609970L,5119020713873609970L,382493246941965L,1L,1L,269025107855605626L,BigInteger.Parse("101955892318210543172751"),BigInteger.Parse("4179647109945703200884716"),BigInteger.Parse("101955892318210543172751"),269025107855605626L };
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
public class A177811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177811Inst Instance=new A177811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177812
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,1L,5L,5L,1L,6L,15L,1L,7L,35L,1L,8L,70L,1L,9L,126L,1L,1L,10L,210L,10L,1L,11L,330L,55L,1L,12L,495L,220L,1L,13L,715L,715L,1L,14L,1001L,2002L,1L,15L,1365L,5005L,1L,16L,1820L,11440L,1L,1L,17L,2380L,24310L,17L,1L,18L,3060L,48620L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177812Inst : IEnumerable<long>
{
public static readonly long[] Value=A177812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177812.Bytes);
public long this[int i]=>Value[i];

public static A177812Inst Instance=new A177812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177813
{
public static readonly long[] Value={ 1L,7L,203L,11977L,154553L,353423L,3049963L,4482037L,5192537L,7170569L,9904979L,20851957L,33461911L,35852033L,69262991L,88448927L,160274303L,264440183L,306359683L,381231473L,423063571L,978466699L,1974252749L,2115269947L,4647954787L,5218486693L,6824905927L,7803226417L,9040206917L,10041409007L,11055712717L,12483960629L,17244568439L,47773414171L,57280493557L,57729535241L,58257187051L,62418389453L,67340133077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177813Inst : IEnumerable<long>
{
public static readonly long[] Value=A177813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177813.Bytes);
public long this[int i]=>Value[i];

public static A177813Inst Instance=new A177813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177814
{
public static readonly long[] Value={ 1L,3L,5L,15L,57L,183L,285L,355L,505L,915L,1065L,1515L,2005L,2265L,3477L,6015L,10887L,12165L,17385L,20005L,20235L,27015L,28785L,35855L,43035L,54435L,60015L,64965L,92415L,107565L,114285L,134139L,138165L,142355L,160815L,201995L,202505L,228765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177814Inst : IEnumerable<long>
{
public static readonly long[] Value=A177814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177814.Bytes);
public long this[int i]=>Value[i];

public static A177814Inst Instance=new A177814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177815
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,1L,7L,1L,8L,1L,1L,9L,9L,1L,10L,45L,1L,11L,165L,1L,12L,495L,1L,13L,1287L,1L,14L,3003L,1L,15L,6435L,1L,16L,12870L,1L,17L,24310L,1L,18L,43758L,1L,19L,75582L,1L,20L,125970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177815Inst : IEnumerable<long>
{
public static readonly long[] Value=A177815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177815.Bytes);
public long this[int i]=>Value[i];

public static A177815Inst Instance=new A177815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177816
{
public static readonly long[] Value={ 1L,17L,707489L,5030929L,6029713L,209372172193L,250938565921L,1413292053713L,1784415176081L,24025953593297L,48948914347889L,1423524187400657L,5817190224008753L,49446116858851553L,74262006382962977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177816Inst : IEnumerable<long>
{
public static readonly long[] Value=A177816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177816.Bytes);
public long this[int i]=>Value[i];

public static A177816Inst Instance=new A177816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177817
{
public static readonly long[] Value={ 1L,3L,9L,21L,39L,63L,117L,273L,819L,1467L,2067L,3081L,4269L,6201L,7299L,9243L,10269L,12807L,14469L,16959L,19071L,20421L,21567L,23877L,29883L,43407L,48711L,50877L,51093L,55497L,64701L,89649L,94887L,118713L,133497L,142947L,146133L,149331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177817Inst : IEnumerable<long>
{
public static readonly long[] Value=A177817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177817.Bytes);
public long this[int i]=>Value[i];

public static A177817Inst Instance=new A177817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177818
{
public static readonly long[] Value={ 1L,19L,397841L,1152331L,3566699L,24128658809L,74683110361L,216316727651L,1339092172657L,7967201553697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177818Inst : IEnumerable<long>
{
public static readonly long[] Value=A177818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177818.Bytes);
public long this[int i]=>Value[i];

public static A177818Inst Instance=new A177818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177819
{
public static readonly long[] Value={ 1L,5L,55L,1265L,11255L,59455L,123805L,395755L,635255L,874115L,1028555L,1456015L,2847515L,3201715L,3841805L,4353305L,6655055L,6987805L,13443155L,16825765L,23656765L,36370015L,41083405L,66919765L,68432705L,100126015L,123012395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177819Inst : IEnumerable<long>
{
public static readonly long[] Value=A177819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177819.Bytes);
public long this[int i]=>Value[i];

public static A177819Inst Instance=new A177819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177820
{
public static readonly long[] Value={ 1L,3L,7L,21L,381L,903L,921L,2667L,5789L,6447L,17367L,18543L,73703L,114681L,116967L,208443L,221109L,277221L,746781L,797349L,818769L,855141L,871347L,1459101L,2205609L,2354961L,5090367L,5331669L,5692701L,6099429L,7611387L,8710041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177820Inst : IEnumerable<long>
{
public static readonly long[] Value=A177820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177820.Bytes);
public long this[int i]=>Value[i];

public static A177820Inst Instance=new A177820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177821
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,6L,6L,8L,12L,14L,18L,23L,27L,34L,43L,52L,62L,79L,93L,109L,138L,159L,187L,236L,270L,316L,385L,443L,518L,620L,719L,836L,983L,1138L,1314L,1541L,1770L,2041L,2388L,2726L,3122L,3628L,4124L,4720L,5459L,6204L,7063L,8116L,9203L,10440L,11940L,13525L,15306L,17436L,19690L,22231L,25208L,28388L,32013L,36217L,40673L,45729L,51575L,57808L,64817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177821Inst : IEnumerable<long>
{
public static readonly long[] Value=A177821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177821.Bytes);
public long this[int i]=>Value[i];

public static A177821Inst Instance=new A177821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177822
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,11L,1L,26L,1L,1L,57L,57L,1L,120L,1191L,1L,247L,15619L,1L,502L,156190L,1L,1013L,1310354L,1L,1L,2036L,9738114L,2036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177822Inst : IEnumerable<long>
{
public static readonly long[] Value=A177822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177822.Bytes);
public long this[int i]=>Value[i];

public static A177822Inst Instance=new A177822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177823
{
public static readonly long[] Value={ 1L,1L,1L,1L,16L,1L,1L,121L,121L,1L,1L,676L,4356L,676L,1L,1L,3249L,91204L,91204L,3249L,1L,1L,14400L,1418481L,5837056L,1418481L,14400L,1L,1L,61009L,18429849L,243953161L,243953161L,18429849L,61009L,1L,1L,252004L,213393664L,7785238756L,24395316100L,7785238756L,213393664L,252004L,1L,1L,1026169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177823Inst : IEnumerable<long>
{
public static readonly long[] Value=A177823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177823.Bytes);
public long this[int i]=>Value[i];

public static A177823Inst Instance=new A177823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177824
{
public static readonly long[] Value={ 0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L,0L,0L,6L,5L,1L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177824Inst : IEnumerable<long>
{
public static readonly long[] Value=A177824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177824.Bytes);
public long this[int i]=>Value[i];

public static A177824Inst Instance=new A177824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177825
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,2L,0L,1L,0L,3L,0L,2L,-2L,4L,-1L,5L,-5L,6L,-5L,11L,-10L,12L,-15L,22L,-21L,28L,-36L,44L,-48L,65L,-79L,93L,-112L,145L,-171L,206L,-256L,317L,-376L,463L,-572L,694L,-838L,1036L,-1265L,1533L,-1873L,2302L,-2797L,3407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177825Inst : IEnumerable<long>
{
public static readonly long[] Value=A177825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177825.Bytes);
public long this[int i]=>Value[i];

public static A177825Inst Instance=new A177825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177826
{
public static readonly long[] Value={ 1L,1L,1L,1L,230L,1L,1L,10543L,10543L,1L,1L,331612L,4675014L,331612L,1L,1L,9116141L,906923282L,906923282L,9116141L,1L,1L,237231970L,121383780207L,743288515164L,121383780207L,237231970L,1L,1L,6031771195L,13342139253321L,342917527152507L,342917527152507L,13342139253321L,6031771195L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177826Inst : IEnumerable<long>
{
public static readonly long[] Value=A177826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177826.Bytes);
public long this[int i]=>Value[i];

public static A177826Inst Instance=new A177826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177827
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,23548L,1L,1L,21707972L,21707972L,1L,1L,10708911188L,743288515164L,10708911188L,1L,1L,4261002128223L,6453703025399873L,6453703025399873L,4261002128223L,1L,1L,1556000598766224L,BigInteger.Parse("30920009116692763140"),BigInteger.Parse("527896878148304296900"),BigInteger.Parse("30920009116692763140") };
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
public class A177827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177827Inst Instance=new A177827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177828
{
public static readonly long[] Value={ 3L,2L,6L,4L,20L,10L,20L,6L,24L,6L,34L,26L,4L,26L,40L,44L,4L,12L,14L,6L,4L,30L,26L,16L,32L,18L,22L,2L,24L,12L,4L,44L,24L,6L,16L,14L,6L,48L,16L,14L,10L,38L,4L,26L,18L,34L,2L,4L,2L,24L,30L,70L,14L,16L,14L,34L,56L,22L,8L,6L,58L,50L,6L,84L,46L,56L,16L,8L,12L,52L,12L,20L,70L,8L,6L,10L,32L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177828Inst : IEnumerable<long>
{
public static readonly long[] Value=A177828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177828.Bytes);
public long this[int i]=>Value[i];

public static A177828Inst Instance=new A177828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177829
{
public static readonly long[] Value={ 2L,28L,47L,49L,135L,173L,225L,258L,375L,384L,439L,507L,525L,545L,552L,570L,577L,583L,600L,629L,665L,691L,784L,818L,855L,886L,1024L,1050L,1076L,1095L,1187L,1245L,1259L,1306L,1367L,1448L,1495L,1501L,1614L,1618L,1646L,1655L,1720L,1812L,1826L,1832L,1843L,1861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177829Inst : IEnumerable<long>
{
public static readonly long[] Value=A177829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177829.Bytes);
public long this[int i]=>Value[i];

public static A177829Inst Instance=new A177829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177830
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,2L,4L,4L,4L,6L,2L,2L,4L,2L,2L,4L,2L,2L,2L,2L,6L,2L,4L,4L,4L,2L,4L,2L,4L,2L,2L,6L,2L,2L,2L,2L,2L,2L,4L,2L,4L,2L,2L,4L,4L,2L,4L,2L,2L,4L,2L,4L,4L,2L,2L,2L,4L,2L,2L,4L,2L,2L,4L,4L,2L,2L,4L,2L,2L,2L,2L,6L,4L,2L,4L,2L,2L,2L,2L,4L,2L,4L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177830Inst : IEnumerable<long>
{
public static readonly long[] Value=A177830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177830.Bytes);
public long this[int i]=>Value[i];

public static A177830Inst Instance=new A177830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177831
{
public static readonly long[] Value={ 5L,29L,53L,173L,293L,1373L,2213L,4493L,5333L,9413L,10613L,18773L,26573L,27893L,37253L,54293L,76733L,78977L,85853L,94253L,97973L,100493L,120413L,139133L,151337L,177257L,192737L,212557L,214373L,237173L,249017L,253013L,299213L,326057L,332933L,351653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177831Inst : IEnumerable<long>
{
public static readonly long[] Value=A177831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177831.Bytes);
public long this[int i]=>Value[i];

public static A177831Inst Instance=new A177831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177832
{
public static readonly long[] Value={ 1L,2L,2L,16L,32L,118L,14L,22L,12L,110L,232L,4L,48L,46L,78L,624L,104L,1348L,306L,30L,834L,400L,402L,2L,66L,8L,316L,618L,390L,560L,996L,1086L,774L,178L,300L,1912L,1792L,120L,614L,2024L,1854L,1258L,698L,966L,602L,2668L,3712L,294L,560L,108L,524L,3962L,2838L,870L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177832Inst : IEnumerable<long>
{
public static readonly long[] Value=A177832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177832.Bytes);
public long this[int i]=>Value[i];

public static A177832Inst Instance=new A177832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177833
{
public static readonly long[] Value={ 4L,12L,18L,72L,84L,114L,198L,354L,378L,588L,612L,618L,864L,912L,948L,1032L,1068L,1134L,1320L,1410L,1428L,1452L,1500L,1830L,1956L,2046L,2058L,2172L,2298L,2448L,2634L,2748L,2844L,2856L,3192L,3246L,3390L,3474L,3846L,3906L,4092L,4182L,4506L,4842L,4884L,4890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177833Inst : IEnumerable<long>
{
public static readonly long[] Value=A177833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177833.Bytes);
public long this[int i]=>Value[i];

public static A177833Inst Instance=new A177833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177834
{
public static readonly long[] Value={ 1L,2L,6L,12L,45L,54L,56L,56L,245L,504L,1440L,1440L,5044L,5044L,10456L,10569L,11704L,11704L,11704L,13608L,13608L,13608L,26460L,26460L,198007L,258064L,264600L,264600L,475440L,475440L,1754608L,1754608L,2258064L,2258064L,2646004L,2646004L,2992520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177834Inst : IEnumerable<long>
{
public static readonly long[] Value=A177834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177834.Bytes);
public long this[int i]=>Value[i];

public static A177834Inst Instance=new A177834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177835
{
public static readonly long[] Value={ 17L,37L,41L,67L,73L,97L,131L,137L,139L,149L,163L,193L,197L,257L,263L,269L,277L,281L,293L,337L,353L,389L,401L,449L,521L,523L,547L,577L,593L,641L,643L,673L,769L,773L,1031L,1033L,1039L,1049L,1051L,1061L,1063L,1069L,1091L,1093L,1097L,1109L,1123L,1129L,1153L,1163L,1171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177835Inst : IEnumerable<long>
{
public static readonly long[] Value=A177835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177835.Bytes);
public long this[int i]=>Value[i];

public static A177835Inst Instance=new A177835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177836
{
public static readonly long[] Value={ 2L,541L,557L,563L,569L,587L,601L,613L,617L,647L,653L,659L,661L,677L,709L,787L,809L,929L,2141L,2203L,2221L,2251L,2281L,2333L,2347L,2357L,2381L,2389L,2393L,2417L,2467L,2473L,2617L,2659L,2699L,2707L,2713L,2729L,2837L,2851L,2857L,2897L,2953L,3221L,3347L,3461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177836Inst : IEnumerable<long>
{
public static readonly long[] Value=A177836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177836.Bytes);
public long this[int i]=>Value[i];

public static A177836Inst Instance=new A177836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177837
{
public static readonly BigInteger[] Value={ 1L,25L,1891L,302621L,84957251L,37307689133L,23728431347335L,20688443967788245L,BigInteger.Parse("23730591032609929084"),BigInteger.Parse("34687456062438088435890"),BigInteger.Parse("62994291032837018079196115"),BigInteger.Parse("139227352512368728514134480110") };
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
public class A177837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177837Inst Instance=new A177837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177838
{
public static readonly long[] Value={ 1L,0L,6L,1L,5L,5L,2L,2L,3L,1L,8L,4L,5L,7L,1L,9L,8L,4L,2L,9L,2L,7L,5L,3L,0L,6L,8L,6L,2L,5L,0L,2L,1L,8L,0L,2L,7L,5L,3L,5L,0L,0L,7L,5L,2L,2L,5L,0L,6L,1L,2L,3L,0L,9L,8L,7L,9L,9L,4L,0L,3L,8L,1L,9L,6L,2L,3L,0L,6L,3L,1L,1L,1L,0L,1L,4L,7L,2L,3L,1L,8L,3L,8L,9L,9L,6L,4L,9L,7L,6L,6L,2L,3L,2L,2L,6L,8L,9L,9L,0L,8L,6L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177838Inst : IEnumerable<long>
{
public static readonly long[] Value=A177838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177838.Bytes);
public long this[int i]=>Value[i];

public static A177838Inst Instance=new A177838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177839
{
public static readonly long[] Value={ 4L,9L,4L,1L,6L,5L,9L,6L,4L,0L,2L,4L,2L,3L,3L,4L,6L,1L,7L,7L,6L,2L,2L,7L,0L,0L,3L,9L,0L,0L,1L,9L,1L,8L,6L,4L,2L,3L,0L,8L,0L,6L,6L,1L,9L,8L,0L,5L,3L,8L,8L,3L,2L,6L,9L,4L,3L,4L,7L,5L,3L,6L,1L,2L,6L,8L,2L,9L,5L,5L,3L,7L,6L,9L,2L,9L,5L,6L,4L,0L,1L,8L,3L,1L,6L,9L,1L,7L,9L,4L,2L,8L,4L,3L,9L,6L,7L,1L,1L,9L,6L,0L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177839Inst : IEnumerable<long>
{
public static readonly long[] Value=A177839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177839.Bytes);
public long this[int i]=>Value[i];

public static A177839Inst Instance=new A177839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177840
{
public static readonly BigInteger[] Value={ 1L,21L,653L,37577L,3434169L,457819549L,83900098309L,20238575173137L,6217167231292913L,2369809434953636261L,BigInteger.Parse("1097587512530348834301"),BigInteger.Parse("607119566298408076479961"),BigInteger.Parse("395312612701784187384578473"),BigInteger.Parse("299298318246814086742418737197"),BigInteger.Parse("260721599469397754183307347278709") };
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
public class A177840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177840Inst Instance=new A177840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177841
{
public static readonly long[] Value={ 1L,4L,1L,9L,0L,0L,4L,9L,1L,0L,5L,2L,2L,7L,5L,0L,3L,9L,4L,4L,7L,2L,2L,8L,6L,3L,0L,0L,9L,9L,5L,0L,9L,9L,7L,6L,0L,8L,1L,7L,7L,8L,4L,6L,7L,9L,5L,5L,1L,4L,9L,0L,1L,1L,1L,4L,6L,8L,7L,9L,2L,4L,8L,6L,4L,4L,6L,5L,5L,9L,8L,0L,8L,1L,9L,8L,6L,5L,4L,8L,3L,2L,7L,5L,8L,2L,7L,4L,0L,3L,2L,8L,7L,6L,7L,1L,1L,5L,0L,7L,1L,9L,4L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177841Inst : IEnumerable<long>
{
public static readonly long[] Value=A177841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177841.Bytes);
public long this[int i]=>Value[i];

public static A177841Inst Instance=new A177841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177842
{
public static readonly long[] Value={ 1L,81L,81L,3L,81L,81L,9L,81L,81L,3L,81L,81L,3L,81L,81L,9L,81L,81L,3L,81L,81L,1L,81L,81L,9L,81L,81L,1L,81L,81L,3L,81L,81L,9L,81L,81L,3L,81L,81L,3L,81L,81L,9L,81L,81L,3L,81L,81L,1L,81L,81L,9L,81L,81L,1L,81L,81L,3L,81L,81L,9L,81L,81L,3L,81L,81L,3L,81L,81L,9L,81L,81L,3L,81L,81L,1L,81L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177842Inst : IEnumerable<long>
{
public static readonly long[] Value=A177842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177842.Bytes);
public long this[int i]=>Value[i];

public static A177842Inst Instance=new A177842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177843
{
public static readonly long[] Value={ 775L,8919L,49581L,197469L,788157L,3149181L,12589821L,50345469L,201354237L,805361661L,3221336061L,12885123069L,51540049917L,206159314941L,824635490301L,3298538422269L,13194146611197L,52776572289021L,211106260844541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177843Inst : IEnumerable<long>
{
public static readonly long[] Value=A177843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177843.Bytes);
public long this[int i]=>Value[i];

public static A177843Inst Instance=new A177843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177844
{
public static readonly long[] Value={ 279L,3996L,16008L,64784L,260640L,1045568L,4188288L,16765184L,67084800L,268387328L,1073645568L,4294774784L,17179484160L,68718706688L,274876366848L,1099508547584L,4398040350720L,17592173723648L,70368719536128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177844Inst : IEnumerable<long>
{
public static readonly long[] Value=A177844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177844.Bytes);
public long this[int i]=>Value[i];

public static A177844Inst Instance=new A177844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177845
{
public static readonly long[] Value={ 775L,8919L,34223L,133983L,530111L,2108799L,8411903L,33601023L,134310911L,537057279L,2147856383L,8590680063L,34361229311L,137441935359L,549761777663L,2199035183103L,8796116877311L,35184419799039L,140737583775743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177845Inst : IEnumerable<long>
{
public static readonly long[] Value=A177845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177845.Bytes);
public long this[int i]=>Value[i];

public static A177845Inst Instance=new A177845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177846
{
public static readonly long[] Value={ 837L,7896L,32176L,129888L,521920L,2092416L,8379136L,33535488L,134179840L,536795136L,2147332096L,8589631488L,34359132160L,137437741056L,549753389056L,2199018405888L,8796083322880L,35184352690176L,140737449558016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177846Inst : IEnumerable<long>
{
public static readonly long[] Value=A177846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177846.Bytes);
public long this[int i]=>Value[i];

public static A177846Inst Instance=new A177846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177847
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,6L,60L,60L,6L,24L,2016L,12096L,2016L,24L,120L,120960L,7983360L,7983360L,120960L,120L,720L,11404800L,12454041600L,149448499200L,12454041600L,11404800L,720L,5040L,1556755200L,38109367296000L,8688935743488000L,8688935743488000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177847Inst : IEnumerable<long>
{
public static readonly long[] Value=A177847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177847.Bytes);
public long this[int i]=>Value[i];

public static A177847Inst Instance=new A177847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177848
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,55L,55L,1L,1L,1993L,12073L,1993L,1L,1L,120841L,7983241L,7983241L,120841L,1L,1L,11404081L,12454040881L,149448498481L,12454040881L,11404081L,1L,1L,1556750161L,38109367290961L,8688935743482961L,8688935743482961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177848Inst : IEnumerable<long>
{
public static readonly long[] Value=A177848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177848.Bytes);
public long this[int i]=>Value[i];

public static A177848Inst Instance=new A177848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177849
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177849Inst : IEnumerable<long>
{
public static readonly long[] Value=A177849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177849.Bytes);
public long this[int i]=>Value[i];

public static A177849Inst Instance=new A177849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177850
{
public static readonly long[] Value={ 149L,1009L,10009L,100049L,1000849L,10000169L,100000891L,1000000009L,10000001041L,100000000669L,1000000000091L,10000000001011L,100000000000469L,1000000000004449L,10000000000001101L,100000000000000049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177850Inst : IEnumerable<long>
{
public static readonly long[] Value=A177850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177850.Bytes);
public long this[int i]=>Value[i];

public static A177850Inst Instance=new A177850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177851
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,7L,4L,9L,16L,25L,5L,14L,30L,55L,91L,6L,20L,50L,105L,196L,336L,7L,27L,77L,182L,378L,714L,1254L,8L,35L,112L,294L,672L,1386L,2640L,4719L,9L,44L,156L,450L,1122L,2508L,5148L,9867L,17875L,10L,54L,210L,660L,1782L,4290L,9438L,19305L,37180L,68068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177851Inst : IEnumerable<long>
{
public static readonly long[] Value=A177851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177851.Bytes);
public long this[int i]=>Value[i];

public static A177851Inst Instance=new A177851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177852
{
public static readonly long[] Value={ 0L,2L,2L,6L,7L,9L,7L,9L,18L,24L,30L,17L,21L,28L,41L,38L,53L,55L,32L,36L,38L,58L,48L,54L,62L,66L,82L,86L,88L,78L,126L,75L,81L,69L,79L,95L,101L,93L,111L,117L,123L,125L,183L,137L,127L,143L,155L,215L,171L,173L,177L,231L,185L,243L,221L,137L,143L,145L,151L,155L,157L,167L,181L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177852Inst : IEnumerable<long>
{
public static readonly long[] Value=A177852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177852.Bytes);
public long this[int i]=>Value[i];

public static A177852Inst Instance=new A177852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177853
{
public static readonly long[] Value={ 1L,4L,11L,22L,41L,64L,99L,142L,197L,260L,343L,434L,549L,676L,819L,978L,1169L,1372L,1611L,1866L,2145L,2444L,2787L,3146L,3545L,3968L,4427L,4910L,5449L,6004L,6619L,7266L,7953L,8672L,9439L,10230L,11093L,11992L,12939L,13918L,14977L,16060L,17227L,18434L,19689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177853Inst : IEnumerable<long>
{
public static readonly long[] Value=A177853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177853.Bytes);
public long this[int i]=>Value[i];

public static A177853Inst Instance=new A177853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177854
{
public static readonly long[] Value={ 2L,3L,11L,131L,1571L,43717L,5032843L,1047774137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177854Inst : IEnumerable<long>
{
public static readonly long[] Value=A177854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177854.Bytes);
public long this[int i]=>Value[i];

public static A177854Inst Instance=new A177854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177855
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,15L,21L,29L,35L,39L,43L,45L,49L,53L,63L,65L,79L,87L,91L,105L,113L,117L,127L,129L,145L,147L,157L,159L,169L,195L,203L,215L,237L,245L,261L,265L,273L,301L,313L,315L,337L,339L,371L,377L,381L,387L,395L,435L,441L,455L,471L,477L,507L,547L,553L,559L,565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177855Inst : IEnumerable<long>
{
public static readonly long[] Value=A177855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177855.Bytes);
public long this[int i]=>Value[i];

public static A177855Inst Instance=new A177855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177856
{
public static readonly long[] Value={ 1L,2L,10L,13L,14L,23L,31L,32L,40L,41L,100L,1000L,10000L,24000L,42000L,100000L,318317L,713813L,1000000L,10000000L,43029128L,82192034L,100000000L,1000000000L,3632590347L,7430952363L,10000000000L,100000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177856Inst : IEnumerable<long>
{
public static readonly long[] Value=A177856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177856.Bytes);
public long this[int i]=>Value[i];

public static A177856Inst Instance=new A177856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177857
{
public static readonly long[] Value={ 21303L,114143L,148507L,204732L,1044976L,15413568L,3369375L,3926151L,7019351L,7907868L,7942460L,9055625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177857Inst : IEnumerable<long>
{
public static readonly long[] Value=A177857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177857.Bytes);
public long this[int i]=>Value[i];

public static A177857Inst Instance=new A177857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177858
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,3L,0L,1L,3L,4L,2L,1L,1L,3L,6L,4L,4L,0L,1L,3L,9L,9L,8L,0L,1L,1L,3L,12L,13L,20L,0L,5L,0L,1L,4L,12L,23L,31L,8L,14L,4L,0L,1L,4L,16L,29L,48L,24L,38L,9L,3L,0L,1L,4L,18L,42L,73L,52L,72L,29L,17L,1L,0L,1L,4L,21L,53L,111L,80L,151L,81L,52L,5L,5L,0L,1L,4L,23L,62L,152L,158L,256L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177858Inst : IEnumerable<long>
{
public static readonly long[] Value=A177858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177858.Bytes);
public long this[int i]=>Value[i];

public static A177858Inst Instance=new A177858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177859
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,9L,10L,12L,14L,16L,18L,19L,20L,21L,22L,23L,25L,27L,28L,29L,30L,31L,33L,34L,36L,38L,39L,40L,41L,42L,43L,44L,45L,47L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,64L,66L,67L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,82L,83L,84L,85L,86L,87L,88L,90L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177859Inst : IEnumerable<long>
{
public static readonly long[] Value=A177859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177859.Bytes);
public long this[int i]=>Value[i];

public static A177859Inst Instance=new A177859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177860
{
public static readonly BigInteger[] Value={ 1L,1L,4L,8L,540L,12960L,1797120L,22619520L,465813504L,267346759680000L,216218419200000L,BigInteger.Parse("199658024013127680000"),BigInteger.Parse("136256285631578112000000"),BigInteger.Parse("12446179270879850496000000"),BigInteger.Parse("34611344543529418987929600") };
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
public class A177860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177860Inst Instance=new A177860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177861
{
public static readonly BigInteger[] Value={ 1L,2L,6L,90L,6720L,36960L,11642400L,283046400L,2412984420000L,1140422816332800L,1226781977195174400L,BigInteger.Parse("1863152400854384640000"),BigInteger.Parse("5988092802221559085056000"),BigInteger.Parse("112886540292742916603904000"),BigInteger.Parse("158983195607776600998537600000000") };
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
public class A177861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177861Inst Instance=new A177861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177862
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,6L,7L,5L,8L,9L,10L,11L,6L,10L,12L,13L,14L,15L,16L,7L,12L,15L,16L,17L,18L,19L,20L,21L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177862Inst : IEnumerable<long>
{
public static readonly long[] Value=A177862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177862.Bytes);
public long this[int i]=>Value[i];

public static A177862Inst Instance=new A177862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177863
{
public static readonly long[] Value={ 1L,2L,1L,6L,10L,1L,1L,18L,22L,1L,30L,1L,1L,42L,46L,1L,58L,1L,66L,70L,1L,78L,82L,1L,1L,1L,102L,106L,1L,1L,126L,130L,1L,138L,1L,150L,1L,162L,166L,1L,178L,1L,190L,1L,1L,198L,210L,222L,226L,1L,1L,238L,1L,250L,1L,262L,1L,270L,1L,1L,282L,1L,306L,310L,1L,1L,330L,1L,346L,1L,1L,358L,366L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177863Inst : IEnumerable<long>
{
public static readonly long[] Value=A177863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177863.Bytes);
public long this[int i]=>Value[i];

public static A177863Inst Instance=new A177863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177864
{
public static readonly long[] Value={ 4L,2L,3L,3L,2L,4L,2L,4L,2L,3L,2L,4L,2L,4L,3L,3L,4L,2L,2L,2L,3L,2L,2L,4L,2L,3L,3L,2L,2L,3L,2L,4L,4L,2L,3L,4L,2L,4L,3L,3L,2L,2L,4L,2L,4L,2L,3L,3L,2L,2L,2L,3L,2L,2L,4L,2L,3L,2L,4L,4L,4L,2L,2L,4L,4L,2L,3L,3L,2L,2L,2L,3L,4L,2L,4L,3L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,4L,2L,3L,2L,2L,3L,4L,2L,4L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177864Inst : IEnumerable<long>
{
public static readonly long[] Value=A177864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177864.Bytes);
public long this[int i]=>Value[i];

public static A177864Inst Instance=new A177864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177865
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,2L,3L,5L,3L,6L,4L,4L,5L,8L,5L,9L,4L,6L,10L,5L,10L,9L,6L,6L,7L,10L,9L,6L,6L,10L,15L,7L,9L,7L,14L,8L,9L,18L,9L,15L,7L,19L,8L,11L,18L,12L,15L,15L,9L,10L,22L,8L,21L,10L,21L,11L,22L,14L,10L,13L,11L,14L,25L,11L,13L,14L,12L,17L,12L,12L,27L,19L,16L,15L,27L,12L,12L,12L,12L,27L,11L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177865Inst : IEnumerable<long>
{
public static readonly long[] Value=A177865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177865.Bytes);
public long this[int i]=>Value[i];

public static A177865Inst Instance=new A177865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177866
{
public static readonly long[] Value={ 2L,4L,6L,7L,8L,14L,20L,110L,138L,140L,145L,300L,390L,1484L,3194L,3300L,3950L,4986L,5574L,5630L,5874L,8866L,11390L,45130L,86110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177866Inst : IEnumerable<long>
{
public static readonly long[] Value=A177866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177866.Bytes);
public long this[int i]=>Value[i];

public static A177866Inst Instance=new A177866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177867
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,14L,20L,24L,30L,36L,54L,68L,72L,84L,94L,102L,120L,134L,138L,168L,198L,258L,310L,320L,328L,338L,348L,360L,370L,390L,426L,446L,450L,510L,574L,588L,624L,660L,672L,692L,728L,754L,760L,778L,804L,870L,940L,974L,996L,1014L,1030L,1036L,1040L,1044L,1086L,1142L,1166L,1174L,1180L,1194L,1206L,1210L,1212L,1230L,1248L,1260L,1280L,1292L,1296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177867Inst : IEnumerable<long>
{
public static readonly long[] Value=A177867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177867.Bytes);
public long this[int i]=>Value[i];

public static A177867Inst Instance=new A177867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177868
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177868Inst : IEnumerable<long>
{
public static readonly long[] Value=A177868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177868.Bytes);
public long this[int i]=>Value[i];

public static A177868Inst Instance=new A177868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177869
{
public static readonly long[] Value={ 1L,2L,6L,8L,12L,20L,25L,30L,36L,42L,48L,54L,60L,70L,77L,84L,91L,98L,105L,112L,119L,126L,128L,136L,144L,152L,160L,168L,176L,184L,192L,200L,208L,216L,224L,232L,240L,248L,261L,270L,279L,288L,297L,306L,315L,324L,333L,342L,351L,360L,369L,378L,387L,396L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177869Inst : IEnumerable<long>
{
public static readonly long[] Value=A177869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177869.Bytes);
public long this[int i]=>Value[i];

public static A177869Inst Instance=new A177869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177870
{
public static readonly long[] Value={ 2L,3L,5L,6L,1L,9L,4L,4L,9L,0L,1L,9L,2L,3L,4L,4L,9L,2L,8L,8L,4L,6L,9L,8L,2L,5L,3L,7L,4L,5L,9L,6L,2L,7L,1L,6L,3L,1L,4L,7L,8L,7L,7L,0L,4L,9L,5L,3L,1L,3L,2L,9L,3L,6L,5L,7L,3L,1L,2L,0L,8L,4L,4L,4L,2L,3L,0L,8L,6L,2L,3L,0L,4L,7L,1L,4L,6L,5L,6L,7L,4L,8L,9L,7L,1L,0L,2L,6L,1L,1L,9L,0L,0L,6L,5L,8L,7L,8L,0L,0L,9L,8L,6L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177870Inst : IEnumerable<long>
{
public static readonly long[] Value=A177870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177870.Bytes);
public long this[int i]=>Value[i];

public static A177870Inst Instance=new A177870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177871
{
public static readonly long[] Value={ 60L,120L,210L,420L,840L,1260L,1680L,2310L,2730L,3360L,4620L,5460L,6930L,7140L,9240L,10920L,13860L,14280L,15960L,16380L,18480L,21840L,27720L,28560L,30030L,31920L,32760L,36960L,39270L,43680L,43890L,46410L,55440L,57120L,60060L,73920L,78540L,87360L,87780L,90090L,92820L,103740L,106260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177871Inst : IEnumerable<long>
{
public static readonly long[] Value=A177871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177871.Bytes);
public long this[int i]=>Value[i];

public static A177871Inst Instance=new A177871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177872
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,15L,22L,29L,33L,37L,38L,40L,44L,47L,51L,55L,56L,65L,66L,73L,74L,77L,78L,79L,83L,87L,88L,90L,92L,97L,99L,100L,101L,110L,111L,113L,117L,121L,124L,125L,131L,141L,143L,144L,146L,149L,151L,161L,163L,164L,167L,169L,171L,174L,181L,187L,189L,191L,198L,202L,209L,212L,222L,226L,232L,242L,252L,262L,263L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177872Inst : IEnumerable<long>
{
public static readonly long[] Value=A177872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177872.Bytes);
public long this[int i]=>Value[i];

public static A177872Inst Instance=new A177872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177873
{
public static readonly long[] Value={ 29L,37L,47L,73L,79L,83L,97L,113L,149L,163L,167L,263L,277L,283L,311L,317L,349L,359L,389L,421L,433L,449L,461L,509L,521L,607L,617L,641L,761L,941L,953L,983L,1009L,1021L,1031L,1033L,1069L,1097L,1109L,1153L,1181L,1193L,1201L,1213L,1231L,1237L,1283L,1301L,1321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177873Inst : IEnumerable<long>
{
public static readonly long[] Value=A177873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177873.Bytes);
public long this[int i]=>Value[i];

public static A177873Inst Instance=new A177873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177874
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,19L,37L,74L,147L,293L,586L,1172L,2343L,4686L,9371L,18742L,37484L,74967L,149933L,299866L,599731L,1199461L,2398922L,4797844L,9595688L,19191376L,38382751L,76765501L,153531001L,307062002L,614124003L,1228248006L,2456496012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177874Inst : IEnumerable<long>
{
public static readonly long[] Value=A177874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177874.Bytes);
public long this[int i]=>Value[i];

public static A177874Inst Instance=new A177874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177875
{
public static readonly BigInteger[] Value={ 2L,5L,19L,1172L,18742L,74967L,307062002L,329705313529178423L,BigInteger.Parse("88504596182827979077122168"),BigInteger.Parse("23200948861751257747193113585514"),BigInteger.Parse("24327958153659686843520766271043070385") };
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
public class A177875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177875Inst Instance=new A177875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177876
{
public static readonly long[] Value={ 2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177876Inst : IEnumerable<long>
{
public static readonly long[] Value=A177876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177876.Bytes);
public long this[int i]=>Value[i];

public static A177876Inst Instance=new A177876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177877
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,10L,4L,10L,16L,20L,5L,13L,22L,30L,35L,6L,16L,28L,40L,50L,56L,7L,19L,34L,50L,65L,77L,84L,8L,22L,40L,60L,80L,98L,112L,120L,9L,25L,46L,70L,95L,119L,140L,156L,165L,10L,28L,52L,80L,110L,140L,168L,192L,210L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177877Inst : IEnumerable<long>
{
public static readonly long[] Value=A177877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177877.Bytes);
public long this[int i]=>Value[i];

public static A177877Inst Instance=new A177877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177878
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,2L,4L,2L,4L,0L,5L,3L,6L,2L,3L,6L,4L,8L,4L,6L,0L,7L,5L,10L,6L,9L,3L,4L,8L,6L,12L,8L,12L,6L,8L,0L,9L,7L,14L,10L,15L,9L,12L,4L,5L,10L,8L,16L,12L,18L,12L,16L,8L,10L,0L,11L,9L,18L,14L,21L,15L,20L,12L,15L,5L,6L,12L,10L,20L,16L,24L,18L,24L,16L,20L,10L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177878Inst : IEnumerable<long>
{
public static readonly long[] Value=A177878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177878.Bytes);
public long this[int i]=>Value[i];

public static A177878Inst Instance=new A177878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177879
{
public static readonly BigInteger[] Value={ 7L,97L,31L,708158977L,127L,22783L,BigInteger.Parse("113210499946729046527"),12289L };
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
public class A177879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177879Inst Instance=new A177879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177880
{
public static readonly long[] Value={ 4L,9L,12L,18L,20L,25L,28L,32L,36L,44L,45L,49L,50L,52L,60L,63L,64L,68L,72L,75L,76L,84L,90L,92L,96L,98L,99L,100L,108L,116L,117L,121L,124L,126L,128L,132L,140L,144L,147L,148L,150L,153L,156L,160L,164L,169L,171L,172L,175L,180L,188L,192L,196L,198L,200L,204L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177880Inst : IEnumerable<long>
{
public static readonly long[] Value=A177880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177880.Bytes);
public long this[int i]=>Value[i];

public static A177880Inst Instance=new A177880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177881
{
public static readonly long[] Value={ 0L,0L,1L,4L,12L,36L,109L,328L,984L,2952L,8857L,26572L,79716L,239148L,717445L,2152336L,6457008L,19371024L,58113073L,174339220L,523017660L,1569052980L,4707158941L,14121476824L,42364430472L,127093291416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177881Inst : IEnumerable<long>
{
public static readonly long[] Value=A177881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177881.Bytes);
public long this[int i]=>Value[i];

public static A177881Inst Instance=new A177881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177882
{
public static readonly long[] Value={ 1L,15L,85L,771L,4369L,65535L,327685L,3342387L,16843009L,252645135L,1431655765L,12884901891L,73014444049L,1095216660735L,5519032976645L,56294136361779L,281479271743489L,4222189076152335L,23925738098196565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177882Inst : IEnumerable<long>
{
public static readonly long[] Value=A177882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177882.Bytes);
public long this[int i]=>Value[i];

public static A177882Inst Instance=new A177882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177883
{
public static readonly long[] Value={ 4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L,7L,2L,1L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177883Inst : IEnumerable<long>
{
public static readonly long[] Value=A177883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177883.Bytes);
public long this[int i]=>Value[i];

public static A177883Inst Instance=new A177883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177884
{
public static readonly long[] Value={ 1387L,2047L,4371L,8911L,13747L,14491L,19951L,42799L,60787L,90751L,123251L,150851L,256999L,258511L,271951L,272251L,275887L,294271L,387731L,396271L,422659L,435671L,443719L,452051L,476971L,514447L,672487L,680627L,741751L,769567L,877099L,916327L,1024651L,1052503L,1092547L,1152271L,1277179L,1302451L,1325843L,1397419L,1419607L,1433407L,1441091L,1459927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177884Inst : IEnumerable<long>
{
public static readonly long[] Value=A177884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177884.Bytes);
public long this[int i]=>Value[i];

public static A177884Inst Instance=new A177884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177885
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,4L,-27L,256L,-3125L,46656L,-823543L,16777216L,-387420489L,10000000000L,-285311670611L,8916100448256L,-302875106592253L,11112006825558016L,-437893890380859375L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("-827240261886336764177") };
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
public class A177885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177885Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177885.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177885Inst Instance=new A177885Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177886
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,0L,5L,2L,8L,0L,9L,1L,11L,0L,5L,9L,15L,0L,17L,3L,7L,0L,21L,2L,34L,0L,62L,7L,27L,0L,29L,8L,11L,0L,15L,9L,35L,0L,13L,6L,39L,0L,41L,9L,36L,0L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177886Inst : IEnumerable<long>
{
public static readonly long[] Value=A177886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177886.Bytes);
public long this[int i]=>Value[i];

public static A177886Inst Instance=new A177886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177887
{
public static readonly long[] Value={ 1L,4L,5L,9L,10L,14L,16L,20L,25L,30L,35L,36L,40L,45L,49L,55L,56L,64L,80L,81L,84L,90L,91L,100L,105L,120L,121L,125L,126L,140L,144L,154L,160L,165L,169L,180L,196L,204L,220L,224L,225L,231L,245L,250L,256L,260L,270L,285L,286L,289L,315L,320L,324L,336L,350L,360L,361L,364L,385L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177887Inst : IEnumerable<long>
{
public static readonly long[] Value=A177887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177887.Bytes);
public long this[int i]=>Value[i];

public static A177887Inst Instance=new A177887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177888
{
public static readonly BigInteger[] Value={ 1L,2L,1L,3L,3L,1L,4L,5L,7L,1L,5L,7L,17L,43L,1L,6L,9L,31L,257L,1807L,1L,7L,11L,49L,871L,65537L,3263443L,1L,8L,13L,71L,2209L,756031L,4294967297L,10650056950807L,1L,9L,15L,97L,4691L,4870849L,571580604871L,BigInteger.Parse("18446744073709551617"),BigInteger.Parse("113423713055421844361000443"),1L };
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
public class A177888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177888Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177888.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177888Inst Instance=new A177888Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177889
{
public static readonly long[] Value={ 6L,2L,8L,0L,0L,4L,5L,2L,7L,9L,3L,7L,9L,9L,0L,4L,6L,8L,6L,9L,8L,2L,3L,1L,4L,8L,9L,1L,3L,6L,2L,0L,8L,1L,6L,7L,7L,7L,1L,3L,3L,3L,1L,5L,9L,5L,8L,8L,2L,0L,8L,1L,4L,7L,2L,8L,5L,2L,1L,8L,2L,0L,6L,2L,0L,8L,7L,5L,0L,1L,3L,5L,3L,0L,7L,1L,7L,9L,3L,7L,7L,4L,0L,6L,3L,3L,2L,6L,6L,5L,6L,7L,0L,3L,4L,1L,2L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177889Inst : IEnumerable<long>
{
public static readonly long[] Value=A177889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177889.Bytes);
public long this[int i]=>Value[i];

public static A177889Inst Instance=new A177889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177890
{
public static readonly long[] Value={ 0L,1L,16L,58L,140L,275L,476L,756L,1128L,1605L,2200L,2926L,3796L,4823L,6020L,7400L,8976L,10761L,12768L,15010L,17500L,20251L,23276L,26588L,30200L,34125L,38376L,42966L,47908L,53215L,58900L,64976L,71456L,78353L,85680L,93450L,101676L,110371L,119548L,129220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177890Inst : IEnumerable<long>
{
public static readonly long[] Value=A177890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177890.Bytes);
public long this[int i]=>Value[i];

public static A177890Inst Instance=new A177890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177891
{
public static readonly long[] Value={ 6L,9L,14L,15L,16L,18L,20L,22L,25L,33L,36L,38L,45L,46L,51L,52L,62L,68L,70L,72L,75L,80L,86L,87L,91L,93L,95L,99L,104L,105L,110L,116L,117L,118L,119L,130L,136L,141L,142L,143L,144L,145L,148L,154L,158L,159L,160L,162L,165L,166L,169L,183L,195L,196L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177891Inst : IEnumerable<long>
{
public static readonly long[] Value=A177891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177891.Bytes);
public long this[int i]=>Value[i];

public static A177891Inst Instance=new A177891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177892
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177892Inst : IEnumerable<long>
{
public static readonly long[] Value=A177892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177892.Bytes);
public long this[int i]=>Value[i];

public static A177892Inst Instance=new A177892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177893
{
public static readonly long[] Value={ 4L,0L,0L,1L,-80L,0L,0L,20L,1L,0L,11200L,0L,0L,0L,0L,60L,0L,0L,1L,-6272000L,0L,0L,-3136000L,0L,0L,78400L,0L,0L,2800L,0L,0L,140L,0L,0L,1L,-38635520000L,0L,0L,19317760000L,0L,0L,1448832000L,0L,0L,-17248000L,0L,0L,627200L,0L,0L,18480L,0L,0L,280L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177893Inst : IEnumerable<long>
{
public static readonly long[] Value=A177893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177893.Bytes);
public long this[int i]=>Value[i];

public static A177893Inst Instance=new A177893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177894
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,0L,-3L,-8L,-15L,-24L,-35L,-48L,-63L,-80L,4L,3L,0L,-5L,-12L,-21L,-32L,-45L,-60L,-77L,9L,8L,5L,0L,-7L,-16L,-27L,-40L,-55L,-72L,16L,15L,12L,7L,0L,-9L,-20L,-33L,-48L,-65L,25L,24L,21L,16L,9L,0L,-11L,-24L,-39L,-56L,36L,35L,32L,27L,20L,11L,0L,-13L,-28L,-45L,49L,48L,45L,40L,33L,24L,13L,0L,-15L,-32L,64L,63L,60L,55L,48L,39L,28L,15L,0L,-17L,81L,80L,77L,72L,65L,56L,45L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177894Inst : IEnumerable<long>
{
public static readonly long[] Value=A177894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177894.Bytes);
public long this[int i]=>Value[i];

public static A177894Inst Instance=new A177894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177895
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177895Inst : IEnumerable<long>
{
public static readonly long[] Value=A177895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177895.Bytes);
public long this[int i]=>Value[i];

public static A177895Inst Instance=new A177895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177896
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,4L,9L,6L,1L,9L,26L,26L,10L,1L,21L,75L,100L,60L,15L,1L,51L,216L,360L,295L,120L,21L,1L,127L,623L,1246L,1295L,735L,217L,28L,1L,323L,1800L,4200L,5292L,3864L,1624L,364L,36L,1L,835L,5211L,13896L,20580L,18396L,10080L,3276L,576L,45L,1L,2188L,15115L,45345L,77190L,81690L,55314L,23730L,6150L,870L,55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177896Inst : IEnumerable<long>
{
public static readonly long[] Value=A177896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177896.Bytes);
public long this[int i]=>Value[i];

public static A177896Inst Instance=new A177896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177897
{
public static readonly BigInteger[] Value={ 1L,255L,21845L,3342387L,286331153L,64424509455L,5519032976645L,844437815230467L,72340172838076673L,18446744073709551615UL,BigInteger.Parse("1567973246265311887445"),BigInteger.Parse("241781474574111093044019") };
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
public class A177897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177897Inst Instance=new A177897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177898
{
public static readonly long[] Value={ 1L,6L,4L,9L,7L,12L,10L,15L,13L,18L,16L,21L,19L,24L,22L,27L,25L,30L,28L,33L,31L,36L,34L,39L,37L,42L,40L,45L,43L,48L,46L,51L,49L,54L,52L,57L,55L,60L,58L,63L,61L,66L,64L,69L,67L,72L,70L,75L,73L,78L,76L,81L,79L,84L,82L,87L,85L,90L,88L,93L,91L,96L,94L,99L,97L,102L,100L,105L,103L,108L,106L,111L,109L,114L,112L,117L,115L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177898Inst : IEnumerable<long>
{
public static readonly long[] Value=A177898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177898.Bytes);
public long this[int i]=>Value[i];

public static A177898Inst Instance=new A177898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177899
{
public static readonly long[] Value={ 8L,16L,24L,27L,40L,48L,54L,56L,80L,81L,88L,104L,112L,120L,125L,135L,136L,152L,162L,168L,176L,184L,189L,208L,216L,232L,240L,248L,250L,264L,270L,272L,280L,296L,297L,304L,312L,328L,336L,343L,344L,351L,368L,375L,376L,378L,405L,408L,424L,432L,440L,456L,459L,464L,472L,488L,496L,512L,513L,520L,528L,536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177899Inst : IEnumerable<long>
{
public static readonly long[] Value=A177899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177899.Bytes);
public long this[int i]=>Value[i];

public static A177899Inst Instance=new A177899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177900
{
public static readonly long[] Value={ 0L,4L,0L,8L,21L,27L,39L,65L,57L,115L,32L,155L,63L,50L,129L,235L,265L,371L,305L,201L,98L,365L,237L,171L,245L,291L,485L,309L,325L,327L,128L,189L,279L,917L,1507L,1529L,242L,785L,489L,835L,865L,1211L,385L,605L,579L,965L,338L,2321L,669L,1115L,687L,1165L,399L,2629L,549L,1285L,595L,1841L,1025L,603L,1385L,715L,3809L,921L,1175L,939L,4121L,1655L,805L,1325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177900Inst : IEnumerable<long>
{
public static readonly long[] Value=A177900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177900.Bytes);
public long this[int i]=>Value[i];

public static A177900Inst Instance=new A177900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177901
{
public static readonly long[] Value={ 2L,3L,5L,14L,22L,27L,35L,95L,96L,197L,261L,5935L,7399L,8998L,11671L,17411L,108965L,165535L,258335L,549545L,1542194L,2064173L,4146167L,4594140L,5814278L,9242360L,21603225L,28563732L,40700787L,54528830L,252544447L,1430841730L,5042264463L,11012237562L,31774693500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177901Inst : IEnumerable<long>
{
public static readonly long[] Value=A177901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177901.Bytes);
public long this[int i]=>Value[i];

public static A177901Inst Instance=new A177901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177902
{
public static readonly long[] Value={ 1L,11L,12L,14L,18L,21L,23L,29L,31L,34L,37L,41L,51L,56L,61L,71L,81L,91L,111L,131L,157L,191L,211L,213L,219L,437L,511L,857L,1111L,1112L,1117L,1121L,1123L,1129L,1131L,1153L,1161L,1172L,1187L,1191L,1212L,1216L,1512L,1731L,2111L,2113L,2119L,2121L,2143L,2173L,2321L,2517L,2587L,2711L,3112L,3121L,3712L,4121L,4153L,4161L,4197L,5111L,5116L,5121L,5176L,5321L,5721L,6121L,7512L,8113L,8121L,8321L,8921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177902Inst : IEnumerable<long>
{
public static readonly long[] Value=A177902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177902.Bytes);
public long this[int i]=>Value[i];

public static A177902Inst Instance=new A177902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177903
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,4L,3L,3L,4L,4L,4L,3L,4L,4L,5L,5L,5L,5L,4L,4L,5L,4L,5L,6L,4L,4L,6L,5L,6L,5L,5L,5L,5L,5L,5L,5L,5L,5L,4L,5L,6L,7L,6L,6L,6L,6L,6L,5L,6L,5L,6L,6L,6L,6L,5L,6L,7L,6L,6L,6L,6L,6L,6L,6L,5L,6L,5L,7L,7L,6L,6L,7L,7L,6L,7L,6L,6L,6L,5L,5L,7L,6L,6L,6L,7L,7L,7L,6L,6L,6L,7L,7L,6L,7L,7L,7L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177903Inst : IEnumerable<long>
{
public static readonly long[] Value=A177903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177903.Bytes);
public long this[int i]=>Value[i];

public static A177903Inst Instance=new A177903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177904
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,3L,11L,19L,11L,41L,71L,41L,17L,43L,101L,23L,167L,97L,41L,61L,199L,43L,101L,7L,151L,37L,13L,67L,13L,31L,37L,3L,71L,37L,37L,29L,103L,13L,29L,29L,71L,43L,13L,127L,61L,67L,17L,29L,113L,53L,13L,179L,7L,199L,11L,31L,241L,283L,37L,17L,337L,23L,29L,389L,7L,17L,59L,83L,53L,13L,149L,43L,41L,233L,317L,197L,83L,199L,479L,761L,1439L,47L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177904Inst : IEnumerable<long>
{
public static readonly long[] Value=A177904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177904.Bytes);
public long this[int i]=>Value[i];

public static A177904Inst Instance=new A177904Inst();

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