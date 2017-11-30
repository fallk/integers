using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A166605
{
public static readonly long[] Value={ 1L,13L,64L,95L,111L,118L,123L,133L,134L,140L,151L,177L,199L,217L,229L,242L,255L,264L,274L,281L,302L,305L,325L,333L,338L,354L,359L,365L,376L,394L,411L,414L,431L,433L,440L,472L,475L,477L,489L,514L,525L,528L,529L,537L,547L,569L,574L,583L,584L,585L,589L,594L,615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166605Inst : IEnumerable<long>
{
public static readonly long[] Value=A166605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166605.Bytes);
public long this[int i]=>Value[i];

public static A166605Inst Instance=new A166605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166606
{
public static readonly long[] Value={ 1L,1556L,1640L,3907L,5642L,6205L,7238L,8311L,10350L,11551L,12499L,13371L,13812L,17524L,17589L,18162L,18790L,21569L,21573L,22381L,22544L,23809L,24312L,24416L,24598L,24629L,25247L,25463L,26093L,26583L,26829L,27091L,27098L,28646L,28804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166606Inst : IEnumerable<long>
{
public static readonly long[] Value=A166606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166606.Bytes);
public long this[int i]=>Value[i];

public static A166606Inst Instance=new A166606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166607
{
public static readonly long[] Value={ 1L,733L,1637L,2096L,2367L,4231L,5674L,5839L,7585L,8344L,13719L,13753L,14983L,15151L,15197L,15257L,15757L,16595L,17305L,18791L,20701L,21442L,23652L,23738L,24519L,24789L,25474L,25916L,25933L,27474L,27487L,29185L,31455L,32846L,32950L,33421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166607Inst : IEnumerable<long>
{
public static readonly long[] Value=A166607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166607.Bytes);
public long this[int i]=>Value[i];

public static A166607Inst Instance=new A166607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166608
{
public static readonly BigInteger[] Value={ 1L,22L,462L,9702L,203742L,4278582L,89850222L,1886854662L,39623947902L,832102905942L,17474161024782L,366957381520422L,7706105011928631L,161828205250496400L,3398392310260322760L,BigInteger.Parse("71366238515464643520") };
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
public class A166608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166608Inst Instance=new A166608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166609
{
public static readonly long[] Value={ 1L,1441L,1715L,11706L,16741L,18435L,23793L,29927L,32071L,33932L,45768L,45831L,47103L,47215L,48257L,55743L,56007L,61976L,62773L,64841L,68561L,70853L,70880L,81624L,83526L,86243L,87529L,88162L,91054L,91395L,92288L,92933L,94211L,98982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166609Inst : IEnumerable<long>
{
public static readonly long[] Value=A166609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166609.Bytes);
public long this[int i]=>Value[i];

public static A166609Inst Instance=new A166609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166610
{
public static readonly BigInteger[] Value={ 1L,23L,506L,11132L,244904L,5387888L,118533536L,2607737792L,57370231424L,1262145091328L,27767192009216L,610878224202752L,13439320932460291L,295665060514120836L,6504631331310536193L,BigInteger.Parse("143101889288829107868") };
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
public class A166610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166610Inst Instance=new A166610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166611
{
public static readonly BigInteger[] Value={ 1L,24L,552L,12696L,292008L,6716184L,154472232L,3552861336L,81715810728L,1879463646744L,43227663875112L,994236269127576L,22867434189933972L,525950986368475008L,12096872686474779456UL,BigInteger.Parse("278228071788916575744") };
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
public class A166611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166611Inst Instance=new A166611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166612
{
public static readonly BigInteger[] Value={ 1L,25L,600L,14400L,345600L,8294400L,199065600L,4777574400L,114661785600L,2751882854400L,66045188505600L,1585084524134400L,38042028579225300L,913008685901400000L,BigInteger.Parse("21912208461633427500"),BigInteger.Parse("525893003079198120000") };
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
public class A166612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166612Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166612.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166612Inst Instance=new A166612Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166613
{
public static readonly BigInteger[] Value={ 1L,26L,650L,16250L,406250L,10156250L,253906250L,6347656250L,158691406250L,3967285156250L,99182128906250L,2479553222656250L,61988830566405925L,1549720764160140000L,BigInteger.Parse("38743019104003297200"),BigInteger.Parse("968575477600077360000") };
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
public class A166613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166613Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166613.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166613Inst Instance=new A166613Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166614
{
public static readonly BigInteger[] Value={ 1L,27L,702L,18252L,474552L,12338352L,320797152L,8340725952L,216858874752L,5638330743552L,146596599332352L,3811511582641152L,99099301148669601L,2576581829865400500L,BigInteger.Parse("66991127576500176075"),BigInteger.Parse("1741769316988998417900") };
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
public class A166614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166614Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166614.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166614Inst Instance=new A166614Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166615
{
public static readonly BigInteger[] Value={ 1L,28L,756L,20412L,551124L,14880348L,401769396L,10847773692L,292889889684L,7908027021468L,213516729579636L,5764951698650172L,155653695863554266L,4202649788315954976L,BigInteger.Parse("113471544284530509168"),BigInteger.Parse("3063731695682316317568") };
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
public class A166615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166615Inst Instance=new A166615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166616
{
public static readonly BigInteger[] Value={ 1L,29L,812L,22736L,636608L,17825024L,499100672L,13974818816L,391294926848L,10956257951744L,306775222648832L,8589706234167296L,240511774556683882L,6734329687587137328L,BigInteger.Parse("188561231252439527286"),BigInteger.Parse("5279714475068297862864") };
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
public class A166616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166616Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166616.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166616Inst Instance=new A166616Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166617
{
public static readonly BigInteger[] Value={ 1L,30L,870L,25230L,731670L,21218430L,615334470L,17844699630L,517496289270L,15007392388830L,435214379276070L,12621216999006030L,366015292971174435L,10614443496164046000UL,BigInteger.Parse("307818861388756968600"),BigInteger.Parse("8926746980273941492800") };
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
public class A166617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166617Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166617.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166617Inst Instance=new A166617Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166618
{
public static readonly BigInteger[] Value={ 1L,31L,930L,27900L,837000L,25110000L,753300000L,22599000000L,677970000000L,20339100000000L,610173000000000L,18305190000000000L,549155699999999535L,16474670999999972100UL,BigInteger.Parse("494240129999998744965"),BigInteger.Parse("14827203899999949807900") };
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
public class A166618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166618Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166618.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166618Inst Instance=new A166618Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166619
{
public static readonly long[] Value={ 5L,67L,1523L,1987L,3119L,9323L,11783L,14551L,21019L,42929L,108191L,177337L,194527L,225227L,244753L,251417L,265123L,301123L,308569L,450503L,507523L,622067L,655351L,772789L,835249L,860891L,900241L,940403L,995611L,1141241L,1171789L,1534727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166619Inst : IEnumerable<long>
{
public static readonly long[] Value=A166619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166619.Bytes);
public long this[int i]=>Value[i];

public static A166619Inst Instance=new A166619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166620
{
public static readonly long[] Value={ 1L,4L,16L,18L,22L,36L,40L,44L,52L,72L,110L,138L,144L,154L,160L,162L,166L,176L,178L,212L,224L,246L,252L,272L,282L,286L,292L,298L,306L,326L,330L,374L,386L,420L,428L,442L,446L,468L,472L,478L,482L,488L,498L,512L,518L,524L,532L,534L,550L,556L,564L,586L,602L,628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166620Inst : IEnumerable<long>
{
public static readonly long[] Value=A166620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166620.Bytes);
public long this[int i]=>Value[i];

public static A166620Inst Instance=new A166620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166621
{
public static readonly long[] Value={ 5L,15L,15L,25L,25L,35L,35L,45L,45L,55L,55L,65L,65L,75L,75L,85L,85L,95L,95L,105L,105L,115L,115L,125L,125L,135L,135L,145L,145L,155L,155L,165L,165L,175L,175L,185L,185L,195L,195L,205L,205L,215L,215L,225L,225L,235L,235L,245L,245L,255L,255L,265L,265L,275L,275L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166621Inst : IEnumerable<long>
{
public static readonly long[] Value=A166621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166621.Bytes);
public long this[int i]=>Value[i];

public static A166621Inst Instance=new A166621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166622
{
public static readonly BigInteger[] Value={ 1L,32L,992L,30752L,953312L,29552672L,916132832L,28400117792L,880403651552L,27292513198112L,846067909141472L,26228105183385632L,813071260684954096L,BigInteger.Parse("25205209081233561600"),BigInteger.Parse("781361481518239933440"),BigInteger.Parse("24222205927065423175680") };
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
public class A166622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166622Inst Instance=new A166622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166623
{
public static readonly long[] Value={ 1L,2L,1L,5L,8L,1L,29L,55L,1L,1L,3164L,3416L,1L,3665L,1L,1L,28L,96446L,923362L,1L,3435L,1L,34381388L,34381640L,1L,20017650854L,1L,93367L,30033648031L,8936504649405L,8936504649431L,1L,31L,93344L,17852200903304L,606046687989917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166623Inst : IEnumerable<long>
{
public static readonly long[] Value=A166623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166623.Bytes);
public long this[int i]=>Value[i];

public static A166623Inst Instance=new A166623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166624
{
public static readonly long[] Value={ 1L,6L,9L,36L,15L,54L,21L,216L,81L,90L,33L,324L,39L,126L,135L,1296L,51L,486L,57L,540L,189L,198L,69L,1944L,225L,234L,729L,756L,87L,810L,93L,7776L,297L,306L,315L,2916L,111L,342L,351L,3240L,123L,1134L,129L,1188L,1215L,414L,141L,11664L,441L,1350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166624Inst : IEnumerable<long>
{
public static readonly long[] Value=A166624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166624.Bytes);
public long this[int i]=>Value[i];

public static A166624Inst Instance=new A166624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166625
{
public static readonly long[] Value={ 1L,8L,12L,64L,20L,96L,28L,512L,144L,160L,44L,768L,52L,224L,240L,4096L,68L,1152L,76L,1280L,336L,352L,92L,6144L,400L,416L,1728L,1792L,116L,1920L,124L,32768L,528L,544L,560L,9216L,148L,608L,624L,10240L,164L,2688L,172L,2816L,2880L,736L,188L,49152L,784L,3200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166625Inst : IEnumerable<long>
{
public static readonly long[] Value=A166625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166625.Bytes);
public long this[int i]=>Value[i];

public static A166625Inst Instance=new A166625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166626
{
public static readonly long[] Value={ 1L,10L,15L,100L,25L,150L,35L,1000L,225L,250L,55L,1500L,65L,350L,375L,10000L,85L,2250L,95L,2500L,525L,550L,115L,15000L,625L,650L,3375L,3500L,145L,3750L,155L,100000L,825L,850L,875L,22500L,185L,950L,975L,25000L,205L,5250L,215L,5500L,5625L,1150L,235L,150000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166626Inst : IEnumerable<long>
{
public static readonly long[] Value=A166626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166626.Bytes);
public long this[int i]=>Value[i];

public static A166626Inst Instance=new A166626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166627
{
public static readonly long[] Value={ 1L,12L,18L,144L,30L,216L,42L,1728L,324L,360L,66L,2592L,78L,504L,540L,20736L,102L,3888L,114L,4320L,756L,792L,138L,31104L,900L,936L,5832L,6048L,174L,6480L,186L,248832L,1188L,1224L,1260L,46656L,222L,1368L,1404L,51840L,246L,9072L,258L,9504L,9720L,1656L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166627Inst : IEnumerable<long>
{
public static readonly long[] Value=A166627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166627.Bytes);
public long this[int i]=>Value[i];

public static A166627Inst Instance=new A166627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166628
{
public static readonly long[] Value={ 1L,14L,21L,196L,35L,294L,49L,2744L,441L,490L,77L,4116L,91L,686L,735L,38416L,119L,6174L,133L,6860L,1029L,1078L,161L,57624L,1225L,1274L,9261L,9604L,203L,10290L,217L,537824L,1617L,1666L,1715L,86436L,259L,1862L,1911L,96040L,287L,14406L,301L,15092L,15435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166628Inst : IEnumerable<long>
{
public static readonly long[] Value=A166628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166628.Bytes);
public long this[int i]=>Value[i];

public static A166628Inst Instance=new A166628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166629
{
public static readonly long[] Value={ 1L,16L,24L,256L,40L,384L,56L,4096L,576L,640L,88L,6144L,104L,896L,960L,65536L,136L,9216L,152L,10240L,1344L,1408L,184L,98304L,1600L,1664L,13824L,14336L,232L,15360L,248L,1048576L,2112L,2176L,2240L,147456L,296L,2432L,2496L,163840L,328L,21504L,344L,22528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166629Inst : IEnumerable<long>
{
public static readonly long[] Value=A166629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166629.Bytes);
public long this[int i]=>Value[i];

public static A166629Inst Instance=new A166629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166630
{
public static readonly long[] Value={ 1L,18L,27L,324L,45L,486L,63L,5832L,729L,810L,99L,8748L,117L,1134L,1215L,104976L,153L,13122L,171L,14580L,1701L,1782L,207L,157464L,2025L,2106L,19683L,20412L,261L,21870L,279L,1889568L,2673L,2754L,2835L,236196L,333L,3078L,3159L,262440L,369L,30618L,387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166630Inst : IEnumerable<long>
{
public static readonly long[] Value=A166630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166630.Bytes);
public long this[int i]=>Value[i];

public static A166630Inst Instance=new A166630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166631
{
public static readonly long[] Value={ 1L,20L,30L,400L,50L,600L,70L,8000L,900L,1000L,110L,12000L,130L,1400L,1500L,160000L,170L,18000L,190L,20000L,2100L,2200L,230L,240000L,2500L,2600L,27000L,28000L,290L,30000L,310L,3200000L,3300L,3400L,3500L,360000L,370L,3800L,3900L,400000L,410L,42000L,430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166631Inst : IEnumerable<long>
{
public static readonly long[] Value=A166631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166631.Bytes);
public long this[int i]=>Value[i];

public static A166631Inst Instance=new A166631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166632
{
public static readonly long[] Value={ 1L,2L,4L,4L,8L,8L,12L,8L,16L,16L,20L,16L,24L,24L,32L,16L,32L,32L,36L,32L,48L,40L,44L,32L,64L,48L,64L,48L,56L,64L,60L,32L,80L,64L,96L,64L,72L,72L,96L,64L,80L,96L,84L,80L,128L,88L,92L,64L,144L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166632Inst : IEnumerable<long>
{
public static readonly long[] Value=A166632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166632.Bytes);
public long this[int i]=>Value[i];

public static A166632Inst Instance=new A166632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166633
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,18L,18L,27L,36L,36L,30L,54L,36L,54L,72L,81L,48L,108L,54L,108L,108L,90L,66L,162L,144L,108L,216L,162L,84L,216L,90L,243L,180L,144L,216L,324L,108L,162L,216L,324L,120L,324L,126L,270L,432L,198L,138L,486L,324L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166633Inst : IEnumerable<long>
{
public static readonly long[] Value=A166633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166633.Bytes);
public long this[int i]=>Value[i];

public static A166633Inst Instance=new A166633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166634
{
public static readonly long[] Value={ 1L,4L,8L,16L,16L,32L,24L,64L,64L,64L,40L,128L,48L,96L,128L,256L,64L,256L,72L,256L,192L,160L,88L,512L,256L,192L,512L,384L,112L,512L,120L,1024L,320L,256L,384L,1024L,144L,288L,384L,1024L,160L,768L,168L,640L,1024L,352L,184L,2048L,576L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166634Inst : IEnumerable<long>
{
public static readonly long[] Value=A166634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166634.Bytes);
public long this[int i]=>Value[i];

public static A166634Inst Instance=new A166634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166635
{
public static readonly long[] Value={ 1L,5L,10L,25L,20L,50L,30L,125L,100L,100L,50L,250L,60L,150L,200L,625L,80L,500L,90L,500L,300L,250L,110L,1250L,400L,300L,1000L,750L,140L,1000L,150L,3125L,500L,400L,600L,2500L,180L,450L,600L,2500L,200L,1500L,210L,1250L,2000L,550L,230L,6250L,900L,2000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166635Inst : IEnumerable<long>
{
public static readonly long[] Value=A166635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166635.Bytes);
public long this[int i]=>Value[i];

public static A166635Inst Instance=new A166635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166636
{
public static readonly long[] Value={ 1L,6L,12L,36L,24L,72L,36L,216L,144L,144L,60L,432L,72L,216L,288L,1296L,96L,864L,108L,864L,432L,360L,132L,2592L,576L,432L,1728L,1296L,168L,1728L,180L,7776L,720L,576L,864L,5184L,216L,648L,864L,5184L,240L,2592L,252L,2160L,3456L,792L,276L,15552L,1296L,3456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166636Inst : IEnumerable<long>
{
public static readonly long[] Value=A166636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166636.Bytes);
public long this[int i]=>Value[i];

public static A166636Inst Instance=new A166636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166637
{
public static readonly long[] Value={ 1L,7L,14L,49L,28L,98L,42L,343L,196L,196L,70L,686L,84L,294L,392L,2401L,112L,1372L,126L,1372L,588L,490L,154L,4802L,784L,588L,2744L,2058L,196L,2744L,210L,16807L,980L,784L,1176L,9604L,252L,882L,1176L,9604L,280L,4116L,294L,3430L,5488L,1078L,322L,33614L,1764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166637Inst : IEnumerable<long>
{
public static readonly long[] Value=A166637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166637.Bytes);
public long this[int i]=>Value[i];

public static A166637Inst Instance=new A166637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166638
{
public static readonly long[] Value={ 1L,8L,16L,64L,32L,128L,48L,512L,256L,256L,80L,1024L,96L,384L,512L,4096L,128L,2048L,144L,2048L,768L,640L,176L,8192L,1024L,768L,4096L,3072L,224L,4096L,240L,32768L,1280L,1024L,1536L,16384L,288L,1152L,1536L,16384L,320L,6144L,336L,5120L,8192L,1408L,368L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166638Inst : IEnumerable<long>
{
public static readonly long[] Value=A166638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166638.Bytes);
public long this[int i]=>Value[i];

public static A166638Inst Instance=new A166638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166639
{
public static readonly long[] Value={ 7L,5L,19L,17L,31L,29L,43L,41L,55L,53L,67L,65L,79L,77L,91L,89L,103L,101L,115L,113L,127L,125L,139L,137L,151L,149L,163L,161L,175L,173L,187L,185L,199L,197L,211L,209L,223L,221L,235L,233L,247L,245L,259L,257L,271L,269L,283L,281L,295L,293L,307L,305L,319L,317L,331L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166639Inst : IEnumerable<long>
{
public static readonly long[] Value=A166639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166639.Bytes);
public long this[int i]=>Value[i];

public static A166639Inst Instance=new A166639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166640
{
public static readonly long[] Value={ 1L,9L,18L,81L,36L,162L,54L,729L,324L,324L,90L,1458L,108L,486L,648L,6561L,144L,2916L,162L,2916L,972L,810L,198L,13122L,1296L,972L,5832L,4374L,252L,5832L,270L,59049L,1620L,1296L,1944L,26244L,324L,1458L,1944L,26244L,360L,8748L,378L,7290L,11664L,1782L,414L,118098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166640Inst : IEnumerable<long>
{
public static readonly long[] Value=A166640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166640.Bytes);
public long this[int i]=>Value[i];

public static A166640Inst Instance=new A166640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166641
{
public static readonly long[] Value={ 1L,10L,20L,100L,40L,200L,60L,1000L,400L,400L,100L,2000L,120L,600L,800L,10000L,160L,4000L,180L,4000L,1200L,1000L,220L,20000L,1600L,1200L,8000L,6000L,280L,8000L,300L,100000L,2000L,1600L,2400L,40000L,360L,1800L,2400L,40000L,400L,12000L,420L,10000L,16000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166641Inst : IEnumerable<long>
{
public static readonly long[] Value=A166641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166641.Bytes);
public long this[int i]=>Value[i];

public static A166641Inst Instance=new A166641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166642
{
public static readonly long[] Value={ 1L,6L,8L,36L,12L,48L,16L,216L,64L,72L,24L,288L,28L,96L,96L,1296L,36L,384L,40L,432L,128L,144L,48L,1728L,144L,168L,512L,576L,60L,576L,64L,7776L,192L,216L,192L,2304L,76L,240L,224L,2592L,84L,768L,88L,864L,768L,288L,96L,10368L,256L,864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166642Inst : IEnumerable<long>
{
public static readonly long[] Value=A166642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166642.Bytes);
public long this[int i]=>Value[i];

public static A166642Inst Instance=new A166642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166643
{
public static readonly long[] Value={ 1L,9L,12L,81L,18L,108L,24L,729L,144L,162L,36L,972L,42L,216L,216L,6561L,54L,1296L,60L,1458L,288L,324L,72L,8748L,324L,378L,1728L,1944L,90L,1944L,96L,59049L,432L,486L,432L,11664L,114L,540L,504L,13122L,126L,2592L,132L,2916L,2592L,648L,144L,78732L,576L,2916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166643Inst : IEnumerable<long>
{
public static readonly long[] Value=A166643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166643.Bytes);
public long this[int i]=>Value[i];

public static A166643Inst Instance=new A166643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166644
{
public static readonly long[] Value={ 1L,12L,16L,144L,24L,192L,32L,1728L,256L,288L,48L,2304L,56L,384L,384L,20736L,72L,3072L,80L,3456L,512L,576L,96L,27648L,576L,672L,4096L,4608L,120L,4608L,128L,248832L,768L,864L,768L,36864L,152L,960L,896L,41472L,168L,6144L,176L,6912L,6144L,1152L,192L,331776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166644Inst : IEnumerable<long>
{
public static readonly long[] Value=A166644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166644.Bytes);
public long this[int i]=>Value[i];

public static A166644Inst Instance=new A166644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166645
{
public static readonly long[] Value={ 1L,15L,20L,225L,30L,300L,40L,3375L,400L,450L,60L,4500L,70L,600L,600L,50625L,90L,6000L,100L,6750L,800L,900L,120L,67500L,900L,1050L,8000L,9000L,150L,9000L,160L,759375L,1200L,1350L,1200L,90000L,190L,1500L,1400L,101250L,210L,12000L,220L,13500L,12000L,1800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166645Inst : IEnumerable<long>
{
public static readonly long[] Value=A166645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166645.Bytes);
public long this[int i]=>Value[i];

public static A166645Inst Instance=new A166645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166646
{
public static readonly long[] Value={ 1L,18L,24L,324L,36L,432L,48L,5832L,576L,648L,72L,7776L,84L,864L,864L,104976L,108L,10368L,120L,11664L,1152L,1296L,144L,139968L,1296L,1512L,13824L,15552L,180L,15552L,192L,1889568L,1728L,1944L,1728L,186624L,228L,2160L,2016L,209952L,252L,20736L,264L,23328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166646Inst : IEnumerable<long>
{
public static readonly long[] Value=A166646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166646.Bytes);
public long this[int i]=>Value[i];

public static A166646Inst Instance=new A166646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166647
{
public static readonly long[] Value={ 1L,21L,28L,441L,42L,588L,56L,9261L,784L,882L,84L,12348L,98L,1176L,1176L,194481L,126L,16464L,140L,18522L,1568L,1764L,168L,259308L,1764L,2058L,21952L,24696L,210L,24696L,224L,4084101L,2352L,2646L,2352L,345744L,266L,2940L,2744L,388962L,294L,32928L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166647Inst : IEnumerable<long>
{
public static readonly long[] Value=A166647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166647.Bytes);
public long this[int i]=>Value[i];

public static A166647Inst Instance=new A166647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166648
{
public static readonly long[] Value={ 1L,24L,32L,576L,48L,768L,64L,13824L,1024L,1152L,96L,18432L,112L,1536L,1536L,331776L,144L,24576L,160L,27648L,2048L,2304L,192L,442368L,2304L,2688L,32768L,36864L,240L,36864L,256L,7962624L,3072L,3456L,3072L,589824L,304L,3840L,3584L,663552L,336L,49152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166648Inst : IEnumerable<long>
{
public static readonly long[] Value=A166648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166648.Bytes);
public long this[int i]=>Value[i];

public static A166648Inst Instance=new A166648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166649
{
public static readonly long[] Value={ 1L,27L,36L,729L,54L,972L,72L,19683L,1296L,1458L,108L,26244L,126L,1944L,1944L,531441L,162L,34992L,180L,39366L,2592L,2916L,216L,708588L,2916L,3402L,46656L,52488L,270L,52488L,288L,14348907L,3888L,4374L,3888L,944784L,342L,4860L,4536L,1062882L,378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166649Inst : IEnumerable<long>
{
public static readonly long[] Value=A166649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166649.Bytes);
public long this[int i]=>Value[i];

public static A166649Inst Instance=new A166649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166650
{
public static readonly long[] Value={ 1L,30L,40L,900L,60L,1200L,80L,27000L,1600L,1800L,120L,36000L,140L,2400L,2400L,810000L,180L,48000L,200L,54000L,3200L,3600L,240L,1080000L,3600L,4200L,64000L,72000L,300L,72000L,320L,24300000L,4800L,5400L,4800L,1440000L,380L,6000L,5600L,1620000L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166650Inst : IEnumerable<long>
{
public static readonly long[] Value=A166650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166650.Bytes);
public long this[int i]=>Value[i];

public static A166650Inst Instance=new A166650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166651
{
public static readonly long[] Value={ 1L,3L,5L,9L,9L,15L,13L,27L,25L,27L,21L,45L,25L,39L,45L,81L,33L,75L,37L,81L,65L,63L,45L,135L,81L,75L,125L,117L,57L,135L,61L,243L,105L,99L,117L,225L,73L,111L,125L,243L,81L,195L,85L,189L,225L,135L,93L,405L,169L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166651Inst : IEnumerable<long>
{
public static readonly long[] Value=A166651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166651.Bytes);
public long this[int i]=>Value[i];

public static A166651Inst Instance=new A166651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166652
{
public static readonly long[] Value={ 1L,5L,8L,25L,14L,40L,20L,125L,64L,70L,32L,200L,38L,100L,112L,625L,50L,320L,56L,350L,160L,160L,68L,1000L,196L,190L,512L,500L,86L,560L,92L,3125L,256L,250L,280L,1600L,110L,280L,304L,1750L,122L,800L,128L,800L,896L,340L,140L,5000L,400L,980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166652Inst : IEnumerable<long>
{
public static readonly long[] Value=A166652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166652.Bytes);
public long this[int i]=>Value[i];

public static A166652Inst Instance=new A166652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166653
{
public static readonly long[] Value={ 1L,7L,11L,49L,19L,77L,27L,343L,121L,133L,43L,539L,51L,189L,209L,2401L,67L,847L,75L,931L,297L,301L,91L,3773L,361L,357L,1331L,1323L,115L,1463L,123L,16807L,473L,469L,513L,5929L,147L,525L,561L,6517L,163L,2079L,171L,2107L,2299L,637L,187L,26411L,729L,2527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166653Inst : IEnumerable<long>
{
public static readonly long[] Value=A166653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166653.Bytes);
public long this[int i]=>Value[i];

public static A166653Inst Instance=new A166653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166654
{
public static readonly long[] Value={ 1L,9L,14L,81L,24L,126L,34L,729L,196L,216L,54L,1134L,64L,306L,336L,6561L,84L,1764L,94L,1944L,476L,486L,114L,10206L,576L,576L,2744L,2754L,144L,3024L,154L,59049L,756L,756L,816L,15876L,184L,846L,896L,17496L,204L,4284L,214L,4374L,4704L,1026L,234L,91854L,1156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166654Inst : IEnumerable<long>
{
public static readonly long[] Value=A166654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166654.Bytes);
public long this[int i]=>Value[i];

public static A166654Inst Instance=new A166654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166655
{
public static readonly long[] Value={ 1L,11L,17L,121L,29L,187L,41L,1331L,289L,319L,65L,2057L,77L,451L,493L,14641L,101L,3179L,113L,3509L,697L,715L,137L,22627L,841L,847L,4913L,4961L,173L,5423L,185L,161051L,1105L,1111L,1189L,34969L,221L,1243L,1309L,38599L,245L,7667L,257L,7865L,8381L,1507L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166655Inst : IEnumerable<long>
{
public static readonly long[] Value=A166655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166655.Bytes);
public long this[int i]=>Value[i];

public static A166655Inst Instance=new A166655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166656
{
public static readonly long[] Value={ 1L,13L,20L,169L,34L,260L,48L,2197L,400L,442L,76L,3380L,90L,624L,680L,28561L,118L,5200L,132L,5746L,960L,988L,160L,43940L,1156L,1170L,8000L,8112L,202L,8840L,216L,371293L,1520L,1534L,1632L,67600L,258L,1716L,1800L,74698L,286L,12480L,300L,12844L,13600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166656Inst : IEnumerable<long>
{
public static readonly long[] Value=A166656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166656.Bytes);
public long this[int i]=>Value[i];

public static A166656Inst Instance=new A166656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166657
{
public static readonly long[] Value={ 1L,15L,23L,225L,39L,345L,55L,3375L,529L,585L,87L,5175L,103L,825L,897L,50625L,135L,7935L,151L,8775L,1265L,1305L,183L,77625L,1521L,1545L,12167L,12375L,231L,13455L,247L,759375L,2001L,2025L,2145L,119025L,295L,2265L,2369L,131625L,327L,18975L,343L,19575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166657Inst : IEnumerable<long>
{
public static readonly long[] Value=A166657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166657.Bytes);
public long this[int i]=>Value[i];

public static A166657Inst Instance=new A166657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166658
{
public static readonly long[] Value={ 1L,17L,26L,289L,44L,442L,62L,4913L,676L,748L,98L,7514L,116L,1054L,1144L,83521L,152L,11492L,170L,12716L,1612L,1666L,206L,127738L,1936L,1972L,17576L,17918L,260L,19448L,278L,1419857L,2548L,2584L,2728L,195364L,332L,2890L,3016L,216172L,368L,27404L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166658Inst : IEnumerable<long>
{
public static readonly long[] Value=A166658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166658.Bytes);
public long this[int i]=>Value[i];

public static A166658Inst Instance=new A166658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166659
{
public static readonly long[] Value={ 1L,19L,29L,361L,49L,551L,69L,6859L,841L,931L,109L,10469L,129L,1311L,1421L,130321L,169L,15979L,189L,17689L,2001L,2071L,229L,198911L,2401L,2451L,24389L,24909L,289L,26999L,309L,2476099L,3161L,3211L,3381L,303601L,369L,3591L,3741L,336091L,409L,38019L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166659Inst : IEnumerable<long>
{
public static readonly long[] Value=A166659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166659.Bytes);
public long this[int i]=>Value[i];

public static A166659Inst Instance=new A166659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166660
{
public static readonly long[] Value={ 1L,5L,7L,25L,11L,35L,15L,125L,49L,55L,23L,175L,27L,75L,77L,625L,35L,245L,39L,275L,105L,115L,47L,875L,121L,135L,343L,375L,59L,385L,63L,3125L,161L,175L,165L,1225L,75L,195L,189L,1375L,83L,525L,87L,575L,539L,235L,95L,4375L,225L,605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166660Inst : IEnumerable<long>
{
public static readonly long[] Value=A166660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166660.Bytes);
public long this[int i]=>Value[i];

public static A166660Inst Instance=new A166660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166661
{
public static readonly long[] Value={ 1L,7L,10L,49L,16L,70L,22L,343L,100L,112L,34L,490L,40L,154L,160L,2401L,52L,700L,58L,784L,220L,238L,70L,3430L,256L,280L,1000L,1078L,88L,1120L,94L,16807L,340L,364L,352L,4900L,112L,406L,400L,5488L,124L,1540L,130L,1666L,1600L,490L,142L,24010L,484L,1792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166661Inst : IEnumerable<long>
{
public static readonly long[] Value=A166661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166661.Bytes);
public long this[int i]=>Value[i];

public static A166661Inst Instance=new A166661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166662
{
public static readonly long[] Value={ 1L,9L,13L,81L,21L,117L,29L,729L,169L,189L,45L,1053L,53L,261L,273L,6561L,69L,1521L,77L,1701L,377L,405L,93L,9477L,441L,477L,2197L,2349L,117L,2457L,125L,59049L,585L,621L,609L,13689L,149L,693L,689L,15309L,165L,3393L,173L,3645L,3549L,837L,189L,85293L,841L,3969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166662Inst : IEnumerable<long>
{
public static readonly long[] Value=A166662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166662.Bytes);
public long this[int i]=>Value[i];

public static A166662Inst Instance=new A166662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166663
{
public static readonly long[] Value={ 1L,11L,16L,121L,26L,176L,36L,1331L,256L,286L,56L,1936L,66L,396L,416L,14641L,86L,2816L,96L,3146L,576L,616L,116L,21296L,676L,726L,4096L,4356L,146L,4576L,156L,161051L,896L,946L,936L,30976L,186L,1056L,1056L,34606L,206L,6336L,216L,6776L,6656L,1276L,236L,234256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166663Inst : IEnumerable<long>
{
public static readonly long[] Value=A166663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166663.Bytes);
public long this[int i]=>Value[i];

public static A166663Inst Instance=new A166663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166664
{
public static readonly long[] Value={ 1L,13L,19L,169L,31L,247L,43L,2197L,361L,403L,67L,3211L,79L,559L,589L,28561L,103L,4693L,115L,5239L,817L,871L,139L,41743L,961L,1027L,6859L,7267L,175L,7657L,187L,371293L,1273L,1339L,1333L,61009L,223L,1495L,1501L,68107L,247L,10621L,259L,11323L,11191L,1807L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166664Inst : IEnumerable<long>
{
public static readonly long[] Value=A166664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166664.Bytes);
public long this[int i]=>Value[i];

public static A166664Inst Instance=new A166664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166665
{
public static readonly long[] Value={ 1L,15L,22L,225L,36L,330L,50L,3375L,484L,540L,78L,4950L,92L,750L,792L,50625L,120L,7260L,134L,8100L,1100L,1170L,162L,74250L,1296L,1380L,10648L,11250L,204L,11880L,218L,759375L,1716L,1800L,1800L,108900L,260L,2010L,2024L,121500L,288L,16500L,302L,17550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166665Inst : IEnumerable<long>
{
public static readonly long[] Value=A166665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166665.Bytes);
public long this[int i]=>Value[i];

public static A166665Inst Instance=new A166665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166666
{
public static readonly long[] Value={ 1L,17L,25L,289L,41L,425L,57L,4913L,625L,697L,89L,7225L,105L,969L,1025L,83521L,137L,10625L,153L,11849L,1425L,1513L,185L,122825L,1681L,1785L,15625L,16473L,233L,17425L,249L,1419857L,2225L,2329L,2337L,180625L,297L,2601L,2625L,201433L,329L,24225L,345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166666Inst : IEnumerable<long>
{
public static readonly long[] Value=A166666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166666.Bytes);
public long this[int i]=>Value[i];

public static A166666Inst Instance=new A166666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166667
{
public static readonly long[] Value={ 1L,19L,28L,361L,46L,532L,64L,6859L,784L,874L,100L,10108L,118L,1216L,1288L,130321L,154L,14896L,172L,16606L,1792L,1900L,208L,192052L,2116L,2242L,21952L,23104L,262L,24472L,280L,2476099L,2800L,2926L,2944L,283024L,334L,3268L,3304L,315514L,370L,34048L,388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166667Inst : IEnumerable<long>
{
public static readonly long[] Value=A166667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166667.Bytes);
public long this[int i]=>Value[i];

public static A166667Inst Instance=new A166667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166668
{
public static readonly long[] Value={ 1L,21L,31L,441L,51L,651L,71L,9261L,961L,1071L,111L,13671L,131L,1491L,1581L,194481L,171L,20181L,191L,22491L,2201L,2331L,231L,287091L,2601L,2751L,29791L,31311L,291L,33201L,311L,4084101L,3441L,3591L,3621L,423801L,371L,4011L,4061L,472311L,411L,46221L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166668Inst : IEnumerable<long>
{
public static readonly long[] Value=A166668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166668.Bytes);
public long this[int i]=>Value[i];

public static A166668Inst Instance=new A166668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166669
{
public static readonly long[] Value={ 1L,4L,7L,16L,13L,28L,19L,64L,49L,52L,31L,112L,37L,76L,91L,256L,49L,196L,55L,208L,133L,124L,67L,448L,169L,148L,343L,304L,85L,364L,91L,1024L,217L,196L,247L,784L,109L,220L,259L,832L,121L,532L,127L,496L,637L,268L,139L,1792L,361L,676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166669Inst : IEnumerable<long>
{
public static readonly long[] Value=A166669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166669.Bytes);
public long this[int i]=>Value[i];

public static A166669Inst Instance=new A166669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166670
{
public static readonly long[] Value={ 1L,8L,13L,64L,23L,104L,33L,512L,169L,184L,53L,832L,63L,264L,299L,4096L,83L,1352L,93L,1472L,429L,424L,113L,6656L,529L,504L,2197L,2112L,143L,2392L,153L,32768L,689L,664L,759L,10816L,183L,744L,819L,11776L,203L,3432L,213L,3392L,3887L,904L,233L,53248L,1089L,4232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166670Inst : IEnumerable<long>
{
public static readonly long[] Value=A166670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166670.Bytes);
public long this[int i]=>Value[i];

public static A166670Inst Instance=new A166670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166671
{
public static readonly long[] Value={ 1L,12L,19L,144L,33L,228L,47L,1728L,361L,396L,75L,2736L,89L,564L,627L,20736L,117L,4332L,131L,4752L,893L,900L,159L,32832L,1089L,1068L,6859L,6768L,201L,7524L,215L,248832L,1425L,1404L,1551L,51984L,257L,1572L,1691L,57024L,285L,10716L,299L,10800L,11913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166671Inst : IEnumerable<long>
{
public static readonly long[] Value=A166671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166671.Bytes);
public long this[int i]=>Value[i];

public static A166671Inst Instance=new A166671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166672
{
public static readonly long[] Value={ 1L,16L,25L,256L,43L,400L,61L,4096L,625L,688L,97L,6400L,115L,976L,1075L,65536L,151L,10000L,169L,11008L,1525L,1552L,205L,102400L,1849L,1840L,15625L,15616L,259L,17200L,277L,1048576L,2425L,2416L,2623L,160000L,331L,2704L,2875L,176128L,367L,24400L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166672Inst : IEnumerable<long>
{
public static readonly long[] Value=A166672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166672.Bytes);
public long this[int i]=>Value[i];

public static A166672Inst Instance=new A166672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166673
{
public static readonly long[] Value={ 1L,8L,11L,64L,17L,88L,23L,512L,121L,136L,35L,704L,41L,184L,187L,4096L,53L,968L,59L,1088L,253L,280L,71L,5632L,289L,328L,1331L,1472L,89L,1496L,95L,32768L,385L,424L,391L,7744L,113L,472L,451L,8704L,125L,2024L,131L,2240L,2057L,568L,143L,45056L,529L,2312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166673Inst : IEnumerable<long>
{
public static readonly long[] Value=A166673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166673.Bytes);
public long this[int i]=>Value[i];

public static A166673Inst Instance=new A166673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166674
{
public static readonly long[] Value={ 1L,12L,17L,144L,27L,204L,37L,1728L,289L,324L,57L,2448L,67L,444L,459L,20736L,87L,3468L,97L,3888L,629L,684L,117L,29376L,729L,804L,4913L,5328L,147L,5508L,157L,248832L,969L,1044L,999L,41616L,187L,1164L,1139L,46656L,207L,7548L,217L,8208L,7803L,1404L,237L,352512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166674Inst : IEnumerable<long>
{
public static readonly long[] Value=A166674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166674.Bytes);
public long this[int i]=>Value[i];

public static A166674Inst Instance=new A166674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166675
{
public static readonly long[] Value={ 1L,16L,23L,256L,37L,368L,51L,4096L,529L,592L,79L,5888L,93L,816L,851L,65536L,121L,8464L,135L,9472L,1173L,1264L,163L,94208L,1369L,1488L,12167L,13056L,205L,13616L,219L,1048576L,1817L,1936L,1887L,135424L,261L,2160L,2139L,151552L,289L,18768L,303L,20224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166675Inst : IEnumerable<long>
{
public static readonly long[] Value=A166675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166675.Bytes);
public long this[int i]=>Value[i];

public static A166675Inst Instance=new A166675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166676
{
public static readonly long[] Value={ 1L,20L,29L,400L,47L,580L,65L,8000L,841L,940L,101L,11600L,119L,1300L,1363L,160000L,155L,16820L,173L,18800L,1885L,2020L,209L,232000L,2209L,2380L,24389L,26000L,263L,27260L,281L,3200000L,2929L,3100L,3055L,336400L,335L,3460L,3451L,376000L,371L,37700L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166676Inst : IEnumerable<long>
{
public static readonly long[] Value=A166676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166676.Bytes);
public long this[int i]=>Value[i];

public static A166676Inst Instance=new A166676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166677
{
public static readonly long[] Value={ 1L,5L,18L,66L,280L,1420L,8544L,59836L,478720L,4308516L,43085200L,473937244L,5687246976L,73934210740L,1035078950416L,15526184256300L,248418948100864L,4223122117714756L,76016198118865680L,1444307764258447996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166677Inst : IEnumerable<long>
{
public static readonly long[] Value=A166677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166677.Bytes);
public long this[int i]=>Value[i];

public static A166677Inst Instance=new A166677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166678
{
public static readonly long[] Value={ 2L,2L,3L,6L,14L,34L,110L,384L,1540L,7019L,34501L,183439L,1045196L,6164423L,38285946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166678Inst : IEnumerable<long>
{
public static readonly long[] Value=A166678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166678.Bytes);
public long this[int i]=>Value[i];

public static A166678Inst Instance=new A166678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166679
{
public static readonly BigInteger[] Value={ 1L,33L,1056L,33792L,1081344L,34603008L,1107296256L,35433480192L,1133871366144L,36283883716608L,1161084278931456L,37154696925806592L,1188950301625810416L,BigInteger.Parse("38046409652025916416"),BigInteger.Parse("1217485108864828785168"),BigInteger.Parse("38959523483674503840768") };
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
public class A166679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166679Inst Instance=new A166679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166680
{
public static readonly long[] Value={ 1L,-3L,-14L,-54L,-232L,-1180L,-7104L,-49756L,-398080L,-3582756L,-35827600L,-394103644L,-4729243776L,-61480169140L,-860722368016L,-12910835520300L,-206573368324864L,-3511747261522756L,-63211450707409680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166680Inst : IEnumerable<long>
{
public static readonly long[] Value=A166680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166680.Bytes);
public long this[int i]=>Value[i];

public static A166680Inst Instance=new A166680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166681
{
public static readonly long[] Value={ 13L,17L,37L,79L,107L,113L,127L,131L,137L,139L,149L,157L,163L,167L,173L,179L,181L,191L,197L,199L,239L,241L,251L,277L,281L,283L,313L,337L,347L,349L,359L,367L,373L,379L,389L,397L,419L,457L,461L,463L,467L,479L,491L,563L,569L,571L,577L,587L,593L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166681Inst : IEnumerable<long>
{
public static readonly long[] Value=A166681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166681.Bytes);
public long this[int i]=>Value[i];

public static A166681Inst Instance=new A166681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166682
{
public static readonly BigInteger[] Value={ 1L,34L,1122L,37026L,1221858L,40321314L,1330603362L,43909910946L,1449027061218L,47817893020194L,1577990469666402L,52073685498991266L,1718431621466711217L,BigInteger.Parse("56708243508401451648"),BigInteger.Parse("1871372035777247294016"),BigInteger.Parse("61755277180649140560384") };
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
public class A166682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166682Inst Instance=new A166682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166683
{
public static readonly BigInteger[] Value={ 1L,35L,1190L,40460L,1375640L,46771760L,1590239840L,54068154560L,1838317255040L,62502786671360L,2125094746826240L,72253221392092160L,2456609527331132845L,BigInteger.Parse("83524723929258496500"),BigInteger.Parse("2839840613594788193775"),BigInteger.Parse("96554580862222775222700") };
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
public class A166683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166683Inst Instance=new A166683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166684
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166684Inst : IEnumerable<long>
{
public static readonly long[] Value=A166684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166684.Bytes);
public long this[int i]=>Value[i];

public static A166684Inst Instance=new A166684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166685
{
public static readonly long[] Value={ 1L,5L,17L,19L,29L,31L,41L,43L,49L,51L,53L,55L,65L,67L,69L,71L,77L,79L,89L,91L,97L,99L,101L,103L,109L,111L,113L,115L,125L,127L,129L,131L,137L,139L,149L,151L,153L,155L,161L,163L,169L,171L,173L,175L,181L,183L,185L,187L,189L,191L,197L,199L,209L,211L,221L,223L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166685Inst : IEnumerable<long>
{
public static readonly long[] Value=A166685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166685.Bytes);
public long this[int i]=>Value[i];

public static A166685Inst Instance=new A166685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166686
{
public static readonly long[] Value={ 1L,2L,8L,9L,13L,14L,16L,17L,30L,31L,33L,34L,53L,59L,61L,65L,80L,85L,89L,92L,94L,96L,97L,103L,113L,116L,117L,121L,127L,128L,142L,143L,160L,163L,180L,182L,188L,189L,206L,208L,216L,221L,227L,235L,236L,242L,255L,256L,261L,262L,265L,271L,294L,297L,298L,300L,304L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166686Inst : IEnumerable<long>
{
public static readonly long[] Value=A166686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166686.Bytes);
public long this[int i]=>Value[i];

public static A166686Inst Instance=new A166686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166687
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,10L,11L,14L,17L,18L,19L,21L,26L,27L,30L,33L,35L,37L,38L,41L,42L,46L,50L,51L,53L,54L,59L,62L,65L,66L,69L,73L,74L,75L,81L,82L,83L,86L,90L,91L,98L,99L,101L,102L,105L,107L,110L,114L,117L,118L,122L,123L,126L,129L,131L,137L,138L,145L,146L,147L,149L,150L,154L,158L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166687Inst : IEnumerable<long>
{
public static readonly long[] Value=A166687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166687.Bytes);
public long this[int i]=>Value[i];

public static A166687Inst Instance=new A166687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166688
{
public static readonly BigInteger[] Value={ 1L,36L,1260L,44100L,1543500L,54022500L,1890787500L,66177562500L,2316214687500L,81067514062500L,2837362992187500L,99307704726562500L,3475769665429686870L,BigInteger.Parse("121651938290039018400"),BigInteger.Parse("4257817840151364872880"),BigInteger.Parse("149023624405297743561600") };
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
public class A166688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166688Inst Instance=new A166688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166689
{
public static readonly BigInteger[] Value={ 1L,37L,1332L,47952L,1726272L,62145792L,2237248512L,80540946432L,2899474071552L,104381066575872L,3757718396731392L,135277862282330112L,4870003042163883366L,BigInteger.Parse("175320109517899777200"),BigInteger.Parse("6311523942644391116730") };
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
public class A166689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166689Inst Instance=new A166689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166690
{
public static readonly BigInteger[] Value={ 1L,38L,1406L,52022L,1924814L,71218118L,2635070366L,97497603542L,3607411331054L,133474219248998L,4938546112212926L,182726206151878262L,6760869627619494991L,BigInteger.Parse("250152176221921288656"),BigInteger.Parse("9255630520211086718568") };
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
public class A166690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166690Inst Instance=new A166690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166691
{
public static readonly BigInteger[] Value={ 1L,39L,1482L,56316L,2140008L,81320304L,3090171552L,117426518976L,4462207721088L,169563893401344L,6443427949251072L,244850262071540736L,9304309958718547227UL,BigInteger.Parse("353563778431304766468"),BigInteger.Parse("13435423580389580056521") };
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
public class A166691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166691Inst Instance=new A166691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166692
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,0L,1L,2L,4L,1L,1L,2L,4L,8L,0L,1L,2L,4L,8L,16L,1L,1L,2L,4L,8L,16L,32L,0L,1L,2L,4L,8L,16L,32L,64L,1L,1L,2L,4L,8L,16L,32L,64L,128L,0L,1L,2L,4L,8L,16L,32L,64L,128L,256L,1L,1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,0L,1L,2L,4L,8L,16L,32L,64L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166692Inst : IEnumerable<long>
{
public static readonly long[] Value=A166692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166692.Bytes);
public long this[int i]=>Value[i];

public static A166692Inst Instance=new A166692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166693
{
public static readonly BigInteger[] Value={ 1L,40L,1560L,60840L,2372760L,92537640L,3608967960L,140749750440L,5489240267160L,214080370419240L,8349134446350360L,325616243407664040L,12699033492898896780UL,BigInteger.Parse("495262306223056944000"),BigInteger.Parse("19315229942699219630400") };
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
public class A166693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166693Inst Instance=new A166693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166694
{
public static readonly long[] Value={ 1L,2L,10L,52L,290L,1706L,10440L,65822L,424710L,2791340L,18622510L,125791894L,858621680L,5913143706L,41036613570L,286702877908L,2014876764170L,14234073943986L,101025202379480L,720017430722598L,5151008515543790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166694Inst : IEnumerable<long>
{
public static readonly long[] Value=A166694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166694.Bytes);
public long this[int i]=>Value[i];

public static A166694Inst Instance=new A166694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166695
{
public static readonly long[] Value={ 1L,3L,2L,4L,6L,5L,7L,9L,11L,13L,15L,8L,10L,12L,14L,16L,18L,20L,22L,24L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,53L,55L,57L,59L,61L,63L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166695Inst : IEnumerable<long>
{
public static readonly long[] Value=A166695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166695.Bytes);
public long this[int i]=>Value[i];

public static A166695Inst Instance=new A166695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166696
{
public static readonly long[] Value={ 1L,3L,21L,162L,1365L,12219L,114156L,1100649L,10871175L,109438830L,1118798079L,11583712617L,121219182504L,1280065637487L,13623341795049L,145977237305874L,1573536198376401L,17051418418204671L,185646639499541892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166696Inst : IEnumerable<long>
{
public static readonly long[] Value=A166696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166696.Bytes);
public long this[int i]=>Value[i];

public static A166696Inst Instance=new A166696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166697
{
public static readonly long[] Value={ 1L,4L,25L,187L,1552L,13771L,127927L,1228576L,12099751L,121538581L,1240336660L,12824049277L,134043231781L,1414108869268L,15037450664317L,161014687970191L,1734550886346592L,18785969304551263L,204432608804093155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166697Inst : IEnumerable<long>
{
public static readonly long[] Value=A166697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166697.Bytes);
public long this[int i]=>Value[i];

public static A166697Inst Instance=new A166697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166698
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166698Inst : IEnumerable<long>
{
public static readonly long[] Value=A166698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166698.Bytes);
public long this[int i]=>Value[i];

public static A166698Inst Instance=new A166698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166699
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,17L,27L,25L,33L,35L,45L,47L,51L,55L,81L,83L,75L,77L,99L,85L,105L,107L,135L,121L,141L,125L,153L,155L,165L,167L,243L,175L,249L,187L,225L,227L,231L,235L,297L,299L,255L,257L,315L,275L,321L,323L,405L,289L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166699Inst : IEnumerable<long>
{
public static readonly long[] Value=A166699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166699.Bytes);
public long this[int i]=>Value[i];

public static A166699Inst Instance=new A166699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166700
{
public static readonly long[] Value={ 1L,4L,7L,16L,19L,28L,31L,64L,49L,76L,79L,112L,115L,124L,133L,256L,259L,196L,199L,304L,217L,316L,319L,448L,361L,460L,343L,496L,499L,532L,535L,1024L,553L,1036L,589L,784L,787L,796L,805L,1216L,1219L,868L,871L,1264L,931L,1276L,1279L,1792L,961L,1444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166700Inst : IEnumerable<long>
{
public static readonly long[] Value=A166700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166700.Bytes);
public long this[int i]=>Value[i];

public static A166700Inst Instance=new A166700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166701
{
public static readonly long[] Value={ 1L,5L,9L,25L,29L,45L,49L,125L,81L,145L,149L,225L,229L,245L,261L,625L,629L,405L,409L,725L,441L,745L,749L,1125L,841L,1145L,729L,1225L,1229L,1305L,1309L,3125L,1341L,3145L,1421L,2025L,2029L,2045L,2061L,3625L,3629L,2205L,2209L,3725L,2349L,3745L,3749L,5625L,2401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166701Inst : IEnumerable<long>
{
public static readonly long[] Value=A166701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166701.Bytes);
public long this[int i]=>Value[i];

public static A166701Inst Instance=new A166701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166702
{
public static readonly long[] Value={ 1L,6L,11L,36L,41L,66L,71L,216L,121L,246L,251L,396L,401L,426L,451L,1296L,1301L,726L,731L,1476L,781L,1506L,1511L,2376L,1681L,2406L,1331L,2556L,2561L,2706L,2711L,7776L,2761L,7806L,2911L,4356L,4361L,4386L,4411L,8856L,8861L,4686L,4691L,9036L,4961L,9066L,9071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166702Inst : IEnumerable<long>
{
public static readonly long[] Value=A166702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166702.Bytes);
public long this[int i]=>Value[i];

public static A166702Inst Instance=new A166702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166703
{
public static readonly long[] Value={ 1L,7L,13L,49L,55L,91L,97L,343L,169L,385L,391L,637L,643L,679L,715L,2401L,2407L,1183L,1189L,2695L,1261L,2737L,2743L,4459L,3025L,4501L,2197L,4753L,4759L,5005L,5011L,16807L,5083L,16849L,5335L,8281L,8287L,8323L,8359L,18865L,18871L,8827L,8833L,19159L,9295L,19201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166703Inst : IEnumerable<long>
{
public static readonly long[] Value=A166703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166703.Bytes);
public long this[int i]=>Value[i];

public static A166703Inst Instance=new A166703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166704
{
public static readonly long[] Value={ 1L,8L,15L,64L,71L,120L,127L,512L,225L,568L,575L,960L,967L,1016L,1065L,4096L,4103L,1800L,1807L,4544L,1905L,4600L,4607L,7680L,5041L,7736L,3375L,8128L,8135L,8520L,8527L,32768L,8625L,32824L,9017L,14400L,14407L,14456L,14505L,36352L,36359L,15240L,15247L,36800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166704Inst : IEnumerable<long>
{
public static readonly long[] Value=A166704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166704.Bytes);
public long this[int i]=>Value[i];

public static A166704Inst Instance=new A166704Inst();

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