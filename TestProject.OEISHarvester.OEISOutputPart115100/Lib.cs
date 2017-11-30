using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A282392
{
public static readonly BigInteger[] Value={ 2L,16L,324L,23773L,5297294L,3599858930L,7910979963313L,53854022070851701L,BigInteger.Parse("1148683749680759012469"),BigInteger.Parse("77042220735586114776631734"),BigInteger.Parse("16170289409470789812334507667662") };
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
public class A282392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A282392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A282392Inst Instance=new A282392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282393
{
public static readonly long[] Value={ 4L,16L,57L,213L,796L,2964L,11049L,41193L,153556L,572424L,2133897L,7954765L,29653852L,110543980L,412087129L,1536183105L,5726601012L,21347689024L,79580160153L,296659834437L,1105891936092L,4122556653316L,15368114012745L,57289431819225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282393Inst : IEnumerable<long>
{
public static readonly long[] Value=A282393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282393.Bytes);
public long this[int i]=>Value[i];

public static A282393Inst Instance=new A282393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282394
{
public static readonly long[] Value={ 8L,57L,324L,2048L,12771L,79266L,493671L,3072417L,19120172L,119000389L,740614274L,4609310900L,28686740079L,178536045502L,1111144834977L,6915370693273L,43038808688816L,267858246154477L,1667054510423628L,10375154684003232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282394Inst : IEnumerable<long>
{
public static readonly long[] Value=A282394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282394.Bytes);
public long this[int i]=>Value[i];

public static A282394Inst Instance=new A282394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282395
{
public static readonly long[] Value={ 16L,213L,2048L,23773L,266425L,2966724L,33295509L,372745151L,4173376213L,46739417550L,523384918422L,5860963933056L,65632659610425L,734967860658205L,8230333458750528L,92165106111769481L,1032085136849026696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282395Inst : IEnumerable<long>
{
public static readonly long[] Value=A282395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282395.Bytes);
public long this[int i]=>Value[i];

public static A282395Inst Instance=new A282395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282396
{
public static readonly BigInteger[] Value={ 32L,796L,12771L,266425L,5297294L,104126212L,2073090293L,41113855962L,815396431544L,16180271550797L,320994645608890L,6368309327679546L,126345207041984379L,2506615691847812429L,BigInteger.Parse("49729959598966238800") };
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
public class A282396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A282396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A282396Inst Instance=new A282396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282397
{
public static readonly BigInteger[] Value={ 64L,2964L,79266L,2966724L,104126212L,3599858930L,126635741170L,4430221392726L,155002258286662L,5427337813678379L,189966490267227686L,6649542196394993215L,BigInteger.Parse("232765335664684281060"),BigInteger.Parse("8147716503175076371428"),BigInteger.Parse("285204201527962753414930") };
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
public class A282397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282397Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A282397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282397.Bytes);
public BigInteger this[int i]=>Value[i];

public static A282397Inst Instance=new A282397Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282398
{
public static readonly BigInteger[] Value={ 128L,11049L,493671L,33295509L,2073090293L,126635741170L,7910979963313L,490628902023166L,30431979525697236L,1889587741570229743L,BigInteger.Parse("117269093511110140693"),BigInteger.Parse("7278377038031604032628"),BigInteger.Parse("451754768247190778744879") };
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
public class A282398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A282398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A282398Inst Instance=new A282398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282399
{
public static readonly long[] Value={ 2L,4L,4L,8L,16L,8L,16L,57L,57L,16L,32L,213L,324L,213L,32L,64L,796L,2048L,2048L,796L,64L,128L,2964L,12771L,23773L,12771L,2964L,128L,256L,11049L,79266L,266425L,266425L,79266L,11049L,256L,512L,41193L,493671L,2966724L,5297294L,2966724L,493671L,41193L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282399Inst : IEnumerable<long>
{
public static readonly long[] Value=A282399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282399.Bytes);
public long this[int i]=>Value[i];

public static A282399Inst Instance=new A282399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282416
{
public static readonly BigInteger[] Value={ 1L,1L,110L,11L,11100L,111L,1111000L,1111L,111110000L,11111L,11111100000L,111111L,1111111000000L,1111111L,111111110000000L,11111111L,11111111100000000L,111111111L,1111111111000000000L,1111111111L,BigInteger.Parse("111111111110000000000"),11111111111L,BigInteger.Parse("11111111111100000000000") };
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
public class A282416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A282416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A282416Inst Instance=new A282416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282417
{
public static readonly long[] Value={ 1L,2L,3L,12L,7L,56L,15L,240L,31L,992L,63L,4032L,127L,16256L,255L,65280L,511L,261632L,1023L,1047552L,2047L,4192256L,4095L,16773120L,8191L,67100672L,16383L,268419072L,32767L,1073709056L,65535L,4294901760L,131071L,17179738112L,262143L,68719214592L,524287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282417Inst : IEnumerable<long>
{
public static readonly long[] Value=A282417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282417.Bytes);
public long this[int i]=>Value[i];

public static A282417Inst Instance=new A282417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282418
{
public static readonly long[] Value={ 1L,1L,6L,3L,28L,7L,120L,15L,496L,31L,2016L,63L,8128L,127L,32640L,255L,130816L,511L,523776L,1023L,2096128L,2047L,8386560L,4095L,33550336L,8191L,134209536L,16383L,536854528L,32767L,2147450880L,65535L,8589869056L,131071L,34359607296L,262143L,137438691328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282418Inst : IEnumerable<long>
{
public static readonly long[] Value=A282418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282418.Bytes);
public long this[int i]=>Value[i];

public static A282418Inst Instance=new A282418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282419
{
public static readonly ulong[] Value={ 1L,11L,100L,1110L,10011L,111100L,1000110L,11101001L,100111111L,1111000000L,10001110110L,111010001001L,1001111010111L,11110000111000L,100011101000110L,1110100010101001L,10011110111110111L,111100011100001000L,1000111100011011110L,11101000110111110001UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282419Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A282419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282419.Bytes);
public ulong this[int i]=>Value[i];

public static A282419Inst Instance=new A282419Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282420
{
public static readonly BigInteger[] Value={ 1L,11L,1L,111L,11001L,1111L,110001L,10010111L,111111001L,1111L,1101110001L,100100010111L,1110101111001L,11100001111L,11000101110001L,1001010100010111L,11101111101111001L,100001110001111L,111101100011110001L,10001111101100010111UL,BigInteger.Parse("111100000101101111001") };
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
public class A282420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A282420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A282420Inst Instance=new A282420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282421
{
public static readonly long[] Value={ 1L,3L,4L,14L,19L,60L,70L,233L,319L,960L,1142L,3721L,5079L,15416L,18246L,59561L,81399L,247560L,293086L,953841L,1301007L,3941752L,4685710L,15253721L,20790063L,63366360L,75184942L,244180209L,333070095L,1009082576L,1199545150L,3904961761L,5322244891L,16221846758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282421Inst : IEnumerable<long>
{
public static readonly long[] Value=A282421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282421.Bytes);
public long this[int i]=>Value[i];

public static A282421Inst Instance=new A282421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282422
{
public static readonly long[] Value={ 1L,3L,1L,7L,25L,15L,49L,151L,505L,15L,881L,2327L,7545L,1807L,12657L,38167L,122745L,17295L,252145L,588567L,1969017L,502031L,3735409L,10158871L,32094585L,7118223L,61269745L,150108951L,505383801L,46246159L,1047330673L,2269053719L,7273036153L,6928375183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282422Inst : IEnumerable<long>
{
public static readonly long[] Value=A282422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282422.Bytes);
public long this[int i]=>Value[i];

public static A282422Inst Instance=new A282422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282423
{
public static readonly long[] Value={ 3L,2L,0L,13L,19L,0L,427L,4L,0L,0L,1L,0L,802L,99412L,0L,3097L,7L,0L,637L,0L,0L,7225627L,30898822L,0L,0L,280134277L,0L,31705902442L,43190647L,0L,965577112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282423Inst : IEnumerable<long>
{
public static readonly long[] Value=A282423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282423.Bytes);
public long this[int i]=>Value[i];

public static A282423Inst Instance=new A282423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282424
{
public static readonly long[] Value={ 1226777L,4732631L,5093729L,9210671L,12515461L,12917989L,16121409L,16183253L,16698881L,17263069L,19418903L,23003807L,24534161L,26519563L,26726659L,27625067L,29605299L,29772471L,32655031L,34027277L,34366179L,35340719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282424Inst : IEnumerable<long>
{
public static readonly long[] Value=A282424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282424.Bytes);
public long this[int i]=>Value[i];

public static A282424Inst Instance=new A282424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282425
{
public static readonly long[] Value={ 0L,5L,16L,45L,84L,163L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282425Inst : IEnumerable<long>
{
public static readonly long[] Value=A282425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282425.Bytes);
public long this[int i]=>Value[i];

public static A282425Inst Instance=new A282425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282426
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,3L,3L,4L,3L,2L,3L,4L,2L,1L,5L,6L,5L,4L,5L,4L,5L,3L,4L,7L,5L,5L,7L,5L,3L,5L,6L,5L,6L,4L,5L,5L,6L,4L,7L,7L,6L,9L,6L,5L,6L,5L,4L,6L,4L,4L,7L,6L,6L,6L,5L,2L,6L,3L,4L,6L,6L,5L,6L,6L,6L,10L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282426Inst : IEnumerable<long>
{
public static readonly long[] Value=A282426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282426.Bytes);
public long this[int i]=>Value[i];

public static A282426Inst Instance=new A282426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282427
{
public static readonly long[] Value={ 1L,3L,7L,39L,47L,111L,959L,3319L,7407L,11967L,13007L,16239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282427Inst : IEnumerable<long>
{
public static readonly long[] Value=A282427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282427.Bytes);
public long this[int i]=>Value[i];

public static A282427Inst Instance=new A282427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282428
{
public static readonly long[] Value={ 1L,2L,6L,10L,18L,29L,63L,155L,211L,264L,546L,1032L,1156L,1321L,1553L,3460L,4901L,5907L,8335L,8529L,11455L,13153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282428Inst : IEnumerable<long>
{
public static readonly long[] Value=A282428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282428.Bytes);
public long this[int i]=>Value[i];

public static A282428Inst Instance=new A282428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282429
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,11L,13L,14L,16L,17L,19L,22L,23L,26L,28L,29L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282429Inst : IEnumerable<long>
{
public static readonly long[] Value=A282429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282429.Bytes);
public long this[int i]=>Value[i];

public static A282429Inst Instance=new A282429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282430
{
public static readonly long[] Value={ 2L,328L,562L,716L,794L,898L,1084L,1772L,1808L,1918L,1924L,1972L,2186L,2434L,2564L,2572L,2894L,2986L,3056L,3524L,3578L,3716L,3868L,4144L,4304L,4414L,4714L,4774L,4838L,4852L,4924L,5072L,5098L,5164L,5204L,5272L,5338L,5398L,5456L,5614L,5708L,5756L,5968L,5972L,5974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282430Inst : IEnumerable<long>
{
public static readonly long[] Value=A282430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282430.Bytes);
public long this[int i]=>Value[i];

public static A282430Inst Instance=new A282430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282431
{
public static readonly long[] Value={ 1L,-120L,5400L,-104160L,511800L,6770736L,-19504800L,-452207040L,-2959622280L,-12932941080L,-44497080432L,-129918587040L,-335811977760L,-788655411600L,-1714912983360L,-3498061536576L,-6761506680840L,-12481939678320L,-22138262633160L,-37922739116640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282431Inst : IEnumerable<long>
{
public static readonly long[] Value=A282431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282431.Bytes);
public long this[int i]=>Value[i];

public static A282431Inst Instance=new A282431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282866
{
public static readonly long[] Value={ 1L,1L,0L,0L,4L,4L,0L,0L,0L,9L,9L,0L,0L,36L,36L,0L,16L,16L,0L,0L,64L,64L,0L,0L,0L,169L,169L,0L,0L,676L,676L,0L,0L,0L,225L,225L,36L,36L,900L,900L,144L,544L,400L,0L,0L,1924L,1924L,0L,0L,1345L,4945L,3600L,576L,772L,14596L,14400L,2304L,2304L,441L,441L,0L,6084L,7848L,1764L,64L,25184L,25120L,0L,256L,3392L,11236L,8100L,0L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282866Inst : IEnumerable<long>
{
public static readonly long[] Value=A282866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282866.Bytes);
public long this[int i]=>Value[i];

public static A282866Inst Instance=new A282866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282867
{
public static readonly long[] Value={ 41L,313L,3593L,4481L,32633L,42961L,66361L,67073L,165233L,198593L,237161L,266921L,378953L,462073L,465041L,487073L,559001L,594161L,750353L,757633L,815401L,1157033L,1414081L,1416161L,1687393L,2439881L,2793481L,2866121L,2947561L,3344161L,3577913L,3759713L,4295281L,4617073L,4795481L,5654641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282867Inst : IEnumerable<long>
{
public static readonly long[] Value=A282867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282867.Bytes);
public long this[int i]=>Value[i];

public static A282867Inst Instance=new A282867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282868
{
public static readonly long[] Value={ 11L,1L,22L,2L,33L,3L,44L,4L,55L,5L,66L,6L,77L,7L,88L,8L,99L,9L,1001L,0L,1010L,1111L,1100L,2222L,3333L,4444L,5555L,6666L,7777L,8888L,9999L,111111L,222222L,333333L,444444L,555555L,666666L,777777L,888888L,999999L,10000111L,200222L,200002L,202022L,11111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282868Inst : IEnumerable<long>
{
public static readonly long[] Value=A282868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282868.Bytes);
public long this[int i]=>Value[i];

public static A282868Inst Instance=new A282868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282869
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,2L,1L,1L,7L,5L,2L,1L,1L,12L,10L,6L,2L,1L,1L,20L,21L,12L,7L,2L,1L,1L,33L,41L,28L,14L,8L,2L,1L,1L,54L,81L,56L,36L,16L,9L,2L,1L,1L,88L,155L,120L,72L,45L,18L,10L,2L,1L,1L,143L,297L,239L,165L,90L,55L,20L,11L,2L,1L,1L,232L,560L,492L,330L,220L,110L,66L,22L,12L,2L,1L,1L,376L,1054L,974L,715L,440L,286L,132L,78L,24L,13L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282869Inst : IEnumerable<long>
{
public static readonly long[] Value=A282869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282869.Bytes);
public long this[int i]=>Value[i];

public static A282869Inst Instance=new A282869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282870
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,3L,3L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,3L,3L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,4L,4L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,4L,5L,5L,4L,4L,4L,5L,4L,4L,3L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282870Inst : IEnumerable<long>
{
public static readonly long[] Value=A282870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282870.Bytes);
public long this[int i]=>Value[i];

public static A282870Inst Instance=new A282870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282871
{
public static readonly ulong[] Value={ 1L,0L,11L,1L,1110L,110L,111110L,11110L,11111110L,1111110L,1111111110L,111111110L,111111111110L,11111111110L,11111111111110L,1111111111110L,1111111111111110L,111111111111110L,111111111111111110L,11111111111111110L,11111111111111111110UL,1111111111111111110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282871Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A282871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282871.Bytes);
public ulong this[int i]=>Value[i];

public static A282871Inst Instance=new A282871Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282872
{
public static readonly long[] Value={ 2457L,4914L,4977L,8001L,8216L,10773L,15561L,16263L,19656L,39816L,64008L,66339L,80236L,86184L,124336L,124488L,127062L,130104L,132678L,132867L,157248L,166887L,201717L,221832L,238329L,252035L,290871L,307125L,318528L,338821L,358036L,406952L,411021L,420147L,421876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282872Inst : IEnumerable<long>
{
public static readonly long[] Value=A282872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282872.Bytes);
public long this[int i]=>Value[i];

public static A282872Inst Instance=new A282872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282873
{
public static readonly long[] Value={ 10202696L,29791125L,48137544L,70957971L,81621568L,238329000L,275472792L,288975141L,385100352L,387352719L,553514689L,567663768L,652972544L,692612137L,728274456L,1051871977L,1104726168L,1275337000L,1299713688L,1402390152L,1484204904L,1906632000L,2203782336L,2311801128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282873Inst : IEnumerable<long>
{
public static readonly long[] Value=A282873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282873.Bytes);
public long this[int i]=>Value[i];

public static A282873Inst Instance=new A282873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282874
{
public static readonly long[] Value={ 25L,529L,49L,169L,361L,841L,289L,5041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282874Inst : IEnumerable<long>
{
public static readonly long[] Value=A282874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282874.Bytes);
public long this[int i]=>Value[i];

public static A282874Inst Instance=new A282874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282875
{
public static readonly long[] Value={ 5L,23L,7L,13L,19L,29L,17L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282875Inst : IEnumerable<long>
{
public static readonly long[] Value=A282875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282875.Bytes);
public long this[int i]=>Value[i];

public static A282875Inst Instance=new A282875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282876
{
public static readonly long[] Value={ 1L,3L,8L,11L,25L,35L,57L,86L,139L,198L,291L,417L,588L,812L,1132L,1538L,2103L,2805L,3767L,4963L,6554L,8548L,11165L,14426L,18601L,23830L,30443L,38642L,48986L,61748L,77669L,97206L,121478L,151067L,187556L,231974L,286385L,352340L,432641L,529688L,647241L,788738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282876Inst : IEnumerable<long>
{
public static readonly long[] Value=A282876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282876.Bytes);
public long this[int i]=>Value[i];

public static A282876Inst Instance=new A282876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282877
{
public static readonly long[] Value={ 1L,9L,51L,204L,681L,1956L,5135L,12360L,28119L,60572L,125682L,251040L,487426L,920568L,1699611L,3070508L,5445510L,9490116L,16283793L,27537708L,45959775L,75760640L,123471327L,199081632L,317814988L,502608456L,787889775L,1224834672L,1889206080L,2892264900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282877Inst : IEnumerable<long>
{
public static readonly long[] Value=A282877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282877.Bytes);
public long this[int i]=>Value[i];

public static A282877Inst Instance=new A282877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282878
{
public static readonly BigInteger[] Value={ 0L,2L,74L,3762L,480995L,128768496L,79687436788L,115172557654616L,393143666098549156L,BigInteger.Parse("3196549492640753656296"),BigInteger.Parse("62216948503916625663186184") };
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
public class A282878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A282878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A282878Inst Instance=new A282878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282879
{
public static readonly long[] Value={ 0L,2L,8L,32L,122L,416L,1414L,4626L,14930L,47432L,149032L,463918L,1432956L,4397436L,13419434L,40754026L,123245234L,371322718L,1115052844L,3338521720L,9969125698L,29697147320L,88271949298L,261856896380L,775373941754L,2292071140404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282879Inst : IEnumerable<long>
{
public static readonly long[] Value=A282879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282879.Bytes);
public long this[int i]=>Value[i];

public static A282879Inst Instance=new A282879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282880
{
public static readonly long[] Value={ 1L,8L,74L,430L,2426L,13062L,67676L,342972L,1707597L,8384136L,40716024L,195950228L,935955604L,4442192472L,20968437076L,98509310972L,460879910601L,2148369624844L,9981992555058L,46244594782978L,213681269956154L,985012878231418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282880Inst : IEnumerable<long>
{
public static readonly long[] Value=A282880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282880.Bytes);
public long this[int i]=>Value[i];

public static A282880Inst Instance=new A282880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A282881
{
public static readonly long[] Value={ 2L,32L,430L,3762L,34314L,286920L,2342046L,18668994L,146171090L,1129426388L,8631205392L,65377140772L,491525631332L,3672205687546L,27287152439396L,201813637267634L,1486474449573152L,10909072654743782L,79802389614658676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A282881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A282881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A282881Inst : IEnumerable<long>
{
public static readonly long[] Value=A282881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A282881.Bytes);
public long this[int i]=>Value[i];

public static A282881Inst Instance=new A282881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283922
{
public static readonly BigInteger[] Value={ 1L,32L,7776L,41472L,194400000L,25920000L,653456160000L,49787136000L,25204737600000L,160030080000L,16913534146740000L,312400053504000L,BigInteger.Parse("319702820637227227200000"),788601079506240000L,BigInteger.Parse("1053965342760089760000"),187184432058624000L };
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
public class A283922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283922Inst Instance=new A283922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283923
{
public static readonly BigInteger[] Value={ 1L,1L,-601L,4409L,-42849721L,-878249L,1363125719173L,-129898224049L,-297927535838903L,4572261241181L,-525680140620492443L,-301857269916983503L,BigInteger.Parse("4258363189724529911241659137"),BigInteger.Parse("6916875732289230327479"),BigInteger.Parse("-57491970528985420156677059"),BigInteger.Parse("-4871655423556947027887") };
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
public class A283923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283923Inst Instance=new A283923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283924
{
public static readonly BigInteger[] Value={ 1L,64L,46656L,497664L,11664000000L,518400000L,274451587200000L,41821194240000L,63515938752000000L,403275801600000L,BigInteger.Parse("3750745332381062400000"),8659729483130880000L,BigInteger.Parse("115208108444831203593792000000"),BigInteger.Parse("60895775359471852800000"),BigInteger.Parse("189903475458512972956800000") };
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
public class A283924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283924Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283924.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283924Inst Instance=new A283924Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283925
{
public static readonly BigInteger[] Value={ 1L,1L,-1931L,32459L,-2310243527L,56642411L,229396175476157L,-106580201025857L,113274473629427263L,5016925009330883L,BigInteger.Parse("-816236427314937438059737"),BigInteger.Parse("-1108823743074112124111"),BigInteger.Parse("1385996135483315761385354011661489") };
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
public class A283925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283925Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283925.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283925Inst Instance=new A283925Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283926
{
public static readonly BigInteger[] Value={ 1L,128L,279936L,5971968L,699840000000L,93312000000L,115269666624000000L,35129803161600000L,BigInteger.Parse("160060165655040000000"),1016255020032000000L,BigInteger.Parse("103970660613603049728000000"),BigInteger.Parse("240047701272387993600000"),BigInteger.Parse("41516393959179372527058885120000000") };
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
public class A283926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283926Inst Instance=new A283926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283927
{
public static readonly long[] Value={ 11L,22L,33L,66L,91L,99L,160L,182L,198L,255L,364L,380L,390L,456L,462L,637L,657L,728L,828L,882L,1134L,1280L,1400L,1470L,1980L,2240L,2244L,2256L,2496L,2646L,2673L,2940L,3108L,3128L,3136L,3384L,3402L,3528L,3572L,3588L,3612L,3690L,3900L,4026L,4131L,4158L,4176L,4312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283927Inst : IEnumerable<long>
{
public static readonly long[] Value=A283927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283927.Bytes);
public long this[int i]=>Value[i];

public static A283927Inst Instance=new A283927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283928
{
public static readonly long[] Value={ 436L,2753L,13396L,19960L,24293L,26157L,58492L,58723L,61935L,121992L,136592L,145803L,149027L,159752L,179811L,180776L,184575L,194499L,262321L,268645L,280911L,315198L,327876L,339951L,364307L,390394L,413010L,433626L,444744L,492661L,510412L,518156L,541925L,542177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283928Inst : IEnumerable<long>
{
public static readonly long[] Value=A283928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283928.Bytes);
public long this[int i]=>Value[i];

public static A283928Inst Instance=new A283928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283929
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,1L,2L,1L,2L,1L,2L,1L,3L,2L,3L,2L,3L,0L,2L,2L,3L,2L,2L,1L,3L,3L,4L,3L,4L,2L,3L,3L,4L,4L,2L,1L,3L,3L,5L,4L,4L,2L,3L,3L,4L,4L,1L,2L,1L,5L,4L,5L,6L,2L,4L,5L,5L,4L,2L,3L,2L,5L,5L,6L,5L,2L,4L,5L,5L,6L,2L,3L,4L,4L,6L,5L,4L,3L,3L,5L,6L,8L,3L,7L,4L,9L,6L,6L,3L,3L,3L,5L,6L,7L,4L,5L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283929Inst : IEnumerable<long>
{
public static readonly long[] Value=A283929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283929.Bytes);
public long this[int i]=>Value[i];

public static A283929Inst Instance=new A283929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283930
{
public static readonly long[] Value={ 2L,11L,14L,21L,23L,29L,45L,47L,53L,71L,73L,74L,82L,86L,95L,99L,101L,105L,113L,115L,121L,142L,167L,169L,179L,181L,199L,203L,209L,233L,235L,277L,307L,311L,317L,335L,337L,343L,347L,349L,353L,355L,358L,361L,382L,434L,449L,465L,494L,509L,515L,518L,529L,535L,547L,549L,570L,583L,585L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283930Inst : IEnumerable<long>
{
public static readonly long[] Value=A283930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283930.Bytes);
public long this[int i]=>Value[i];

public static A283930Inst Instance=new A283930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283931
{
public static readonly long[] Value={ 1L,63L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283931Inst : IEnumerable<long>
{
public static readonly long[] Value=A283931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283931.Bytes);
public long this[int i]=>Value[i];

public static A283931Inst Instance=new A283931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283932
{
public static readonly BigInteger[] Value={ 1L,1L,-6049L,220961L,-94911125449L,671622173L,16973944396387813L,-46178297272884601L,BigInteger.Parse("648295260682210793677"),58263405848420369L,BigInteger.Parse("-12621473417377804010947847693"),BigInteger.Parse("30937406138704675992342953"),BigInteger.Parse("117859933384302464321297008587517702333") };
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
public class A283932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283932Inst Instance=new A283932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283933
{
public static readonly BigInteger[] Value={ 1L,256L,1679616L,71663616L,41990400000000L,622080000000L,BigInteger.Parse("48413259982080000000"),BigInteger.Parse("29509034655744000000"),BigInteger.Parse("403351617450700800000000"),BigInteger.Parse("102438506019225600000"),BigInteger.Parse("2882066712209076538460160000000"),BigInteger.Parse("6654122279270595182592000000") };
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
public class A283933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283933Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283933.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283933Inst Instance=new A283933Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283934
{
public static readonly BigInteger[] Value={ 1L,1L,-18659L,1437155L,-3443781552263L,299038554059L,-4578818318657408083L,BigInteger.Parse("-13134546687973878593"),BigInteger.Parse("1056237841304782111497583"),BigInteger.Parse("-4359513902194586454589"),BigInteger.Parse("-88697240413616501738435495501197"),BigInteger.Parse("635822194381744885857116976721") };
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
public class A283934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283934Inst Instance=new A283934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283935
{
public static readonly BigInteger[] Value={ 1L,512L,10077696L,859963392L,2519424000000000L,335923200000000L,BigInteger.Parse("20333569192473600000000"),BigInteger.Parse("24787589110824960000000"),BigInteger.Parse("1016446075975766016000000000"),BigInteger.Parse("6453625879211212800000000"),BigInteger.Parse("79890889262435601646115635200000000"),BigInteger.Parse("184452269581380898461450240000000") };
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
public class A283935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283935Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283935.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283935Inst Instance=new A283935Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283936
{
public static readonly long[] Value={ 2L,3L,5L,8L,13L,21L,32L,54L,83L,149L,251L,450L,807L,1481L,2696L,4968L,9155L,17143L,32009L,60024L,112785L,213193L,404285L,766690L,1456473L,2773176L,5292017L,10125044L,19403747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283936Inst : IEnumerable<long>
{
public static readonly long[] Value=A283936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283936.Bytes);
public long this[int i]=>Value[i];

public static A283936Inst Instance=new A283936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283937
{
public static readonly long[] Value={ 7L,13L,31L,43L,47L,73L,127L,157L,211L,241L,307L,421L,463L,601L,757L,1093L,1123L,1229L,1483L,1723L,1847L,2551L,2801L,2971L,3307L,3323L,3541L,3907L,4423L,4831L,5113L,5701L,6007L,6163L,6481L,6577L,7523L,8011L,8191L,9901L,10303L,11131L,12211L,12433L,13807L,14281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283937Inst : IEnumerable<long>
{
public static readonly long[] Value=A283937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283937.Bytes);
public long this[int i]=>Value[i];

public static A283937Inst Instance=new A283937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283970
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,15L,17L,19L,23L,25L,29L,30L,31L,35L,36L,37L,40L,41L,43L,47L,48L,49L,50L,53L,59L,60L,61L,65L,67L,71L,73L,76L,79L,83L,89L,97L,101L,103L,107L,109L,113L,120L,121L,127L,130L,131L,132L,136L,137L,139L,140L,149L,150L,151L,157L,163L,167L,169L,173L,175L,179L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283970Inst : IEnumerable<long>
{
public static readonly long[] Value=A283970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283970.Bytes);
public long this[int i]=>Value[i];

public static A283970Inst Instance=new A283970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283971
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,5L,3L,7L,8L,9L,5L,11L,12L,13L,7L,15L,16L,17L,9L,19L,20L,21L,11L,23L,24L,25L,13L,27L,28L,29L,15L,31L,32L,33L,17L,35L,36L,37L,19L,39L,40L,41L,21L,43L,44L,45L,23L,47L,48L,49L,25L,51L,52L,53L,27L,55L,56L,57L,29L,59L,60L,61L,31L,63L,64L,65L,33L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283971Inst : IEnumerable<long>
{
public static readonly long[] Value=A283971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283971.Bytes);
public long this[int i]=>Value[i];

public static A283971Inst Instance=new A283971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283972
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,4L,4L,7L,8L,9L,9L,10L,11L,11L,11L,15L,16L,17L,17L,19L,20L,20L,20L,22L,23L,24L,23L,25L,26L,26L,26L,31L,32L,33L,33L,35L,36L,36L,36L,39L,40L,41L,41L,42L,43L,43L,43L,46L,47L,48L,47L,50L,51L,50L,49L,53L,54L,55L,53L,56L,57L,57L,57L,63L,64L,65L,65L,67L,68L,68L,68L,71L,72L,73L,73L,74L,75L,75L,75L,79L,80L,81L,81L,83L,84L,84L,84L,86L,87L,88L,87L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283972Inst : IEnumerable<long>
{
public static readonly long[] Value=A283972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283972.Bytes);
public long this[int i]=>Value[i];

public static A283972Inst Instance=new A283972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283973
{
public static readonly long[] Value={ 1L,3L,4L,9L,10L,12L,13L,15L,16L,21L,22L,27L,28L,33L,36L,37L,48L,49L,60L,61L,64L,78L,84L,85L,87L,88L,90L,91L,93L,94L,99L,100L,102L,103L,105L,106L,108L,109L,115L,129L,130L,133L,135L,136L,141L,144L,145L,153L,159L,160L,162L,171L,172L,189L,190L,192L,193L,195L,196L,213L,214L,223L,225L,226L,232L,240L,241L,244L,249L,250L,252L,255L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283973Inst : IEnumerable<long>
{
public static readonly long[] Value=A283973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283973.Bytes);
public long this[int i]=>Value[i];

public static A283973Inst Instance=new A283973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283974
{
public static readonly long[] Value={ 2L,5L,6L,7L,8L,11L,14L,17L,18L,19L,20L,23L,24L,25L,26L,29L,30L,31L,32L,34L,35L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,79L,80L,81L,82L,83L,86L,89L,92L,95L,96L,97L,98L,101L,104L,107L,110L,111L,112L,113L,114L,116L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283974Inst : IEnumerable<long>
{
public static readonly long[] Value=A283974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283974.Bytes);
public long this[int i]=>Value[i];

public static A283974Inst Instance=new A283974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283975
{
public static readonly long[] Value={ 1L,3L,1L,7L,5L,7L,1L,15L,13L,7L,5L,11L,13L,15L,1L,31L,29L,7L,13L,3L,1L,11L,5L,19L,21L,15L,13L,19L,29L,31L,1L,63L,61L,7L,29L,19L,25L,3L,13L,11L,9L,11L,1L,23L,25L,19L,5L,35L,37L,15L,21L,11L,9L,19L,13L,43L,37L,31L,29L,35L,61L,63L,1L,127L,125L,7L,61L,51L,41L,19L,29L,59L,49L,3L,25L,31L,17L,11L,13L,27L,25L,11L,9L,31L,21L,23L,1L,47L,33L,19L,25L,63L,41L,35L,5L,67L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283975Inst : IEnumerable<long>
{
public static readonly long[] Value=A283975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283975.Bytes);
public long this[int i]=>Value[i];

public static A283975Inst Instance=new A283975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283976
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,2L,3L,1L,3L,3L,3L,2L,3L,3L,3L,1L,5L,4L,7L,3L,7L,5L,7L,2L,7L,5L,7L,3L,7L,4L,5L,1L,5L,5L,5L,4L,7L,7L,7L,3L,11L,8L,13L,5L,7L,7L,7L,2L,7L,7L,7L,5L,13L,8L,11L,3L,7L,7L,7L,4L,5L,5L,5L,1L,7L,6L,7L,5L,13L,9L,13L,4L,15L,11L,15L,7L,15L,10L,11L,3L,11L,11L,11L,8L,13L,13L,13L,5L,13L,12L,15L,7L,15L,9L,11L,2L,11L,9L,15L,7L,15L,12L,13L,5L,13L,13L,13L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283976Inst : IEnumerable<long>
{
public static readonly long[] Value=A283976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283976.Bytes);
public long this[int i]=>Value[i];

public static A283976Inst Instance=new A283976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283977
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,3L,2L,3L,1L,2L,3L,1L,2L,1L,3L,2L,1L,5L,4L,7L,3L,6L,5L,7L,2L,7L,5L,6L,3L,7L,4L,5L,1L,4L,5L,1L,4L,3L,7L,4L,3L,11L,8L,13L,5L,2L,7L,5L,2L,5L,7L,2L,5L,13L,8L,11L,3L,4L,7L,3L,4L,1L,5L,4L,1L,7L,6L,3L,5L,12L,9L,13L,4L,15L,11L,12L,7L,13L,10L,9L,3L,8L,11L,3L,8L,5L,13L,8L,5L,9L,12L,11L,7L,14L,9L,11L,2L,11L,9L,14L,7L,11L,12L,9L,5L,8L,13L,5L,8L,3L,11L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283977Inst : IEnumerable<long>
{
public static readonly long[] Value=A283977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283977.Bytes);
public long this[int i]=>Value[i];

public static A283977Inst Instance=new A283977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283978
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,2L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,4L,0L,4L,0L,3L,0L,0L,0L,0L,0L,5L,0L,2L,0L,2L,0L,5L,0L,0L,0L,0L,0L,3L,0L,4L,0L,4L,0L,1L,0L,0L,0L,4L,0L,1L,0L,0L,0L,0L,0L,3L,0L,2L,0L,2L,0L,3L,0L,8L,0L,8L,0L,5L,0L,4L,0L,4L,0L,1L,0L,0L,0L,0L,0L,1L,0L,4L,0L,4L,0L,5L,0L,8L,0L,8L,0L,3L,0L,2L,0L,2L,0L,3L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283978Inst : IEnumerable<long>
{
public static readonly long[] Value=A283978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283978.Bytes);
public long this[int i]=>Value[i];

public static A283978Inst Instance=new A283978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283979
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,2L,3L,0L,3L,0L,0L,0L,7L,6L,5L,4L,4L,6L,7L,0L,5L,6L,5L,0L,7L,0L,0L,0L,15L,14L,9L,12L,10L,10L,9L,8L,10L,8L,8L,12L,10L,14L,15L,0L,9L,10L,15L,12L,14L,10L,9L,0L,9L,14L,9L,0L,15L,0L,0L,0L,31L,30L,17L,28L,22L,18L,21L,24L,20L,20L,18L,20L,16L,18L,17L,16L,22L,20L,22L,16L,21L,16L,16L,24L,16L,20L,18L,28L,22L,30L,31L,0L,17L,18L,27L,20L,28L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283979Inst : IEnumerable<long>
{
public static readonly long[] Value=A283979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283979.Bytes);
public long this[int i]=>Value[i];

public static A283979Inst Instance=new A283979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283980
{
public static readonly long[] Value={ 1L,6L,5L,36L,7L,30L,11L,216L,25L,42L,13L,180L,17L,66L,35L,1296L,19L,150L,23L,252L,55L,78L,29L,1080L,49L,102L,125L,396L,31L,210L,37L,7776L,65L,114L,77L,900L,41L,138L,85L,1512L,43L,330L,47L,468L,175L,174L,53L,6480L,121L,294L,95L,612L,59L,750L,91L,2376L,115L,186L,61L,1260L,67L,222L,275L,46656L,119L,390L,71L,684L,145L,462L,73L,5400L,79L,246L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283980Inst : IEnumerable<long>
{
public static readonly long[] Value=A283980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283980.Bytes);
public long this[int i]=>Value[i];

public static A283980Inst Instance=new A283980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283981
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,3L,3L,3L,0L,4L,4L,4L,4L,4L,6L,7L,0L,5L,5L,5L,5L,5L,7L,8L,5L,5L,8L,9L,8L,9L,11L,11L,0L,6L,6L,6L,6L,6L,8L,9L,6L,6L,9L,10L,9L,10L,12L,12L,6L,6L,10L,11L,10L,11L,13L,13L,10L,11L,14L,14L,14L,14L,14L,17L,0L,7L,7L,7L,7L,7L,9L,10L,7L,7L,10L,11L,10L,11L,13L,13L,7L,7L,11L,12L,11L,12L,14L,14L,11L,12L,15L,15L,15L,15L,15L,18L,7L,7L,12L,13L,12L,13L,15L,15L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283981Inst : IEnumerable<long>
{
public static readonly long[] Value=A283981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283981.Bytes);
public long this[int i]=>Value[i];

public static A283981Inst Instance=new A283981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283982
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,0L,0L,3L,2L,1L,1L,0L,1L,1L,0L,4L,3L,2L,2L,1L,2L,2L,1L,0L,2L,2L,1L,1L,2L,1L,0L,5L,4L,3L,3L,2L,3L,3L,2L,1L,3L,3L,2L,2L,3L,2L,1L,0L,3L,3L,2L,2L,3L,2L,1L,1L,3L,2L,2L,1L,0L,2L,0L,6L,5L,4L,4L,3L,4L,4L,3L,2L,4L,4L,3L,3L,4L,3L,2L,1L,4L,4L,3L,3L,4L,3L,2L,2L,4L,3L,3L,2L,1L,3L,1L,0L,4L,4L,3L,3L,4L,3L,2L,2L,4L,3L,3L,2L,1L,3L,1L,1L,4L,3L,3L,2L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283982Inst : IEnumerable<long>
{
public static readonly long[] Value=A283982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283982.Bytes);
public long this[int i]=>Value[i];

public static A283982Inst Instance=new A283982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283983
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,5L,3L,1L,15L,1L,1L,1L,3L,5L,15L,7L,45L,5L,15L,1L,15L,35L,15L,1L,105L,1L,1L,1L,3L,5L,105L,7L,225L,35L,525L,11L,1575L,175L,1125L,7L,1575L,35L,105L,1L,105L,35L,525L,77L,1575L,35L,525L,1L,105L,385L,105L,1L,1155L,1L,1L,1L,3L,5L,1155L,7L,1575L,385L,3675L,11L,7875L,1225L,275625L,77L,55125L,2695L,5775L,13L,17325L,13475L,275625L,539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283983Inst : IEnumerable<long>
{
public static readonly long[] Value=A283983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283983.Bytes);
public long this[int i]=>Value[i];

public static A283983Inst Instance=new A283983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283984
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,10L,12L,13L,33L,34L,36L,37L,42L,43L,45L,46L,153L,154L,156L,157L,162L,163L,165L,166L,186L,187L,189L,190L,195L,196L,198L,199L,873L,874L,876L,877L,882L,883L,885L,886L,906L,907L,909L,910L,915L,916L,918L,919L,1026L,1027L,1029L,1030L,1035L,1036L,1038L,1039L,1059L,1060L,1062L,1063L,1068L,1069L,1071L,1072L,5913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283984Inst : IEnumerable<long>
{
public static readonly long[] Value=A283984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283984.Bytes);
public long this[int i]=>Value[i];

public static A283984Inst Instance=new A283984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283985
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,10L,12L,13L,39L,40L,42L,43L,48L,49L,51L,52L,249L,250L,252L,253L,258L,259L,261L,262L,288L,289L,291L,292L,297L,298L,300L,301L,2559L,2560L,2562L,2563L,2568L,2569L,2571L,2572L,2598L,2599L,2601L,2602L,2607L,2608L,2610L,2611L,2808L,2809L,2811L,2812L,2817L,2818L,2820L,2821L,2847L,2848L,2850L,2851L,2856L,2857L,2859L,2860L,32589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283985Inst : IEnumerable<long>
{
public static readonly long[] Value=A283985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283985.Bytes);
public long this[int i]=>Value[i];

public static A283985Inst Instance=new A283985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283986
{
public static readonly long[] Value={ 1L,1L,3L,3L,3L,3L,3L,3L,5L,7L,7L,7L,7L,7L,7L,5L,5L,5L,7L,7L,11L,13L,7L,7L,7L,7L,13L,11L,7L,7L,5L,5L,7L,7L,13L,13L,15L,15L,15L,11L,11L,11L,13L,13L,13L,15L,15L,11L,11L,15L,15L,13L,13L,13L,11L,11L,11L,15L,15L,15L,13L,13L,7L,7L,7L,7L,15L,15L,15L,15L,13L,13L,15L,15L,27L,23L,23L,27L,15L,15L,15L,15L,27L,27L,29L,29L,31L,23L,21L,29L,31L,23L,23L,25L,11L,11L,11L,11L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283986Inst : IEnumerable<long>
{
public static readonly long[] Value=A283986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283986.Bytes);
public long this[int i]=>Value[i];

public static A283986Inst Instance=new A283986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283987
{
public static readonly long[] Value={ 1L,0L,3L,3L,2L,1L,1L,2L,5L,7L,6L,7L,7L,6L,7L,5L,4L,1L,3L,4L,11L,13L,2L,5L,5L,2L,13L,11L,4L,3L,1L,4L,7L,3L,12L,13L,15L,12L,13L,9L,8L,3L,5L,8L,9L,11L,14L,11L,11L,14L,11L,9L,8L,5L,3L,8L,9L,13L,12L,15L,13L,12L,3L,7L,6L,1L,13L,14L,11L,7L,4L,9L,11L,4L,25L,21L,22L,27L,7L,14L,13L,5L,24L,27L,29L,24L,31L,23L,20L,29L,31L,20L,23L,25L,2L,9L,9L,2L,25L,23L,20L,31L,29L,20L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283987Inst : IEnumerable<long>
{
public static readonly long[] Value=A283987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283987.Bytes);
public long this[int i]=>Value[i];

public static A283987Inst Instance=new A283987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283988
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,4L,4L,3L,0L,0L,5L,2L,2L,5L,0L,0L,3L,4L,4L,1L,0L,4L,1L,0L,0L,3L,2L,2L,3L,8L,8L,5L,4L,4L,1L,0L,0L,1L,4L,4L,5L,8L,8L,3L,2L,2L,3L,0L,0L,1L,4L,0L,1L,6L,2L,1L,4L,8L,9L,4L,4L,11L,2L,2L,1L,0L,8L,1L,2L,10L,3L,0L,0L,5L,0L,0L,1L,0L,0L,3L,0L,0L,9L,2L,2L,9L,0L,0L,3L,0L,0L,1L,0L,0L,5L,0L,0L,3L,10L,2L,1L,8L,0L,1L,2L,2L,11L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283988Inst : IEnumerable<long>
{
public static readonly long[] Value=A283988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283988.Bytes);
public long this[int i]=>Value[i];

public static A283988Inst Instance=new A283988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283989
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,9L,1L,1L,1L,9L,25L,9L,1L,225L,1L,1L,1L,9L,25L,225L,49L,2025L,25L,225L,1L,225L,1225L,225L,1L,11025L,1L,1L,1L,9L,25L,11025L,49L,50625L,1225L,275625L,121L,2480625L,30625L,1265625L,49L,2480625L,1225L,11025L,1L,11025L,1225L,275625L,5929L,2480625L,1225L,275625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283989Inst : IEnumerable<long>
{
public static readonly long[] Value=A283989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283989.Bytes);
public long this[int i]=>Value[i];

public static A283989Inst Instance=new A283989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283990
{
public static readonly ulong[] Value={ 1L,2L,2L,8L,2L,144L,2L,64L,8L,1152L,2L,124416L,2L,1152L,144L,1024L,2L,35831808L,2L,221184L,144L,18432L,2L,859963392L,8L,18432L,64L,221184L,2L,261213880320000000L,2L,32768L,1152L,589824L,144L,26748301344768L,2L,589824L,1152L,1528823808L,2L,12036735605145600000UL,2L,7077888L,124416L,589824L,2L,1283918464548864L,8L,27518828544L,1152L,7077888L,2L,69331597085638656L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283990Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283990.Bytes);
public ulong this[int i]=>Value[i];

public static A283990Inst Instance=new A283990Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283991
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283991Inst : IEnumerable<long>
{
public static readonly long[] Value=A283991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283991.Bytes);
public long this[int i]=>Value[i];

public static A283991Inst Instance=new A283991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283992
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,10L,10L,10L,10L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,18L,18L,18L,18L,19L,19L,20L,20L,20L,20L,21L,21L,22L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,26L,26L,26L,26L,27L,27L,27L,27L,27L,27L,28L,28L,29L,29L,29L,29L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283992Inst : IEnumerable<long>
{
public static readonly long[] Value=A283992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283992.Bytes);
public long this[int i]=>Value[i];

public static A283992Inst Instance=new A283992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283993
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,3L,4L,5L,5L,6L,6L,7L,8L,9L,9L,10L,10L,11L,12L,13L,13L,14L,14L,15L,16L,17L,17L,18L,18L,19L,20L,21L,22L,23L,23L,24L,25L,26L,26L,27L,27L,28L,29L,30L,30L,31L,32L,33L,34L,35L,35L,36L,36L,37L,38L,39L,39L,40L,40L,41L,42L,43L,43L,44L,44L,45L,46L,47L,47L,48L,48L,49L,50L,51L,51L,52L,52L,53L,54L,55L,55L,56L,57L,58L,59L,60L,60L,61L,61L,62L,63L,64L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283993Inst : IEnumerable<long>
{
public static readonly long[] Value=A283993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283993.Bytes);
public long this[int i]=>Value[i];

public static A283993Inst Instance=new A283993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283994
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,4L,3L,4L,5L,5L,6L,6L,7L,8L,9L,7L,10L,8L,11L,12L,13L,9L,14L,10L,15L,16L,17L,11L,18L,12L,19L,20L,21L,22L,23L,13L,24L,25L,26L,14L,27L,15L,28L,29L,30L,16L,31L,32L,33L,34L,35L,17L,36L,18L,37L,38L,39L,19L,40L,20L,41L,42L,43L,21L,44L,22L,45L,46L,47L,23L,48L,24L,49L,50L,51L,25L,52L,26L,53L,54L,55L,27L,56L,57L,58L,59L,60L,28L,61L,29L,62L,63L,64L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283994Inst : IEnumerable<long>
{
public static readonly long[] Value=A283994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283994.Bytes);
public long this[int i]=>Value[i];

public static A283994Inst Instance=new A283994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283995
{
public static readonly long[] Value={ 1L,2L,2L,8L,2L,36L,2L,64L,8L,36L,2L,1728L,2L,36L,36L,1024L,2L,1728L,2L,1728L,36L,36L,2L,331776L,8L,36L,64L,1728L,2L,810000L,2L,32768L,36L,36L,36L,10077696L,2L,36L,36L,331776L,2L,810000L,2L,1728L,1728L,36L,2L,254803968L,8L,1728L,36L,1728L,2L,331776L,36L,331776L,36L,36L,2L,46656000000L,2L,36L,1728L,2097152L,36L,810000L,2L,1728L,36L,810000L,2L,139314069504L,2L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283995Inst : IEnumerable<long>
{
public static readonly long[] Value=A283995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283995.Bytes);
public long this[int i]=>Value[i];

public static A283995Inst Instance=new A283995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283996
{
public static readonly long[] Value={ 0L,1L,3L,3L,7L,7L,6L,7L,15L,15L,10L,11L,14L,15L,15L,15L,31L,31L,18L,19L,22L,23L,23L,23L,30L,31L,31L,31L,29L,29L,30L,31L,63L,63L,34L,35L,38L,39L,39L,39L,46L,47L,47L,47L,45L,45L,46L,47L,62L,63L,63L,63L,53L,53L,54L,55L,61L,61L,62L,63L,60L,61L,63L,63L,127L,127L,66L,67L,70L,71L,71L,71L,78L,79L,79L,79L,77L,77L,78L,79L,94L,95L,95L,95L,85L,85L,86L,87L,93L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283996Inst : IEnumerable<long>
{
public static readonly long[] Value=A283996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283996.Bytes);
public long this[int i]=>Value[i];

public static A283996Inst Instance=new A283996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283997
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,2L,3L,15L,14L,2L,3L,6L,7L,5L,4L,31L,30L,2L,3L,6L,7L,5L,4L,14L,15L,13L,12L,5L,4L,4L,5L,63L,62L,2L,3L,6L,7L,5L,4L,14L,15L,13L,12L,5L,4L,4L,5L,30L,31L,29L,28L,5L,4L,4L,5L,13L,12L,12L,13L,4L,5L,7L,6L,127L,126L,2L,3L,6L,7L,5L,4L,14L,15L,13L,12L,5L,4L,4L,5L,30L,31L,29L,28L,5L,4L,4L,5L,13L,12L,12L,13L,4L,5L,7L,6L,62L,63L,61L,60L,5L,4L,4L,5L,13L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283997Inst : IEnumerable<long>
{
public static readonly long[] Value=A283997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283997.Bytes);
public long this[int i]=>Value[i];

public static A283997Inst Instance=new A283997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283998
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,4L,4L,0L,1L,8L,8L,8L,8L,10L,11L,0L,1L,16L,16L,16L,16L,18L,19L,16L,16L,18L,19L,24L,25L,26L,26L,0L,1L,32L,32L,32L,32L,34L,35L,32L,32L,34L,35L,40L,41L,42L,42L,32L,32L,34L,35L,48L,49L,50L,50L,48L,49L,50L,50L,56L,56L,56L,57L,0L,1L,64L,64L,64L,64L,66L,67L,64L,64L,66L,67L,72L,73L,74L,74L,64L,64L,66L,67L,80L,81L,82L,82L,80L,81L,82L,82L,88L,88L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283998Inst : IEnumerable<long>
{
public static readonly long[] Value=A283998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283998.Bytes);
public long this[int i]=>Value[i];

public static A283998Inst Instance=new A283998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283999
{
public static readonly long[] Value={ 0L,0L,0L,6L,0L,14L,14L,14L,0L,30L,30L,30L,30L,30L,18L,16L,0L,62L,62L,62L,62L,62L,50L,48L,62L,62L,34L,32L,34L,32L,44L,44L,0L,126L,126L,126L,126L,126L,114L,112L,126L,126L,98L,96L,98L,96L,108L,108L,126L,126L,66L,64L,66L,64L,76L,76L,66L,64L,92L,92L,92L,92L,92L,82L,0L,254L,254L,254L,254L,254L,242L,240L,254L,254L,226L,224L,226L,224L,236L,236L,254L,254L,194L,192L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283999Inst : IEnumerable<long>
{
public static readonly long[] Value=A283999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283999.Bytes);
public long this[int i]=>Value[i];

public static A283999Inst Instance=new A283999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284000
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,4L,5L,6L,7L,8L,9L,10L,9L,10L,9L,10L,11L,12L,13L,14L,15L,16L,15L,16L,17L,18L,17L,18L,19L,20L,19L,22L,21L,22L,23L,22L,23L,24L,25L,26L,27L,26L,27L,28L,29L,30L,29L,30L,31L,32L,33L,34L,35L,34L,37L,38L,37L,38L,39L,38L,39L,38L,39L,40L,39L,42L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284000Inst : IEnumerable<long>
{
public static readonly long[] Value=A284000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284000.Bytes);
public long this[int i]=>Value[i];

public static A284000Inst Instance=new A284000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284001
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,4L,6L,1L,2L,4L,6L,8L,12L,18L,24L,1L,2L,4L,6L,8L,12L,18L,24L,16L,24L,36L,48L,54L,72L,96L,120L,1L,2L,4L,6L,8L,12L,18L,24L,16L,24L,36L,48L,54L,72L,96L,120L,32L,48L,72L,96L,108L,144L,192L,240L,162L,216L,288L,360L,384L,480L,600L,720L,1L,2L,4L,6L,8L,12L,18L,24L,16L,24L,36L,48L,54L,72L,96L,120L,32L,48L,72L,96L,108L,144L,192L,240L,162L,216L,288L,360L,384L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284001Inst : IEnumerable<long>
{
public static readonly long[] Value=A284001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284001.Bytes);
public long this[int i]=>Value[i];

public static A284001Inst Instance=new A284001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284002
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,6L,1L,2L,2L,6L,2L,6L,6L,12L,1L,2L,2L,6L,2L,6L,6L,12L,2L,6L,6L,12L,6L,12L,12L,60L,1L,2L,2L,6L,2L,6L,6L,12L,2L,6L,6L,12L,6L,12L,12L,60L,2L,6L,6L,12L,6L,12L,12L,60L,6L,12L,12L,60L,12L,60L,60L,60L,1L,2L,2L,6L,2L,6L,6L,12L,2L,6L,6L,12L,6L,12L,12L,60L,2L,6L,6L,12L,6L,12L,12L,60L,6L,12L,12L,60L,12L,60L,60L,60L,2L,6L,6L,12L,6L,12L,12L,60L,6L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284002Inst : IEnumerable<long>
{
public static readonly long[] Value=A284002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284002.Bytes);
public long this[int i]=>Value[i];

public static A284002Inst Instance=new A284002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284003
{
public static readonly long[] Value={ 1L,2L,6L,3L,30L,15L,5L,10L,210L,105L,35L,70L,7L,14L,42L,21L,2310L,1155L,385L,770L,77L,154L,462L,231L,11L,22L,66L,33L,330L,165L,55L,110L,30030L,15015L,5005L,10010L,1001L,2002L,6006L,3003L,143L,286L,858L,429L,4290L,2145L,715L,1430L,13L,26L,78L,39L,390L,195L,65L,130L,2730L,1365L,455L,910L,91L,182L,546L,273L,510510L,255255L,85085L,170170L,17017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284003Inst : IEnumerable<long>
{
public static readonly long[] Value=A284003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284003.Bytes);
public long this[int i]=>Value[i];

public static A284003Inst Instance=new A284003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284004
{
public static readonly long[] Value={ 1L,2L,6L,2L,30L,6L,2L,6L,210L,30L,6L,30L,2L,6L,30L,6L,2310L,210L,30L,210L,6L,30L,210L,30L,2L,6L,30L,6L,210L,30L,6L,30L,30030L,2310L,210L,2310L,30L,210L,2310L,210L,6L,30L,210L,30L,2310L,210L,30L,210L,2L,6L,30L,6L,210L,30L,6L,30L,2310L,210L,30L,210L,6L,30L,210L,30L,510510L,30030L,2310L,30030L,210L,2310L,30030L,2310L,30L,210L,2310L,210L,30030L,2310L,210L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284004Inst : IEnumerable<long>
{
public static readonly long[] Value=A284004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284004.Bytes);
public long this[int i]=>Value[i];

public static A284004Inst Instance=new A284004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284005
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,18L,24L,16L,24L,36L,48L,54L,72L,96L,120L,32L,48L,72L,96L,108L,144L,192L,240L,162L,216L,288L,360L,384L,480L,600L,720L,64L,96L,144L,192L,216L,288L,384L,480L,324L,432L,576L,720L,768L,960L,1200L,1440L,486L,648L,864L,1080L,1152L,1440L,1800L,2160L,1536L,1920L,2400L,2880L,3000L,3600L,4320L,5040L,128L,192L,288L,384L,432L,576L,768L,960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284005Inst : IEnumerable<long>
{
public static readonly long[] Value=A284005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284005.Bytes);
public long this[int i]=>Value[i];

public static A284005Inst Instance=new A284005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284006
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,5L,5L,6L,6L,7L,8L,8L,9L,10L,11L,11L,12L,13L,13L,13L,14L,15L,15L,16L,17L,17L,19L,19L,20L,20L,21L,21L,21L,22L,23L,24L,25L,25L,26L,27L,28L,29L,28L,30L,31L,31L,32L,32L,33L,33L,34L,34L,34L,34L,35L,36L,37L,38L,38L,40L,40L,41L,42L,43L,43L,44L,45L,45L,46L,47L,47L,48L,48L,49L,51L,50L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284006Inst : IEnumerable<long>
{
public static readonly long[] Value=A284006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284006.Bytes);
public long this[int i]=>Value[i];

public static A284006Inst Instance=new A284006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284007
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,7L,7L,7L,8L,8L,9L,10L,11L,11L,11L,12L,12L,14L,13L,14L,14L,15L,16L,15L,16L,16L,18L,18L,18L,19L,19L,20L,20L,22L,22L,24L,23L,25L,24L,25L,25L,25L,26L,26L,27L,27L,28L,29L,28L,30L,29L,30L,31L,30L,32L,34L,34L,33L,33L,34L,34L,36L,37L,36L,37L,38L,38L,40L,41L,39L,40L,43L,42L,44L,43L,43L,44L,44L,45L,45L,45L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284007Inst : IEnumerable<long>
{
public static readonly long[] Value=A284007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284007.Bytes);
public long this[int i]=>Value[i];

public static A284007Inst Instance=new A284007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284008
{
public static readonly long[] Value={ 2L,6L,6L,30L,90L,90L,30L,210L,630L,450L,1350L,1890L,3150L,3150L,210L,2310L,6930L,3150L,47250L,330750L,992250L,141750L,47250L,103950L,173250L,110250L,330750L,519750L,242550L,242550L,2310L,30030L,90090L,34650L,3638250L,3638250L,272868750L,173643750L,11576250L,200103750L,600311250L,34728750L,2604656250L,28651218750L,1910081250L,272868750L,3638250L,9459450L,15765750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284008Inst : IEnumerable<long>
{
public static readonly long[] Value=A284008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284008.Bytes);
public long this[int i]=>Value[i];

public static A284008Inst Instance=new A284008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284009
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,3L,4L,5L,5L,6L,6L,6L,6L,4L,5L,6L,6L,8L,9L,10L,9L,8L,8L,8L,8L,9L,9L,8L,8L,5L,6L,7L,7L,10L,10L,13L,13L,11L,12L,13L,12L,15L,16L,14L,13L,10L,10L,10L,10L,13L,14L,15L,14L,12L,12L,11L,11L,12L,12L,10L,10L,6L,7L,8L,8L,12L,12L,15L,15L,14L,15L,17L,17L,20L,21L,20L,19L,14L,15L,16L,15L,21L,22L,24L,24L,20L,21L,20L,18L,21L,21L,17L,17L,12L,12L,12L,12L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284009Inst : IEnumerable<long>
{
public static readonly long[] Value=A284009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284009.Bytes);
public long this[int i]=>Value[i];

public static A284009Inst Instance=new A284009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284010
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,2L,8L,0L,2L,2L,16L,2L,32L,6L,6L,0L,64L,2L,128L,2L,6L,2L,256L,2L,4L,6L,2L,2L,512L,2L,1024L,0L,30L,6L,12L,2L,2048L,6L,6L,2L,4096L,2L,8192L,2L,6L,2L,16384L,2L,8L,2L,30L,2L,32768L,2L,12L,2L,30L,30L,65536L,2L,131072L,6L,6L,0L,60L,2L,262144L,2L,30L,2L,524288L,2L,1048576L,6L,6L,2L,24L,6L,2097152L,2L,2L,6L,4194304L,6L,12L,6L,6L,2L,8388608L,4L,24L,2L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284010Inst : IEnumerable<long>
{
public static readonly long[] Value=A284010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284010.Bytes);
public long this[int i]=>Value[i];

public static A284010Inst Instance=new A284010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284011
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,4L,6L,2L,12L,2L,6L,6L,16L,2L,12L,2L,12L,6L,6L,2L,24L,2L,6L,8L,12L,2L,30L,2L,32L,6L,6L,6L,36L,2L,6L,6L,24L,2L,30L,2L,12L,12L,6L,2L,48L,4L,6L,6L,12L,2L,24L,2L,24L,6L,6L,2L,60L,2L,6L,30L,64L,2L,30L,2L,12L,6L,30L,2L,72L,2L,6L,12L,12L,2L,30L,2L,48L,6L,6L,2L,60L,6L,6L,6L,24L,2L,60L,2L,12L,6L,6L,2L,96L,2L,12L,12L,12L,2L,30L,2L,24L,30L,6L,2L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284011Inst : IEnumerable<long>
{
public static readonly long[] Value=A284011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284011.Bytes);
public long this[int i]=>Value[i];

public static A284011Inst Instance=new A284011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284012
{
public static readonly long[] Value={ 2L,2L,6L,2L,12L,6L,30L,2L,60L,12L,120L,6L,180L,30L,210L,2L,420L,6L,30L,2L,60L,6L,30L,2L,420L,6L,30L,6L,60L,6L,30L,2L,420L,6L,30L,2L,60L,30L,60L,6L,30L,6L,30L,2L,60L,30L,30L,2L,30L,6L,30L,2L,30L,6L,30L,6L,60L,30L,30L,6L,30L,6L,30L,2L,210L,6L,30L,2L,60L,6L,120L,2L,30L,30L,60L,6L,240L,6L,30L,2L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284012Inst : IEnumerable<long>
{
public static readonly long[] Value=A284012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284012.Bytes);
public long this[int i]=>Value[i];

public static A284012Inst Instance=new A284012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284013
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,2L,4L,4L,7L,5L,7L,6L,10L,8L,11L,11L,15L,12L,14L,12L,17L,13L,17L,16L,22L,18L,21L,19L,25L,22L,26L,26L,31L,27L,29L,26L,32L,26L,31L,29L,37L,30L,34L,30L,39L,33L,39L,38L,46L,40L,43L,39L,47L,40L,46L,44L,53L,47L,51L,48L,56L,52L,57L,57L,63L,58L,60L,56L,63L,55L,61L,58L,68L,58L,63L,57L,69L,60L,68L,66L,77L,67L,71L,64L,76L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284013Inst : IEnumerable<long>
{
public static readonly long[] Value=A284013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284013.Bytes);
public long this[int i]=>Value[i];

public static A284013Inst Instance=new A284013Inst();

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