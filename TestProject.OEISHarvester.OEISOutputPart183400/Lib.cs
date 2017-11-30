using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A213857
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,8L,10L,12L,14L,16L,19L,21L,23L,26L,28L,31L,34L,36L,39L,42L,45L,47L,50L,53L,56L,59L,62L,65L,68L,72L,75L,78L,81L,84L,88L,91L,94L,98L,101L,104L,108L,111L,115L,118L,122L,125L,129L,132L,136L,139L,143L,146L,150L,154L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213857Inst : IEnumerable<long>
{
public static readonly long[] Value=A213857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213857.Bytes);
public long this[int i]=>Value[i];

public static A213857Inst Instance=new A213857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213858
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,10L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,38L,40L,42L,45L,47L,49L,52L,54L,57L,59L,62L,64L,67L,70L,72L,75L,77L,80L,83L,85L,88L,91L,94L,96L,99L,102L,105L,108L,110L,113L,116L,119L,122L,125L,128L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213858Inst : IEnumerable<long>
{
public static readonly long[] Value=A213858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213858.Bytes);
public long this[int i]=>Value[i];

public static A213858Inst Instance=new A213858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213859
{
public static readonly long[] Value={ 1L,2L,0L,3L,4L,4L,0L,2L,6L,6L,4L,7L,8L,2L,0L,9L,16L,10L,4L,2L,12L,12L,16L,8L,14L,20L,4L,15L,16L,16L,0L,2L,18L,22L,16L,19L,20L,2L,24L,21L,16L,22L,4L,38L,24L,24L,16L,32L,6L,2L,4L,27L,34L,52L,8L,2L,30L,30L,4L,31L,32L,2L,0L,8L,16L,34L,4L,2L,46L,36L,16L,37L,38L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213859Inst : IEnumerable<long>
{
public static readonly long[] Value=A213859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213859.Bytes);
public long this[int i]=>Value[i];

public static A213859Inst Instance=new A213859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213860
{
public static readonly long[] Value={ 1L,3L,8L,30L,106L,413L,1616L,6525L,26588L,109900L,457964L,1924270L,8135692L,34592460L,147780810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213860Inst : IEnumerable<long>
{
public static readonly long[] Value=A213860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213860.Bytes);
public long this[int i]=>Value[i];

public static A213860Inst Instance=new A213860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213861
{
public static readonly long[] Value={ 2L,0L,1L,3L,4L,2949L,8L,11L,12L,15L,17L,115L,20L,7863275L,24L,27L,16L,73L,32L,35L,25L,39L,33L,103L,38L,48589961800007L,228L,51L,119L,97L,56L,59L,47L,323L,52L,581L,69L,71L,43L,2277L,77L,17509L,80L,75L,84L,87L,68L,133L,92L,95L,2209L,99L,53L,29363L,104L,107L,6848L,111L,2585L,3241L,116L,449L,120L,7847L,78L,1111L,129L,173L,132L,135L,137L,5340185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213861Inst : IEnumerable<long>
{
public static readonly long[] Value=A213861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213861.Bytes);
public long this[int i]=>Value[i];

public static A213861Inst Instance=new A213861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213862
{
public static readonly BigInteger[] Value={ 1L,1L,3L,106L,115955L,7236515981L,40684710729862072L,BigInteger.Parse("29745278219128813035415595"),BigInteger.Parse("3847028733161627562733350467148495403"),BigInteger.Parse("114752550881830601773639529476205016572641397025904"),BigInteger.Parse("996942995951678818059423286104073541295789338859855813183302036541") };
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
public class A213862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213862Inst Instance=new A213862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213863
{
public static readonly BigInteger[] Value={ 1L,1L,7L,106L,2575L,87595L,3864040L,210455470L,13681123135L,1035588754375L,89575852312675L,8724157965777400L,945424197750836500L,BigInteger.Parse("112891958206958894500"),BigInteger.Parse("14733016566584898017500"),BigInteger.Parse("2086947723639167040631750"),BigInteger.Parse("318968341048949169038143375") };
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
public class A213863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213863Inst Instance=new A213863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213864
{
public static readonly BigInteger[] Value={ 1L,1L,19L,1075L,115955L,19558470L,4622269345L,1428739165560L,551211090935595L,256653852463806955L,BigInteger.Parse("140633739174235040170"),BigInteger.Parse("88931024447225475920050"),BigInteger.Parse("63897452586372538310261555"),BigInteger.Parse("51509615229665486538200354125"),BigInteger.Parse("46102293227619069563429377126200") };
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
public class A213864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213864Inst Instance=new A213864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213865
{
public static readonly BigInteger[] Value={ 1L,1L,56L,13326L,7364321L,7236515981L,10915151070941L,23060727168393236L,BigInteger.Parse("64157120593526429971"),BigInteger.Parse("224909472938181653263446"),BigInteger.Parse("961415357313559098150122721"),BigInteger.Parse("4886376056824611061263607492146"),BigInteger.Parse("28944590736206982153001156958037271"),BigInteger.Parse("196631118571992127875305845382720388771") };
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
public class A213865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213865Inst Instance=new A213865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213866
{
public static readonly BigInteger[] Value={ 1L,1L,174L,188196L,586368681L,3745777177366L,40684710729862072L,BigInteger.Parse("668821362774214965294"),BigInteger.Parse("15388200323143520006870562"),BigInteger.Parse("468682891926540940991787213006"),BigInteger.Parse("18131599140232990157442722880124741"),BigInteger.Parse("863168115684925396146477660939182979547") };
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
public class A213866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213866Inst Instance=new A213866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213867
{
public static readonly BigInteger[] Value={ 1L,1L,561L,2914395L,54862627919L,2468722942369153L,BigInteger.Parse("211109968702038259993"),BigInteger.Parse("29745278219128813035415595"),BigInteger.Parse("6273648300104128965616586081511"),BigInteger.Parse("1850042480471503379038420801262526759"),BigInteger.Parse("725168149513389307543056971716033431701831") };
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
public class A213867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213867Inst Instance=new A213867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213868
{
public static readonly BigInteger[] Value={ 1L,1L,1859L,48349015L,5795673908453L,1953740543358042205L,BigInteger.Parse("1409438188685787895321841"),BigInteger.Parse("1835364055105945091130559202709"),BigInteger.Parse("3847028733161627562733350467148495403"),BigInteger.Parse("11963401430840044468894095677711389363239184"),BigInteger.Parse("51960277212541922189750307005207837858451630919380") };
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
public class A213868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213868Inst Instance=new A213868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213869
{
public static readonly BigInteger[] Value={ 1L,1L,6292L,846167608L,673174876488400L,BigInteger.Parse("1785201362960729511070"),BigInteger.Parse("11481253272835564584899247346"),BigInteger.Parse("146812609193179942830629976945746464"),BigInteger.Parse("3264601141014490309682718148875987514642243"),BigInteger.Parse("114752550881830601773639529476205016572641397025904") };
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
public class A213869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213869Inst Instance=new A213869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213870
{
public static readonly BigInteger[] Value={ 1L,1L,21658L,15456538890L,84386541996407430L,BigInteger.Parse("1831976833971352074708780"),BigInteger.Parse("109898940874611419792791074271620"),BigInteger.Parse("14506158303190746913523011613729321067580"),BigInteger.Parse("3612014977093890544877702499165438785779326595871"),BigInteger.Parse("1520262998870097218529031803141231246364682853428845871416") };
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
public class A213870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213870Inst Instance=new A213870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213871
{
public static readonly BigInteger[] Value={ 1L,362880L,34459425L,1035588754375L,256653852463806955L,BigInteger.Parse("224909472938181653263446"),BigInteger.Parse("468682891926540940991787213006"),BigInteger.Parse("1850042480471503379038420801262526759"),BigInteger.Parse("11963401430840044468894095677711389363239184"),BigInteger.Parse("114752550881830601773639529476205016572641397025904") };
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
public class A213871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213871Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213871.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213871Inst Instance=new A213871Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213872
{
public static readonly BigInteger[] Value={ 1L,3628800L,654729075L,89575852312675L,BigInteger.Parse("140633739174235040170"),BigInteger.Parse("961415357313559098150122721"),BigInteger.Parse("18131599140232990157442722880124741"),BigInteger.Parse("725168149513389307543056971716033431701831"),BigInteger.Parse("51960277212541922189750307005207837858451630919380") };
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
public class A213872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213872Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213872.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213872Inst Instance=new A213872Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213873
{
public static readonly BigInteger[] Value={ 1L,6L,15L,106L,1075L,13326L,188196L,2914395L,48349015L,846167608L,15456538890L,292407484590L,5695907466120L,113735416237808L,2319861446805120L,48199341935153655L,1017747539683821855L,BigInteger.Parse("21799192392184931700"),BigInteger.Parse("472889100118180757550"),BigInteger.Parse("10375788309377599231200") };
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
public class A213873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213873Inst Instance=new A213873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213874
{
public static readonly BigInteger[] Value={ 1L,24L,105L,2575L,115955L,7364321L,586368681L,54862627919L,5795673908453L,673174876488400L,84386541996407430L,11262879538848476760UL,BigInteger.Parse("1584243362361105791448"),BigInteger.Parse("233004893382083549345048"),BigInteger.Parse("35610340402841609968092950"),BigInteger.Parse("5627093485549459958456588775") };
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
public class A213874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213874Inst Instance=new A213874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213875
{
public static readonly BigInteger[] Value={ 1L,120L,945L,87595L,19558470L,7236515981L,3745777177366L,2468722942369153L,1953740543358042205L,BigInteger.Parse("1785201362960729511070"),BigInteger.Parse("1831976833971352074708780"),BigInteger.Parse("2068976591723429552651743620"),BigInteger.Parse("2532392303303120865350779766160"),BigInteger.Parse("3319547855302819899374947284511390") };
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
public class A213875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213875Inst Instance=new A213875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213876
{
public static readonly BigInteger[] Value={ 1L,720L,10395L,3864040L,4622269345L,10915151070941L,40684710729862072L,BigInteger.Parse("211109968702038259993"),BigInteger.Parse("1409438188685787895321841"),BigInteger.Parse("11481253272835564584899247346"),BigInteger.Parse("109898940874611419792791074271620"),BigInteger.Parse("1202306852636261419990922606451803760") };
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
public class A213876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213876Inst Instance=new A213876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213877
{
public static readonly BigInteger[] Value={ 1L,5040L,135135L,210455470L,1428739165560L,23060727168393236L,BigInteger.Parse("668821362774214965294"),BigInteger.Parse("29745278219128813035415595"),BigInteger.Parse("1835364055105945091130559202709"),BigInteger.Parse("146812609193179942830629976945746464"),BigInteger.Parse("14506158303190746913523011613729321067580") };
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
public class A213877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213877Inst Instance=new A213877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213878
{
public static readonly BigInteger[] Value={ 1L,40320L,2027025L,13681123135L,551211090935595L,BigInteger.Parse("64157120593526429971"),BigInteger.Parse("15388200323143520006870562"),BigInteger.Parse("6273648300104128965616586081511"),BigInteger.Parse("3847028733161627562733350467148495403"),BigInteger.Parse("3264601141014490309682718148875987514642243") };
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
public class A213878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213878Inst Instance=new A213878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213879
{
public static readonly long[] Value={ 1L,111L,131L,141L,151L,161L,171L,181L,191L,1331L,1441L,1551L,1661L,1771L,1881L,1991L,10301L,10401L,10501L,10601L,10701L,10801L,10901L,11111L,11211L,11311L,11411L,11511L,11611L,11711L,11811L,11911L,12021L,12121L,12321L,12421L,12521L,12621L,12721L,12821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213879Inst : IEnumerable<long>
{
public static readonly long[] Value=A213879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213879.Bytes);
public long this[int i]=>Value[i];

public static A213879Inst Instance=new A213879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213880
{
public static readonly long[] Value={ 45L,3960L,279720L,16798320L,839991600L,33599966400L,1007999899200L,20159999798400L,201599999798400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213880Inst : IEnumerable<long>
{
public static readonly long[] Value=A213880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213880.Bytes);
public long this[int i]=>Value[i];

public static A213880Inst Instance=new A213880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213881
{
public static readonly long[] Value={ 1L,5L,8L,9L,13L,14L,22L,26L,36L,43L,88L,104L,112L,118L,169L,181L,198L,352L,378L,530L,622L,697L,1136L,1246L,1315L,1579L,1798L,1918L,2874L,2917L,4228L,5876L,6768L,10052L,17864L,18077L,22652L,23034L,25448L,47509L,52140L,55862L,62938L,67404L,134739L,145126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213881Inst : IEnumerable<long>
{
public static readonly long[] Value=A213881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213881.Bytes);
public long this[int i]=>Value[i];

public static A213881Inst Instance=new A213881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213882
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,13L,14L,15L,19L,21L,23L,26L,40L,43L,45L,52L,54L,55L,69L,77L,90L,99L,106L,128L,147L,176L,202L,267L,331L,458L,512L,555L,908L,942L,1004L,1123L,1374L,1386L,1467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213882Inst : IEnumerable<long>
{
public static readonly long[] Value=A213882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213882.Bytes);
public long this[int i]=>Value[i];

public static A213882Inst Instance=new A213882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213883
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,2L,1L,1L,3L,5L,5L,3L,1L,3L,3L,1L,1L,9L,1L,1L,1L,1L,1L,7L,3L,6L,4L,1L,4L,4L,1L,15L,10L,1L,7L,3L,1L,3L,2L,2L,4L,6L,1L,3L,5L,20L,1L,1L,1L,8L,10L,7L,15L,10L,1L,4L,2L,5L,8L,3L,23L,11L,2L,2L,9L,3L,1L,5L,4L,1L,6L,3L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213883Inst : IEnumerable<long>
{
public static readonly long[] Value=A213883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213883.Bytes);
public long this[int i]=>Value[i];

public static A213883Inst Instance=new A213883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213884
{
public static readonly long[] Value={ 1L,4L,1L,2L,2L,5L,1L,2L,1L,2L,1L,4L,4L,5L,5L,1L,4L,7L,1L,4L,2L,4L,4L,1L,2L,8L,7L,4L,1L,1L,2L,1L,1L,4L,7L,4L,1L,1L,7L,4L,8L,2L,7L,4L,8L,8L,7L,2L,2L,1L,8L,2L,8L,5L,7L,1L,8L,4L,8L,1L,4L,1L,4L,7L,1L,2L,8L,2L,4L,1L,4L,8L,4L,5L,8L,2L,1L,2L,7L,7L,5L,1L,4L,8L,7L,4L,1L,4L,2L,2L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213884Inst : IEnumerable<long>
{
public static readonly long[] Value=A213884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213884.Bytes);
public long this[int i]=>Value[i];

public static A213884Inst Instance=new A213884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213885
{
public static readonly long[] Value={ 1L,0L,3L,1L,3L,2L,2L,2L,5L,1L,2L,2L,0L,4L,1L,2L,2L,2L,5L,0L,7L,2L,2L,3L,2L,4L,0L,2L,3L,2L,2L,5L,2L,2L,4L,0L,2L,3L,0L,2L,0L,1L,4L,1L,3L,1L,4L,2L,1L,4L,5L,1L,4L,2L,0L,1L,4L,3L,3L,3L,5L,1L,1L,3L,1L,3L,1L,2L,5L,4L,2L,1L,2L,3L,1L,4L,2L,2L,1L,1L,5L,2L,2L,2L,0L,2L,2L,1L,3L,4L,3L,5L,4L,1L,1L,2L,3L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213885Inst : IEnumerable<long>
{
public static readonly long[] Value=A213885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213885.Bytes);
public long this[int i]=>Value[i];

public static A213885Inst Instance=new A213885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213886
{
public static readonly long[] Value={ 7L,7L,11L,10L,15L,7L,10L,13L,19L,13L,10L,11L,9L,16L,10L,7L,10L,9L,15L,13L,17L,17L,18L,4L,10L,14L,7L,11L,8L,12L,16L,15L,18L,10L,17L,8L,12L,8L,6L,13L,7L,9L,15L,8L,12L,10L,18L,5L,3L,11L,18L,9L,18L,14L,10L,13L,15L,13L,12L,8L,11L,8L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213886Inst : IEnumerable<long>
{
public static readonly long[] Value=A213886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213886.Bytes);
public long this[int i]=>Value[i];

public static A213886Inst Instance=new A213886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213887
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,1L,0L,0L,4L,6L,4L,1L,0L,0L,3L,10L,10L,5L,1L,0L,0L,2L,12L,20L,15L,6L,1L,0L,0L,1L,12L,31L,35L,21L,7L,1L,0L,0L,0L,10L,40L,65L,56L,28L,8L,1L,0L,0L,0L,6L,44L,101L,120L,84L,36L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213887Inst : IEnumerable<long>
{
public static readonly long[] Value=A213887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213887.Bytes);
public long this[int i]=>Value[i];

public static A213887Inst Instance=new A213887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213888
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,1L,0L,1L,4L,6L,4L,1L,0L,0L,5L,10L,10L,5L,1L,0L,0L,4L,15L,20L,15L,6L,1L,0L,0L,3L,18L,35L,35L,21L,7L,1L,0L,0L,2L,19L,52L,70L,56L,28L,8L,1L,0L,0L,1L,18L,68L,121L,126L,84L,36L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213888Inst : IEnumerable<long>
{
public static readonly long[] Value=A213888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213888.Bytes);
public long this[int i]=>Value[i];

public static A213888Inst Instance=new A213888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213889
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,1L,0L,1L,4L,6L,4L,1L,0L,1L,5L,10L,10L,5L,1L,0L,0L,6L,15L,20L,15L,6L,1L,0L,0L,5L,21L,35L,35L,21L,7L,1L,0L,0L,4L,25L,56L,70L,56L,28L,8L,1L,0L,0L,3L,27L,80L,126L,126L,84L,36L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213889Inst : IEnumerable<long>
{
public static readonly long[] Value=A213889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213889.Bytes);
public long this[int i]=>Value[i];

public static A213889Inst Instance=new A213889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213890
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,2L,0L,1L,0L,3L,1L,3L,0L,2L,0L,3L,2L,3L,1L,2L,1L,3L,2L,3L,0L,1L,0L,2L,1L,2L,0L,1L,0L,4L,1L,4L,0L,2L,0L,4L,2L,4L,1L,2L,1L,4L,2L,4L,0L,1L,0L,3L,1L,3L,0L,1L,0L,4L,1L,4L,0L,3L,0L,4L,3L,4L,1L,3L,1L,4L,3L,4L,0L,2L,0L,3L,2L,3L,0L,2L,0L,4L,2L,4L,0L,3L,0L,4L,3L,4L,2L,3L,2L,4L,3L,4L,1L,2L,1L,3L,2L,3L,1L,2L,1L,4L,2L,4L,1L,3L,1L,4L,3L,4L,2L,3L,2L,4L,3L,4L,0L,1L,0L,2L,1L,2L,0L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213890Inst : IEnumerable<long>
{
public static readonly long[] Value=A213890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213890.Bytes);
public long this[int i]=>Value[i];

public static A213890Inst Instance=new A213890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213891
{
public static readonly long[] Value={ 3L,11L,19L,43L,67L,83L,107L,131L,139L,163L,211L,283L,307L,331L,347L,467L,491L,499L,523L,547L,563L,571L,587L,619L,659L,691L,739L,787L,811L,859L,883L,907L,947L,971L,1019L,1051L,1123L,1163L,1171L,1283L,1291L,1307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213891Inst : IEnumerable<long>
{
public static readonly long[] Value=A213891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213891.Bytes);
public long this[int i]=>Value[i];

public static A213891Inst Instance=new A213891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213892
{
public static readonly long[] Value={ 2L,7L,19L,31L,47L,67L,71L,83L,151L,163L,167L,223L,227L,271L,307L,331L,359L,379L,431L,463L,479L,487L,499L,631L,643L,683L,691L,743L,787L,811L,839L,863L,947L,967L,1019L,1051L,1087L,1103L,1123L,1163L,1259L,1279L,1307L,1319L,1399L,1423L,1451L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213892Inst : IEnumerable<long>
{
public static readonly long[] Value=A213892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213892.Bytes);
public long this[int i]=>Value[i];

public static A213892Inst Instance=new A213892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213893
{
public static readonly long[] Value={ 3L,7L,43L,67L,103L,127L,163L,223L,283L,367L,463L,487L,523L,547L,607L,643L,727L,787L,823L,883L,907L,1063L,1123L,1303L,1327L,1423L,1447L,1543L,1567L,1627L,1663L,1723L,1747L,1783L,1867L,1987L,2083L,2143L,2203L,2287L,2347L,2383L,2467L,2683L,2707L,2767L,2803L,2887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213893Inst : IEnumerable<long>
{
public static readonly long[] Value=A213893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213893.Bytes);
public long this[int i]=>Value[i];

public static A213893Inst Instance=new A213893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213894
{
public static readonly long[] Value={ 2L,3L,11L,19L,31L,43L,47L,79L,127L,131L,163L,211L,251L,271L,307L,311L,331L,367L,379L,443L,503L,563L,599L,607L,659L,743L,751L,823L,839L,859L,887L,907L,911L,947L,967L,1063L,1087L,1091L,1123L,1163L,1171L,1187L,1259L,1279L,1291L,1303L,1307L,1319L,1423L,1447L,1471L,1487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213894Inst : IEnumerable<long>
{
public static readonly long[] Value=A213894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213894.Bytes);
public long this[int i]=>Value[i];

public static A213894Inst Instance=new A213894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213895
{
public static readonly long[] Value={ 7L,11L,23L,47L,127L,139L,211L,223L,251L,331L,367L,379L,383L,463L,487L,499L,607L,619L,691L,727L,739L,743L,811L,823L,863L,887L,967L,971L,983L,1051L,1063L,1087L,1171L,1291L,1303L,1327L,1367L,1423L,1447L,1451L,1459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213895Inst : IEnumerable<long>
{
public static readonly long[] Value=A213895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213895.Bytes);
public long this[int i]=>Value[i];

public static A213895Inst Instance=new A213895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213896
{
public static readonly long[] Value={ 2L,3L,19L,31L,67L,79L,103L,127L,139L,151L,167L,179L,191L,263L,283L,359L,383L,443L,463L,479L,491L,503L,571L,631L,691L,787L,827L,883L,919L,1019L,1087L,1171L,1291L,1303L,1307L,1327L,1399L,1423L,1451L,1487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213896Inst : IEnumerable<long>
{
public static readonly long[] Value=A213896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213896.Bytes);
public long this[int i]=>Value[i];

public static A213896Inst Instance=new A213896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213897
{
public static readonly long[] Value={ 3L,7L,23L,31L,71L,107L,131L,139L,163L,199L,211L,227L,283L,347L,367L,379L,419L,431L,439L,487L,499L,503L,547L,571L,607L,619L,643L,691L,719L,751L,787L,811L,823L,827L,907L,911L,983L,991L,1031L,1051L,1091L,1151L,1163L,1231L,1303L,1319L,1367L,1399L,1423L,1439L,1459L,1499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213897Inst : IEnumerable<long>
{
public static readonly long[] Value=A213897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213897.Bytes);
public long this[int i]=>Value[i];

public static A213897Inst Instance=new A213897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213898
{
public static readonly long[] Value={ 2L,11L,31L,43L,47L,67L,79L,103L,127L,199L,211L,223L,263L,307L,311L,383L,431L,439L,463L,467L,499L,523L,563L,571L,587L,691L,719L,751L,811L,839L,863L,883L,911L,967L,991L,1051L,1063L,1087L,1091L,1123L,1151L,1231L,1307L,1327L,1399L,1447L,1451L,1459L,1483L,1499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213898Inst : IEnumerable<long>
{
public static readonly long[] Value=A213898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213898.Bytes);
public long this[int i]=>Value[i];

public static A213898Inst Instance=new A213898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213899
{
public static readonly long[] Value={ 3L,7L,31L,43L,47L,71L,107L,151L,167L,179L,211L,223L,239L,251L,271L,283L,419L,431L,463L,467L,487L,491L,523L,547L,563L,571L,631L,839L,859L,883L,907L,967L,971L,1087L,1103L,1171L,1187L,1279L,1283L,1291L,1367L,1399L,1423L,1459L,1471L,1483L,1487L,1499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213899Inst : IEnumerable<long>
{
public static readonly long[] Value=A213899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213899.Bytes);
public long this[int i]=>Value[i];

public static A213899Inst Instance=new A213899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213900
{
public static readonly long[] Value={ 2L,3L,5L,4L,11L,7L,5L,11L,14L,1L,11L,6L,23L,19L,11L,8L,11L,17L,29L,7L,5L,23L,11L,24L,20L,35L,23L,13L,59L,5L,23L,3L,8L,39L,11L,18L,17L,27L,29L,3L,23L,43L,5L,59L,23L,15L,11L,55L,74L,35L,41L,26L,35L,9L,23L,35L,41L,57L,59L,2L,5L,23L,47L,34L,11L,67L,17L,23L,119L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213900Inst : IEnumerable<long>
{
public static readonly long[] Value=A213900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213900.Bytes);
public long this[int i]=>Value[i];

public static A213900Inst Instance=new A213900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213901
{
public static readonly long[] Value={ 5L,7L,29L,31L,79L,103L,127L,149L,151L,173L,197L,199L,223L,269L,271L,293L,317L,367L,439L,463L,487L,557L,631L,701L,727L,751L,773L,797L,821L,823L,941L,967L,991L,1039L,1061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213901Inst : IEnumerable<long>
{
public static readonly long[] Value=A213901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213901.Bytes);
public long this[int i]=>Value[i];

public static A213901Inst Instance=new A213901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213902
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,2L,0L,0L,0L,0L,0L,4L,0L,1L,0L,2L,0L,1L,1L,0L,1L,1L,0L,2L,0L,0L,0L,3L,3L,0L,0L,0L,1L,0L,2L,1L,1L,1L,0L,1L,0L,0L,2L,4L,0L,0L,0L,4L,1L,2L,0L,0L,1L,2L,1L,1L,0L,1L,2L,0L,2L,2L,0L,2L,0L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213902Inst : IEnumerable<long>
{
public static readonly long[] Value=A213902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213902.Bytes);
public long this[int i]=>Value[i];

public static A213902Inst Instance=new A213902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213903
{
public static readonly long[] Value={ 1L,9L,24L,46L,30L,99L,154L,263L,367L,590L,217L,1183L,2191L,1879L,1831L,3077L,2225L,3793L,4612L,4522L,3644L,14862L,12542L,3385L,19026L,17006L,23283L,38590L,14357L,34215L,73321L,30802L,33608L,110224L,85633L,165326L,31545L,40933L,103520L,141718L,224659L,126172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213903Inst : IEnumerable<long>
{
public static readonly long[] Value=A213903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213903.Bytes);
public long this[int i]=>Value[i];

public static A213903Inst Instance=new A213903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213904
{
public static readonly long[] Value={ 1006301L,0L,11L,1022381L,0L,3512051L,1871L,632081L,0L,1121831L,15731L,0L,1481L,1155611L,1068251L,0L,18911L,284741L,0L,12390011L,191L,821L,0L,3837131L,875261L,0L,854921L,10865291L,18041L,0L,958541L,680291L,0L,299471L,1063961L,663581L,0L,165701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213904Inst : IEnumerable<long>
{
public static readonly long[] Value=A213904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213904.Bytes);
public long this[int i]=>Value[i];

public static A213904Inst Instance=new A213904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213905
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,9L,20L,47L,112L,274L,678L,1702L,4314L,11039L,28460L,73875L,192884L,506251L,1334899L,3534591L,9394196L,25052866L,67019457L,179793858L,483591479L,1303836901L,3523141231L,9539570474L,25879559378L,70332798052L,191461351903L,522012186777L,1425327940690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213905Inst : IEnumerable<long>
{
public static readonly long[] Value=A213905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213905.Bytes);
public long this[int i]=>Value[i];

public static A213905Inst Instance=new A213905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213906
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,14L,36L,85L,226L,577L,1561L,4158L,11413L,31200L,86722L,241227L,677729L,1908832L,5411431L,15386107L,43949347L,125896209L,361904137L,1043032250L,3014490719L,8732211825L,25353395331L,73759912892L,215007439768L,627844428958L,1836466543942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213906Inst : IEnumerable<long>
{
public static readonly long[] Value=A213906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213906.Bytes);
public long this[int i]=>Value[i];

public static A213906Inst Instance=new A213906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213907
{
public static readonly long[] Value={ 1L,3L,9L,34L,61L,261L,709L,1324L,4937L,15040L,28561L,107262L,248341L,522445L,1972363L,7591936L,8835345L,26421129L,145475533L,183752250L,701184621L,2234736295L,2996725227L,15105451596L,32483720761L,77618520551L,217809217211L,625456400842L,1638545943301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213907Inst : IEnumerable<long>
{
public static readonly long[] Value=A213907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213907.Bytes);
public long this[int i]=>Value[i];

public static A213907Inst Instance=new A213907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213908
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,13L,15L,17L,19L,20L,22L,24L,25L,27L,29L,31L,32L,34L,36L,37L,39L,41L,43L,44L,46L,48L,49L,51L,53L,55L,56L,58L,60L,62L,63L,65L,67L,68L,70L,72L,74L,75L,77L,79L,80L,82L,84L,86L,87L,89L,91L,92L,94L,96L,98L,99L,101L,103L,104L,106L,108L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213908Inst : IEnumerable<long>
{
public static readonly long[] Value=A213908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213908.Bytes);
public long this[int i]=>Value[i];

public static A213908Inst Instance=new A213908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213909
{
public static readonly long[] Value={ 0L,2L,40L,6L,30L,46L,234L,14L,276L,40L,212L,58L,100L,248L,562L,30L,178L,294L,424L,60L,126L,234L,516L,82L,538L,126L,81178L,276L,366L,592L,80910L,62L,688L,212L,446L,330L,444L,462L,1894L,100L,81096L,168L,1090L,278L,416L,562L,80816L,130L,666L,588L,926L,178L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213909Inst : IEnumerable<long>
{
public static readonly long[] Value=A213909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213909.Bytes);
public long this[int i]=>Value[i];

public static A213909Inst Instance=new A213909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213910
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,0L,1L,1L,3L,1L,2L,1L,1L,1L,1L,4L,3L,3L,4L,2L,4L,1L,3L,0L,1L,1L,5L,6L,5L,9L,5L,10L,5L,9L,4L,7L,3L,3L,2L,1L,1L,1L,6L,10L,9L,16L,13L,19L,17L,19L,19L,17L,19L,13L,17L,7L,13L,3L,8L,1L,4L,0L,1L,1L,7L,15L,16L,26L,29L,34L,43L,39L,54L,41L,61L,40L,62L,36L,58L,28L,47L,21L,34L,15L,21L,10L,11L,6L,4L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213910Inst : IEnumerable<long>
{
public static readonly long[] Value=A213910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213910.Bytes);
public long this[int i]=>Value[i];

public static A213910Inst Instance=new A213910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213911
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,3L,1L,1L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,1L,1L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,2L,2L,3L,3L,3L,3L,3L,4L,1L,1L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,2L,2L,3L,3L,3L,3L,3L,4L,2L,2L,3L,3L,3L,3L,3L,4L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213911Inst : IEnumerable<long>
{
public static readonly long[] Value=A213911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213911.Bytes);
public long this[int i]=>Value[i];

public static A213911Inst Instance=new A213911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213912
{
public static readonly long[] Value={ 1L,3L,9L,27L,5L,2L,6L,18L,4L,12L,36L,108L,10L,30L,90L,270L,16L,48L,144L,432L,20L,60L,7L,21L,63L,189L,13L,39L,117L,351L,1053L,32L,96L,288L,864L,29L,87L,261L,783L,2349L,7047L,83L,249L,15L,45L,135L,11L,33L,99L,297L,17L,51L,153L,459L,1377L,37L,111L,333L,999L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213912Inst : IEnumerable<long>
{
public static readonly long[] Value=A213912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213912.Bytes);
public long this[int i]=>Value[i];

public static A213912Inst Instance=new A213912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213913
{
public static readonly long[] Value={ 1L,6L,2L,9L,5L,7L,23L,84L,3L,13L,47L,10L,27L,88L,44L,17L,51L,8L,92L,21L,24L,96L,132L,85L,105L,114L,4L,64L,36L,14L,60L,32L,48L,141L,73L,11L,56L,194L,28L,255L,155L,89L,137L,175L,45L,124L,69L,18L,270L,449L,52L,146L,78L,280L,199L,190L,93L,225L,180L,22L,129L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213913Inst : IEnumerable<long>
{
public static readonly long[] Value=A213913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213913.Bytes);
public long this[int i]=>Value[i];

public static A213913Inst Instance=new A213913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213914
{
public static readonly long[] Value={ 28382041L,35213777L,64411157L,92223749L,132079147L,176955343L,253042357L,273128939L,365502299L,589730549L,644178091L,712541329L,827389151L,993274127L,1128722657L,1357950109L,1504974139L,1580552933L,1625263531L,1665516431L,1666495867L,1848493579L,2218519117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213914Inst : IEnumerable<long>
{
public static readonly long[] Value=A213914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213914.Bytes);
public long this[int i]=>Value[i];

public static A213914Inst Instance=new A213914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213915
{
public static readonly long[] Value={ 107L,113L,383L,567L,601L,951L,1005L,1059L,1169L,1269L,1313L,1343L,1415L,1641L,1719L,1759L,1823L,2237L,2315L,2323L,2505L,2605L,2737L,2743L,2801L,2881L,2913L,3351L,3355L,3405L,3583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213915Inst : IEnumerable<long>
{
public static readonly long[] Value=A213915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213915.Bytes);
public long this[int i]=>Value[i];

public static A213915Inst Instance=new A213915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213916
{
public static readonly long[] Value={ 1L,1L,9L,1L,6L,9L,54L,1L,63L,6L,47L,9L,19L,54L,132L,1L,36L,63L,95L,6L,22L,47L,117L,9L,120L,19L,20262L,54L,76L,132L,20194L,1L,153L,36L,94L,63L,91L,95L,450L,6L,20235L,22L,248L,47L,81L,117L,20163L,9L,140L,120L,204L,19L,59L,20262L,20426L,54L,305L,76L,411L,132L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213916Inst : IEnumerable<long>
{
public static readonly long[] Value=A213916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213916.Bytes);
public long this[int i]=>Value[i];

public static A213916Inst Instance=new A213916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213917
{
public static readonly long[] Value={ -1L,1L,31L,5L,24L,37L,180L,13L,213L,34L,165L,49L,81L,194L,430L,29L,142L,231L,329L,54L,104L,187L,399L,73L,418L,107L,60916L,222L,290L,460L,60716L,61L,535L,176L,352L,267L,353L,367L,1444L,94L,60861L,146L,842L,231L,335L,445L,60653L,121L,526L,468L,722L,159L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213917Inst : IEnumerable<long>
{
public static readonly long[] Value=A213917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213917.Bytes);
public long this[int i]=>Value[i];

public static A213917Inst Instance=new A213917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213918
{
public static readonly long[] Value={ 1L,1L,2L,6L,36L,210L,14976L,552720L,309582000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213918Inst : IEnumerable<long>
{
public static readonly long[] Value=A213918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213918.Bytes);
public long this[int i]=>Value[i];

public static A213918Inst Instance=new A213918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213919
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,4L,1L,1L,1L,1L,4L,8L,1L,1L,9L,1L,1L,5L,16L,1L,1L,1L,1L,6L,16L,27L,32L,1L,1L,1L,1L,7L,64L,1L,1L,25L,81L,1L,1L,8L,64L,128L,1L,1L,1L,1L,9L,36L,243L,256L,1L,1L,1L,1L,10L,125L,256L,512L,1L,1L,49L,729L,1L,1L,11L,1024L,1L,1L,1L,1L,12L,64L,216L,1024L,2187L,2096L,1L,1L,625L,1L,1L,13L,4096L,1L,1L,81L,6561L,1L,1L,14L,343L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213919Inst : IEnumerable<long>
{
public static readonly long[] Value=A213919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213919.Bytes);
public long this[int i]=>Value[i];

public static A213919Inst Instance=new A213919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213920
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,7L,15L,34L,79L,190L,457L,1132L,2823L,7126L,18136L,46541L,120103L,312109L,815012L,2137755L,5632399L,14895684L,39519502L,105198371L,280815067L,751490363L,2016142768L,5420945437L,14604580683L,39425557103L,106618273626L,288792927325L,783516425820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213920Inst : IEnumerable<long>
{
public static readonly long[] Value=A213920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213920.Bytes);
public long this[int i]=>Value[i];

public static A213920Inst Instance=new A213920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213921
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,10L,8L,9L,13L,17L,14L,6L,16L,21L,26L,22L,11L,12L,25L,31L,37L,32L,18L,15L,20L,36L,43L,50L,44L,27L,23L,24L,30L,49L,57L,65L,58L,38L,33L,19L,35L,42L,64L,73L,82L,74L,51L,45L,28L,29L,48L,56L,81L,91L,101L,92L,66L,59L,39L,34L,41L,63L,72L,100L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213921Inst : IEnumerable<long>
{
public static readonly long[] Value=A213921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213921.Bytes);
public long this[int i]=>Value[i];

public static A213921Inst Instance=new A213921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213922
{
public static readonly long[] Value={ 1L,3L,4L,8L,2L,9L,15L,6L,7L,16L,24L,13L,5L,14L,25L,35L,22L,11L,12L,23L,36L,48L,33L,20L,10L,21L,34L,49L,63L,46L,31L,18L,19L,32L,47L,64L,80L,61L,44L,29L,17L,30L,45L,62L,81L,99L,78L,59L,42L,27L,28L,43L,60L,79L,100L,120L,97L,76L,57L,40L,26L,41L,58L,77L,98L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213922Inst : IEnumerable<long>
{
public static readonly long[] Value=A213922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213922.Bytes);
public long this[int i]=>Value[i];

public static A213922Inst Instance=new A213922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213923
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,9L,11L,11L,11L,13L,15L,13L,15L,15L,15L,15L,17L,15L,17L,17L,17L,19L,21L,17L,19L,19L,17L,19L,21L,19L,21L,19L,21L,21L,21L,19L,21L,21L,21L,21L,23L,21L,23L,23L,21L,23L,25L,21L,23L,23L,23L,23L,25L,21L,23L,23L,23L,25L,27L,23L,25L,25L,23L,23L,25L,25L,27L,25L,27L,25L,27L,23L,25L,25L,25L,25L,27L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213923Inst : IEnumerable<long>
{
public static readonly long[] Value=A213923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213923.Bytes);
public long this[int i]=>Value[i];

public static A213923Inst Instance=new A213923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213924
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,9L,9L,11L,13L,15L,17L,19L,21L,11L,13L,15L,17L,19L,21L,23L,25L,21L,13L,15L,11L,13L,15L,17L,19L,13L,15L,17L,19L,15L,17L,19L,21L,23L,23L,25L,23L,25L,25L,27L,29L,25L,17L,19L,21L,23L,25L,23L,25L,27L,27L,27L,25L,27L,29L,31L,27L,13L,15L,17L,19L,21L,23L,25L,27L,23L,23L,25L,27L,29L,31L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213924Inst : IEnumerable<long>
{
public static readonly long[] Value=A213924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213924.Bytes);
public long this[int i]=>Value[i];

public static A213924Inst Instance=new A213924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213925
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,2L,3L,7L,2L,4L,9L,2L,5L,11L,3L,4L,13L,2L,7L,3L,5L,16L,17L,2L,9L,19L,4L,5L,3L,7L,2L,11L,23L,2L,3L,4L,25L,2L,13L,3L,9L,4L,7L,29L,2L,3L,5L,31L,2L,16L,3L,11L,2L,17L,5L,7L,4L,9L,37L,2L,19L,3L,13L,2L,4L,5L,41L,2L,3L,7L,43L,4L,11L,5L,9L,2L,23L,47L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213925Inst : IEnumerable<long>
{
public static readonly long[] Value=A213925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213925.Bytes);
public long this[int i]=>Value[i];

public static A213925Inst Instance=new A213925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213926
{
public static readonly long[] Value={ 0L,4L,18L,46L,86L,138L,210L,292L,396L,512L,630L,790L,968L,1150L,1380L,1566L,1820L,2082L,2370L,2670L,3010L,3382L,3720L,4122L,4540L,4950L,5416L,5900L,6372L,6884L,7446L,8030L,8600L,9202L,9782L,10476L,11164L,11886L,12576L,13326L,14148L,14920L,15686L,16554L,17412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213926Inst : IEnumerable<long>
{
public static readonly long[] Value=A213926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213926.Bytes);
public long this[int i]=>Value[i];

public static A213926Inst Instance=new A213926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213927
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,4L,7L,8L,9L,10L,11L,12L,13L,14L,15L,21L,20L,19L,18L,17L,16L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,45L,44L,43L,42L,41L,40L,39L,38L,37L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213927Inst : IEnumerable<long>
{
public static readonly long[] Value=A213927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213927.Bytes);
public long this[int i]=>Value[i];

public static A213927Inst Instance=new A213927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213928
{
public static readonly long[] Value={ 1L,4L,2L,5L,3L,9L,16L,6L,8L,10L,25L,15L,7L,11L,17L,26L,24L,14L,12L,18L,36L,49L,27L,23L,13L,19L,35L,37L,64L,48L,28L,22L,20L,34L,38L,50L,65L,63L,47L,29L,21L,33L,39L,51L,81L,100L,66L,62L,46L,30L,32L,40L,52L,80L,82L,121L,99L,67L,61L,45L,31L,41L,53L,79L,83L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213928Inst : IEnumerable<long>
{
public static readonly long[] Value=A213928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213928.Bytes);
public long this[int i]=>Value[i];

public static A213928Inst Instance=new A213928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213929
{
public static readonly long[] Value={ 25L,30L,40L,50L,45L,50L,45L,50L,40L,30L,25L,31L,42L,54L,49L,55L,50L,56L,46L,35L,30L,36L,48L,60L,54L,60L,54L,60L,48L,36L,30L,35L,46L,56L,50L,55L,49L,54L,42L,31L,25L,30L,40L,50L,45L,50L,45L,50L,40L,30L,25L,29L,38L,46L,41L,45L,40L,44L,34L,25L,20L,24L,32L,40L,36L,40L,36L,40L,32L,24L,20L,22L,28L,32L,28L,30L,26L,28L,20L,14L,10L,11L,14L,16L,14L,15L,13L,14L,10L,7L,5L,5L,6L,6L,5L,5L,4L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213929Inst : IEnumerable<long>
{
public static readonly long[] Value=A213929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213929.Bytes);
public long this[int i]=>Value[i];

public static A213929Inst Instance=new A213929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213930
{
public static readonly long[] Value={ 2L,8L,7L,7L,1L,35L,40L,44L,15L,16L,7L,7L,0L,1L,1L,205L,202L,299L,101L,119L,105L,54L,33L,40L,15L,16L,15L,3L,5L,11L,1L,2L,1L,1224L,1215L,1940L,773L,916L,964L,484L,339L,514L,238L,223L,206L,88L,98L,146L,32L,33L,54L,19L,28L,19L,5L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213930Inst : IEnumerable<long>
{
public static readonly long[] Value=A213930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213930.Bytes);
public long this[int i]=>Value[i];

public static A213930Inst Instance=new A213930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213931
{
public static readonly long[] Value={ 3L,7L,6L,21L,19L,14L,12L,21L,22L,27L,43L,33L,63L,28L,24L,66L,67L,30L,98L,57L,44L,129L,367L,42L,199L,63L,85L,84L,463L,54L,48L,93L,86L,201L,76L,66L,219L,111L,99L,120L,163L,60L,1285L,129L,88L,274L,751L,105L,156L,199L,134L,198L,211L,102L,327L,84L,147L,346L,1765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213931Inst : IEnumerable<long>
{
public static readonly long[] Value=A213931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213931.Bytes);
public long this[int i]=>Value[i];

public static A213931Inst Instance=new A213931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213932
{
public static readonly BigInteger[] Value={ 1L,5L,707L,268326L,168146839L,143163177336L,149998192424502L,182598353781240533L,BigInteger.Parse("249032962712552804432"),BigInteger.Parse("371285830572997665257695"),BigInteger.Parse("594729699502746726969433566"),BigInteger.Parse("1010574132470951359396337494800"),BigInteger.Parse("1804193873947216124589237862262262") };
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
public class A213932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213932Inst Instance=new A213932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213933
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,9L,9L,15L,27L,25L,45L,81L,75L,135L,243L,225L,405L,729L,675L,1215L,2187L,2025L,3645L,6561L,6075L,10935L,19683L,18225L,32805L,59049L,54675L,98415L,177147L,164025L,295245L,531441L,492075L,885735L,1594323L,1476225L,2657205L,4782969L,4428675L,7971615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213933Inst : IEnumerable<long>
{
public static readonly long[] Value=A213933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213933.Bytes);
public long this[int i]=>Value[i];

public static A213933Inst Instance=new A213933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213934
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,3L,6L,1L,3L,10L,12L,24L,1L,8L,31L,50L,60L,120L,1L,9L,71L,180L,300L,360L,720L,1L,22L,187L,815L,1260L,2100L,2520L,5040L,1L,29L,574L,2324L,6496L,10080L,16800L,20160L,40320L,1L,66L,1373L,9570L,32268L,58464L,90720L,151200L,181440L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213934Inst : IEnumerable<long>
{
public static readonly long[] Value=A213934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213934.Bytes);
public long this[int i]=>Value[i];

public static A213934Inst Instance=new A213934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213935
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,2L,4L,24L,36L,6L,5L,60L,300L,240L,24L,6L,180L,1820L,3900L,1800L,120L,7L,378L,9030L,42000L,50400L,15120L,720L,8L,952L,40824L,357420L,882000L,670320L,141120L,5040L,9L,2088L,169512L,2610720L,11677680L,17781120L,9313920L,1451520L,40320L,10L,4770L,673560L,17193960L,128598624L,345144240L,355622400L,136080000L,16329600L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213935Inst : IEnumerable<long>
{
public static readonly long[] Value=A213935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213935.Bytes);
public long this[int i]=>Value[i];

public static A213935Inst Instance=new A213935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213936
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,6L,3L,1L,1L,24L,12L,4L,1L,1L,120L,60L,20L,5L,1L,1L,720L,360L,120L,30L,6L,1L,1L,5040L,2520L,840L,210L,42L,7L,1L,1L,40320L,20160L,6720L,1680L,336L,56L,8L,1L,1L,362880L,181440L,60480L,15120L,3024L,504L,72L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213936Inst : IEnumerable<long>
{
public static readonly long[] Value=A213936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213936.Bytes);
public long this[int i]=>Value[i];

public static A213936Inst Instance=new A213936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213937
{
public static readonly long[] Value={ 1L,2L,4L,11L,42L,207L,1238L,8661L,69282L,623531L,6235302L,68588313L,823059746L,10699776687L,149796873606L,2246953104077L,35951249665218L,611171244308691L,11001082397556422L,209020565553572001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213937Inst : IEnumerable<long>
{
public static readonly long[] Value=A213937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213937.Bytes);
public long this[int i]=>Value[i];

public static A213937Inst Instance=new A213937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213938
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,6L,4L,5L,6L,7L,10L,5L,6L,7L,8L,9L,11L,15L,6L,7L,8L,9L,9L,10L,12L,12L,13L,16L,21L,7L,8L,9L,10L,10L,11L,12L,13L,13L,14L,16L,17L,18L,22L,28L,8L,9L,10L,11L,12L,11L,12L,13L,14L,15L,14L,15L,16L,17L,20L,18L,19L,21L,23L,24L,29L,36L,9L,10L,11L,12L,13L,12L,13L,14L,15L,15L,16L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213938Inst : IEnumerable<long>
{
public static readonly long[] Value=A213938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213938.Bytes);
public long this[int i]=>Value[i];

public static A213938Inst Instance=new A213938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213939
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,1L,1L,2L,2L,4L,6L,12L,1L,1L,3L,3L,3L,6L,11L,10L,16L,30L,60L,1L,1L,3L,4L,3L,9L,10L,18L,15L,30L,48L,60L,90L,180L,360L,1L,1L,4L,5L,8L,4L,12L,19L,33L,38L,21L,54L,70L,108L,171L,105L,210L,318L,420L,630L,1260L,2520L,1L,1L,4L,7L,10L,4L,16L,28L,38L,48L,76L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213939Inst : IEnumerable<long>
{
public static readonly long[] Value=A213939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213939.Bytes);
public long this[int i]=>Value[i];

public static A213939Inst Instance=new A213939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213940
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,2L,3L,1L,3L,6L,6L,12L,1L,7L,20L,26L,30L,60L,1L,8L,40L,93L,150L,180L,360L,1L,18L,106L,424L,633L,1050L,1260L,2520L,1L,22L,304L,1180L,3260L,5040L,8400L,10080L,20160L,1L,46L,731L,4844L,16212L,29244L,45360L,75600L,90720L,181440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213940Inst : IEnumerable<long>
{
public static readonly long[] Value=A213940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213940.Bytes);
public long this[int i]=>Value[i];

public static A213940Inst Instance=new A213940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213941
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,1L,4L,12L,12L,24L,3L,5L,20L,40L,60L,120L,120L,12L,6L,30L,90L,45L,180L,720L,220L,600L,1440L,900L,60L,7L,42L,126L,168L,315L,1890L,1050L,1890L,2100L,12600L,6720L,6300L,18900L,7560L,360L,8L,56L,224L,280L,224L,672L,4032L,6384L,5544L,6384L,5880L,45360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213941Inst : IEnumerable<long>
{
public static readonly long[] Value=A213941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213941.Bytes);
public long this[int i]=>Value[i];

public static A213941Inst Instance=new A213941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213942
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,18L,22L,46L,62L,136L,189L,409L,611L,1344L,2055L,4535L,7154L,15881L,25481L,56533L,92204L,204759L,337593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213942Inst : IEnumerable<long>
{
public static readonly long[] Value=A213942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213942.Bytes);
public long this[int i]=>Value[i];

public static A213942Inst Instance=new A213942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213943
{
public static readonly BigInteger[] Value={ 1L,2L,3L,9L,28L,144L,832L,6012L,48447L,444198L,4469834L,49650464L,597810739L,7809600123L,109524985564L,1646900490716L,26373465572350L,448901183773766L,8083772124339442L,153686286512223573L,3074405841292532560L,BigInteger.Parse("64582422678961767945") };
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
public class A213943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213943Inst Instance=new A213943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213944
{
public static readonly long[] Value={ 1L,2L,0L,3L,2L,0L,3L,4L,0L,0L,3L,6L,3L,0L,0L,3L,6L,6L,0L,0L,0L,3L,6L,9L,4L,0L,0L,0L,3L,6L,9L,8L,0L,0L,0L,0L,3L,6L,9L,12L,5L,0L,0L,0L,0L,3L,6L,9L,12L,10L,0L,0L,0L,0L,0L,3L,6L,9L,12L,15L,6L,0L,0L,0L,0L,0L,3L,6L,9L,12L,15L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213944Inst : IEnumerable<long>
{
public static readonly long[] Value=A213944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213944.Bytes);
public long this[int i]=>Value[i];

public static A213944Inst Instance=new A213944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213945
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,1L,1L,1L,2L,11L,1L,1L,1L,1L,4L,24L,1L,1L,1L,1L,2L,7L,51L,1L,1L,1L,1L,1L,4L,12L,107L,1L,1L,1L,1L,1L,2L,6L,21L,222L,1L,1L,1L,1L,1L,1L,4L,9L,36L,457L,1L,1L,1L,1L,1L,1L,2L,6L,14L,61L,935L,1L,1L,1L,1L,1L,1L,1L,4L,8L,22L,103L,1904L,1L,1L,1L,1L,1L,1L,1L,2L,6L,11L,34L,173L,3863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213945Inst : IEnumerable<long>
{
public static readonly long[] Value=A213945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213945.Bytes);
public long this[int i]=>Value[i];

public static A213945Inst Instance=new A213945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213946
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,4L,4L,5L,1L,7L,10L,10L,14L,1L,12L,24L,25L,28L,42L,1L,20L,52L,70L,70L,84L,132L,1L,33L,112L,185L,196L,210L,264L,429L,1L,54L,238L,445L,588L,588L,660L,858L,1430L,1L,88L,496L,1080L,1652L,1764L,1848L,2145L,2860L,4862L,1L,143L,1026L,2610L,4242L,5544L,5544L,6006L,7150L,9724L,16796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213946Inst : IEnumerable<long>
{
public static readonly long[] Value=A213946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213946.Bytes);
public long this[int i]=>Value[i];

public static A213946Inst Instance=new A213946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213947
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,1L,10L,6L,4L,1L,20L,21L,8L,5L,1L,42L,57L,28L,10L,6L,1L,84L,150L,88L,35L,12L,7L,1L,170L,390L,252L,110L,42L,14L,8L,1L,340L,990L,712L,335L,132L,49L,16L,9L,1L,682L,2475L,1992L,975L,402L,154L,56L,18L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213947Inst : IEnumerable<long>
{
public static readonly long[] Value=A213947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213947.Bytes);
public long this[int i]=>Value[i];

public static A213947Inst Instance=new A213947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213948
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,4L,4L,4L,1L,7L,10L,8L,8L,1L,12L,24L,20L,16L,16L,1L,20L,52L,56L,40L,32L,32L,1L,33L,112L,144L,112L,80L,64L,64L,1L,54L,238L,344L,320L,224L,160L,128L,128L,1L,88L,496L,828L,848L,640L,448L,320L,256L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213948Inst : IEnumerable<long>
{
public static readonly long[] Value=A213948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213948.Bytes);
public long this[int i]=>Value[i];

public static A213948Inst Instance=new A213948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213949
{
public static readonly long[] Value={ 1L,4L,10L,18L,36L,57L,77L,110L,141L,177L,232L,270L,337L,402L,453L,566L,610L,721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213949Inst : IEnumerable<long>
{
public static readonly long[] Value=A213949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213949.Bytes);
public long this[int i]=>Value[i];

public static A213949Inst Instance=new A213949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213950
{
public static readonly long[] Value={ 1L,2L,7L,24L,99L,416L,1852L,8386L,38798L,181531L,858570L,4092042L,19636172L,94750922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213950Inst : IEnumerable<long>
{
public static readonly long[] Value=A213950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213950.Bytes);
public long this[int i]=>Value[i];

public static A213950Inst Instance=new A213950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213951
{
public static readonly long[] Value={ 1L,2L,8L,24L,98L,418L,1846L,8378L,38776L,181482L,858387L,4091814L,19635210L,94749398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213951Inst : IEnumerable<long>
{
public static readonly long[] Value=A213951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213951.Bytes);
public long this[int i]=>Value[i];

public static A213951Inst Instance=new A213951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213952
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,5L,5L,8L,15L,13L,33L,49L,35L,49L,73L,107L,143L,211L,293L,398L,505L,510L,685L,710L,948L,740L,994L,2033L,1735L,2266L,1780L,2333L,4653L,5923L,7311L,9213L,7683L,9719L,17878L,14703L,19072L,22814L,28266L,34878L,42876L,52390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213952Inst : IEnumerable<long>
{
public static readonly long[] Value=A213952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213952.Bytes);
public long this[int i]=>Value[i];

public static A213952Inst Instance=new A213952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213953
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-2L,-1L,1L,-2L,5L,0L,-3L,-1L,1L,-9L,5L,10L,-2L,-4L,-1L,1L,-9L,-21L,25L,15L,-5L,-5L,-1L,1L,50L,-105L,-11L,62L,19L,-9L,-6L,-1L,1L,267L,-141L,-301L,56L,119L,21L,-14L,-7L,-1L,1L,413L,777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213953Inst : IEnumerable<long>
{
public static readonly long[] Value=A213953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213953.Bytes);
public long this[int i]=>Value[i];

public static A213953Inst Instance=new A213953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213954
{
public static readonly long[] Value={ 3L,4L,8L,6L,6L,8L,17L,14L,12L,10L,36L,32L,25L,18L,20L,12L,77L,68L,51L,36L,38L,20L,164L,142L,106L,72L,72L,38L,64L,28L,347L,298L,225L,146L,142L,74L,109L,46L,732L,628L,476L,302L,294L,148L,197L,82L,168L,64L,1543L,1324L,1003L,632L,614L,304L,385L,156L,277L,100L,3252L,2790L,2112L,1328L,1284L,634L,777L,312L,504L,174L,414L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213954Inst : IEnumerable<long>
{
public static readonly long[] Value=A213954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213954.Bytes);
public long this[int i]=>Value[i];

public static A213954Inst Instance=new A213954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213955
{
public static readonly BigInteger[] Value={ 2L,10L,138L,5314L,575122L,176041978L,153143689594L,380082566144530L,2699632942815871042L,BigInteger.Parse("55016905649245690586122"),BigInteger.Parse("3223966155402204759824471786") };
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
public class A213955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213955Inst Instance=new A213955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213956
{
public static readonly BigInteger[] Value={ 3L,42L,3186L,1299735L,2860343784L,34107691901433L,2211749000480369037L,BigInteger.Parse("782349734245964422491828") };
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
public class A213956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213956Inst Instance=new A213956Inst();

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