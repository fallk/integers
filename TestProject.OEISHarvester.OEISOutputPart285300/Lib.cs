using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A187303
{
public static readonly long[] Value={ 0L,0L,72L,2028L,12778L,37124L,81362L,145100L,231552L,338044L,465734L,613212L,780752L,968044L,1175118L,1401948L,1648534L,1914876L,2200974L,2506828L,2832438L,3177804L,3542926L,3927804L,4332438L,4756828L,5200974L,5664876L,6148534L,6651948L,7175118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187303Inst : IEnumerable<long>
{
public static readonly long[] Value=A187303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187303.Bytes);
public long this[int i]=>Value[i];

public static A187303Inst Instance=new A187303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187304
{
public static readonly long[] Value={ 0L,0L,54L,2968L,25716L,87432L,209700L,399524L,668522L,1010572L,1430378L,1921532L,2485628L,3120300L,3825896L,4601996L,5448634L,6365780L,7353434L,8411596L,9540266L,10739444L,12009130L,13349324L,14760026L,16241236L,17792954L,19415180L,21107914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187304Inst : IEnumerable<long>
{
public static readonly long[] Value=A187304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187304.Bytes);
public long this[int i]=>Value[i];

public static A187304Inst Instance=new A187304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187305
{
public static readonly long[] Value={ 0L,0L,0L,3096L,44824L,187924L,505878L,1044900L,1847506L,2912204L,4254568L,5853664L,7715596L,9827696L,12192058L,14805028L,17667036L,20777536L,24136566L,27744092L,31600114L,35704632L,40057646L,44659156L,49509162L,54607664L,59954662L,65550156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187305Inst : IEnumerable<long>
{
public static readonly long[] Value=A187305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187305.Bytes);
public long this[int i]=>Value[i];

public static A187305Inst Instance=new A187305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187306
{
public static readonly long[] Value={ 1L,0L,2L,2L,7L,14L,37L,90L,233L,602L,1586L,4212L,11299L,30536L,83098L,227474L,625993L,1730786L,4805596L,13393688L,37458331L,105089228L,295673995L,834086420L,2358641377L,6684761124L,18985057352L,54022715450L,154000562759L,439742222070L,1257643249141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187306Inst : IEnumerable<long>
{
public static readonly long[] Value=A187306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187306.Bytes);
public long this[int i]=>Value[i];

public static A187306Inst Instance=new A187306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187307
{
public static readonly long[] Value={ 1L,2L,2L,-1L,-5L,-5L,1L,8L,8L,-1L,-11L,-11L,1L,14L,14L,-1L,-17L,-17L,1L,20L,20L,-1L,-23L,-23L,1L,26L,26L,-1L,-29L,-29L,1L,32L,32L,-1L,-35L,-35L,1L,38L,38L,-1L,-41L,-41L,1L,44L,44L,-1L,-47L,-47L,1L,50L,50L,-1L,-53L,-53L,1L,56L,56L,-1L,-59L,-59L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187307Inst : IEnumerable<long>
{
public static readonly long[] Value=A187307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187307.Bytes);
public long this[int i]=>Value[i];

public static A187307Inst Instance=new A187307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187308
{
public static readonly BigInteger[] Value={ 210L,18792L,5422402L,5243407780L,16720419105846L,176072290483114471L,BigInteger.Parse("6123962812371625570408") };
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
public class A187308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187308Inst Instance=new A187308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187309
{
public static readonly long[] Value={ 210L,1472L,10262L,71836L,502545L,3516295L,24602854L,172142801L,1204456419L,8427400133L,58965241283L,412570864570L,2886695849049L,20197773668299L,141320763334969L,988799977661816L,6918483687265734L,48407582536978550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187309Inst : IEnumerable<long>
{
public static readonly long[] Value=A187309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187309.Bytes);
public long this[int i]=>Value[i];

public static A187309Inst Instance=new A187309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187310
{
public static readonly long[] Value={ 1472L,18792L,237650L,3029032L,38586679L,491649803L,6264576384L,79823385565L,1017110076243L,12960036515411L,165137035418995L,2104179269485804L,26811492792678275L,341632558227269955L,4353088643047986551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187310Inst : IEnumerable<long>
{
public static readonly long[] Value=A187310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187310.Bytes);
public long this[int i]=>Value[i];

public static A187310Inst Instance=new A187310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187311
{
public static readonly BigInteger[] Value={ 10262L,237650L,5422402L,125103786L,2885253967L,66555378453L,1535446610156L,35423389400148L,817231843461740L,18853921505477183L,434968805589706807L,10034934369985494192UL,BigInteger.Parse("231510653332437370574"),BigInteger.Parse("5341059614442076742761") };
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
public class A187311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187311Inst Instance=new A187311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187312
{
public static readonly BigInteger[] Value={ 71836L,3029032L,125103786L,5243407780L,219684364642L,9206325629324L,385878307185440L,16174152113717987L,677941845846382141L,BigInteger.Parse("28416164592526303012"),BigInteger.Parse("1191073362353254969342"),BigInteger.Parse("49924255054152257493562") };
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
public class A187312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187312Inst Instance=new A187312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187313
{
public static readonly BigInteger[] Value={ 502545L,38586679L,2885253967L,219684364642L,16720419105846L,1272968321737346L,96936541525346279L,7381886136632779297L,BigInteger.Parse("562143290050791907402"),BigInteger.Parse("42808456214913586706030"),BigInteger.Parse("3259959385289599256192062") };
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
public class A187313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187313Inst Instance=new A187313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187314
{
public static readonly BigInteger[] Value={ 3516295L,491649803L,66555378453L,9206325629324L,1272968321737346L,176072290483114471L,BigInteger.Parse("24360553147588517588"),BigInteger.Parse("3370511547179611607654"),BigInteger.Parse("466342029228106604821988"),BigInteger.Parse("64523343089040070530245388") };
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
public class A187314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187314Inst Instance=new A187314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187315
{
public static readonly BigInteger[] Value={ 24602854L,6264576384L,1535446610156L,385878307185440L,96936541525346279L,BigInteger.Parse("24360553147588517588"),BigInteger.Parse("6123962812371625570408") };
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
public class A187315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187315Inst Instance=new A187315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187316
{
public static readonly BigInteger[] Value={ 172142801L,79823385565L,35423389400148L,16174152113717987L,7381886136632779297L,BigInteger.Parse("3370511547179611607654") };
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
public class A187316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187316Inst Instance=new A187316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187317
{
public static readonly long[] Value={ 210L,1472L,1472L,10262L,18792L,10262L,71836L,237650L,237650L,71836L,502545L,3029032L,5422402L,3029032L,502545L,3516295L,38586679L,125103786L,125103786L,38586679L,3516295L,24602854L,491649803L,2885253967L,5243407780L,2885253967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187317Inst : IEnumerable<long>
{
public static readonly long[] Value=A187317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187317.Bytes);
public long this[int i]=>Value[i];

public static A187317Inst Instance=new A187317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187318
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,10L,12L,14L,16L,18L,19L,21L,23L,25L,27L,28L,30L,32L,34L,36L,37L,39L,41L,43L,45L,46L,48L,50L,52L,54L,55L,57L,59L,61L,63L,64L,66L,68L,70L,72L,73L,75L,77L,79L,81L,82L,84L,86L,88L,90L,91L,93L,95L,97L,99L,100L,102L,104L,106L,108L,109L,111L,113L,115L,117L,118L,120L,122L,124L,126L,127L,129L,131L,133L,135L,136L,138L,140L,142L,144L,145L,147L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187318Inst : IEnumerable<long>
{
public static readonly long[] Value=A187318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187318.Bytes);
public long this[int i]=>Value[i];

public static A187318Inst Instance=new A187318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187319
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,10L,11L,12L,13L,15L,16L,18L,19L,20L,22L,23L,24L,25L,27L,29L,30L,32L,33L,35L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,67L,69L,70L,71L,73L,74L,76L,77L,78L,79L,81L,83L,84L,85L,86L,88L,89L,91L,93L,94L,95L,96L,98L,99L,101L,102L,103L,105L,106L,108L,110L,111L,112L,113L,115L,116L,118L,119L,120L,122L,123L,125L,126L,127L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187319Inst : IEnumerable<long>
{
public static readonly long[] Value=A187319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187319.Bytes);
public long this[int i]=>Value[i];

public static A187319Inst Instance=new A187319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187320
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,84L,85L,86L,87L,89L,90L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,102L,103L,105L,106L,107L,108L,109L,110L,111L,113L,114L,115L,116L,117L,118L,119L,121L,122L,123L,124L,125L,126L,127L,128L,130L,131L,132L,133L,134L,135L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187320Inst : IEnumerable<long>
{
public static readonly long[] Value=A187320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187320.Bytes);
public long this[int i]=>Value[i];

public static A187320Inst Instance=new A187320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187321
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,3L,4L,4L,6L,6L,7L,7L,9L,9L,10L,10L,12L,12L,13L,13L,15L,15L,16L,16L,18L,18L,19L,19L,21L,21L,22L,22L,24L,24L,25L,25L,27L,27L,28L,28L,30L,30L,31L,31L,33L,33L,34L,34L,36L,36L,37L,37L,39L,39L,40L,40L,42L,42L,43L,43L,45L,45L,46L,46L,48L,48L,49L,49L,51L,51L,52L,52L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187321Inst : IEnumerable<long>
{
public static readonly long[] Value=A187321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187321.Bytes);
public long this[int i]=>Value[i];

public static A187321Inst Instance=new A187321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187322
{
public static readonly long[] Value={ 0L,0L,2L,3L,5L,5L,7L,8L,10L,10L,12L,13L,15L,15L,17L,18L,20L,20L,22L,23L,25L,25L,27L,28L,30L,30L,32L,33L,35L,35L,37L,38L,40L,40L,42L,43L,45L,45L,47L,48L,50L,50L,52L,53L,55L,55L,57L,58L,60L,60L,62L,63L,65L,65L,67L,68L,70L,70L,72L,73L,75L,75L,77L,78L,80L,80L,82L,83L,85L,85L,87L,88L,90L,90L,92L,93L,95L,95L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187322Inst : IEnumerable<long>
{
public static readonly long[] Value=A187322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187322.Bytes);
public long this[int i]=>Value[i];

public static A187322Inst Instance=new A187322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187323
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,4L,6L,6L,8L,9L,10L,10L,13L,13L,14L,15L,17L,17L,19L,19L,21L,22L,23L,23L,26L,26L,27L,28L,30L,30L,32L,32L,34L,35L,36L,36L,39L,39L,40L,41L,43L,43L,45L,45L,47L,48L,49L,49L,52L,52L,53L,54L,56L,56L,58L,58L,60L,61L,62L,62L,65L,65L,66L,67L,69L,69L,71L,71L,73L,74L,75L,75L,78L,78L,79L,80L,82L,82L,84L,84L,86L,87L,88L,88L,91L,91L,92L,93L,95L,95L,97L,97L,99L,100L,101L,101L,104L,104L,105L,106L,108L,108L,110L,110L,112L,113L,114L,114L,117L,117L,118L,119L,121L,121L,123L,123L,125L,126L,127L,127L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187323Inst : IEnumerable<long>
{
public static readonly long[] Value=A187323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187323.Bytes);
public long this[int i]=>Value[i];

public static A187323Inst Instance=new A187323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187324
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,4L,4L,4L,5L,6L,6L,7L,7L,8L,9L,9L,9L,11L,11L,11L,12L,13L,13L,14L,14L,15L,16L,16L,16L,18L,18L,18L,19L,20L,20L,21L,21L,22L,23L,23L,23L,25L,25L,25L,26L,27L,27L,28L,28L,29L,30L,30L,30L,32L,32L,32L,33L,34L,34L,35L,35L,36L,37L,37L,37L,39L,39L,39L,40L,41L,41L,42L,42L,43L,44L,44L,44L,46L,46L,46L,47L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187324Inst : IEnumerable<long>
{
public static readonly long[] Value=A187324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187324.Bytes);
public long this[int i]=>Value[i];

public static A187324Inst Instance=new A187324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187325
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,5L,7L,7L,9L,10L,12L,12L,15L,15L,16L,18L,20L,20L,22L,22L,25L,26L,27L,27L,30L,31L,32L,33L,35L,35L,38L,38L,40L,41L,42L,43L,46L,46L,47L,48L,51L,51L,53L,53L,55L,57L,58L,58L,61L,61L,63L,64L,66L,66L,68L,69L,71L,72L,73L,73L,77L,77L,78L,79L,81L,82L,84L,84L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187325Inst : IEnumerable<long>
{
public static readonly long[] Value=A187325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187325.Bytes);
public long this[int i]=>Value[i];

public static A187325Inst Instance=new A187325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187326
{
public static readonly long[] Value={ 0L,0L,2L,3L,6L,6L,8L,9L,12L,12L,14L,15L,18L,18L,20L,21L,24L,24L,26L,27L,30L,30L,32L,33L,36L,36L,38L,39L,42L,42L,44L,45L,48L,48L,50L,51L,54L,54L,56L,57L,60L,60L,62L,63L,66L,66L,68L,69L,72L,72L,74L,75L,78L,78L,80L,81L,84L,84L,86L,87L,90L,90L,92L,93L,96L,96L,98L,99L,102L,102L,104L,105L,108L,108L,110L,111L,114L,114L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187326Inst : IEnumerable<long>
{
public static readonly long[] Value=A187326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187326.Bytes);
public long this[int i]=>Value[i];

public static A187326Inst Instance=new A187326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187327
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,6L,6L,7L,8L,9L,12L,12L,13L,14L,15L,18L,18L,19L,20L,21L,24L,24L,25L,26L,27L,30L,30L,31L,32L,33L,36L,36L,37L,38L,39L,42L,42L,43L,44L,45L,48L,48L,49L,50L,51L,54L,54L,55L,56L,57L,60L,60L,61L,62L,63L,66L,66L,67L,68L,69L,72L,72L,73L,74L,75L,78L,78L,79L,80L,81L,84L,84L,85L,86L,87L,90L,90L,91L,92L,93L,96L,96L,97L,98L,99L,102L,102L,103L,104L,105L,108L,108L,109L,110L,111L,114L,114L,115L,116L,117L,120L,120L,121L,122L,123L,126L,126L,127L,128L,129L,132L,132L,133L,134L,135L,138L,138L,139L,140L,141L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187327Inst : IEnumerable<long>
{
public static readonly long[] Value=A187327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187327.Bytes);
public long this[int i]=>Value[i];

public static A187327Inst Instance=new A187327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187328
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,9L,10L,11L,12L,14L,15L,16L,18L,19L,20L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,34L,36L,37L,38L,40L,41L,42L,43L,45L,46L,47L,49L,50L,51L,53L,54L,55L,56L,58L,59L,60L,62L,63L,64L,65L,67L,68L,69L,71L,72L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,89L,90L,91L,93L,94L,95L,96L,98L,99L,100L,102L,103L,104L,106L,107L,108L,109L,111L,112L,113L,115L,116L,117L,118L,120L,121L,122L,124L,125L,126L,127L,129L,130L,131L,133L,134L,135L,137L,138L,139L,140L,142L,143L,144L,146L,147L,148L,149L,151L,152L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187328Inst : IEnumerable<long>
{
public static readonly long[] Value=A187328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187328.Bytes);
public long this[int i]=>Value[i];

public static A187328Inst Instance=new A187328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187329
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,3L,4L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,16L,16L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,25L,25L,26L,27L,28L,29L,29L,30L,31L,32L,32L,33L,34L,35L,35L,36L,37L,38L,38L,39L,40L,41L,42L,42L,43L,44L,45L,45L,46L,47L,48L,48L,49L,50L,51L,51L,52L,53L,54L,55L,55L,56L,57L,58L,58L,59L,60L,61L,61L,62L,63L,64L,64L,65L,66L,67L,67L,68L,69L,70L,71L,71L,72L,73L,74L,74L,75L,76L,77L,77L,78L,79L,80L,80L,81L,82L,83L,84L,84L,85L,86L,87L,87L,88L,89L,90L,90L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187329Inst : IEnumerable<long>
{
public static readonly long[] Value=A187329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187329.Bytes);
public long this[int i]=>Value[i];

public static A187329Inst Instance=new A187329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187330
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,8L,10L,12L,14L,15L,17L,19L,21L,22L,24L,26L,28L,29L,31L,33L,35L,37L,38L,40L,42L,44L,45L,47L,49L,51L,52L,54L,56L,58L,59L,61L,63L,65L,67L,68L,70L,72L,74L,75L,77L,79L,81L,82L,84L,86L,88L,89L,91L,93L,95L,97L,98L,100L,102L,104L,105L,107L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187330Inst : IEnumerable<long>
{
public static readonly long[] Value=A187330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187330.Bytes);
public long this[int i]=>Value[i];

public static A187330Inst Instance=new A187330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187331
{
public static readonly long[] Value={ 0L,1L,4L,6L,10L,11L,14L,16L,20L,21L,24L,26L,30L,31L,34L,36L,40L,41L,44L,46L,50L,51L,54L,56L,60L,61L,64L,66L,70L,71L,74L,76L,80L,81L,84L,86L,90L,91L,94L,96L,100L,101L,104L,106L,110L,111L,114L,116L,120L,121L,124L,126L,130L,131L,134L,136L,140L,141L,144L,146L,150L,151L,154L,156L,160L,161L,164L,166L,170L,171L,174L,176L,180L,181L,184L,186L,190L,191L,194L,196L,200L,201L,204L,206L,210L,211L,214L,216L,220L,221L,224L,226L,230L,231L,234L,236L,240L,241L,244L,246L,250L,251L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187331Inst : IEnumerable<long>
{
public static readonly long[] Value=A187331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187331.Bytes);
public long this[int i]=>Value[i];

public static A187331Inst Instance=new A187331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187332
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,9L,12L,13L,15L,17L,18L,19L,22L,23L,25L,27L,28L,29L,32L,33L,35L,37L,38L,39L,42L,43L,45L,47L,48L,49L,52L,53L,55L,57L,58L,59L,62L,63L,65L,67L,68L,69L,72L,73L,75L,77L,78L,79L,82L,83L,85L,87L,88L,89L,92L,93L,95L,97L,98L,99L,102L,103L,105L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187332Inst : IEnumerable<long>
{
public static readonly long[] Value=A187332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187332.Bytes);
public long this[int i]=>Value[i];

public static A187332Inst Instance=new A187332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187333
{
public static readonly long[] Value={ 0L,0L,2L,4L,6L,10L,10L,12L,14L,16L,20L,20L,22L,24L,26L,30L,30L,32L,34L,36L,40L,40L,42L,44L,46L,50L,50L,52L,54L,56L,60L,60L,62L,64L,66L,70L,70L,72L,74L,76L,80L,80L,82L,84L,86L,90L,90L,92L,94L,96L,100L,100L,102L,104L,106L,110L,110L,112L,114L,116L,120L,120L,122L,124L,126L,130L,130L,132L,134L,136L,140L,140L,142L,144L,146L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187333Inst : IEnumerable<long>
{
public static readonly long[] Value=A187333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187333.Bytes);
public long this[int i]=>Value[i];

public static A187333Inst Instance=new A187333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187334
{
public static readonly long[] Value={ 0L,1L,4L,7L,10L,15L,16L,19L,22L,25L,30L,31L,34L,37L,40L,45L,46L,49L,52L,55L,60L,61L,64L,67L,70L,75L,76L,79L,82L,85L,90L,91L,94L,97L,100L,105L,106L,109L,112L,115L,120L,121L,124L,127L,130L,135L,136L,139L,142L,145L,150L,151L,154L,157L,160L,165L,166L,169L,172L,175L,180L,181L,184L,187L,190L,195L,196L,199L,202L,205L,210L,211L,214L,217L,220L,225L,226L,229L,232L,235L,240L,241L,244L,247L,250L,255L,256L,259L,262L,265L,270L,271L,274L,277L,280L,285L,286L,289L,292L,295L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187334Inst : IEnumerable<long>
{
public static readonly long[] Value=A187334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187334.Bytes);
public long this[int i]=>Value[i];

public static A187334Inst Instance=new A187334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187335
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,11L,12L,13L,14L,17L,18L,20L,21L,23L,24L,26L,27L,28L,29L,32L,33L,35L,36L,38L,39L,41L,42L,43L,44L,47L,48L,50L,51L,53L,54L,56L,57L,58L,59L,62L,63L,65L,66L,68L,69L,71L,72L,73L,74L,77L,78L,80L,81L,83L,84L,86L,87L,88L,89L,92L,93L,95L,96L,98L,99L,101L,102L,103L,104L,107L,108L,110L,111L,113L,114L,116L,117L,118L,119L,122L,123L,125L,126L,128L,129L,131L,132L,133L,134L,137L,138L,140L,141L,143L,144L,146L,147L,148L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187335Inst : IEnumerable<long>
{
public static readonly long[] Value=A187335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187335.Bytes);
public long this[int i]=>Value[i];

public static A187335Inst Instance=new A187335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187336
{
public static readonly long[] Value={ 0L,0L,3L,6L,8L,10L,15L,15L,18L,21L,23L,25L,30L,30L,33L,36L,38L,40L,45L,45L,48L,51L,53L,55L,60L,60L,63L,66L,68L,70L,75L,75L,78L,81L,83L,85L,90L,90L,93L,96L,98L,100L,105L,105L,108L,111L,113L,115L,120L,120L,123L,126L,128L,130L,135L,135L,138L,141L,143L,145L,150L,150L,153L,156L,158L,160L,165L,165L,168L,171L,173L,175L,180L,180L,183L,186L,188L,190L,195L,195L,198L,201L,203L,205L,210L,210L,213L,216L,218L,220L,225L,225L,228L,231L,233L,235L,240L,240L,243L,246L,248L,250L,255L,255L,258L,261L,263L,265L,270L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187336Inst : IEnumerable<long>
{
public static readonly long[] Value=A187336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187336.Bytes);
public long this[int i]=>Value[i];

public static A187336Inst Instance=new A187336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187337
{
public static readonly long[] Value={ 0L,0L,3L,6L,9L,12L,15L,21L,21L,24L,27L,30L,33L,36L,42L,42L,45L,48L,51L,54L,57L,63L,63L,66L,69L,72L,75L,78L,84L,84L,87L,90L,93L,96L,99L,105L,105L,108L,111L,114L,117L,120L,126L,126L,129L,132L,135L,138L,141L,147L,147L,150L,153L,156L,159L,162L,168L,168L,171L,174L,177L,180L,183L,189L,189L,192L,195L,198L,201L,204L,210L,210L,213L,216L,219L,222L,225L,231L,231L,234L,237L,240L,243L,246L,252L,252L,255L,258L,261L,264L,267L,273L,273L,276L,279L,282L,285L,288L,294L,294L,297L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187337Inst : IEnumerable<long>
{
public static readonly long[] Value=A187337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187337.Bytes);
public long this[int i]=>Value[i];

public static A187337Inst Instance=new A187337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187338
{
public static readonly long[] Value={ 4L,8L,13L,17L,22L,26L,30L,35L,39L,44L,48L,52L,57L,61L,66L,70L,75L,79L,83L,88L,92L,97L,101L,105L,110L,114L,119L,123L,128L,132L,136L,141L,145L,150L,154L,158L,163L,167L,172L,176L,180L,185L,189L,194L,198L,203L,207L,211L,216L,220L,225L,229L,233L,238L,242L,247L,251L,256L,260L,264L,269L,273L,278L,282L,286L,291L,295L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187338Inst : IEnumerable<long>
{
public static readonly long[] Value=A187338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187338.Bytes);
public long this[int i]=>Value[i];

public static A187338Inst Instance=new A187338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187339
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,13L,16L,18L,20L,23L,25L,27L,30L,32L,34L,36L,39L,41L,43L,46L,48L,50L,53L,55L,57L,60L,62L,64L,66L,69L,71L,73L,76L,78L,80L,83L,85L,87L,90L,92L,94L,96L,99L,101L,103L,106L,108L,110L,113L,115L,117L,120L,122L,124L,126L,129L,131L,133L,136L,138L,140L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187339Inst : IEnumerable<long>
{
public static readonly long[] Value=A187339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187339.Bytes);
public long this[int i]=>Value[i];

public static A187339Inst Instance=new A187339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187548
{
public static readonly BigInteger[] Value={ 1L,2L,64L,2436L,131824L,9203264L,787735648L,79884060128L,9366719620672L,1246887723480128L,185786630586649792L,BigInteger.Parse("30635253866287585088"),BigInteger.Parse("5538860010787064796352"),BigInteger.Parse("1089574788981508858403648"),BigInteger.Parse("231683608824013918904796352"),BigInteger.Parse("52954849085008593516185123648") };
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
public class A187548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187548Inst Instance=new A187548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187549
{
public static readonly long[] Value={ 1L,0L,0L,2L,1L,9L,1L,6L,8L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187549Inst : IEnumerable<long>
{
public static readonly long[] Value=A187549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187549.Bytes);
public long this[int i]=>Value[i];

public static A187549Inst Instance=new A187549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187550
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,12L,15L,19L,24L,35L,46L,60L,83L,102L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187550Inst : IEnumerable<long>
{
public static readonly long[] Value=A187550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187550.Bytes);
public long this[int i]=>Value[i];

public static A187550Inst Instance=new A187550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187551
{
public static readonly long[] Value={ 23469768L,23579640L,23594760L,23674896L,23684976L,23687496L,23745960L,23746968L,23769648L,23796864L,23876496L,23897664L,23947560L,23957640L,23976540L,24367896L,24375960L,24376968L,24539760L,24679368L,24687936L,24753960L,24783696L,24869376L,24876936L,25497360L,25639740L,25749360L,25793460L,25967340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187551Inst : IEnumerable<long>
{
public static readonly long[] Value=A187551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187551.Bytes);
public long this[int i]=>Value[i];

public static A187551Inst Instance=new A187551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187552
{
public static readonly long[] Value={ 1L,6L,1L,18L,24L,1L,40L,180L,60L,1L,75L,800L,900L,120L,1L,126L,2625L,7000L,3150L,210L,1L,196L,7056L,36750L,39200L,8820L,336L,1L,288L,16464L,148176L,308700L,164640L,21168L,504L,1L,405L,34560L,493920L,1778112L,1852200L,564480L,45360L,720L,1L,550L,66825L,1425600L,8149680L,14669424L,8731800L,1663200L,89100L,990L,1L,726L,121000L,3675375L,31363200L,89646480L,92207808L,34303500L,4356000L,163350L,1320L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187552Inst : IEnumerable<long>
{
public static readonly long[] Value=A187552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187552.Bytes);
public long this[int i]=>Value[i];

public static A187552Inst Instance=new A187552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187553
{
public static readonly long[] Value={ 0L,11L,0L,2L,101111L,211L,2111L,101111111L,3L,13L,113L,112121L,23L,21221L,1123L,11213L,41L,1223L,313L,10133L,241L,233L,112223L,21313L,5L,431L,151L,1151L,13313L,251L,2333L,11251L,2243L,53L,1433L,1153L,61L,523L,1523L,11161L,443L,541L,353L,33413L,2621L,163L,1163L,13523L,7L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187553Inst : IEnumerable<long>
{
public static readonly long[] Value=A187553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187553.Bytes);
public long this[int i]=>Value[i];

public static A187553Inst Instance=new A187553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187554
{
public static readonly long[] Value={ 1L,9L,35L,39L,65L,125L,749L,755L,905L,935L,989L,1469L,1829L,1859L,2519L,3161L,4269L,4859L,5165L,5699L,6005L,7319L,8309L,8759L,9155L,9869L,11129L,12819L,12851L,14141L,14279L,15539L,15899L,18689L,19859L,20019L,25115L,25535L,26679L,28049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187554Inst : IEnumerable<long>
{
public static readonly long[] Value=A187554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187554.Bytes);
public long this[int i]=>Value[i];

public static A187554Inst Instance=new A187554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187555
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,6L,9L,1L,0L,24L,66L,24L,1L,0L,120L,500L,350L,50L,1L,0L,720L,4110L,4500L,1275L,90L,1L,0L,5040L,37044L,56840L,25725L,3675L,147L,1L,0L,40320L,365904L,735392L,473830L,109760L,9016L,224L,1L,0L,362880L,3945024L,9922416L,8477784L,2828574L,381024L,19656L,324L,1L,0L,3628800L,46195920L,140724000L,151972800L,67869900L,13287330L,1134000L,39150L,450L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187555Inst : IEnumerable<long>
{
public static readonly long[] Value=A187555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187555.Bytes);
public long this[int i]=>Value[i];

public static A187555Inst Instance=new A187555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187556
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,9L,1L,0L,6L,77L,36L,1L,0L,24L,750L,875L,100L,1L,0L,120L,8494L,20250L,5525L,225L,1L,0L,720L,111132L,488824L,257250L,24500L,441L,1L,0L,5040L,1659636L,12685512L,11514069L,2058000L,85652L,784L,1L,0L,40320L,27943920L,357325100L,522796680L,156042999L,12002256L,252252L,1296L,1L,0L,362880L,524580336L,10941291000L,24681106400L,11453045625L,1444332771L,55566000L,652500L,2025L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187556Inst : IEnumerable<long>
{
public static readonly long[] Value=A187556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187556.Bytes);
public long this[int i]=>Value[i];

public static A187556Inst Instance=new A187556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187557
{
public static readonly long[] Value={ 1L,0L,1L,0L,3L,1L,0L,7L,18L,1L,0L,15L,175L,60L,1L,0L,31L,1350L,1625L,150L,1L,0L,63L,9331L,31500L,9100L,315L,1L,0L,127L,60858L,512001L,367500L,37240L,588L,1L,0L,255L,384175L,7505820L,11823651L,2778300L,122892L,1008L,1L,0L,511L,2379150L,103167625L,330419250L,158670477L,15558480L,346500L,1620L,1L,0L,1023L,14564011L,1359847500L,8414726650L,7632684675L,1460631249L,69854400L,866250L,2475L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187557Inst : IEnumerable<long>
{
public static readonly long[] Value=A187557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187557.Bytes);
public long this[int i]=>Value[i];

public static A187557Inst Instance=new A187557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187558
{
public static readonly long[] Value={ 1L,0L,1L,0L,3L,1L,0L,22L,18L,1L,0L,300L,385L,60L,1L,0L,6576L,11250L,2975L,150L,1L,0L,211680L,444976L,165375L,14875L,315L,1L,0L,9408960L,23164848L,10992856L,1440600L,56350L,588L,1L,0L,552303360L,1543644432L,883573488L,151957281L,8890560L,175812L,1008L,1L,0L,41391544320L,128509156800L,85483976320L,18121263300L,1420415577L,42865200L,475020L,1620L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187558Inst : IEnumerable<long>
{
public static readonly long[] Value=A187558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187558.Bytes);
public long this[int i]=>Value[i];

public static A187558Inst Instance=new A187558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187559
{
public static readonly long[] Value={ 2L,3L,5L,7L,2L,3L,5L,7L,2L,3L,5L,7L,3L,5L,7L,11L,13L,17L,19L,2L,5L,11L,17L,23L,29L,3L,7L,11L,19L,23L,31L,19L,29L,5L,11L,17L,23L,29L,41L,47L,53L,59L,13L,41L,7L,23L,31L,47L,71L,79L,17L,53L,71L,89L,19L,29L,59L,79L,89L,2L,2L,5L,11L,17L,23L,29L,11L,31L,41L,17L,31L,59L,73L,23L,41L,59L,29L,73L,3L,3L,7L,11L,19L,23L,31L,11L,31L,41L,19L,47L,61L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187559Inst : IEnumerable<long>
{
public static readonly long[] Value=A187559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187559.Bytes);
public long this[int i]=>Value[i];

public static A187559Inst Instance=new A187559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187560
{
public static readonly long[] Value={ 2L,13L,59L,247L,1007L,4063L,16319L,65407L,261887L,1048063L,4193279L,16775167L,67104767L,268427263L,1073725439L,4294934527L,17179803647L,68719345663L,274877644799L,1099511103487L,4398045462527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187560Inst : IEnumerable<long>
{
public static readonly long[] Value=A187560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187560.Bytes);
public long this[int i]=>Value[i];

public static A187560Inst Instance=new A187560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187561
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,5L,1L,7L,7L,1L,1L,7L,11L,13L,1L,5L,7L,1L,1L,1L,7L,23L,5L,7L,1L,1L,5L,11L,7L,5L,1L,1L,13L,1L,1L,11L,7L,29L,13L,5L,11L,1L,13L,7L,1L,13L,13L,13L,7L,11L,25L,13L,1L,17L,5L,5L,1L,11L,11L,11L,17L,13L,1L,7L,17L,7L,1L,17L,5L,37L,25L,1L,11L,25L,1L,5L,43L,1L,37L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187561Inst : IEnumerable<long>
{
public static readonly long[] Value=A187561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187561.Bytes);
public long this[int i]=>Value[i];

public static A187561Inst Instance=new A187561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187562
{
public static readonly long[] Value={ 0L,1L,3L,1L,3L,1L,3L,7L,3L,11L,9L,3L,3L,3L,3L,9L,5L,3L,1L,11L,9L,1L,9L,5L,7L,5L,3L,9L,7L,11L,3L,21L,23L,1L,11L,1L,3L,1L,9L,3L,5L,15L,5L,1L,3L,9L,3L,13L,3L,7L,3L,5L,13L,21L,9L,21L,9L,21L,21L,5L,3L,21L,3L,3L,9L,11L,15L,1L,11L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187562Inst : IEnumerable<long>
{
public static readonly long[] Value=A187562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187562.Bytes);
public long this[int i]=>Value[i];

public static A187562Inst Instance=new A187562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187563
{
public static readonly long[] Value={ 0L,1L,-1L,1L,-1L,-1L,11L,7L,17L,11L,-1L,-1L,11L,13L,41L,-1L,41L,-1L,1L,11L,-1L,-1L,17L,41L,-1L,23L,97L,11L,7L,47L,-1L,59L,71L,1L,137L,31L,97L,67L,137L,119L,47L,43L,101L,7L,101L,91L,43L,13L,11L,31L,137L,71L,49L,41L,137L,47L,11L,61L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187563Inst : IEnumerable<long>
{
public static readonly long[] Value=A187563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187563.Bytes);
public long this[int i]=>Value[i];

public static A187563Inst Instance=new A187563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187596
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,2L,0L,1L,1L,1L,3L,3L,1L,1L,1L,0L,5L,0L,5L,0L,1L,1L,1L,8L,11L,11L,8L,1L,1L,1L,0L,13L,0L,36L,0L,13L,0L,1L,1L,1L,21L,41L,95L,95L,41L,21L,1L,1L,1L,0L,34L,0L,281L,0L,281L,0L,34L,0L,1L,1L,1L,55L,153L,781L,1183L,1183L,781L,153L,55L,1L,1L,1L,0L,89L,0L,2245L,0L,6728L,0L,2245L,0L,89L,0L,1L,1L,1L,144L,571L,6336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187596Inst : IEnumerable<long>
{
public static readonly long[] Value=A187596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187596.Bytes);
public long this[int i]=>Value[i];

public static A187596Inst Instance=new A187596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187597
{
public static readonly BigInteger[] Value={ 12780L,226450L,4034228L,71799716L,1277660426L,22737087954L,404628180446L,7200721963324L,128143309080518L,2280425597710644L,40582226931510876L,722197265643541486L,12852150564182578146UL,BigInteger.Parse("228715590684800201626") };
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
public class A187597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187597Inst Instance=new A187597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187598
{
public static readonly BigInteger[] Value={ 226450L,8074640L,292759792L,10573764644L,381716567508L,13784634186006L,497795278276942L,17976310976633484L,649156690187966610L,BigInteger.Parse("23442274798739620648"),BigInteger.Parse("846544307284117366816"),BigInteger.Parse("30570298979230731956070") };
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
public class A187598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187598Inst Instance=new A187598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187599
{
public static readonly BigInteger[] Value={ 4034228L,292759792L,21834817212L,1616392693134L,119535001467744L,8847026088947870L,654776681640016806L,BigInteger.Parse("48458293039460233184"),BigInteger.Parse("3586264824879128318610"),BigInteger.Parse("265411874452236154181166") };
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
public class A187599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187599Inst Instance=new A187599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187600
{
public static readonly long[] Value={ 12780L,226450L,226450L,4034228L,8074640L,4034228L,71799716L,292759792L,292759792L,71799716L,1277660426L,10573764644L,21834817212L,10573764644L,1277660426L,22737087954L,381716567508L,1616392693134L,1616392693134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187600Inst : IEnumerable<long>
{
public static readonly long[] Value=A187600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187600.Bytes);
public long this[int i]=>Value[i];

public static A187600Inst Instance=new A187600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187601
{
public static readonly long[] Value={ 0L,1L,3L,6L,6L,5L,3L,7L,12L,18L,15L,11L,6L,13L,21L,30L,24L,17L,9L,19L,30L,42L,33L,23L,12L,25L,39L,54L,42L,29L,15L,31L,48L,66L,51L,35L,18L,37L,57L,78L,60L,41L,21L,43L,66L,90L,69L,47L,24L,49L,75L,102L,78L,53L,27L,55L,84L,114L,87L,59L,30L,61L,93L,126L,96L,65L,33L,67L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187601Inst : IEnumerable<long>
{
public static readonly long[] Value=A187601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187601.Bytes);
public long this[int i]=>Value[i];

public static A187601Inst Instance=new A187601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187602
{
public static readonly long[] Value={ 2L,5L,19L,1301L,262151L,4782977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187602Inst : IEnumerable<long>
{
public static readonly long[] Value=A187602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187602.Bytes);
public long this[int i]=>Value[i];

public static A187602Inst Instance=new A187602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187603
{
public static readonly BigInteger[] Value={ 2L,7L,283L,47381L,BigInteger.Parse("39346414477670243303441"),BigInteger.Parse("11756638905368911244213090105451203173227585429569569") };
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
public class A187603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187603Inst Instance=new A187603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187604
{
public static readonly long[] Value={ 2L,5L,3011L,45943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187604Inst : IEnumerable<long>
{
public static readonly long[] Value=A187604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187604.Bytes);
public long this[int i]=>Value[i];

public static A187604Inst Instance=new A187604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187605
{
public static readonly BigInteger[] Value={ 5L,29L,BigInteger.Parse("1978419655660313589123997"),BigInteger.Parse("205891132094649000000000000000000000000000029") };
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
public class A187605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187605Inst Instance=new A187605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187606
{
public static readonly long[] Value={ 1L,4L,0L,9L,1L,0L,16L,9L,0L,0L,25L,25L,9L,0L,0L,36L,49L,36L,0L,0L,0L,49L,81L,100L,28L,0L,0L,0L,64L,121L,196L,144L,8L,0L,0L,0L,81L,169L,324L,340L,130L,0L,0L,0L,0L,100L,225L,484L,675L,500L,96L,0L,0L,0L,0L,121L,289L,676L,1120L,1274L,711L,48L,0L,0L,0L,0L,144L,361L,900L,1675L,2372L,2083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187606Inst : IEnumerable<long>
{
public static readonly long[] Value=A187606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187606.Bytes);
public long this[int i]=>Value[i];

public static A187606Inst Instance=new A187606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187607
{
public static readonly long[] Value={ 0L,0L,9L,36L,100L,196L,324L,484L,676L,900L,1156L,1444L,1764L,2116L,2500L,2916L,3364L,3844L,4356L,4900L,5476L,6084L,6724L,7396L,8100L,8836L,9604L,10404L,11236L,12100L,12996L,13924L,14884L,15876L,16900L,17956L,19044L,20164L,21316L,22500L,23716L,24964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187607Inst : IEnumerable<long>
{
public static readonly long[] Value=A187607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187607.Bytes);
public long this[int i]=>Value[i];

public static A187607Inst Instance=new A187607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187608
{
public static readonly long[] Value={ 0L,0L,0L,28L,144L,340L,675L,1120L,1675L,2340L,3115L,4000L,4995L,6100L,7315L,8640L,10075L,11620L,13275L,15040L,16915L,18900L,20995L,23200L,25515L,27940L,30475L,33120L,35875L,38740L,41715L,44800L,47995L,51300L,54715L,58240L,61875L,65620L,69475L,73440L,77515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187608Inst : IEnumerable<long>
{
public static readonly long[] Value=A187608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187608.Bytes);
public long this[int i]=>Value[i];

public static A187608Inst Instance=new A187608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187609
{
public static readonly long[] Value={ 0L,0L,0L,8L,130L,500L,1274L,2372L,3953L,5920L,8273L,11012L,14137L,17648L,21545L,25828L,30497L,35552L,40993L,46820L,53033L,59632L,66617L,73988L,81745L,89888L,98417L,107332L,116633L,126320L,136393L,146852L,157697L,168928L,180545L,192548L,204937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187609Inst : IEnumerable<long>
{
public static readonly long[] Value=A187609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187609.Bytes);
public long this[int i]=>Value[i];

public static A187609Inst Instance=new A187609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187610
{
public static readonly long[] Value={ 0L,0L,0L,0L,96L,711L,2083L,4758L,8979L,14434L,21526L,29978L,39790L,50962L,63494L,77386L,92638L,109250L,127222L,146554L,167246L,189298L,212710L,237482L,263614L,291106L,319958L,350170L,381742L,414674L,448966L,484618L,521630L,560002L,599734L,640826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187610Inst : IEnumerable<long>
{
public static readonly long[] Value=A187610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187610.Bytes);
public long this[int i]=>Value[i];

public static A187610Inst Instance=new A187610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187611
{
public static readonly long[] Value={ 0L,0L,0L,0L,48L,616L,2936L,8530L,17611L,32086L,51955L,76258L,105978L,140386L,179482L,223266L,271738L,324898L,382746L,445282L,512506L,584418L,661018L,742306L,828282L,918946L,1014298L,1114338L,1219066L,1328482L,1442586L,1561378L,1684858L,1813026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187611Inst : IEnumerable<long>
{
public static readonly long[] Value=A187611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187611.Bytes);
public long this[int i]=>Value[i];

public static A187611Inst Instance=new A187611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187692
{
public static readonly long[] Value={ 2L,6L,8L,10L,14L,18L,21L,24L,26L,30L,32L,34L,38L,40L,44L,46L,50L,54L,56L,58L,62L,66L,69L,72L,74L,78L,81L,84L,86L,90L,93L,96L,98L,102L,104L,106L,110L,114L,117L,120L,122L,126L,128L,130L,134L,136L,140L,142L,146L,150L,152L,154L,158L,160L,164L,166L,170L,174L,176L,178L,182L,184L,188L,190L,194L,198L,200L,202L,206L,210L,213L,216L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187692Inst : IEnumerable<long>
{
public static readonly long[] Value=A187692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187692.Bytes);
public long this[int i]=>Value[i];

public static A187692Inst Instance=new A187692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187693
{
public static readonly long[] Value={ 0L,0L,1L,11L,57L,229L,815L,2715L,8701L,27233L,83979L,256519L,778745L,2354637L,7100743L,21375923L,64275189L,193120441L,579951107L,1741032927L,5225458033L,15681092645L,47052715071L,141177019531L,423568807277L,1270781919249L,3812496752635L,11437792247735L,34313980722921L,102943150128253L,308831866303799L,926500430749539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187693Inst : IEnumerable<long>
{
public static readonly long[] Value=A187693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187693.Bytes);
public long this[int i]=>Value[i];

public static A187693Inst Instance=new A187693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187694
{
public static readonly long[] Value={ -1L,3L,22L,-53L,-56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187694Inst : IEnumerable<long>
{
public static readonly long[] Value=A187694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187694.Bytes);
public long this[int i]=>Value[i];

public static A187694Inst Instance=new A187694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187695
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,26L,264L,1846L,10616L,54354L,258388L,1168862L,5109696L,21805162L,91460972L,378874998L,1555269016L,6341845250L,25732834116L,104034429454L,419461348976L,1687846763418L,6781455643420L,27216164395430L,109135969307976L,437358413244466L,1751878519306484L,7014851306040126L,28081422396752416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187695Inst : IEnumerable<long>
{
public static readonly long[] Value=A187695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187695.Bytes);
public long this[int i]=>Value[i];

public static A187695Inst Instance=new A187695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187696
{
public static readonly BigInteger[] Value={ 6L,0L,104L,0L,9350L,0L,4280018L,0L,9966761956L,0L,118224466422070L,0L,7149599148533804130L,0L,BigInteger.Parse("2205540801307910506482568"),0L };
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
public class A187696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187696Inst Instance=new A187696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187697
{
public static readonly long[] Value={ 50L,8L,7954L,1548L,15128848L,454640L,231192094416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187697Inst : IEnumerable<long>
{
public static readonly long[] Value=A187697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187697.Bytes);
public long this[int i]=>Value[i];

public static A187697Inst Instance=new A187697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187698
{
public static readonly long[] Value={ 192L,74L,87258L,22738L,1089964504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187698Inst : IEnumerable<long>
{
public static readonly long[] Value=A187698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187698.Bytes);
public long this[int i]=>Value[i];

public static A187698Inst Instance=new A187698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187699
{
public static readonly long[] Value={ 6L,50L,0L,192L,8L,104L,512L,74L,7954L,0L,1126L,280L,87258L,1548L,9350L,2146L,784L,692410L,22738L,15128848L,0L,3760L,1970L,2363474L,320674L,1089964504L,454640L,4280018L,6112L,3580L,10839282L,1147854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187699Inst : IEnumerable<long>
{
public static readonly long[] Value=A187699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187699.Bytes);
public long this[int i]=>Value[i];

public static A187699Inst Instance=new A187699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187700
{
public static readonly long[] Value={ 104L,7954L,87258L,692410L,2363474L,10839282L,23999702L,69386216L,148926738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187700Inst : IEnumerable<long>
{
public static readonly long[] Value=A187700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187700.Bytes);
public long this[int i]=>Value[i];

public static A187700Inst Instance=new A187700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187701
{
public static readonly long[] Value={ 31L,1489L,72L,5030L,36L,7410L,474L,176936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187701Inst : IEnumerable<long>
{
public static readonly long[] Value=A187701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187701.Bytes);
public long this[int i]=>Value[i];

public static A187701Inst Instance=new A187701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187702
{
public static readonly long[] Value={ 64L,8272L,322L,81456L,530L,230446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187702Inst : IEnumerable<long>
{
public static readonly long[] Value=A187702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187702.Bytes);
public long this[int i]=>Value[i];

public static A187702Inst Instance=new A187702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187703
{
public static readonly long[] Value={ 113L,31461L,1718L,875696L,4612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187703Inst : IEnumerable<long>
{
public static readonly long[] Value=A187703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187703.Bytes);
public long this[int i]=>Value[i];

public static A187703Inst Instance=new A187703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187704
{
public static readonly long[] Value={ 170L,93476L,2904L,4225652L,12898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187704Inst : IEnumerable<long>
{
public static readonly long[] Value=A187704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187704.Bytes);
public long this[int i]=>Value[i];

public static A187704Inst Instance=new A187704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187705
{
public static readonly long[] Value={ 10L,31L,128L,64L,1489L,2L,113L,8272L,72L,34L,170L,31461L,322L,5030L,0L,255L,93476L,1718L,81456L,36L,2L,336L,235773L,2904L,875696L,530L,7410L,0L,449L,524284L,9834L,4225652L,4612L,230446L,474L,0L,570L,1062857L,13324L,22532156L,12898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187705Inst : IEnumerable<long>
{
public static readonly long[] Value=A187705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187705.Bytes);
public long this[int i]=>Value[i];

public static A187705Inst Instance=new A187705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187706
{
public static readonly long[] Value={ 128L,1489L,8272L,31461L,93476L,235773L,524284L,1062857L,1999212L,3541677L,5967404L,9648841L,15048584L,22766353L,33534080L,48248321L,67983232L,94042589L,127929948L,171449249L,226655576L,295941137L,382036240L,488090685L,617595596L,774557293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187706Inst : IEnumerable<long>
{
public static readonly long[] Value=A187706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187706.Bytes);
public long this[int i]=>Value[i];

public static A187706Inst Instance=new A187706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187707
{
public static readonly long[] Value={ 2L,72L,322L,1718L,2904L,9834L,13324L,31000L,49910L,84760L,98226L,211526L,234336L,325654L,454612L,691052L,742006L,1152832L,1224538L,1765938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187707Inst : IEnumerable<long>
{
public static readonly long[] Value=A187707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187707.Bytes);
public long this[int i]=>Value[i];

public static A187707Inst Instance=new A187707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187772
{
public static readonly long[] Value={ 3L,14L,8L,21L,52L,6L,124L,54L,28L,20L,315L,484L,42L,124L,24L,90L,130L,248L,186L,364L,16L,105L,144L,630L,3124L,378L,84L,12L,4088L,11480L,180L,120L,15004L,342L,56L,24L,567L,78728L,210L,120L,8190L,11204L,84L,156L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187772Inst : IEnumerable<long>
{
public static readonly long[] Value=A187772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187772.Bytes);
public long this[int i]=>Value[i];

public static A187772Inst Instance=new A187772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187773
{
public static readonly long[] Value={ 23L,31L,44L,59L,76L,83L,87L,104L,107L,108L,116L,135L,139L,140L,152L,172L,175L,200L,204L,211L,212L,216L,231L,239L,243L,244L,247L,255L,268L,300L,324L,356L,379L,411L,419L,424L,431L,440L,451L,460L,472L,484L,492L,499L,503L,515L,516L,519L,543L,628L,652L,687L,696L,728L,744L,771L,815L,876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187773Inst : IEnumerable<long>
{
public static readonly long[] Value=A187773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187773.Bytes);
public long this[int i]=>Value[i];

public static A187773Inst Instance=new A187773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187774
{
public static readonly long[] Value={ 2L,3L,5L,7L,12L,13L,20L,28L,52L,61L,116L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187774Inst : IEnumerable<long>
{
public static readonly long[] Value=A187774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187774.Bytes);
public long this[int i]=>Value[i];

public static A187774Inst Instance=new A187774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187775
{
public static readonly long[] Value={ 1L,3L,4L,13L,22L,84L,169L,585L,1368L,4352L,11018L,33610L,89097L,265059L,724070L,2122093L,5909279L,17178016L,48426584L,140179658L,398403254L,1150970558L,3289206057L,9495961430L,27241417922L,78650410773L,226250990962L,653512163209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187775Inst : IEnumerable<long>
{
public static readonly long[] Value=A187775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187775.Bytes);
public long this[int i]=>Value[i];

public static A187775Inst Instance=new A187775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187776
{
public static readonly long[] Value={ 14L,22L,31L,89L,97L,113L,129L,137L,161L,193L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187776Inst : IEnumerable<long>
{
public static readonly long[] Value=A187776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187776.Bytes);
public long this[int i]=>Value[i];

public static A187776Inst Instance=new A187776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187777
{
public static readonly long[] Value={ 43L,46L,61L,69L,93L,109L,133L,157L,177L,181L,201L,217L,241L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187777Inst : IEnumerable<long>
{
public static readonly long[] Value=A187777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187777.Bytes);
public long this[int i]=>Value[i];

public static A187777Inst Instance=new A187777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187778
{
public static readonly long[] Value={ 1L,6L,12L,18L,24L,36L,48L,54L,72L,96L,108L,144L,162L,192L,216L,288L,324L,384L,432L,486L,576L,648L,768L,864L,972L,1152L,1296L,1458L,1536L,1728L,1944L,2304L,2592L,2916L,3072L,3456L,3888L,4374L,4608L,5184L,5832L,6144L,6912L,7776L,8748L,9216L,10368L,11664L,12288L,13122L,13824L,15552L,17496L,18432L,20736L,23328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187778Inst : IEnumerable<long>
{
public static readonly long[] Value=A187778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187778.Bytes);
public long this[int i]=>Value[i];

public static A187778Inst Instance=new A187778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187779
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,32L,36L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187779Inst : IEnumerable<long>
{
public static readonly long[] Value=A187779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187779.Bytes);
public long this[int i]=>Value[i];

public static A187779Inst Instance=new A187779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187780
{
public static readonly BigInteger[] Value={ 1L,3L,6L,13L,31L,84L,271L,1111L,6096L,44965L,434321L,5388944L,85434621L,1727597731L,44466614106L,1455616862597L,60619117448531L,3211943842710212L,216483614502128251L,BigInteger.Parse("18558646821817827015"),BigInteger.Parse("2023790814160269113876"),BigInteger.Parse("280732940929438329958733"),BigInteger.Parse("49535201863823517417076181") };
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
public class A187780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187780Inst Instance=new A187780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187781
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,7L,14L,14L,25L,22L,41L,40L,63L,61L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187781Inst : IEnumerable<long>
{
public static readonly long[] Value=A187781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187781.Bytes);
public long this[int i]=>Value[i];

public static A187781Inst Instance=new A187781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187782
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,5L,3L,5L,2L,6L,3L,6L,4L,7L,5L,7L,5L,6L,6L,7L,4L,7L,6L,7L,6L,9L,4L,8L,5L,7L,6L,8L,6L,8L,6L,7L,7L,9L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187782Inst : IEnumerable<long>
{
public static readonly long[] Value=A187782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187782.Bytes);
public long this[int i]=>Value[i];

public static A187782Inst Instance=new A187782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187783
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,6L,6L,1L,1L,1L,20L,90L,24L,1L,1L,1L,70L,1680L,2520L,120L,1L,1L,1L,252L,34650L,369600L,113400L,720L,1L,1L,1L,924L,756756L,63063000L,168168000L,7484400L,5040L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187783Inst : IEnumerable<long>
{
public static readonly long[] Value=A187783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187783.Bytes);
public long this[int i]=>Value[i];

public static A187783Inst Instance=new A187783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187784
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,1L,6L,0L,6L,7L,8L,36L,0L,24L,21L,100L,60L,240L,0L,120L,141L,372L,1170L,480L,1800L,0L,720L,743L,3584L,5166L,13440L,4200L,15120L,0L,5040L,5699L,22864L,67368L,68544L,159600L,40320L,141120L,0L,40320L,42241L,225684L,502200L,1161216L,922320L,1995840L,423360L,1451520L,0L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187784Inst : IEnumerable<long>
{
public static readonly long[] Value=A187784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187784.Bytes);
public long this[int i]=>Value[i];

public static A187784Inst Instance=new A187784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187785
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,3L,1L,2L,3L,2L,4L,0L,2L,2L,3L,4L,1L,3L,1L,3L,3L,3L,2L,3L,2L,3L,2L,2L,4L,2L,7L,1L,3L,2L,1L,6L,4L,4L,3L,1L,3L,2L,3L,6L,3L,6L,0L,3L,3L,2L,6L,2L,4L,1L,3L,4L,3L,3L,4L,4L,1L,1L,1L,3L,3L,6L,2L,2L,2L,2L,7L,1L,3L,3L,2L,5L,2L,5L,2L,1L,5L,1L,4L,1L,4L,4L,1L,3L,2L,3L,4L,2L,3L,4L,2L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187785Inst : IEnumerable<long>
{
public static readonly long[] Value=A187785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187785.Bytes);
public long this[int i]=>Value[i];

public static A187785Inst Instance=new A187785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187786
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,5L,6L,7L,8L,9L,10L,12L,9L,10L,12L,11L,13L,14L,9L,10L,12L,11L,13L,14L,11L,13L,14L,15L,16L,17L,18L,20L,24L,17L,18L,20L,24L,19L,21L,22L,25L,26L,28L,17L,18L,20L,24L,19L,21L,22L,25L,26L,28L,19L,21L,22L,25L,26L,28L,23L,27L,29L,30L,17L,18L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187786Inst : IEnumerable<long>
{
public static readonly long[] Value=A187786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187786.Bytes);
public long this[int i]=>Value[i];

public static A187786Inst Instance=new A187786Inst();

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