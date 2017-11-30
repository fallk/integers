using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A189431
{
public static readonly long[] Value={ 1L,8L,65L,571L,5680L,52241L,493941L,4681376L,44341381L,420325171L,3983969024L,37773176577L,358128315977L,3395458162288L,32193312416793L,305234770125411L,2894031473957664L,27439272582314225L,260161002358646165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189431Inst : IEnumerable<long>
{
public static readonly long[] Value=A189431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189431.Bytes);
public long this[int i]=>Value[i];

public static A189431Inst Instance=new A189431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189432
{
public static readonly long[] Value={ 1L,13L,181L,2413L,40065L,606201L,9557077L,150278792L,2367212857L,37358187521L,589449930573L,9305507958493L,146913309982185L,2319624020512093L,36626205645266813L,578327113990185529L,9131891816444663056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189432Inst : IEnumerable<long>
{
public static readonly long[] Value=A189432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189432.Bytes);
public long this[int i]=>Value[i];

public static A189432Inst Instance=new A189432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189433
{
public static readonly BigInteger[] Value={ 1L,21L,441L,10069L,278105L,6944573L,181540773L,4742833745L,124239687001L,3261208487441L,85625162598265L,2250063012268697L,59139108575177913L,1554641730277194809L,BigInteger.Parse("40872537373376873929"),BigInteger.Parse("1074626580793742218601") };
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
public class A189433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189433Inst Instance=new A189433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189434
{
public static readonly BigInteger[] Value={ 1L,34L,1165L,42205L,1940868L,79826592L,3467525301L,150293731826L,6540976400913L,285499775348185L,12468705796935816L,545183904690537217L,BigInteger.Parse("23847514960230618480"),BigInteger.Parse("1043490861604911009586"),BigInteger.Parse("45668994694128002511925") };
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
public class A189434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189434Inst Instance=new A189434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189435
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,5L,1L,1L,5L,9L,9L,1L,1L,8L,29L,31L,20L,1L,1L,13L,65L,140L,109L,41L,1L,1L,21L,181L,571L,841L,367L,85L,1L,1L,34L,441L,2413L,5680L,4653L,1245L,178L,1L,1L,55L,1165L,10069L,40065L,52241L,26589L,4247L,369L,1L,1L,89L,2929L,42205L,278105L,606201L,493941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189435Inst : IEnumerable<long>
{
public static readonly long[] Value=A189435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189435.Bytes);
public long this[int i]=>Value[i];

public static A189435Inst Instance=new A189435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189484
{
public static readonly long[] Value={ 1L,4L,6L,9L,16L,22L,33L,36L,55L,56L,64L,77L,81L,111L,121L,136L,141L,156L,161L,202L,216L,256L,262L,276L,296L,303L,323L,351L,376L,393L,441L,454L,484L,505L,515L,516L,535L,545L,560L,565L,621L,626L,707L,717L,729L,737L,765L,767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189484Inst : IEnumerable<long>
{
public static readonly long[] Value=A189484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189484.Bytes);
public long this[int i]=>Value[i];

public static A189484Inst Instance=new A189484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189485
{
public static readonly BigInteger[] Value={ 1L,1L,5L,13L,29L,10L,76L,1736L,4660L,548336L,29284676L,11332669880L,83479779988156L,1588027776066548704L,BigInteger.Parse("3951095430355142456915900"),BigInteger.Parse("559704716364298877070828931075144"),BigInteger.Parse("29061471629068026188294896544835477139588124"),BigInteger.Parse("10492921417426945424117408776017371634826648342796156209040") };
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
public class A189485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189485Inst Instance=new A189485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189486
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,14L,7L,43L,731L,2023L,293573L,16486961L,5626477847L,38535553135033L,776247953589619099L,BigInteger.Parse("2069276059395278540341403"),BigInteger.Parse("288477890749068052847537054483767"),BigInteger.Parse("14233818196730866565020787814994280535215309"),BigInteger.Parse("5106374385967496893562303709860513496951269918036531477033") };
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
public class A189486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189486Inst Instance=new A189486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189487
{
public static readonly BigInteger[] Value={ 1L,1L,5L,28L,185L,1456L,13267L,135598L,1528193L,18805240L,250522451L,3585332554L,54774501025L,888739031116L,15249006695483L,275641537989766L,5231788966650113L,103968303762747472L,2157673505603964643L,BigInteger.Parse("46656574558459795522"),BigInteger.Parse("1049037051211541521121") };
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
public class A189487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189487Inst Instance=new A189487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189488
{
public static readonly BigInteger[] Value={ 1L,1L,5L,34L,281L,2656L,28867L,359038L,5002097L,76499128L,1269310931L,22704893674L,435561243625L,8912650794412L,193534333139435L,4440414121757926L,107270144994315233L,2720370239752704592L,BigInteger.Parse("72227750784404889187"),BigInteger.Parse("2002807470702054148930"),BigInteger.Parse("57871801203185571969881") };
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
public class A189488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189488Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189488.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189488Inst Instance=new A189488Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189489
{
public static readonly BigInteger[] Value={ 1L,4L,39L,604L,12865L,349326L,11538415L,449107688L,20131351425L,1021358296090L,57859311137551L,3620137646441196L,247941397429600225L,BigInteger.Parse("18450166102594552886"),BigInteger.Parse("1482272087674859722095") };
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
public class A189489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189489Inst Instance=new A189489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189490
{
public static readonly BigInteger[] Value={ 0L,12L,152L,3388L,85480L,2642358L,93830584L,3870426602L,179336321514L,9289851475820L,529329739784248L,33294638055400354L,2251636269472534394L,BigInteger.Parse("165280305640591105462"),BigInteger.Parse("13029806159083867494110"),BigInteger.Parse("1097830097296833990293942") };
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
public class A189490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189490Inst Instance=new A189490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189491
{
public static readonly long[] Value={ 2L,12L,42L,136L,550L,1892L,7384L,26816L,103288L,386928L,1485566L,5654000L,21736466L,83448592L,321767288L,1241835856L,4803432344L,18605438864L,72168550344L,280295950240L,1089835505354L,4242072071396L,16526909026016L,64446293812896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189491Inst : IEnumerable<long>
{
public static readonly long[] Value=A189491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189491.Bytes);
public long this[int i]=>Value[i];

public static A189491Inst Instance=new A189491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189492
{
public static readonly long[] Value={ 6L,38L,152L,928L,4920L,27508L,152358L,852940L,4796962L,27117826L,153988846L,877458110L,5015185460L,28736333450L,165022598514L,949503677434L,5472715411708L,31592116727316L,182623690514234L,1057008913476932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189492Inst : IEnumerable<long>
{
public static readonly long[] Value=A189492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189492.Bytes);
public long this[int i]=>Value[i];

public static A189492Inst Instance=new A189492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189493
{
public static readonly long[] Value={ 12L,78L,462L,3388L,24806L,182634L,1350418L,10077438L,75593372L,569975518L,4314566150L,32776245696L,249736590734L,1907787461862L,14606641601322L,112053156457254L,861099306196596L,6627602924590818L,51081646472620460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189493Inst : IEnumerable<long>
{
public static readonly long[] Value=A189493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189493.Bytes);
public long this[int i]=>Value[i];

public static A189493Inst Instance=new A189493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189494
{
public static readonly long[] Value={ 20L,148L,1088L,9394L,85480L,787412L,7250142L,67449574L,630466648L,5926141678L,55929815964L,529724228140L,5032227826544L,47929965246944L,457554555905322L,4376712118553570L,41939283915535994L,402511337790992824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189494Inst : IEnumerable<long>
{
public static readonly long[] Value=A189494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189494.Bytes);
public long this[int i]=>Value[i];

public static A189494Inst Instance=new A189494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189495
{
public static readonly long[] Value={ 30L,240L,2128L,22088L,238836L,2642358L,29261538L,326423068L,3664621084L,41363200538L,468946573672L,5336062742740L,60905410016682L,697014919372024L,7995252612136370L,91897595260805282L,1058172169719093028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189495Inst : IEnumerable<long>
{
public static readonly long[] Value=A189495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189495.Bytes);
public long this[int i]=>Value[i];

public static A189495Inst Instance=new A189495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189496
{
public static readonly long[] Value={ 42L,380L,3850L,45892L,567774L,7269852L,93830584L,1218634086L,15936391068L,209537582772L,2767610804790L,36693616556076L,488053206844182L,6509219419657784L,87019925011505106L,1165759230193567534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189496Inst : IEnumerable<long>
{
public static readonly long[] Value=A189496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189496.Bytes);
public long this[int i]=>Value[i];

public static A189496Inst Instance=new A189496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189497
{
public static readonly ulong[] Value={ 56L,554L,6474L,86416L,1218778L,17692662L,260746932L,3870426602L,57837221756L,869215927390L,13123761537778L,198920666858552L,3025059739988546L,46133139520964090L,705259604715611042L,10804567651956071366UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189497Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A189497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189497.Bytes);
public ulong this[int i]=>Value[i];

public static A189497Inst Instance=new A189497Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189498
{
public static readonly long[] Value={ 0L,2L,4L,6L,12L,0L,12L,38L,42L,12L,20L,78L,152L,136L,0L,30L,148L,462L,928L,550L,40L,42L,240L,1088L,3388L,4920L,1892L,0L,56L,380L,2128L,9394L,24806L,27508L,7384L,140L,72L,554L,3850L,22088L,85480L,182634L,152358L,26816L,0L,90L,788L,6474L,45892L,238836L,787412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189498Inst : IEnumerable<long>
{
public static readonly long[] Value=A189498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189498.Bytes);
public long this[int i]=>Value[i];

public static A189498Inst Instance=new A189498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189499
{
public static readonly long[] Value={ 4L,12L,38L,78L,148L,240L,380L,554L,788L,1062L,1410L,1806L,2294L,2844L,3498L,4226L,5068L,5988L,7040L,8180L,9466L,10850L,12396L,14046L,15876L,17824L,19960L,22226L,24696L,27296L,30118L,33090L,36288L,39642L,43242L,47002L,51022L,55220L,59690L,64346L,69294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189499Inst : IEnumerable<long>
{
public static readonly long[] Value=A189499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189499.Bytes);
public long this[int i]=>Value[i];

public static A189499Inst Instance=new A189499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189532
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,13L,16L,19L,21L,23L,25L,28L,31L,33L,35L,38L,40L,43L,45L,47L,50L,52L,55L,58L,59L,62L,65L,67L,70L,71L,74L,77L,79L,81L,84L,86L,89L,91L,93L,96L,98L,101L,104L,105L,108L,110L,113L,116L,117L,120L,123L,125L,128L,130L,132L,135L,137L,140L,142L,144L,147L,150L,152L,154L,156L,159L,162L,163L,166L,169L,171L,174L,175L,178L,181L,183L,186L,188L,190L,193L,196L,198L,200L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189532Inst : IEnumerable<long>
{
public static readonly long[] Value=A189532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189532.Bytes);
public long this[int i]=>Value[i];

public static A189532Inst Instance=new A189532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189533
{
public static readonly long[] Value={ 1L,4L,6L,9L,12L,14L,17L,20L,22L,25L,28L,30L,33L,35L,37L,40L,42L,45L,48L,50L,53L,56L,58L,61L,64L,66L,69L,71L,73L,76L,78L,81L,84L,86L,89L,92L,94L,97L,100L,102L,105L,107L,109L,112L,114L,117L,120L,122L,125L,128L,130L,133L,136L,138L,141L,143L,145L,148L,150L,153L,156L,158L,161L,164L,166L,169L,172L,174L,176L,179L,181L,184L,186L,189L,192L,194L,197L,200L,202L,205L,208L,210L,212L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189533Inst : IEnumerable<long>
{
public static readonly long[] Value=A189533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189533.Bytes);
public long this[int i]=>Value[i];

public static A189533Inst Instance=new A189533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189534
{
public static readonly long[] Value={ 3L,7L,11L,15L,19L,23L,27L,31L,34L,39L,43L,47L,51L,55L,59L,63L,67L,70L,75L,79L,83L,87L,91L,95L,99L,103L,106L,111L,115L,119L,123L,127L,131L,134L,139L,142L,147L,151L,155L,159L,163L,167L,170L,175L,178L,183L,187L,191L,195L,199L,203L,206L,211L,214L,219L,223L,227L,231L,235L,239L,242L,247L,250L,255L,259L,263L,267L,270L,275L,278L,283L,286L,291L,294L,299L,303L,306L,311L,314L,319L,322L,327L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189534Inst : IEnumerable<long>
{
public static readonly long[] Value=A189534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189534.Bytes);
public long this[int i]=>Value[i];

public static A189534Inst Instance=new A189534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189535
{
public static readonly long[] Value={ 2L,5L,8L,10L,13L,16L,18L,21L,24L,26L,29L,32L,36L,38L,41L,44L,46L,49L,52L,54L,57L,60L,62L,65L,68L,72L,74L,77L,80L,82L,85L,88L,90L,93L,96L,98L,101L,104L,108L,110L,113L,116L,118L,121L,124L,126L,129L,132L,135L,137L,140L,144L,146L,149L,152L,154L,157L,160L,162L,165L,168L,171L,173L,177L,180L,182L,185L,188L,190L,193L,196L,198L,201L,204L,207L,209L,213L,216L,218L,221L,224L,226L,229L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189535Inst : IEnumerable<long>
{
public static readonly long[] Value=A189535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189535.Bytes);
public long this[int i]=>Value[i];

public static A189535Inst Instance=new A189535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189536
{
public static readonly long[] Value={ 0L,2L,3L,5L,17L,37L,101L,0L,401L,3137L,4357L,62501L,21317L,16901L,1008017L,15877L,1020101L,33857L,69697L,14401L,331777L,78401L,32401L,57601L,828101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189536Inst : IEnumerable<long>
{
public static readonly long[] Value=A189536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189536.Bytes);
public long this[int i]=>Value[i];

public static A189536Inst Instance=new A189536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189537
{
public static readonly BigInteger[] Value={ 0L,8L,192L,3664L,97836L,3022220L,111406336L,4628970120L,218096627156L,11386607289752L,663503578718392L,41531582314206828L,2853359963095951888L,BigInteger.Parse("211159586315457308624"),BigInteger.Parse("16744498622418072268632"),BigInteger.Parse("1413898875545606092572904") };
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
public class A189537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189537Inst Instance=new A189537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189538
{
public static readonly long[] Value={ 4L,8L,44L,152L,552L,2000L,7628L,28440L,108792L,411888L,1586424L,6066032L,23474384L,90378912L,351072012L,1358520600L,5293045208L,20561697200L,80309986856L,312934745552L,1224770426672L,4784290151264L,18757260263352L,73421632108656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189538Inst : IEnumerable<long>
{
public static readonly long[] Value=A189538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189538.Bytes);
public long this[int i]=>Value[i];

public static A189538Inst Instance=new A189538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189539
{
public static readonly long[] Value={ 12L,28L,192L,964L,5416L,31280L,173792L,977092L,5562216L,31839976L,182830560L,1054020072L,6094150672L,35317631800L,205154575120L,1194077810020L,6961965310984L,40654382303400L,237732203953600L,1391919066252408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189539Inst : IEnumerable<long>
{
public static readonly long[] Value=A189539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189539.Bytes);
public long this[int i]=>Value[i];

public static A189539Inst Instance=new A189539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189540
{
public static readonly long[] Value={ 24L,72L,544L,3664L,26804L,204544L,1526520L,11544464L,87396896L,665272176L,5096651048L,39149596736L,301739941644L,2331728722640L,18056185672312L,140109131577968L,1089078310071600L,8478661335953200L,66101375005684576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189540Inst : IEnumerable<long>
{
public static readonly long[] Value=A189540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189540.Bytes);
public long this[int i]=>Value[i];

public static A189540Inst Instance=new A189540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189541
{
public static readonly long[] Value={ 40L,152L,1340L,11276L,97836L,911144L,8485264L,80270588L,762015216L,7245223968L,69300586592L,665123270568L,6402235178628L,61805759252168L,598018355467584L,5798061848435388L,56317251524412720L,547885648488675312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189541Inst : IEnumerable<long>
{
public static readonly long[] Value=A189541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189541.Bytes);
public long this[int i]=>Value[i];

public static A189541Inst Instance=new A189541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189542
{
public static readonly long[] Value={ 60L,264L,2520L,26152L,274132L,3022220L,33638540L,379997096L,4324466328L,49387377504L,566509205348L,6521404038024L,75307822934828L,872056487276532L,10122186382107364L,117736171713864168L,1371964294216603880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189542Inst : IEnumerable<long>
{
public static readonly long[] Value=A189542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189542.Bytes);
public long this[int i]=>Value[i];

public static A189542Inst Instance=new A189542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189543
{
public static readonly long[] Value={ 84L,432L,4620L,56440L,683144L,8655424L,111406336L,1456853916L,19269747584L,256327259704L,3425977826592L,45971056435280L,618874800769152L,8355263758869800L,113080150945285296L,1533719330087763556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189543Inst : IEnumerable<long>
{
public static readonly long[] Value=A189543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189543.Bytes);
public long this[int i]=>Value[i];

public static A189543Inst Instance=new A189543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189544
{
public static readonly ulong[] Value={ 112L,660L,7716L,107464L,1481908L,21284040L,311438060L,4628970120L,69656466100L,1056054983348L,16103559487552L,246657108114908L,3791540831400220L,58459686887550560L,903694350477338140L,14001035809162949776UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189544Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A189544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189544.Bytes);
public ulong this[int i]=>Value[i];

public static A189544Inst Instance=new A189544Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189545
{
public static readonly long[] Value={ 0L,4L,4L,12L,8L,0L,24L,28L,44L,12L,40L,72L,192L,152L,0L,60L,152L,544L,964L,552L,40L,84L,264L,1340L,3664L,5416L,2000L,0L,112L,432L,2520L,11276L,26804L,31280L,7628L,140L,144L,660L,4620L,26152L,97836L,204544L,173792L,28440L,0L,180L,968L,7716L,56440L,274132L,911144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189545Inst : IEnumerable<long>
{
public static readonly long[] Value=A189545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189545.Bytes);
public long this[int i]=>Value[i];

public static A189545Inst Instance=new A189545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189546
{
public static readonly long[] Value={ 4L,8L,28L,72L,152L,264L,432L,660L,968L,1352L,1832L,2400L,3084L,3880L,4808L,5876L,7100L,8472L,10020L,11736L,13648L,15748L,18064L,20576L,23328L,26304L,29536L,33012L,36764L,40768L,45068L,49656L,54556L,59756L,65292L,71148L,77360L,83908L,90828L,98100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189546Inst : IEnumerable<long>
{
public static readonly long[] Value=A189546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189546.Bytes);
public long this[int i]=>Value[i];

public static A189546Inst Instance=new A189546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189547
{
public static readonly long[] Value={ 0L,44L,192L,544L,1340L,2520L,4620L,7716L,12500L,18896L,27876L,38860L,53492L,71460L,93972L,121328L,155180L,194484L,241980L,296528L,360804L,434048L,519528L,614164L,723528L,845504L,983924L,1136840L,1309496L,1497332L,1707736L,1938160L,2193024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189547Inst : IEnumerable<long>
{
public static readonly long[] Value=A189547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189547.Bytes);
public long this[int i]=>Value[i];

public static A189547Inst Instance=new A189547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189564
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,336L,1474L,8340L,57756L,475658L,4171070L,41950294L,472535256L,5882635676L,79963449714L,1173614446044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189564Inst : IEnumerable<long>
{
public static readonly long[] Value=A189564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189564.Bytes);
public long this[int i]=>Value[i];

public static A189564Inst Instance=new A189564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189565
{
public static readonly long[] Value={ 1L,1L,2L,6L,12L,36L,174L,708L,4334L,31424L,263732L,2503296L,26844578L,316692056L,4090634212L,57274447458L,863488976620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189565Inst : IEnumerable<long>
{
public static readonly long[] Value=A189565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189565.Bytes);
public long this[int i]=>Value[i];

public static A189565Inst Instance=new A189565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189566
{
public static readonly long[] Value={ 1L,2L,6L,24L,60L,208L,1184L,7840L,51636L,410272L,3836456L,39971896L,455888312L,5717233896L,78164908748L,1153568477544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189566Inst : IEnumerable<long>
{
public static readonly long[] Value=A189566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189566.Bytes);
public long this[int i]=>Value[i];

public static A189566Inst Instance=new A189566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189567
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,392L,1810L,10400L,72228L,589674L,5196870L,52398658L,588036216L,7274466172L,98024173852L,1427556373892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189567Inst : IEnumerable<long>
{
public static readonly long[] Value=A189567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189567.Bytes);
public long this[int i]=>Value[i];

public static A189567Inst Instance=new A189567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189568
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,80L,326L,1566L,9544L,65036L,518498L,4750006L,48830634L,554929274L,6926227324L,93970452970L,1377573324202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189568Inst : IEnumerable<long>
{
public static readonly long[] Value=A189568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189568.Bytes);
public long this[int i]=>Value[i];

public static A189568Inst Instance=new A189568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189569
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,464L,2274L,13236L,91760L,740562L,6541984L,65632694L,732880076L,8995905626L,120367234946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189569Inst : IEnumerable<long>
{
public static readonly long[] Value=A189569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189569.Bytes);
public long this[int i]=>Value[i];

public static A189569Inst Instance=new A189569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189570
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,552L,2826L,17080L,117816L,943250L,8330356L,82954582L,915854808L,11147075946L,147948526182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189570Inst : IEnumerable<long>
{
public static readonly long[] Value=A189570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189570.Bytes);
public long this[int i]=>Value[i];

public static A189570Inst Instance=new A189570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189571
{
public static readonly long[] Value={ 3L,29L,31L,37L,47L,79L,83L,89L,107L,109L,127L,131L,139L,149L,157L,173L,179L,193L,197L,199L,211L,241L,277L,347L,359L,367L,373L,389L,397L,433L,449L,487L,491L,521L,577L,593L,619L,643L,659L,677L,743L,761L,829L,853L,953L,977L,1049L,1063L,1087L,1129L,1151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189571Inst : IEnumerable<long>
{
public static readonly long[] Value=A189571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189571.Bytes);
public long this[int i]=>Value[i];

public static A189571Inst Instance=new A189571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189572
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189572Inst : IEnumerable<long>
{
public static readonly long[] Value=A189572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189572.Bytes);
public long this[int i]=>Value[i];

public static A189572Inst Instance=new A189572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189573
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,11L,13L,15L,16L,18L,20L,21L,23L,25L,27L,28L,30L,32L,33L,35L,37L,39L,40L,42L,44L,45L,47L,49L,51L,52L,54L,56L,57L,59L,61L,62L,64L,66L,68L,69L,71L,73L,74L,76L,78L,80L,81L,83L,85L,86L,88L,90L,91L,93L,95L,97L,98L,100L,102L,103L,105L,107L,109L,110L,112L,114L,115L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189573Inst : IEnumerable<long>
{
public static readonly long[] Value=A189573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189573.Bytes);
public long this[int i]=>Value[i];

public static A189573Inst Instance=new A189573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189574
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,7L,7L,8L,8L,8L,9L,9L,10L,10L,11L,11L,11L,12L,12L,13L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,18L,19L,19L,20L,20L,21L,21L,21L,22L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,26L,27L,27L,28L,28L,28L,29L,29L,30L,30L,30L,31L,31L,32L,32L,33L,33L,33L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189574Inst : IEnumerable<long>
{
public static readonly long[] Value=A189574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189574.Bytes);
public long this[int i]=>Value[i];

public static A189574Inst Instance=new A189574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189575
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,5L,6L,6L,6L,6L,7L,7L,8L,8L,9L,10L,10L,10L,10L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,15L,15L,16L,17L,17L,17L,17L,18L,19L,19L,19L,19L,20L,21L,21L,21L,22L,22L,22L,22L,23L,23L,24L,24L,25L,26L,26L,26L,27L,27L,27L,27L,28L,28L,29L,30L,30L,30L,30L,31L,31L,32L,32L,33L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189575Inst : IEnumerable<long>
{
public static readonly long[] Value=A189575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189575.Bytes);
public long this[int i]=>Value[i];

public static A189575Inst Instance=new A189575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189576
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189576Inst : IEnumerable<long>
{
public static readonly long[] Value=A189576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189576.Bytes);
public long this[int i]=>Value[i];

public static A189576Inst Instance=new A189576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189577
{
public static readonly long[] Value={ 1L,5L,8L,11L,12L,16L,19L,20L,24L,27L,28L,30L,34L,37L,40L,41L,45L,48L,49L,51L,55L,58L,61L,62L,66L,69L,70L,72L,76L,77L,81L,84L,87L,88L,92L,95L,96L,100L,103L,104L,106L,110L,113L,116L,117L,121L,124L,125L,127L,131L,132L,136L,139L,142L,143L,147L,150L,151L,155L,158L,159L,161L,165L,168L,171L,172L,176L,179L,180L,182L,186L,187L,191L,194L,197L,198L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189577Inst : IEnumerable<long>
{
public static readonly long[] Value=A189577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189577.Bytes);
public long this[int i]=>Value[i];

public static A189577Inst Instance=new A189577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189578
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,9L,10L,13L,14L,15L,17L,18L,21L,22L,23L,25L,26L,29L,31L,32L,33L,35L,36L,38L,39L,42L,43L,44L,46L,47L,50L,52L,53L,54L,56L,57L,59L,60L,63L,64L,65L,67L,68L,71L,73L,74L,75L,78L,79L,80L,82L,83L,85L,86L,89L,90L,91L,93L,94L,97L,98L,99L,101L,102L,105L,107L,108L,109L,111L,112L,114L,115L,118L,119L,120L,122L,123L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189578Inst : IEnumerable<long>
{
public static readonly long[] Value=A189578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189578.Bytes);
public long this[int i]=>Value[i];

public static A189578Inst Instance=new A189578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189579
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,5L,5L,6L,7L,7L,7L,8L,9L,10L,10L,11L,12L,12L,12L,13L,14L,15L,15L,16L,17L,17L,17L,18L,18L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,25L,26L,27L,28L,28L,29L,30L,30L,30L,31L,31L,32L,33L,34L,34L,35L,36L,36L,37L,38L,38L,38L,39L,40L,41L,41L,42L,43L,43L,43L,44L,44L,45L,46L,47L,47L,47L,48L,49L,50L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189579Inst : IEnumerable<long>
{
public static readonly long[] Value=A189579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189579.Bytes);
public long this[int i]=>Value[i];

public static A189579Inst Instance=new A189579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189612
{
public static readonly long[] Value={ 12L,144L,1164L,8496L,65160L,515560L,4075336L,32031600L,251533888L,1976926440L,15543816656L,122208548968L,960755182696L,7553047614920L,59379727197728L,466827426445200L,3670067881137352L,28853031765433504L,226834374728410104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189612Inst : IEnumerable<long>
{
public static readonly long[] Value=A189612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189612.Bytes);
public long this[int i]=>Value[i];

public static A189612Inst Instance=new A189612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189613
{
public static readonly long[] Value={ 21L,441L,5238L,50024L,532565L,6110500L,69943253L,783072552L,8759983583L,98440457351L,1108879339651L,12480666817260L,140421583259356L,1580016922218493L,17782853849081975L,200149452833682454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189613Inst : IEnumerable<long>
{
public static readonly long[] Value=A189613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189613.Bytes);
public long this[int i]=>Value[i];

public static A189613Inst Instance=new A189613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189614
{
public static readonly BigInteger[] Value={ 37L,1369L,25046L,357323L,6204967L,118571483L,2239578131L,41236726541L,764615054191L,14279876468131L,267312630925466L,4997721311916752L,93457924722647556L,1748307417599408282L,BigInteger.Parse("32716532907276172258") };
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
public class A189614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189614Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189614.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189614Inst Instance=new A189614Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189615
{
public static readonly BigInteger[] Value={ 65L,4225L,116100L,2482591L,68121839L,2076231513L,61652076124L,1785011303305L,52081392909734L,1531637258052071L,45087524679984918L,1325492265359151122L,BigInteger.Parse("38967877720497094747"),BigInteger.Parse("1146070566293713302197"),BigInteger.Parse("33712980614275859943483") };
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
public class A189615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189615Inst Instance=new A189615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189616
{
public static readonly BigInteger[] Value={ 114L,12996L,526418L,15915001L,636683482L,28823835852L,1256763617551L,52939317116118L,2243913970341972L,96114581661833896L,4121472431976051699L,BigInteger.Parse("176378174243580691358"),BigInteger.Parse("7545272457917436835785"),BigInteger.Parse("322957852724963531996423") };
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
public class A189616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189616Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189616.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189616Inst Instance=new A189616Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189617
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,8L,12L,49L,64L,16L,21L,144L,292L,256L,32L,37L,441L,1164L,1723L,1024L,64L,65L,1369L,5238L,8496L,10327L,4096L,128L,114L,4225L,25046L,50024L,65160L,61996L,16384L,256L,200L,12996L,116100L,357323L,532565L,515560L,371641L,65536L,512L,351L,40000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189617Inst : IEnumerable<long>
{
public static readonly long[] Value=A189617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189617.Bytes);
public long this[int i]=>Value[i];

public static A189617Inst Instance=new A189617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189618
{
public static readonly long[] Value={ 8L,64L,292L,1164L,5238L,25046L,116100L,526418L,2403976L,11065442L,50854642L,233077382L,1068505272L,4902990456L,22498260976L,103204910914L,473409837692L,2171794653270L,9963444579674L,45707359388096L,209680588779494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189618Inst : IEnumerable<long>
{
public static readonly long[] Value=A189618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189618.Bytes);
public long this[int i]=>Value[i];

public static A189618Inst Instance=new A189618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189619
{
public static readonly long[] Value={ 16L,256L,1723L,8496L,50024L,357323L,2482591L,15915001L,100745265L,655633882L,4322765564L,28292943180L,183873191611L,1195974189947L,7802581300173L,50931021729006L,332106212299242L,2164490825527781L,14110729853099870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189619Inst : IEnumerable<long>
{
public static readonly long[] Value=A189619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189619.Bytes);
public long this[int i]=>Value[i];

public static A189619Inst Instance=new A189619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189620
{
public static readonly long[] Value={ 32L,1024L,10327L,65160L,532565L,6204967L,68121839L,636683482L,5785616468L,56137313726L,563010113815L,5529846867761L,53193183705288L,513158091226513L,5003028394342619L,48867656731556592L,475282571037202342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189620Inst : IEnumerable<long>
{
public static readonly long[] Value=A189620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189620.Bytes);
public long this[int i]=>Value[i];

public static A189620Inst Instance=new A189620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189621
{
public static readonly long[] Value={ 64L,4096L,61996L,515560L,6110500L,118571483L,2076231513L,28823835852L,385459961106L,5723963509791L,89346030665338L,1342965562065607L,19505273464622126L,285343732611331021L,4255443558501922341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189621Inst : IEnumerable<long>
{
public static readonly long[] Value=A189621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189621.Bytes);
public long this[int i]=>Value[i];

public static A189621Inst Instance=new A189621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189622
{
public static readonly BigInteger[] Value={ 128L,16384L,371641L,4075336L,69943253L,2239578131L,61652076124L,1256763617551L,24523253340435L,553063756559791L,13299838117765230L,302455226663091586L,6562256770141965765L,BigInteger.Parse("144156209612197100001"),BigInteger.Parse("3257064388881887530527") };
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
public class A189622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189622Inst Instance=new A189622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189623
{
public static readonly BigInteger[] Value={ 256L,65536L,2227333L,32031600L,783072552L,41236726541L,1785011303305L,52939317116118L,1481899787122910L,50278308247706514L,1860556623858510413L,BigInteger.Parse("63647690214269161385"),BigInteger.Parse("2037957253448016880897"),BigInteger.Parse("66466260524616890792281") };
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
public class A189623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189623Inst Instance=new A189623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189624
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189624Inst : IEnumerable<long>
{
public static readonly long[] Value=A189624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189624.Bytes);
public long this[int i]=>Value[i];

public static A189624Inst Instance=new A189624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189625
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,10L,12L,13L,16L,18L,19L,20L,22L,23L,25L,26L,29L,30L,31L,33L,34L,37L,39L,40L,41L,44L,45L,46L,48L,49L,51L,52L,55L,56L,57L,59L,60L,63L,64L,65L,67L,68L,71L,73L,74L,75L,77L,78L,80L,81L,84L,85L,86L,88L,89L,92L,94L,95L,96L,99L,100L,101L,103L,104L,106L,107L,110L,112L,113L,114L,116L,117L,119L,120L,123L,124L,125L,127L,128L,131L,132L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189625Inst : IEnumerable<long>
{
public static readonly long[] Value=A189625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189625.Bytes);
public long this[int i]=>Value[i];

public static A189625Inst Instance=new A189625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189626
{
public static readonly long[] Value={ 3L,6L,7L,11L,14L,15L,17L,21L,24L,27L,28L,32L,35L,36L,38L,42L,43L,47L,50L,53L,54L,58L,61L,62L,66L,69L,70L,72L,76L,79L,82L,83L,87L,90L,91L,93L,97L,98L,102L,105L,108L,109L,111L,115L,118L,121L,122L,126L,129L,130L,134L,137L,138L,140L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189626Inst : IEnumerable<long>
{
public static readonly long[] Value=A189626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189626.Bytes);
public long this[int i]=>Value[i];

public static A189626Inst Instance=new A189626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189627
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,3L,3L,3L,4L,4L,4L,5L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,11L,11L,11L,11L,12L,12L,12L,13L,14L,14L,15L,15L,15L,15L,16L,17L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,21L,21L,21L,21L,22L,22L,22L,23L,24L,24L,24L,24L,25L,25L,25L,26L,27L,27L,28L,28L,28L,28L,29L,29L,29L,30L,30L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189627Inst : IEnumerable<long>
{
public static readonly long[] Value=A189627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189627.Bytes);
public long this[int i]=>Value[i];

public static A189627Inst Instance=new A189627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189676
{
public static readonly long[] Value={ 4L,8L,14L,18L,24L,28L,34L,38L,42L,48L,52L,58L,62L,68L,72L,78L,82L,86L,92L,96L,102L,106L,112L,116L,122L,126L,130L,136L,140L,146L,150L,156L,160L,164L,170L,174L,180L,184L,190L,194L,200L,204L,208L,214L,218L,224L,228L,234L,238L,244L,248L,252L,258L,262L,268L,272L,278L,282L,288L,292L,296L,302L,306L,312L,316L,322L,326L,330L,336L,340L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189676Inst : IEnumerable<long>
{
public static readonly long[] Value=A189676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189676.Bytes);
public long this[int i]=>Value[i];

public static A189676Inst Instance=new A189676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189677
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,14L,17L,19L,22L,25L,28L,30L,33L,35L,37L,40L,42L,45L,48L,51L,53L,56L,58L,61L,63L,66L,68L,71L,74L,76L,79L,81L,84L,86L,89L,91L,94L,97L,100L,102L,105L,107L,109L,112L,114L,117L,120L,123L,125L,128L,130L,133L,135L,138L,140L,143L,146L,148L,151L,153L,156L,158L,161L,163L,166L,169L,172L,174L,176L,179L,181L,184L,186L,189L,192L,195L,197L,200L,202L,205L,207L,210L,212L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189677Inst : IEnumerable<long>
{
public static readonly long[] Value=A189677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189677.Bytes);
public long this[int i]=>Value[i];

public static A189677Inst Instance=new A189677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189678
{
public static readonly long[] Value={ 5L,10L,16L,21L,26L,32L,38L,44L,49L,54L,60L,65L,72L,77L,82L,88L,93L,98L,104L,110L,116L,121L,126L,132L,137L,144L,149L,154L,160L,165L,171L,177L,182L,188L,193L,198L,204L,209L,216L,221L,226L,232L,237L,243L,249L,254L,260L,265L,271L,276L,281L,288L,293L,298L,304L,309L,315L,321L,326L,332L,337L,343L,348L,354L,360L,365L,370L,376L,381L,387L,393L,398L,404L,409L,415L,420L,426L,432L,437L,443L,448L,453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189678Inst : IEnumerable<long>
{
public static readonly long[] Value=A189678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189678.Bytes);
public long this[int i]=>Value[i];

public static A189678Inst Instance=new A189678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189679
{
public static readonly long[] Value={ 1L,3L,6L,8L,11L,13L,15L,18L,20L,23L,24L,27L,29L,31L,34L,36L,39L,41L,43L,46L,47L,50L,52L,55L,57L,59L,62L,64L,67L,69L,70L,73L,75L,78L,80L,83L,85L,87L,90L,92L,95L,96L,99L,101L,103L,106L,108L,111L,113L,115L,118L,119L,122L,124L,127L,129L,131L,134L,136L,139L,141L,142L,145L,147L,150L,152L,155L,157L,159L,162L,164L,167L,168L,170L,173L,175L,178L,180L,183L,185L,187L,190L,191L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189679Inst : IEnumerable<long>
{
public static readonly long[] Value=A189679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189679.Bytes);
public long this[int i]=>Value[i];

public static A189679Inst Instance=new A189679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189680
{
public static readonly long[] Value={ 2L,6L,10L,12L,16L,20L,22L,26L,30L,32L,36L,40L,44L,46L,50L,54L,56L,60L,64L,66L,70L,74L,76L,80L,84L,88L,90L,94L,98L,100L,104L,108L,110L,114L,118L,120L,124L,128L,132L,134L,138L,142L,144L,148L,152L,154L,158L,162L,166L,168L,172L,176L,178L,182L,186L,188L,192L,196L,198L,202L,206L,210L,212L,216L,220L,222L,226L,230L,232L,236L,240L,242L,246L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189680Inst : IEnumerable<long>
{
public static readonly long[] Value=A189680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189680.Bytes);
public long this[int i]=>Value[i];

public static A189680Inst Instance=new A189680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189681
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,14L,17L,19L,21L,24L,26L,29L,31L,34L,36L,39L,41L,43L,46L,48L,51L,53L,56L,58L,61L,63L,65L,68L,70L,73L,75L,78L,80L,82L,85L,87L,90L,92L,95L,97L,100L,102L,104L,107L,109L,112L,114L,117L,119L,122L,124L,126L,129L,131L,134L,136L,139L,141L,144L,146L,148L,151L,153L,156L,158L,161L,163L,165L,168L,170L,173L,175L,178L,180L,183L,185L,187L,190L,192L,195L,197L,200L,202L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189681Inst : IEnumerable<long>
{
public static readonly long[] Value=A189681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189681.Bytes);
public long this[int i]=>Value[i];

public static A189681Inst Instance=new A189681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189682
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,10L,11L,13L,15L,16L,18L,20L,22L,23L,25L,27L,28L,30L,32L,33L,35L,37L,38L,40L,42L,44L,45L,47L,49L,50L,52L,54L,55L,57L,59L,60L,62L,64L,66L,67L,69L,71L,72L,74L,76L,77L,79L,81L,83L,84L,86L,88L,89L,91L,93L,94L,96L,98L,99L,101L,103L,105L,106L,108L,110L,111L,113L,115L,116L,118L,120L,121L,123L,125L,127L,128L,130L,132L,133L,135L,137L,138L,140L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189682Inst : IEnumerable<long>
{
public static readonly long[] Value=A189682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189682.Bytes);
public long this[int i]=>Value[i];

public static A189682Inst Instance=new A189682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189683
{
public static readonly BigInteger[] Value={ 691L,12L,3617L,16L,43867L,18L,283L,20L,617L,20L,131L,22L,593L,22L,103L,24L,2294797L,24L,657931L,26L,9349L,28L,362903L,28L,1721L,30L,1001259881L,30L,37L,32L,683L,32L,305065927L,32L,151628697551L,34L,BigInteger.Parse("26315271553053477373"),36L,154210205991661L,38L,137616929L,40L };
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
public class A189683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189683Inst Instance=new A189683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189684
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,1L,2L,2L,2L,1L,2L,2L,3L,1L,1L,1L,2L,1L,4L,2L,3L,2L,4L,3L,3L,4L,3L,4L,2L,2L,4L,3L,2L,1L,2L,3L,5L,3L,5L,3L,3L,3L,3L,5L,5L,5L,5L,5L,3L,4L,3L,5L,3L,1L,4L,1L,3L,3L,7L,3L,6L,5L,3L,4L,3L,7L,6L,3L,2L,6L,6L,6L,5L,6L,5L,7L,5L,4L,7L,8L,5L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189684Inst : IEnumerable<long>
{
public static readonly long[] Value=A189684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189684.Bytes);
public long this[int i]=>Value[i];

public static A189684Inst Instance=new A189684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189685
{
public static readonly long[] Value={ 12L,16L,18L,20L,20L,22L,22L,24L,24L,26L,28L,28L,30L,30L,32L,32L,32L,34L,36L,38L,40L,40L,42L,44L,44L,44L,44L,46L,46L,48L,48L,48L,50L,50L,52L,52L,52L,52L,54L,54L,54L,56L,56L,56L,58L,58L,58L,58L,60L,60L,60L,62L,62L,62L,62L,64L,64L,66L,66L,68L,68L,68L,68L,70L,70L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189685Inst : IEnumerable<long>
{
public static readonly long[] Value=A189685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189685.Bytes);
public long this[int i]=>Value[i];

public static A189685Inst Instance=new A189685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189686
{
public static readonly long[] Value={ 2L,4L,6L,12L,24L,36L,48L,60L,120L,180L,240L,360L,720L,840L,1260L,1680L,2520L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189686Inst : IEnumerable<long>
{
public static readonly long[] Value=A189686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189686.Bytes);
public long this[int i]=>Value[i];

public static A189686Inst Instance=new A189686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189687
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189687Inst : IEnumerable<long>
{
public static readonly long[] Value=A189687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189687.Bytes);
public long this[int i]=>Value[i];

public static A189687Inst Instance=new A189687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189688
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,5L,6L,6L,7L,7L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,14L,14L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,21L,22L,23L,23L,24L,24L,25L,26L,26L,27L,27L,28L,28L,29L,30L,30L,31L,31L,32L,33L,33L,34L,34L,35L,36L,36L,37L,37L,38L,38L,39L,40L,40L,41L,41L,42L,43L,43L,44L,44L,45L,45L,46L,47L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189688Inst : IEnumerable<long>
{
public static readonly long[] Value=A189688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189688.Bytes);
public long this[int i]=>Value[i];

public static A189688Inst Instance=new A189688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189689
{
public static readonly BigInteger[] Value={ 2L,16L,292L,11637L,862652L,140346362L,43645304766L,30140493826752L,41065086729341527L,BigInteger.Parse("123548887542841478730"),BigInteger.Parse("745009928964016992782018"),BigInteger.Parse("9811185735768630724517609865"),BigInteger.Parse("262092653227176839857198569967286") };
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
public class A189689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189689Inst Instance=new A189689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189690
{
public static readonly long[] Value={ 8L,64L,292L,1298L,5172L,20316L,77752L,295720L,1117080L,4209924L,15835990L,59521532L,223600028L,839772726L,3153450118L,11840705184L,44458053838L,166922053694L,626717259422L,2353026409758L,8834468527674L,33169066709822L,124533341936372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189690Inst : IEnumerable<long>
{
public static readonly long[] Value=A189690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189690.Bytes);
public long this[int i]=>Value[i];

public static A189690Inst Instance=new A189690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189691
{
public static readonly long[] Value={ 16L,256L,1723L,11637L,65297L,370045L,1999150L,10867960L,58328512L,313915268L,1683430923L,9037137069L,48464436537L,259999868553L,1394419535984L,7479394198332L,40114452013630L,215155499724100L,1153964519450151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189691Inst : IEnumerable<long>
{
public static readonly long[] Value=A189691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189691.Bytes);
public long this[int i]=>Value[i];

public static A189691Inst Instance=new A189691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189708
{
public static readonly long[] Value={ 2L,3L,6L,9L,11L,12L,14L,15L,18L,20L,21L,23L,24L,27L,29L,30L,33L,36L,38L,39L,42L,45L,47L,48L,50L,51L,54L,56L,57L,60L,63L,65L,66L,69L,72L,74L,75L,77L,78L,81L,83L,84L,87L,90L,92L,93L,95L,96L,99L,101L,102L,104L,105L,108L,110L,111L,114L,117L,119L,120L,122L,123L,126L,128L,129L,131L,132L,135L,137L,138L,141L,144L,146L,147L,150L,153L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189708Inst : IEnumerable<long>
{
public static readonly long[] Value=A189708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189708.Bytes);
public long this[int i]=>Value[i];

public static A189708Inst Instance=new A189708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189709
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,6L,6L,7L,8L,8L,8L,9L,9L,10L,11L,11L,12L,13L,13L,13L,14L,14L,15L,16L,16L,16L,17L,17L,17L,18L,18L,19L,20L,20L,20L,21L,21L,21L,22L,22L,23L,24L,24L,25L,26L,26L,26L,27L,27L,28L,29L,29L,29L,30L,30L,30L,31L,31L,32L,33L,33L,33L,34L,34L,34L,35L,35L,36L,37L,37L,38L,39L,39L,39L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189709Inst : IEnumerable<long>
{
public static readonly long[] Value=A189709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189709.Bytes);
public long this[int i]=>Value[i];

public static A189709Inst Instance=new A189709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189710
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,185L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189710Inst : IEnumerable<long>
{
public static readonly long[] Value=A189710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189710.Bytes);
public long this[int i]=>Value[i];

public static A189710Inst Instance=new A189710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189711
{
public static readonly long[] Value={ 2L,10L,8L,28L,54L,22L,60L,190L,204L,52L,110L,490L,916L,676L,114L,182L,1050L,2878L,3932L,2118L,240L,280L,1988L,7278L,15210L,16148L,6474L,494L,408L,3444L,15890L,45738L,77470L,65210L,19576L,1004L,570L,5580L,31192L,115808L,278358L,389640L,261708L,58920L,2026L,770L,8580L,56484L,258720L,820118L,1677048L,1951700L,1048008L,176994L,4072L,1012L,12650L,96006L,525444L,2090296L,5758802L,10073698L,9763628L,4193580L,531262L,8166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189711Inst : IEnumerable<long>
{
public static readonly long[] Value=A189711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189711.Bytes);
public long this[int i]=>Value[i];

public static A189711Inst Instance=new A189711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189712
{
public static readonly long[] Value={ 30L,56L,60L,90L,105L,120L,132L,144L,168L,180L,210L,240L,252L,264L,280L,288L,306L,315L,336L,351L,360L,380L,396L,400L,420L,432L,480L,495L,504L,520L,525L,528L,540L,546L,552L,560L,576L,612L,616L,630L,660L,672L,702L,720L,735L,756L,760L,792L,800L,810L,840L,858L,864L,900L,918L,924L,960L,990L,992L,1008L,1040L,1050L,1053L,1056L,1080L,1092L,1100L,1104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189712Inst : IEnumerable<long>
{
public static readonly long[] Value=A189712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189712.Bytes);
public long this[int i]=>Value[i];

public static A189712Inst Instance=new A189712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189713
{
public static readonly long[] Value={ 1L,6L,23L,56L,168L,459L,1080L,2400L,5461L,12678L,28728L,63336L,138717L,303346L,663179L,1438098L,3062730L,6450121L,13583957L,28627773L,59954459L,124413466L,258510987L,543867101L,1152248068L,2428235533L,5069886692L,10511339217L,21696371682L,44710463120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189713Inst : IEnumerable<long>
{
public static readonly long[] Value=A189713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189713.Bytes);
public long this[int i]=>Value[i];

public static A189713Inst Instance=new A189713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189714
{
public static readonly long[] Value={ 1L,5L,19L,61L,146L,336L,757L,1711L,3868L,8752L,19680L,43869L,96695L,210638L,453863L,968875L,2053227L,4328457L,9093933L,19068574L,39943650L,83628355L,175018478L,366081158L,765102861L,1597315609L,3330380539L,6933810090L,14414812994L,29924339675L,62038821363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189714Inst : IEnumerable<long>
{
public static readonly long[] Value=A189714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189714.Bytes);
public long this[int i]=>Value[i];

public static A189714Inst Instance=new A189714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189715
{
public static readonly long[] Value={ 1L,4L,6L,7L,9L,10L,13L,15L,16L,19L,22L,24L,25L,28L,31L,33L,34L,36L,37L,40L,42L,43L,46L,49L,51L,52L,54L,55L,58L,60L,61L,63L,64L,67L,69L,70L,73L,76L,78L,79L,81L,82L,85L,87L,88L,90L,91L,94L,96L,97L,100L,103L,105L,106L,109L,112L,114L,115L,117L,118L,121L,123L,124L,127L,130L,132L,133L,135L,136L,139L,141L,142L,144L,145L,148L,150L,151L,154L,157L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189715Inst : IEnumerable<long>
{
public static readonly long[] Value=A189715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189715.Bytes);
public long this[int i]=>Value[i];

public static A189715Inst Instance=new A189715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189716
{
public static readonly long[] Value={ 2L,3L,5L,8L,11L,12L,14L,17L,18L,20L,21L,23L,26L,27L,29L,30L,32L,35L,38L,39L,41L,44L,45L,47L,48L,50L,53L,56L,57L,59L,62L,65L,66L,68L,71L,72L,74L,75L,77L,80L,83L,84L,86L,89L,92L,93L,95L,98L,99L,101L,102L,104L,107L,108L,110L,111L,113L,116L,119L,120L,122L,125L,126L,128L,129L,131L,134L,137L,138L,140L,143L,146L,147L,149L,152L,153L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189716Inst : IEnumerable<long>
{
public static readonly long[] Value=A189716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189716.Bytes);
public long this[int i]=>Value[i];

public static A189716Inst Instance=new A189716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189717
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,4L,4L,4L,5L,6L,6L,7L,7L,7L,8L,9L,9L,10L,11L,11L,12L,12L,12L,13L,14L,14L,15L,16L,16L,17L,17L,17L,18L,18L,18L,19L,20L,20L,21L,21L,21L,22L,23L,23L,24L,25L,25L,26L,26L,26L,27L,27L,27L,28L,29L,29L,30L,30L,30L,31L,31L,31L,32L,33L,33L,34L,34L,34L,35L,36L,36L,37L,38L,38L,39L,39L,39L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189717Inst : IEnumerable<long>
{
public static readonly long[] Value=A189717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189717.Bytes);
public long this[int i]=>Value[i];

public static A189717Inst Instance=new A189717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189718
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189718Inst : IEnumerable<long>
{
public static readonly long[] Value=A189718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189718.Bytes);
public long this[int i]=>Value[i];

public static A189718Inst Instance=new A189718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189719
{
public static readonly long[] Value={ 1L,5L,6L,8L,9L,11L,12L,13L,16L,20L,21L,22L,25L,29L,30L,31L,34L,37L,41L,42L,44L,45L,46L,50L,51L,53L,54L,56L,57L,58L,61L,64L,68L,69L,71L,72L,73L,77L,78L,80L,81L,83L,84L,85L,88L,91L,95L,96L,98L,99L,100L,104L,105L,107L,108L,109L,113L,114L,116L,117L,119L,120L,121L,124L,128L,129L,130L,133L,136L,140L,141L,143L,144L,146L,147L,148L,151L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189719Inst : IEnumerable<long>
{
public static readonly long[] Value=A189719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189719.Bytes);
public long this[int i]=>Value[i];

public static A189719Inst Instance=new A189719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189720
{
public static readonly long[] Value={ 2L,3L,4L,7L,10L,14L,15L,17L,18L,19L,23L,24L,26L,27L,28L,32L,33L,35L,36L,38L,39L,40L,43L,47L,48L,49L,52L,55L,59L,60L,62L,63L,65L,66L,67L,70L,74L,75L,76L,79L,82L,86L,87L,89L,90L,92L,93L,94L,97L,101L,102L,103L,106L,110L,111L,112L,115L,118L,122L,123L,125L,126L,127L,131L,132L,134L,135L,137L,138L,139L,142L,145L,149L,150L,152L,153L,154L,158L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189720Inst : IEnumerable<long>
{
public static readonly long[] Value=A189720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189720.Bytes);
public long this[int i]=>Value[i];

public static A189720Inst Instance=new A189720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189721
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,7L,7L,8L,9L,10L,10L,10L,10L,11L,12L,12L,13L,14L,15L,15L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,22L,22L,22L,23L,23L,23L,23L,24L,25L,26L,26L,26L,27L,27L,27L,28L,28L,28L,28L,29L,30L,30L,31L,32L,32L,33L,34L,35L,35L,35L,36L,36L,36L,36L,37L,38L,39L,39L,39L,40L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189721Inst : IEnumerable<long>
{
public static readonly long[] Value=A189721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189721.Bytes);
public long this[int i]=>Value[i];

public static A189721Inst Instance=new A189721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189722
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,141L,226L,362L,580L,921L,1468L,2344L,3740L,5922L,9413L,14978L,23829L,37686L,59770L,94882L,150606L,237947L,376784L,597063L,946086L,1493497L,2361970L,3737699L,5914635L,9330438L,14741315L,23301716L,36833270L,58071568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189722Inst : IEnumerable<long>
{
public static readonly long[] Value=A189722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189722.Bytes);
public long this[int i]=>Value[i];

public static A189722Inst Instance=new A189722Inst();

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