using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A123941
{
public static readonly long[] Value={ 0L,1L,3L,9L,26L,75L,216L,622L,1791L,5157L,14849L,42756L,123111L,354484L,1020696L,2938977L,8462447L,24366645L,70160958L,202020427L,581694636L,1674922950L,4822748423L,13886550633L,39984728949L,115131438424L,331507764639L,954538564968L,2748484256480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123941Inst : IEnumerable<long>
{
public static readonly long[] Value=A123941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123941.Bytes);
public long this[int i]=>Value[i];

public static A123941Inst Instance=new A123941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123942
{
public static readonly long[] Value={ 0L,1L,3L,15L,71L,340L,1626L,7778L,37205L,177966L,851280L,4072001L,19477953L,93170570L,445670811L,2131815570L,10197297001L,48777608903L,233322137235L,1116069871981L,5338593130960L,25536552265626L,122151189577128L,584296304368075L,2794914830384226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123942Inst : IEnumerable<long>
{
public static readonly long[] Value=A123942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123942.Bytes);
public long this[int i]=>Value[i];

public static A123942Inst Instance=new A123942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123943
{
public static readonly long[] Value={ 0L,1L,5L,40L,315L,2490L,19681L,155563L,1229604L,9719061L,76821600L,607214857L,4799560053L,37936780428L,299860673343L,2370164848026L,18734305316497L,148080078051971L,1170457572108040L,9251554605638681L,73126326541645648L,578006601205833441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123943Inst : IEnumerable<long>
{
public static readonly long[] Value=A123943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123943.Bytes);
public long this[int i]=>Value[i];

public static A123943Inst Instance=new A123943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123944
{
public static readonly long[] Value={ 19L,28L,87L,99L,104L,196L,203L,210L,222L,228L,231L,238L,281L,328L,367L,499L,579L,620L,888L,967L,1036L,1147L,1204L,1352L,1372L,1403L,1419L,1430L,1470L,1481L,1498L,1503L,1666L,1693L,1907L,2211L,2359L,2440L,2499L,2521L,2556L,2678L,2948L,3407L,3467L,3504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123944Inst : IEnumerable<long>
{
public static readonly long[] Value=A123944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123944.Bytes);
public long this[int i]=>Value[i];

public static A123944Inst Instance=new A123944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123945
{
public static readonly long[] Value={ 0L,1L,1L,2L,6L,6L,5L,13L,14L,11L,27L,29L,23L,55L,60L,48L,112L,122L,97L,225L,245L,195L,451L,492L,392L,904L,986L,785L,1809L,1972L,1571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123945Inst : IEnumerable<long>
{
public static readonly long[] Value=A123945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123945.Bytes);
public long this[int i]=>Value[i];

public static A123945Inst Instance=new A123945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123946
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,7L,9L,11L,14L,18L,23L,29L,38L,48L,60L,76L,97L,121L,154L,195L,243L,310L,392L,488L,620L,785L,977L,1242L,1571L,1955L,2486L,3144L,3912L,4972L,6289L,7825L,9946L,12579L,15651L,19894L,25160L,31304L,39788L,50321L,62609L,79578L,100643L,125219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123946Inst : IEnumerable<long>
{
public static readonly long[] Value=A123946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123946.Bytes);
public long this[int i]=>Value[i];

public static A123946Inst Instance=new A123946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123947
{
public static readonly long[] Value={ 0L,1L,3L,9L,29L,90L,284L,890L,2797L,8780L,27574L,86581L,271881L,853732L,2680833L,8418132L,26433983L,83005929L,260648825L,818469251L,2570093890L,8070410030L,25342077544L,79577232067L,249882270390L,784660981474L,2463931734897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123947Inst : IEnumerable<long>
{
public static readonly long[] Value=A123947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123947.Bytes);
public long this[int i]=>Value[i];

public static A123947Inst Instance=new A123947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123948
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,1L,1L,-2L,3L,3L,-1L,9L,-15L,-22L,7L,1L,96L,-184L,-314L,139L,19L,-1L,-2500L,5250L,10575L,-5375L,-1026L,51L,1L,-162000L,369900L,842310L,-498171L,-111179L,7644L,141L,-1L,26471025L,-64790985L,-164634169L,109325076L,28870212L,-2322404L,-59193L,393L,1L,11014635520L,-28677390336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123948Inst : IEnumerable<long>
{
public static readonly long[] Value=A123948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123948.Bytes);
public long this[int i]=>Value[i];

public static A123948Inst Instance=new A123948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123949
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-2L,1L,0L,-2L,3L,-1L,1L,0L,-2L,0L,1L,0L,-2L,-1L,3L,1L,-1L,0L,0L,-3L,6L,-2L,-2L,1L,0L,2L,-9L,15L,-11L,3L,1L,-1L,1L,-4L,2L,6L,-1L,-6L,-1L,2L,1L,0L,-2L,7L,-1L,-11L,-3L,8L,4L,-1L,-1L,0L,0L,-3L,-6L,4L,18L,-9L,-2L,-3L,0L,1L,0L,0L,0L,-4L,3L,19L,-29L,11L,-2L,2L,1L,-1L,0L,0L,0L,0L,4L,0L,-25L,16L,26L,-20L,-4L,2L,1L,0L,0L,0L,-4L,11L,7L,-63L,63L,8L,-34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123949Inst : IEnumerable<long>
{
public static readonly long[] Value=A123949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123949.Bytes);
public long this[int i]=>Value[i];

public static A123949Inst Instance=new A123949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123950
{
public static readonly long[] Value={ 0L,1L,1L,6L,19L,73L,264L,973L,3565L,13086L,48007L,176149L,646296L,2371321L,8700553L,31923030L,117128107L,429752305L,1576795176L,5785386229L,21227039605L,77883687150L,285761407807L,1048481205661L,3846960466104L,14114802199681L,51788325586033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123950Inst : IEnumerable<long>
{
public static readonly long[] Value=A123950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123950.Bytes);
public long this[int i]=>Value[i];

public static A123950Inst Instance=new A123950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123951
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-1L,-1L,1L,-1L,-3L,4L,-1L,37L,-88L,69L,-19L,1L,10879L,-14344L,6831L,-1375L,99L,-1L,-4322473L,-40529664L,-17486038L,3188841L,-40896L,-2346L,1L,-11384127259974047L,-783824545942228L,1058675233347L,505084925760L,-64007100L,-32568519L,23164L,-1L,BigInteger.Parse("-121986767767877481129923") };
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
public class A123951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123951Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123951.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123951Inst Instance=new A123951Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123952
{
public static readonly long[] Value={ 1L,4L,17L,77L,371L,1891L,10123L,56503L,326699L,1945799L,11879987L,74039167L,469266331L,3014973511L,19581735203L,128267231663L,845770626539L,5605309590679L,37293554232307L,248855791875007L,1664285028373691L,11148949376158631L,74779855705724483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123952Inst : IEnumerable<long>
{
public static readonly long[] Value=A123952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123952.Bytes);
public long this[int i]=>Value[i];

public static A123952Inst Instance=new A123952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123953
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,5L,6L,3L,3L,5L,8L,4L,4L,13L,9L,3L,9L,11L,12L,9L,4L,12L,21L,6L,4L,22L,14L,6L,12L,14L,15L,14L,5L,17L,25L,5L,10L,37L,23L,6L,14L,22L,23L,20L,7L,21L,44L,14L,13L,33L,25L,13L,24L,35L,23L,16L,17L,39L,58L,13L,14L,61L,35L,20L,20L,26L,43L,33L,19L,27L,48L,25L,26L,72L,37L,17L,32L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123953Inst : IEnumerable<long>
{
public static readonly long[] Value=A123953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123953.Bytes);
public long this[int i]=>Value[i];

public static A123953Inst Instance=new A123953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123954
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,20L,244L,2352L,19725L,150996L,1084600L,7438112L,49268857L,317763732L,2007173532L,12470499600L,76456454725L,463727364692L,2787905507488L,16639142746368L,98709193239921L,582627136604436L,3424383528301252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123954Inst : IEnumerable<long>
{
public static readonly long[] Value=A123954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123954.Bytes);
public long this[int i]=>Value[i];

public static A123954Inst Instance=new A123954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123955
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,15L,139L,1029L,6691L,40041L,226435L,1230009L,6487195L,33464145L,169720915L,849504825L,4208146411L,20674387905L,100901918659L,489826044489L,2367517203931L,11402423910801L,54755709794995L,262308279256089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123955Inst : IEnumerable<long>
{
public static readonly long[] Value=A123955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123955.Bytes);
public long this[int i]=>Value[i];

public static A123955Inst Instance=new A123955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123956
{
public static readonly long[] Value={ -1L,1L,1L,-1L,-2L,-2L,1L,-3L,4L,4L,-1L,4L,8L,-8L,-8L,1L,5L,-12L,-20L,16L,16L,-1L,-6L,-18L,32L,48L,-32L,-32L,1L,-7L,24L,56L,-80L,-112L,64L,64L,-1L,8L,32L,-80L,-160L,192L,256L,-128L,-128L,1L,9L,-40L,-120L,240L,432L,-448L,-576L,256L,256L,-1L,-10L,-50L,160L,400L,-672L,-1120L,1024L,1280L,-512L,-512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123956Inst : IEnumerable<long>
{
public static readonly long[] Value=A123956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123956.Bytes);
public long this[int i]=>Value[i];

public static A123956Inst Instance=new A123956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123957
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,3L,-4L,5L,-24L,19L,-76L,133L,-208L,627L,-852L,2181L,-4232L,7443L,-18012L,30533L,-66880L,133875L,-250724L,547013L,-1020152L,2108435L,-4245612L,8217861L,-17089968L,33202291L,-67158900L,135095301L,-265925992L,541112339L,-1069523580L,2146659781L,-4309316128L,8553624307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123957Inst : IEnumerable<long>
{
public static readonly long[] Value=A123957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123957.Bytes);
public long this[int i]=>Value[i];

public static A123957Inst Instance=new A123957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123958
{
public static readonly long[] Value={ 0L,0L,1L,0L,-2L,-2L,4L,8L,-4L,-24L,-8L,56L,64L,-96L,-240L,64L,672L,352L,-1472L,-2048L,2240L,7040L,-384L,-18560L,-13312L,37888L,63744L,-49152L,-203264L,-29184L,504832L,464896L,-951296L,-1939456L,972800L,5781504L,1933312L,-13508608L,-15429632L,23150592L,57876480L,-15441920L,-162054144L,-84869120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123958Inst : IEnumerable<long>
{
public static readonly long[] Value=A123958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123958.Bytes);
public long this[int i]=>Value[i];

public static A123958Inst Instance=new A123958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123959
{
public static readonly long[] Value={ 1L,0L,4L,8L,8L,56L,64L,192L,576L,768L,2880L,5632L,11520L,34816L,61952L,163328L,389120L,778240L,2088960L,4423680L,10162176L,25067520L,53100544L,129466368L,296255488L,660832256L,1595408384L,3552837632L,8262516736L,19317915648L,43422842880L,102185828352L,233711861760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123959Inst : IEnumerable<long>
{
public static readonly long[] Value=A123959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123959.Bytes);
public long this[int i]=>Value[i];

public static A123959Inst Instance=new A123959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123960
{
public static readonly long[] Value={ 0L,0L,0L,2L,22L,152L,842L,4084L,18116L,75408L,299730L,1152834L,4338280L,16126958L,59713888L,221713192L,829301072L,3132108250L,11945717358L,45938159040L,177695375802L,689616061412L,2679197337100L,10403108215760L,40332521702522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123960Inst : IEnumerable<long>
{
public static readonly long[] Value=A123960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123960.Bytes);
public long this[int i]=>Value[i];

public static A123960Inst Instance=new A123960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123961
{
public static readonly long[] Value={ 0L,-4L,0L,-8L,1L,28L,-12L,4L,52L,132L,-16L,9L,84L,209L,384L,-20L,16L,124L,304L,556L,880L,-24L,25L,172L,417L,760L,1201L,1740L,-28L,36L,228L,548L,996L,1572L,2276L,3108L,-32L,49L,292L,697L,1264L,1993L,2884L,3937L,5152L,-36L,64L,364L,864L,1564L,2464L,3564L,4864L,6364L,8064L,-40L,81L,444L,1049L,1896L,2985L,4316L,5889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123961Inst : IEnumerable<long>
{
public static readonly long[] Value=A123961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123961.Bytes);
public long this[int i]=>Value[i];

public static A123961Inst Instance=new A123961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123962
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,5L,1L,2L,5L,14L,10L,2L,1L,3L,10L,46L,58L,38L,1L,3L,15L,123L,347L,392L,159L,4L,1L,4L,26L,375L,2130L,4895L,3855L,1060L,1L,4L,37L,1061L,14039L,68696L,113774L,64669L,12378L,9L,1L,5L,58L,3331L,103927L,1140623L,3953535L,4607132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123962Inst : IEnumerable<long>
{
public static readonly long[] Value=A123962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123962.Bytes);
public long this[int i]=>Value[i];

public static A123962Inst Instance=new A123962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123963
{
public static readonly long[] Value={ 0L,-1L,0L,-16L,-27L,-120L,-81L,-128L,-485L,-1440L,-256L,-375L,-1248L,-3607L,-8160L,-625L,-864L,-2589L,-7264L,-16329L,-31200L,-1296L,-1715L,-4712L,-12843L,-28640L,-54611L,-93240L,-2401L,-3072L,-7845L,-20800L,-45993L,-87456L,-149197L,-235200L,-4096L,-5103L,-12240L,-31615L,-69312L,-131391L,-223888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123963Inst : IEnumerable<long>
{
public static readonly long[] Value=A123963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123963.Bytes);
public long this[int i]=>Value[i];

public static A123963Inst Instance=new A123963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123964
{
public static readonly long[] Value={ 0L,-1L,0L,-64L,-3L,4080L,-729L,-128L,29515L,236160L,-4096L,-1215L,123168L,986873L,4194240L,-15625L,-6144L,373899L,3004544L,12770391L,39062400L,-46656L,-21875L,925648L,7468533L,31750240L,97119349L,241864560L,-117649L,-62208L,1989555L,16131200L,68598447L,209838336L,522579107L,1129900800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123964Inst : IEnumerable<long>
{
public static readonly long[] Value=A123964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123964.Bytes);
public long this[int i]=>Value[i];

public static A123964Inst Instance=new A123964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123965
{
public static readonly long[] Value={ 1L,3L,-1L,8L,-6L,1L,21L,-25L,9L,-1L,55L,-90L,51L,-12L,1L,144L,-300L,234L,-86L,15L,-1L,377L,-954L,951L,-480L,130L,-18L,1L,987L,-2939L,3573L,-2305L,855L,-183L,21L,-1L,2584L,-8850L,12707L,-10008L,4740L,-1386L,245L,-24L,1L,6765L,-26195L,43398L,-40426L,23373L,-8715L,2100L,-316L,27L,-1L,17711L,-76500L,143682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123965Inst : IEnumerable<long>
{
public static readonly long[] Value=A123965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123965.Bytes);
public long this[int i]=>Value[i];

public static A123965Inst Instance=new A123965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123966
{
public static readonly long[] Value={ 4L,4L,-1L,15L,-8L,1L,56L,-46L,12L,-1L,209L,-232L,93L,-16L,1L,780L,-1091L,592L,-156L,20L,-1L,2911L,-4912L,3366L,-1200L,235L,-24L,1L,10864L,-21468L,17784L,-8010L,2120L,-330L,28L,-1L,40545L,-91824L,89238L,-48624L,16255L,-3416L,441L,-32L,1L,151316L,-386373L,430992L,-275724L,111524L,-29589L,5152L,-568L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123966Inst : IEnumerable<long>
{
public static readonly long[] Value=A123966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123966.Bytes);
public long this[int i]=>Value[i];

public static A123966Inst Instance=new A123966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123967
{
public static readonly long[] Value={ 1L,-5L,1L,24L,-10L,1L,-115L,73L,-15L,1L,551L,-470L,147L,-20L,1L,-2640L,2828L,-1190L,246L,-25L,1L,12649L,-16310L,8631L,-2400L,370L,-30L,1L,-60605L,91371L,-58275L,20385L,-4225L,519L,-35L,1L,290376L,-501150L,374115L,-157800L,41140L,-6790L,693L,-40L,1L,-1391275L,2704755L,-2313450L,1142730L,-359275L,74571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123967Inst : IEnumerable<long>
{
public static readonly long[] Value=A123967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123967.Bytes);
public long this[int i]=>Value[i];

public static A123967Inst Instance=new A123967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123968
{
public static readonly long[] Value={ -2L,1L,6L,13L,22L,33L,46L,61L,78L,97L,118L,141L,166L,193L,222L,253L,286L,321L,358L,397L,438L,481L,526L,573L,622L,673L,726L,781L,838L,897L,958L,1021L,1086L,1153L,1222L,1293L,1366L,1441L,1518L,1597L,1678L,1761L,1846L,1933L,2022L,2113L,2206L,2301L,2398L,2497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123968Inst : IEnumerable<long>
{
public static readonly long[] Value=A123968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123968.Bytes);
public long this[int i]=>Value[i];

public static A123968Inst Instance=new A123968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123969
{
public static readonly long[] Value={ -1L,-1L,1L,0L,4L,-6L,-4L,11L,-6L,1L,6L,-41L,75L,-60L,74L,-119L,57L,64L,-93L,47L,-11L,1L,144L,-492L,886L,-1076L,489L,618L,-1063L,1154L,-1672L,1618L,-410L,-682L,785L,-392L,108L,-16L,1L,744L,-2567L,3782L,-1075L,-6736L,18095L,-29241L,29006L,-12952L,-3601L,11554L,-18942L,24467L,-17741L,2907L,6473L,-6678L,3357L,-1026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123969Inst : IEnumerable<long>
{
public static readonly long[] Value=A123969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123969.Bytes);
public long this[int i]=>Value[i];

public static A123969Inst Instance=new A123969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123970
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-3L,1L,1L,-6L,5L,-1L,1L,-10L,15L,-7L,1L,1L,-15L,35L,-28L,9L,-1L,1L,-21L,70L,-84L,45L,-11L,1L,1L,-28L,126L,-210L,165L,-66L,13L,-1L,1L,-36L,210L,-462L,495L,-286L,91L,-15L,1L,1L,-45L,330L,-924L,1287L,-1001L,455L,-120L,17L,-1L,1L,-55L,495L,-1716L,3003L,-3003L,1820L,-680L,153L,-19L,1L,1L,-66L,715L,-3003L,6435L,-8008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123970Inst : IEnumerable<long>
{
public static readonly long[] Value=A123970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123970.Bytes);
public long this[int i]=>Value[i];

public static A123970Inst Instance=new A123970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123971
{
public static readonly long[] Value={ 1L,2L,-1L,5L,-5L,1L,13L,-19L,8L,-1L,34L,-65L,42L,-11L,1L,89L,-210L,183L,-74L,14L,-1L,233L,-654L,717L,-394L,115L,-17L,1L,610L,-1985L,2622L,-1825L,725L,-165L,20L,-1L,1597L,-5911L,9134L,-7703L,3885L,-1203L,224L,-23L,1L,4181L,-17345L,30691L,-30418L,18633L,-7329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123971Inst : IEnumerable<long>
{
public static readonly long[] Value=A123971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123971.Bytes);
public long this[int i]=>Value[i];

public static A123971Inst Instance=new A123971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123972
{
public static readonly long[] Value={ 1L,-1L,1L,13L,41L,91L,169L,281L,433L,631L,881L,1189L,1561L,2003L,2521L,3121L,3809L,4591L,5473L,6461L,7561L,8779L,10121L,11593L,13201L,14951L,16849L,18901L,21113L,23491L,26041L,28769L,31681L,34783L,38081L,41581L,45289L,49211L,53353L,57721L,62321L,67159L,72241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123972Inst : IEnumerable<long>
{
public static readonly long[] Value=A123972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123972.Bytes);
public long this[int i]=>Value[i];

public static A123972Inst Instance=new A123972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123973
{
public static readonly long[] Value={ 0L,0L,-1L,-1L,-1L,1L,-1L,1L,2L,-1L,0L,3L,0L,-3L,1L,1L,2L,-5L,-2L,4L,-1L,1L,-2L,-7L,6L,5L,-5L,1L,0L,-5L,0L,15L,-5L,-9L,6L,-1L,-1L,-3L,12L,9L,-25L,1L,14L,-7L,1L,-1L,3L,15L,-18L,-29L,35L,7L,-20L,8L,-1L,0L,7L,0L,-42L,14L,63L,-42L,-20L,27L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123973Inst : IEnumerable<long>
{
public static readonly long[] Value=A123973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123973.Bytes);
public long this[int i]=>Value[i];

public static A123973Inst Instance=new A123973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123974
{
public static readonly long[] Value={ 1L,1L,-1L,0L,-2L,1L,-1L,-3L,4L,-1L,-3L,-6L,14L,-7L,1L,-14L,-24L,72L,-48L,12L,-1L,-109L,-172L,586L,-449L,143L,-20L,1L,-1403L,-2103L,7718L,-6375L,2296L,-402L,33L,-1L,-29354L,-42588L,163595L,-141144L,54448L,-10718L,1094L,-54L,1L,-996633L,-1416535L,5597100L,-4956116L,1990080L,-418458L,47881L,-2929L,88L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123974Inst : IEnumerable<long>
{
public static readonly long[] Value=A123974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123974.Bytes);
public long this[int i]=>Value[i];

public static A123974Inst Instance=new A123974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123975
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,5L,7L,10L,14L,20L,27L,37L,49L,66L,86L,113L,147L,190L,243L,311L,394L,499L,627L,786L,980L,1220L,1510L,1865L,2294L,2816L,3443L,4202L,5110L,6203L,7507L,9067L,10923L,13135L,15755L,18865L,22540L,26885L,32001L,38032L,45112L,53430L,63171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123975Inst : IEnumerable<long>
{
public static readonly long[] Value=A123975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123975.Bytes);
public long this[int i]=>Value[i];

public static A123975Inst Instance=new A123975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123976
{
public static readonly long[] Value={ 1L,11L,19L,29L,31L,41L,59L,61L,71L,79L,89L,101L,109L,131L,139L,149L,151L,179L,181L,191L,199L,211L,229L,239L,241L,251L,269L,271L,281L,311L,331L,349L,359L,379L,389L,401L,409L,419L,421L,431L,439L,442L,449L,461L,479L,491L,499L,509L,521L,541L,569L,571L,599L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123976Inst : IEnumerable<long>
{
public static readonly long[] Value=A123976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123976.Bytes);
public long this[int i]=>Value[i];

public static A123976Inst Instance=new A123976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123977
{
public static readonly long[] Value={ 4L,5L,6L,7L,8L,9L,14L,15L,16L,17L,18L,19L,23L,24L,25L,26L,27L,28L,29L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123977Inst : IEnumerable<long>
{
public static readonly long[] Value=A123977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123977.Bytes);
public long this[int i]=>Value[i];

public static A123977Inst Instance=new A123977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123978
{
public static readonly long[] Value={ 2L,5L,80L,107L,110L,185L,260L,332L,500L,1067L,1307L,1472L,1625L,1760L,1790L,1955L,2255L,2612L,2627L,2672L,2882L,2945L,3197L,3335L,3467L,3965L,4007L,4037L,4040L,4202L,4355L,4880L,5147L,5252L,5525L,6242L,6812L,6917L,6977L,7430L,7787L,8192L,8612L,8657L,8720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123978Inst : IEnumerable<long>
{
public static readonly long[] Value=A123978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123978.Bytes);
public long this[int i]=>Value[i];

public static A123978Inst Instance=new A123978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123979
{
public static readonly long[] Value={ 1L,3L,8L,16L,23L,38L,51L,71L,73L,108L,141L,156L,166L,178L,198L,233L,271L,288L,346L,376L,451L,453L,471L,478L,646L,656L,773L,778L,786L,871L,926L,1003L,1013L,1031L,1156L,1213L,1311L,1338L,1543L,1576L,1618L,1696L,1751L,1776L,1793L,1846L,1856L,1921L,1933L,1963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123979Inst : IEnumerable<long>
{
public static readonly long[] Value=A123979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123979.Bytes);
public long this[int i]=>Value[i];

public static A123979Inst Instance=new A123979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123980
{
public static readonly long[] Value={ 12L,24L,57L,162L,234L,249L,267L,297L,432L,519L,564L,717L,969L,984L,1167L,1179L,1389L,1734L,2007L,2364L,2427L,2544L,2664L,2769L,2784L,3582L,3627L,3819L,3897L,4089L,4287L,5244L,5307L,5337L,5472L,5577L,5667L,5727L,5967L,6084L,6102L,6399L,6522L,6822L,6987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123980Inst : IEnumerable<long>
{
public static readonly long[] Value=A123980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123980.Bytes);
public long this[int i]=>Value[i];

public static A123980Inst Instance=new A123980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123981
{
public static readonly long[] Value={ 1L,3L,8L,38L,53L,68L,71L,73L,106L,108L,123L,166L,173L,186L,221L,288L,326L,333L,376L,386L,456L,458L,516L,656L,711L,738L,788L,871L,981L,1076L,1083L,1146L,1156L,1158L,1173L,1193L,1303L,1338L,1503L,1618L,1706L,1741L,1751L,1776L,1781L,1796L,1856L,1886L,1921L,1963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123981Inst : IEnumerable<long>
{
public static readonly long[] Value=A123981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123981.Bytes);
public long this[int i]=>Value[i];

public static A123981Inst Instance=new A123981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123982
{
public static readonly long[] Value={ 1L,3L,8L,19L,29L,38L,56L,71L,73L,78L,84L,91L,101L,108L,119L,124L,129L,133L,134L,166L,199L,203L,224L,236L,246L,288L,294L,301L,316L,344L,376L,399L,411L,423L,488L,623L,628L,631L,656L,686L,724L,728L,819L,861L,871L,883L,894L,1008L,1009L,1053L,1074L,1086L,1156L,1179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123982Inst : IEnumerable<long>
{
public static readonly long[] Value=A123982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123982.Bytes);
public long this[int i]=>Value[i];

public static A123982Inst Instance=new A123982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123983
{
public static readonly long[] Value={ 12L,57L,162L,249L,432L,564L,984L,1734L,2007L,2427L,2664L,2784L,3627L,5307L,5472L,5727L,6399L,7614L,11082L,11547L,11607L,11694L,14127L,14274L,14484L,14862L,15117L,17049L,19104L,19422L,20577L,25677L,27612L,27714L,28152L,29307L,32232L,34602L,35592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123983Inst : IEnumerable<long>
{
public static readonly long[] Value=A123983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123983.Bytes);
public long this[int i]=>Value[i];

public static A123983Inst Instance=new A123983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123984
{
public static readonly long[] Value={ 11L,47L,223L,229L,313L,353L,397L,409L,571L,641L,661L,887L,1051L,1297L,1451L,1789L,2459L,2671L,2801L,2851L,3671L,4463L,4583L,4813L,4861L,5167L,5273L,5437L,5479L,5717L,5879L,6661L,6679L,6763L,6779L,7019L,7109L,7393L,7517L,7589L,7639L,7681L,7993L,8179L,8191L,9241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123984Inst : IEnumerable<long>
{
public static readonly long[] Value=A123984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123984.Bytes);
public long this[int i]=>Value[i];

public static A123984Inst Instance=new A123984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123985
{
public static readonly long[] Value={ 1L,3L,8L,38L,71L,73L,108L,166L,288L,376L,656L,871L,1156L,1338L,1618L,1751L,1776L,1856L,1921L,1963L,2311L,2418L,2801L,3501L,3538L,3648L,3818L,4266L,4541L,4611L,4651L,5076L,6723L,6751L,7388L,7533L,7621L,7698L,7738L,7796L,8083L,8193L,9073L,9243L,9418L,9516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123985Inst : IEnumerable<long>
{
public static readonly long[] Value=A123985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123985.Bytes);
public long this[int i]=>Value[i];

public static A123985Inst Instance=new A123985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123986
{
public static readonly long[] Value={ 1L,4L,7L,10L,25L,34L,37L,49L,67L,70L,115L,130L,142L,154L,160L,202L,205L,214L,220L,262L,265L,307L,319L,322L,325L,370L,424L,430L,469L,487L,499L,520L,532L,535L,559L,577L,595L,637L,664L,682L,697L,700L,742L,814L,832L,847L,865L,889L,895L,955L,979L,982L,1000L,1012L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123986Inst : IEnumerable<long>
{
public static readonly long[] Value=A123986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123986.Bytes);
public long this[int i]=>Value[i];

public static A123986Inst Instance=new A123986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123987
{
public static readonly long[] Value={ 9L,72L,114L,237L,252L,279L,342L,357L,417L,534L,687L,864L,1134L,1284L,1362L,1644L,2637L,2754L,2802L,3144L,3162L,3849L,5427L,6342L,6429L,6774L,7122L,8082L,8742L,9114L,9234L,9597L,9897L,10029L,10059L,10119L,10212L,11229L,11562L,12594L,13107L,14202L,14799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123987Inst : IEnumerable<long>
{
public static readonly long[] Value=A123987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123987.Bytes);
public long this[int i]=>Value[i];

public static A123987Inst Instance=new A123987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123988
{
public static readonly long[] Value={ 3L,7L,17L,31L,41L,43L,47L,71L,73L,79L,89L,97L,103L,109L,113L,127L,137L,151L,157L,167L,191L,193L,199L,223L,229L,233L,239L,241L,251L,257L,263L,271L,277L,281L,283L,307L,311L,313L,331L,337L,353L,359L,367L,383L,397L,401L,409L,431L,433L,439L,449L,457L,463L,479L,487L,499L,503L,521L,569L,571L,577L,593L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123988Inst : IEnumerable<long>
{
public static readonly long[] Value=A123988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123988.Bytes);
public long this[int i]=>Value[i];

public static A123988Inst Instance=new A123988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123989
{
public static readonly BigInteger[] Value={ 0L,3L,25L,294L,4566L,88572L,2064504L,56243184L,1754322480L,61664980320L,2412077832000L,103928089910400L,4890979939104000L,249630539076979200L,13734482066534476800UL,BigInteger.Parse("810355993296898406400"),BigInteger.Parse("51040766703826377676800") };
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
public class A123989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123989Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123989.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123989Inst Instance=new A123989Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123990
{
public static readonly long[] Value={ 1L,7771L,18166L,21691L,26146L,26356L,46801L,69046L,75916L,91516L,111406L,122716L,156196L,171436L,175726L,177316L,201571L,219316L,222706L,259951L,282826L,355531L,426796L,433621L,435301L,438976L,440056L,524371L,560461L,585166L,605506L,608026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123990Inst : IEnumerable<long>
{
public static readonly long[] Value=A123990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123990.Bytes);
public long this[int i]=>Value[i];

public static A123990Inst Instance=new A123990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123991
{
public static readonly long[] Value={ 1L,2L,6L,14L,29L,56L,107L,186L,320L,530L,851L,1332L,2051L,3074L,4544L,6602L,9444L,13322L,18579L,25564L,34827L,46954L,62692L,82954L,108889L,141732L,183169L,235042L,299584L,379434L,477763L,598036L,744628L,922348L,1136838L,1394608L,1703246L,2071068L,2508084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123991Inst : IEnumerable<long>
{
public static readonly long[] Value=A123991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123991.Bytes);
public long this[int i]=>Value[i];

public static A123991Inst Instance=new A123991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123992
{
public static readonly long[] Value={ 1L,40L,106L,133L,250L,265L,271L,280L,295L,313L,418L,580L,691L,736L,748L,826L,946L,1231L,1240L,1435L,1471L,1561L,1756L,2023L,2035L,2038L,2101L,2575L,2728L,2878L,2926L,3268L,3400L,3451L,3688L,3715L,3883L,4213L,4306L,4726L,4936L,5080L,5398L,5761L,5908L,6046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123992Inst : IEnumerable<long>
{
public static readonly long[] Value=A123992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123992.Bytes);
public long this[int i]=>Value[i];

public static A123992Inst Instance=new A123992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123993
{
public static readonly long[] Value={ 2L,3L,41L,907L,1151L,1553L,1609L,1667L,1801L,1907L,1933L,2351L,2473L,2531L,2953L,3001L,3571L,4007L,4073L,4253L,4663L,5023L,5417L,5881L,6143L,6257L,6329L,6343L,7879L,8461L,8521L,8563L,9041L,9067L,10103L,10781L,11243L,11251L,11257L,12097L,12413L,13217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123993Inst : IEnumerable<long>
{
public static readonly long[] Value=A123993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123993.Bytes);
public long this[int i]=>Value[i];

public static A123993Inst Instance=new A123993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123994
{
public static readonly long[] Value={ 64L,57L,2L,2L,107L,203L,1133L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123994Inst : IEnumerable<long>
{
public static readonly long[] Value=A123994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123994.Bytes);
public long this[int i]=>Value[i];

public static A123994Inst Instance=new A123994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123995
{
public static readonly long[] Value={ 2L,7L,89L,1831L,5591L,9551L,89689L,396733L,3851459L,11981443L,70396393L,202551667L,1872851947L,10958687879L,47203303159L,767644374817L,1999066711391L,8817792098461L,78610833115261L,497687231721157L,2069461000669981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123995Inst : IEnumerable<long>
{
public static readonly long[] Value=A123995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123995.Bytes);
public long this[int i]=>Value[i];

public static A123995Inst Instance=new A123995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123996
{
public static readonly long[] Value={ 3L,11L,97L,1847L,5623L,9587L,89753L,396833L,3851587L,11981587L,70396589L,202551883L,1872852203L,10958688203L,47203303559L,767644375301L,8817792099037L,78610833115937L,497687231721941L,2069461000670881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123996Inst : IEnumerable<long>
{
public static readonly long[] Value=A123996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123996.Bytes);
public long this[int i]=>Value[i];

public static A123996Inst Instance=new A123996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123997
{
public static readonly long[] Value={ 1L,133L,166L,208L,313L,418L,616L,691L,718L,1336L,1441L,1573L,1588L,1756L,2083L,2308L,2533L,2926L,2986L,3688L,3766L,3883L,4036L,4096L,4201L,4663L,5311L,5626L,5908L,6181L,7018L,7456L,7771L,7798L,8188L,8881L,9196L,9343L,9388L,9826L,10108L,10123L,10528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123997Inst : IEnumerable<long>
{
public static readonly long[] Value=A123997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123997.Bytes);
public long this[int i]=>Value[i];

public static A123997Inst Instance=new A123997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123998
{
public static readonly long[] Value={ 1L,3L,9L,15L,18L,39L,48L,69L,78L,99L,105L,114L,135L,153L,165L,168L,183L,189L,219L,249L,273L,288L,300L,303L,309L,330L,345L,363L,405L,414L,438L,468L,483L,498L,504L,534L,585L,618L,639L,648L,699L,714L,729L,765L,804L,813L,828L,879L,933L,1005L,1014L,1044L,1065L,1068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123998Inst : IEnumerable<long>
{
public static readonly long[] Value=A123998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123998.Bytes);
public long this[int i]=>Value[i];

public static A123998Inst Instance=new A123998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123999
{
public static readonly long[] Value={ 1L,4L,6L,4L,5L,12L,12L,4L,6L,16L,18L,12L,8L,16L,24L,12L,1L,12L,18L,12L,6L,4L,12L,12L,0L,0L,6L,4L,4L,0L,0L,4L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123999Inst : IEnumerable<long>
{
public static readonly long[] Value=A123999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123999.Bytes);
public long this[int i]=>Value[i];

public static A123999Inst Instance=new A123999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124000
{
public static readonly long[] Value={ 6L,10L,15L,21L,35L,55L,91L,253L,703L,1081L,1711L,1891L,2701L,3403L,5671L,12403L,13861L,15931L,18721L,25651L,34453L,38503L,49141L,60031L,64261L,73153L,79003L,88831L,104653L,108811L,114481L,126253L,146611L,158203L,171991L,188191L,218791L,226801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124000Inst : IEnumerable<long>
{
public static readonly long[] Value=A124000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124000.Bytes);
public long this[int i]=>Value[i];

public static A124000Inst Instance=new A124000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124001
{
public static readonly long[] Value={ 2L,1L,1L,19L,7L,151L,37L,139L,37L,7L,277L,817L,61L,1267L,97L,2371L,1549L,19L,619L,97L,391L,409L,649L,5527L,2731L,559L,949L,427L,601L,2797L,1681L,7189L,2449L,6751L,7597L,8419L,16879L,871L,5569L,10327L,16111L,2131L,6121L,23329L,5179L,4249L,2641L,2257L,3997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124001Inst : IEnumerable<long>
{
public static readonly long[] Value=A124001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124001.Bytes);
public long this[int i]=>Value[i];

public static A124001Inst Instance=new A124001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124002
{
public static readonly long[] Value={ 4L,8L,3L,34L,0L,0L,150L,4L,2L,0L,1044L,0L,0L,0L,0L,12334L,8L,2L,2L,0L,0L,274666L,0L,2L,0L,0L,0L,0L,12005156L,6L,4L,0L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124002Inst : IEnumerable<long>
{
public static readonly long[] Value=A124002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124002.Bytes);
public long this[int i]=>Value[i];

public static A124002Inst Instance=new A124002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124003
{
public static readonly long[] Value={ 3L,2L,9L,7L,19L,8L,8L,56L,90L,2L,16L,496L,520L,12L,0L,266L,8308L,3584L,284L,4L,0L,45186L,199247L,28781L,1434L,20L,0L,0L,6054148L,5637886L,301530L,10686L,914L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124003Inst : IEnumerable<long>
{
public static readonly long[] Value=A124003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124003.Bytes);
public long this[int i]=>Value[i];

public static A124003Inst Instance=new A124003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124004
{
public static readonly long[] Value={ 1L,4L,12L,56L,244L,1396L,8200L,55092L,390216L,3005288L,24571056L,212258216L,1939879668L,18429618408L,184041761768L,1891831332208L,20301171282452L,222742563853912L,2534535926617852L,29335558770589276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124004Inst : IEnumerable<long>
{
public static readonly long[] Value=A124004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124004.Bytes);
public long this[int i]=>Value[i];

public static A124004Inst Instance=new A124004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124005
{
public static readonly long[] Value={ 1L,4L,12L,54L,236L,1288L,7092L,42614L,269352L,1743560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124005Inst : IEnumerable<long>
{
public static readonly long[] Value=A124005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124005.Bytes);
public long this[int i]=>Value[i];

public static A124005Inst Instance=new A124005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124006
{
public static readonly long[] Value={ 1L,4L,12L,52L,228L,1192L,6160L,33344L,191380L,1072232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124006Inst : IEnumerable<long>
{
public static readonly long[] Value=A124006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124006.Bytes);
public long this[int i]=>Value[i];

public static A124006Inst Instance=new A124006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124007
{
public static readonly long[] Value={ 0L,0L,54L,216L,540L,1080L,1890L,3024L,4536L,6480L,8910L,11880L,15444L,19656L,24570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124007Inst : IEnumerable<long>
{
public static readonly long[] Value=A124007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124007.Bytes);
public long this[int i]=>Value[i];

public static A124007Inst Instance=new A124007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124008
{
public static readonly long[] Value={ 9L,189L,1431L,5355L,14310L,31374L,60354L,105786L,172935L,267795L,397089L,568269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124008Inst : IEnumerable<long>
{
public static readonly long[] Value=A124008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124008.Bytes);
public long this[int i]=>Value[i];

public static A124008Inst Instance=new A124008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124009
{
public static readonly BigInteger[] Value={ 0L,0L,216L,49464L,23123880L,19180338840L,25791442770240L,52614269909090064L,BigInteger.Parse("154809621283047068016"),BigInteger.Parse("631429039396055199165840"),BigInteger.Parse("3457808596178310768284115720"),BigInteger.Parse("24763433580060911383347280813320") };
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
public class A124009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124009Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A124009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124009.Bytes);
public BigInteger this[int i]=>Value[i];

public static A124009Inst Instance=new A124009Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124010
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,4L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,4L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,6L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124010Inst : IEnumerable<long>
{
public static readonly long[] Value=A124010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124010.Bytes);
public long this[int i]=>Value[i];

public static A124010Inst Instance=new A124010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124011
{
public static readonly long[] Value={ 5L,8L,14L,23L,35L,50L,68L,89L,113L,140L,170L,203L,239L,278L,320L,365L,413L,464L,518L,575L,635L,698L,764L,833L,905L,980L,1058L,1139L,1223L,1310L,1400L,1493L,1589L,1688L,1790L,1895L,2003L,2114L,2228L,2345L,2465L,2588L,2714L,2843L,2975L,3110L,3248L,3389L,3533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124011Inst : IEnumerable<long>
{
public static readonly long[] Value=A124011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124011.Bytes);
public long this[int i]=>Value[i];

public static A124011Inst Instance=new A124011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124012
{
public static readonly long[] Value={ 8L,4L,8L,9L,6L,9L,0L,3L,4L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124012Inst : IEnumerable<long>
{
public static readonly long[] Value=A124012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124012.Bytes);
public long this[int i]=>Value[i];

public static A124012Inst Instance=new A124012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124013
{
public static readonly long[] Value={ 3L,3L,3L,59L,11L,17L,29L,11L,71L,71L,23L,11L,29L,29L,11L,83L,3L,11L,281L,11L,101L,71L,23L,257L,401L,293L,107L,293L,53L,11L,113L,251L,47L,587L,23L,179L,389L,59L,173L,17L,1427L,83L,431L,53L,563L,593L,41L,47L,239L,383L,431L,1181L,701L,971L,149L,593L,569L,149L,191L,1973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124013Inst : IEnumerable<long>
{
public static readonly long[] Value=A124013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124013.Bytes);
public long this[int i]=>Value[i];

public static A124013Inst Instance=new A124013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124014
{
public static readonly BigInteger[] Value={ 1L,2L,4L,8L,22L,138L,4952L,7139100L,21413761011002L,BigInteger.Parse("226852422426283857888381406"),BigInteger.Parse("25729877378683265674254171054115441638555802828935420"),BigInteger.Parse("331013294649039928470435095480789359495537067296709574238913964352421152489181126832086450397574900411936") };
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
public class A124014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A124014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A124014Inst Instance=new A124014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124015
{
public static readonly long[] Value={ 101L,1015L,4030L,8938L,15788L,24029L,29766L,29150L,22326L,16165L,11417L,7750L,5059L,3157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124015Inst : IEnumerable<long>
{
public static readonly long[] Value=A124015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124015.Bytes);
public long this[int i]=>Value[i];

public static A124015Inst Instance=new A124015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124016
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,28L,69L,181L,474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124016Inst : IEnumerable<long>
{
public static readonly long[] Value=A124016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124016.Bytes);
public long this[int i]=>Value[i];

public static A124016Inst Instance=new A124016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124017
{
public static readonly long[] Value={ 45L,90L,26820L,26925L,30705L,31710L,33375L,63420L,63570L,71805L,83865L,93075L,103185L,127140L,134025L,148050L,170460L,202635L,211035L,223305L,269505L,297225L,303660L,329175L,335625L,362505L,387975L,405270L,405405L,406425L,409755L,463335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124017Inst : IEnumerable<long>
{
public static readonly long[] Value=A124017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124017.Bytes);
public long this[int i]=>Value[i];

public static A124017Inst Instance=new A124017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124018
{
public static readonly long[] Value={ 2L,2L,-1L,-3L,2L,1L,-4L,6L,2L,-1L,5L,-10L,-9L,2L,1L,6L,-19L,-16L,12L,2L,-1L,-7L,28L,42L,-22L,-15L,2L,1L,-8L,44L,68L,-74L,-28L,18L,2L,-1L,9L,-60L,-138L,126L,115L,-34L,-21L,2L,1L,10L,-85L,-208L,316L,202L,-165L,-40L,24L,2L,-1L,-11L,110L,363L,-506L,-605L,296L,224L,-46L,-27L,2L,1L,-12L,146L,518L,-1059L,-1008L,1032L,408L,-292L,-52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124018Inst : IEnumerable<long>
{
public static readonly long[] Value=A124018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124018.Bytes);
public long this[int i]=>Value[i];

public static A124018Inst Instance=new A124018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124019
{
public static readonly long[] Value={ 1L,-2L,1L,3L,-5L,1L,-4L,15L,-8L,1L,5L,-35L,36L,-11L,1L,-6L,70L,-120L,66L,-14L,1L,7L,-126L,330L,-286L,105L,-17L,1L,-8L,210L,-792L,1001L,-560L,153L,-20L,1L,9L,-330L,1716L,-3003L,2380L,-969L,210L,-23L,1L,-10L,495L,-3432L,8008L,-8568L,4845L,-1540L,276L,-26L,1L,11L,-715L,6435L,-19448L,27132L,-20349L,8855L,-2300L,351L,-29L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124019Inst : IEnumerable<long>
{
public static readonly long[] Value=A124019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124019.Bytes);
public long this[int i]=>Value[i];

public static A124019Inst Instance=new A124019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124020
{
public static readonly long[] Value={ 1L,1L,-1L,0L,-3L,1L,-1L,-4L,5L,-1L,-1L,-2L,12L,-7L,1L,0L,2L,17L,-24L,9L,-1L,1L,4L,13L,-52L,40L,-11L,1L,1L,1L,0L,-76L,115L,-60L,13L,-1L,0L,-5L,-10L,-72L,235L,-214L,84L,-15L,1L,-1L,-8L,-2L,-34L,352L,-554L,357L,-112L,17L,-1L,-1L,-4L,24L,2L,383L,-1092L,1113L,-552L,144L,-19L,1L,0L,4L,46L,-24L,295L,-1673L,2688L,-2008L,807L,-180L,21L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124020Inst : IEnumerable<long>
{
public static readonly long[] Value=A124020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124020.Bytes);
public long this[int i]=>Value[i];

public static A124020Inst Instance=new A124020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124021
{
public static readonly long[] Value={ 1L,1L,-1L,0L,2L,1L,1L,3L,1L,-1L,-1L,-4L,-3L,2L,1L,0L,-4L,-2L,6L,1L,-1L,-1L,4L,3L,-10L,-6L,2L,1L,-1L,5L,1L,-17L,-5L,9L,1L,-1L,0L,-6L,-3L,24L,16L,-16L,-9L,2L,1L,-1L,-7L,-2L,34L,11L,-39L,-8L,12L,1L,-1L,1L,8L,6L,-44L,-29L,62L,38L,-22L,-12L,2L,1L,0L,8L,4L,-60L,-18L,114L,30L,-70L,-11L,15L,1L,-1L,1L,-8L,-6L,76L,49L,-166L,-106L,118L,69L,-28L,-15L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124021Inst : IEnumerable<long>
{
public static readonly long[] Value=A124021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124021.Bytes);
public long this[int i]=>Value[i];

public static A124021Inst Instance=new A124021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124022
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,2L,1L,-1L,4L,2L,-1L,1L,-6L,-7L,2L,1L,1L,-9L,-12L,10L,2L,-1L,-1L,12L,26L,-18L,-13L,2L,1L,-1L,16L,40L,-52L,-24L,16L,2L,-1L,1L,-20L,-70L,86L,87L,-30L,-19L,2L,1L,1L,-25L,-100L,190L,150L,-131L,-36L,22L,2L,-1L,-1L,30L,155L,-294L,-403L,232L,184L,-42L,-25L,2L,1L,-1L,36L,210L,-553L,-656L,736L,332L,-246L,-48L,28L,2L,-1L,1L,-42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124022Inst : IEnumerable<long>
{
public static readonly long[] Value=A124022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124022.Bytes);
public long this[int i]=>Value[i];

public static A124022Inst Instance=new A124022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124023
{
public static readonly long[] Value={ 1L,2L,10L,28L,108L,344L,1224L,4080L,14128L,47840L,164128L,558784L,1910976L,6518144L,22267008L,75998976L,259527424L,885980672L,3025129984L,10328034304L,35262925824L,120393537536L,411052492800L,1403414507520L,4791569821696L,16359416717312L,55854594334720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124023Inst : IEnumerable<long>
{
public static readonly long[] Value=A124023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124023.Bytes);
public long this[int i]=>Value[i];

public static A124023Inst Instance=new A124023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124024
{
public static readonly long[] Value={ 1L,-2L,13L,-34L,160L,-486L,2007L,-6618L,25639L,-88340L,331216L,-1168012L,4305373L,-15368994L,56150145L,-201727446L,733589392L,-2644379378L,9593038099L,-34640959450L,125507521051L,-453631399272L,1642455703008L,-5939313991704L,21496877712505L,-77754867323906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124024Inst : IEnumerable<long>
{
public static readonly long[] Value=A124024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124024.Bytes);
public long this[int i]=>Value[i];

public static A124024Inst Instance=new A124024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124025
{
public static readonly long[] Value={ 1L,3L,-1L,8L,-6L,1L,21L,-25L,9L,-1L,55L,-90L,51L,-12L,1L,144L,-300L,234L,-86L,15L,-1L,377L,-954L,951L,-480L,130L,-18L,1L,987L,-2939L,3573L,-2305L,855L,-183L,21L,-1L,2584L,-8850L,12707L,-10008L,4740L,-1386L,245L,-24L,1L,6765L,-26195L,43398L,-40426L,23373L,-8715L,2100L,-316L,27L,-1L,17711L,-76500L,143682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124025Inst : IEnumerable<long>
{
public static readonly long[] Value=A124025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124025.Bytes);
public long this[int i]=>Value[i];

public static A124025Inst Instance=new A124025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124026
{
public static readonly long[] Value={ 0L,2L,1L,14L,26L,132L,364L,1416L,4488L,16016L,53296L,184736L,625184L,2145600L,7303360L,24979584L,85196928L,291057920L,993379072L,3392317952L,11580678656L,39541748736L,134998297600L,460924372992L,1573671536640L,5372896120832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124026Inst : IEnumerable<long>
{
public static readonly long[] Value=A124026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124026.Bytes);
public long this[int i]=>Value[i];

public static A124026Inst Instance=new A124026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124027
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,3L,0L,1L,2L,0L,6L,0L,1L,0L,10L,0L,10L,0L,1L,5L,0L,30L,0L,15L,0L,1L,0L,35L,0L,70L,0L,21L,0L,1L,14L,0L,140L,0L,140L,0L,28L,0L,1L,0L,126L,0L,420L,0L,252L,0L,36L,0L,1L,42L,0L,630L,0L,1050L,0L,420L,0L,45L,0L,1L,0L,462L,0L,2310L,0L,2310L,0L,660L,0L,55L,0L,1L,132L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124027Inst : IEnumerable<long>
{
public static readonly long[] Value=A124027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124027.Bytes);
public long this[int i]=>Value[i];

public static A124027Inst Instance=new A124027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124028
{
public static readonly long[] Value={ 4L,4L,-1L,-15L,2L,1L,-56L,18L,4L,-1L,209L,-34L,-33L,2L,1L,780L,-259L,-128L,36L,4L,-1L,-2911L,484L,738L,-70L,-51L,2L,1L,-10864L,3620L,2824L,-842L,-200L,54L,4L,-1L,40545L,-6756L,-14178L,1614L,1591L,-106L,-69L,2L,1L,151316L,-50437L,-53888L,16564L,6164L,-1749L,-272L,72L,4L,-1L,-564719L,94118L,251811L,-31514L,-39629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124028Inst : IEnumerable<long>
{
public static readonly long[] Value=A124028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124028.Bytes);
public long this[int i]=>Value[i];

public static A124028Inst Instance=new A124028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124029
{
public static readonly long[] Value={ 1L,4L,-1L,15L,-8L,1L,56L,-46L,12L,-1L,209L,-232L,93L,-16L,1L,780L,-1091L,592L,-156L,20L,-1L,2911L,-4912L,3366L,-1200L,235L,-24L,1L,10864L,-21468L,17784L,-8010L,2120L,-330L,28L,-1L,40545L,-91824L,89238L,-48624L,16255L,-3416L,441L,-32L,1L,151316L,-386373L,430992L,-275724L,111524L,-29589L,5152L,-568L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124029Inst : IEnumerable<long>
{
public static readonly long[] Value=A124029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124029.Bytes);
public long this[int i]=>Value[i];

public static A124029Inst Instance=new A124029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124030
{
public static readonly long[] Value={ 1L,1L,-1L,0L,-2L,1L,0L,-3L,4L,-1L,3L,-14L,19L,-8L,1L,48L,-173L,204L,-89L,16L,-1L,1505L,-4866L,5173L,-2082L,381L,-32L,1L,108780L,-325990L,316978L,-113481L,18926L,-1580L,64L,-1L,19072536L,-53887686L,48428411L,-15201276L,2206536L,-164222L,6469L,-128L,1L,8332293760L,-22465873081L,18859204368L,-5176293234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124030Inst : IEnumerable<long>
{
public static readonly long[] Value=A124030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124030.Bytes);
public long this[int i]=>Value[i];

public static A124030Inst Instance=new A124030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124031
{
public static readonly long[] Value={ -1L,-1L,-1L,-2L,0L,1L,3L,3L,-1L,-1L,5L,0L,-5L,0L,1L,-8L,-8L,6L,6L,-1L,-1L,-13L,0L,19L,0L,-8L,0L,1L,21L,21L,-25L,-25L,9L,9L,-1L,-1L,34L,0L,-65L,0L,42L,0L,-11L,0L,1L,-55L,-55L,90L,90L,-51L,-51L,12L,12L,-1L,-1L,-89L,0L,210L,0L,-183L,0L,74L,0L,-14L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124031Inst : IEnumerable<long>
{
public static readonly long[] Value=A124031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124031.Bytes);
public long this[int i]=>Value[i];

public static A124031Inst Instance=new A124031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124032
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,2L,1L,1L,3L,-1L,-1L,-1L,-6L,-3L,2L,1L,-2L,-8L,4L,6L,-1L,-1L,3L,16L,7L,-12L,-6L,2L,1L,5L,21L,-13L,-25L,7L,9L,-1L,-1L,-8L,-42L,-15L,50L,24L,-18L,-9L,2L,1L,-13L,-55L,40L,90L,-33L,-51L,10L,12L,-1L,-1L,21L,110L,30L,-180L,-81L,102L,50L,-24L,-12L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124032Inst : IEnumerable<long>
{
public static readonly long[] Value=A124032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124032.Bytes);
public long this[int i]=>Value[i];

public static A124032Inst Instance=new A124032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124033
{
public static readonly long[] Value={ 4L,31L,225L,1563L,10222L,63030L,374264L,2160300L,12196405L,67724342L,371233523L,2014305995L,10841722966L,57974736592L,308361428628L,1632877406997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124033Inst : IEnumerable<long>
{
public static readonly long[] Value=A124033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124033.Bytes);
public long this[int i]=>Value[i];

public static A124033Inst Instance=new A124033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124034
{
public static readonly long[] Value={ -1L,-1L,-1L,2L,2L,1L,1L,1L,1L,-1L,1L,0L,-1L,2L,1L,2L,0L,0L,4L,1L,-1L,-1L,0L,-1L,-6L,-4L,2L,1L,1L,1L,-1L,-7L,-3L,7L,1L,-1L,-2L,-2L,-1L,8L,6L,-12L,-7L,2L,1L,-1L,-1L,-2L,10L,3L,-23L,-6L,10L,1L,-1L,-1L,0L,2L,-12L,-7L,34L,22L,-18L,-10L,2L,1L,-2L,0L,0L,-16L,-4L,52L,16L,-48L,-9L,13L,1L,-1L,1L,0L,2L,20L,13L,-70L,-46L,78L,47L,-24L,-13L,2L,1L,-1L,-1L,2L,22L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124034Inst : IEnumerable<long>
{
public static readonly long[] Value=A124034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124034.Bytes);
public long this[int i]=>Value[i];

public static A124034Inst Instance=new A124034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124035
{
public static readonly long[] Value={ -1L,-1L,-1L,-2L,0L,1L,-1L,3L,1L,-1L,1L,4L,-3L,-2L,1L,2L,0L,-8L,2L,3L,-1L,1L,-6L,-5L,12L,0L,-4L,1L,-1L,-7L,9L,15L,-15L,-3L,5L,-1L,-2L,0L,21L,-6L,-30L,16L,7L,-6L,1L,-1L,9L,12L,-42L,-9L,49L,-14L,-12L,7L,-1L,1L,10L,-18L,-48L,63L,42L,-70L,8L,18L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124035Inst : IEnumerable<long>
{
public static readonly long[] Value=A124035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124035.Bytes);
public long this[int i]=>Value[i];

public static A124035Inst Instance=new A124035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124036
{
public static readonly long[] Value={ 1L,1L,-1L,0L,-3L,1L,-2L,-1L,4L,-1L,-4L,6L,7L,-6L,1L,0L,12L,-7L,-11L,7L,-1L,8L,12L,-40L,-3L,23L,-9L,1L,8L,-20L,-38L,59L,12L,-30L,10L,-1L,0L,-72L,24L,162L,-81L,-54L,48L,-12L,1L,-16L,-32L,172L,20L,-267L,87L,82L,-58L,13L,-1L,-32L,96L,328L,-456L,-392L,549L,-19L,-174L,82L,-15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124036Inst : IEnumerable<long>
{
public static readonly long[] Value=A124036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124036.Bytes);
public long this[int i]=>Value[i];

public static A124036Inst Instance=new A124036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124037
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-4L,1L,5L,-13L,7L,-1L,13L,-40L,33L,-10L,1L,34L,-120L,132L,-62L,13L,-1L,89L,-354L,483L,-308L,100L,-16L,1L,233L,-1031L,1671L,-1345L,595L,-147L,19L,-1L,610L,-2972L,5561L,-5398L,3030L,-1020L,203L,-22L,1L,1597L,-8495L,17984L,-20410L,13893L,-5943L,1610L,-268L,25L,-1L,4181L,-24110L,56886L,-73816L,59059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124037Inst : IEnumerable<long>
{
public static readonly long[] Value=A124037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124037.Bytes);
public long this[int i]=>Value[i];

public static A124037Inst Instance=new A124037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124038
{
public static readonly long[] Value={ 1L,-2L,1L,-1L,-2L,1L,2L,-2L,-2L,1L,1L,4L,-3L,-2L,1L,-2L,3L,6L,-4L,-2L,1L,-1L,-6L,6L,8L,-5L,-2L,1L,2L,-4L,-12L,10L,10L,-6L,-2L,1L,1L,8L,-10L,-20L,15L,12L,-7L,-2L,1L,-2L,5L,20L,-20L,-30L,21L,14L,-8L,-2L,1L,-1L,-10L,15L,40L,-35L,-42L,28L,16L,-9L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124038Inst : IEnumerable<long>
{
public static readonly long[] Value=A124038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124038.Bytes);
public long this[int i]=>Value[i];

public static A124038Inst Instance=new A124038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124039
{
public static readonly long[] Value={ 3L,3L,-1L,-1L,-3L,1L,-3L,2L,3L,-1L,1L,6L,-3L,-3L,1L,3L,-3L,-9L,4L,3L,-1L,-1L,-9L,6L,12L,-5L,-3L,1L,-3L,4L,18L,-10L,-15L,6L,3L,-1L,1L,12L,-10L,-30L,15L,18L,-7L,-3L,1L,3L,-5L,-30L,20L,45L,-21L,-21L,8L,3L,-1L,-1L,-15L,15L,60L,-35L,-63L,28L,24L,-9L,-3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124039Inst : IEnumerable<long>
{
public static readonly long[] Value=A124039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124039.Bytes);
public long this[int i]=>Value[i];

public static A124039Inst Instance=new A124039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124040
{
public static readonly long[] Value={ 3L,3L,-1L,8L,-6L,1L,20L,-24L,9L,-1L,45L,-84L,50L,-12L,1L,125L,-275L,225L,-85L,15L,-1L,320L,-864L,900L,-468L,129L,-18L,1L,845L,-2639L,3339L,-2219L,840L,-182L,21L,-1L,2205L,-7896L,11756L,-9528L,4610L,-1368L,244L,-24L,1L,5780L,-23256L,39825L,-38121L,22518L,-8532L,2079L,-315L,27L,-1L,15125L,-67650L,130975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124040Inst : IEnumerable<long>
{
public static readonly long[] Value=A124040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124040.Bytes);
public long this[int i]=>Value[i];

public static A124040Inst Instance=new A124040Inst();

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